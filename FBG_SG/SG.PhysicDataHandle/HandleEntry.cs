using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corp.ShanGong.FiberInstrument.BizCore;
using Corp.ShanGong.FiberInstrument.Common;
using Corp.ShanGong.FiberInstrument.ProjectSpec;
using Corp.ShanGong.FiberInstrument.Setting;
using GlobalModel;

namespace SG.PhysicDataHandle
{
    public class HandleEntry
    {
        public void DataHanleEntry(int localPort, string remoteIP, int remotePort, DateTime time, bool mSave, string savePath,ChannelDataStructure[] channelData)
        {
         
            Task.Run(() => new Action(async () =>
            {
                GlobalSetting.Instance.ChannelWay = channelData.Length;
                GlobalSetting.Instance.SensorCount = channelData.First().GratingWavelength.Length;
                var data = PhysicalQuantity.LoadFrom(channelData, new PhysicalCalculatorSpecCSJM());
                data.CurrentTime = time;
                //ReadIniConfig();
                var send = new SendQuantityPackage(localPort, remoteIP, remotePort, data);
                await send.SendData();
                if (mSave)
                {
                    GlobalSetting.Instance.DataFileLocalPath = savePath;
                    var dataArray = data.ToDataString();
                    for(var i=0;i<dataArray.Length;i++)
                    {
                        StressDataFile.SaveByChannel(dataArray[i], i + 1);
                    }
                    
                }
            })());
        }


        public void SetMaxChannelCount(int maxCount)
        {
            GlobalSetting.Instance.ChannelWay = maxCount;
        }


        private int _localPort = 9001;
        private string _remoteIp = "";
        private int _remotePort = 9002;
        private void ReadIniConfig()
        {
            var port = OperateIniFile.ReadIniData("Net", "LocalPort", "9001", "System.ini");
            _localPort = string.IsNullOrEmpty(port) ? 0 : Convert.ToInt32(port);

            _remoteIp = OperateIniFile.ReadIniData("Net", "RemoteIp", "192.168.1.100", "System.ini");
            var rePort = OperateIniFile.ReadIniData("Net", "RemotePort", "9000", "System.ini");
            _remotePort = string.IsNullOrEmpty(rePort) ? 0 : Convert.ToInt32(rePort);
 
        }
    }
}
