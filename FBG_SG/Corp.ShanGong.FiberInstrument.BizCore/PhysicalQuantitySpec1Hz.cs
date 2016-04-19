using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corp.ShanGong.FiberInstrument.Model;
using GlobalModel;
using Corp.ShanGong.FiberInstrument.IBizSpec;
using Corp.ShanGong.FiberInstrument.Setting;

namespace Corp.ShanGong.FiberInstrument.BizCore
{
    public partial class PhysicalQuantity
    {
        public static PhysicalQuantity LoadFrom(ChannelDataStructure[] channelData, IPhysicalCalculator calc)
        {
            var instance = new PhysicalQuantity();


            if (channelData != null && channelData.Any())
            {
                instance.CurrentTime = channelData.First().SampleTime.First();

                var tempExValuePairs = TempExValuePairsSpec1Hz(channelData, calc);

                CalcPhysicalSpec1Hz(channelData, calc, instance, tempExValuePairs);
            }
            return instance;
        }

        private static void CalcPhysicalSpec1Hz(ChannelDataStructure[] channelData, IPhysicalCalculator calc, PhysicalQuantity instance,
            Dictionary<int, QuantityValuePair> tempExValuePairs)
        {
            for (var i = 0; i < channelData.Length; i++)
            {
                var gratingData = channelData[i];
                for (var j = 0; j < gratingData.GratingCount; j++)
                {
                    var current = SensorConfigManager.GetConfigBy(i + 1, j + 1);
                    if (current != null && tempExValuePairs.ContainsKey(current.SensorId))
                    {
                        instance.ChannelValues[i].GratingValues[j] = tempExValuePairs[current.SensorId];
                    }
                    else
                    {
                        instance.ChannelValues[i].GratingValues[j].Orignal = null;
                        var k = channelData[i].SampleTime.Count - 1;
                        var wave = instance.ChannelValues[i].GratingValues[j].WaveLength =
                            instance.ChannelValues[i].GratingValues[j].WaveLengthExtension =
                                Convert.ToDecimal(channelData[i].GratingWavelength[j][k]);

                        var extension = SensorConfigManager.GetTemperatureExtensionConfig(current);
                        decimal? exWave = null;
                        if (extension != null && tempExValuePairs.ContainsKey(extension.SensorId))
                        {
                            exWave = tempExValuePairs[extension.SensorId].WaveLengthExtension;
                        }
                        instance.ChannelValues[i].GratingValues[j].PhysicalValue =
                            QuantityValuePair.CalcPhysicalValue(current, wave, calc, extension, exWave);
                    }
                }
            }
        }

        /// <summary>
        /// 先计算温补通道的数据
        /// </summary>
        /// <param name="channelData"></param>
        /// <param name="calc"></param>
        /// <returns></returns>
        private static Dictionary<int, QuantityValuePair> TempExValuePairsSpec1Hz(ChannelDataStructure[] channelData, IPhysicalCalculator calc)
        {
            var tempExConfigs = SensorConfigManager.GetAllIncludedTempExSensor();
            Dictionary<int, QuantityValuePair> tempExValuePairs = new Dictionary<int, QuantityValuePair>();
            foreach (var config in tempExConfigs)
            {
                var i = config.ChannelIndex - 1;
                var j = config.SensorIndex - 1;
                if (i < channelData.Length && j < channelData[i].GratingCount)
                {
                    QuantityValuePair pair = new QuantityValuePair();

                    pair.Orignal = null;
                    var k = channelData[i].SampleTime.Count -1;
                    var wave = pair.WaveLength = pair.WaveLengthExtension = Convert.ToDecimal(channelData[i].GratingWavelength[j][k]);

                    pair.PhysicalValue = QuantityValuePair.CalcPhysicalValue(config, wave, calc); // 温补通道
                    tempExValuePairs.Add(config.SensorId, pair);
                }
                
            }
            return tempExValuePairs;
        }
    }
}
