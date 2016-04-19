using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Corp.ShanGong.FiberInstrument.Common;

namespace Corp.ShanGong.FiberInstrument.Net
{
    public class ComPortOperation
    {
        public void Init()
        {
            _comm = new NetSpCommunication();
   
            _comm.SPort.PortName = ConfigurationManager.AppSettings["comPortName"];
            //波特率
            _comm.SPort.BaudRate = 115200; //波特率
            //数据位
            _comm.SPort.DataBits = 8;
            //两个停止位
            _comm.SPort.StopBits = System.IO.Ports.StopBits.One;
            //无奇偶校验位
            _comm.SPort.Parity = System.IO.Ports.Parity.None;
            _comm.SPort.ReadTimeout = 100;
            _comm.SPort.WriteTimeout = -1;

            _comm.Open();
            if (_comm.IsOpen)
            {
                _comm.DataReceived += new NetSpCommunication.EventHandle(comm_DataReceived);
            }
        }

        private NetSpCommunication _comm;

        
         void comm_DataReceived(byte[] recBytes)
        {
            //log.Info(HexCon.ByteToString(readBuffer));
            if (recBytes.Length > 1)
            {
                string receive = recBytes.HexToString();
                
                if (string.Equals(receive.Trim(), str, StringComparison.CurrentCultureIgnoreCase))
                {
                    try
                    {
//                        if (is_read_card)
//                        {
//                            byte[] send = new byte[1];
//                            send[0] = 0x05;
//                            comm.WritePort(send, 0, send.Length);
//                            Thread.Sleep(500);
//                            comm.DataReceived -= new Comm.EventHandle(comm_DataReceived);
//                            InitReadComm();
//                        }
//                        if (sendCardToOut)
//                        {
//                            byte[] send = new byte[1];
//                            send[0] = 0x05;
//                            comm.WritePort(send, 0, send.Length);
//
//
//                            readComm.DataReceived -= new Comm.EventHandle(readComm_DataReceived);
//                            readComm.Close();
//
//                            log.Info("发卡完成！");
//                            lblMsg.Text = "发卡成功！";
//                            lblSendCardMsg.Text = "发卡完成，请收好卡！";
//                            timer1.Tick -= new EventHandler(timer1_Tick);
//                            PlaySound();
//                            this.btnOK.Enabled = true;
//
//
//                        }
                    }
                    catch (Exception ex)
                    {
                        //log.Info(ex.ToString());
                    }
                }
            }
    }

        public void SendInstument(byte[] send)
        {
            
            if (_comm.IsOpen)
            {
                _comm.StopReading();
                _comm.WritePort(send, 0, send.Length);
                _comm.StartReading();
            }
        }

        public void SendReadDeviceSn()
        {
            byte[] send = new byte[] {0x10, 0x03, 0x06, 0x00,0x00,0x00};
            SendInstument(send);
        }

        public void Send
        
    }
}
