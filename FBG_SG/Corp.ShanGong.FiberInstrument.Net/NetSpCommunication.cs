using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Corp.ShanGong.FiberInstrument.Net
{
    public class NetSpCommunication
    {
        public delegate void EventHandle(byte[] readBuffer);

        public event EventHandle DataReceived;

        private SerialPort _serialPort;

        public SerialPort SPort { get; set; }
        private Thread thread;
        private volatile bool _keepReading;

        public NetSpCommunication()
        {
            _serialPort = new SerialPort();
            thread = null;
            _keepReading = false;
        }

        public bool IsOpen
        {
            get { return _serialPort.IsOpen; }
        }

        private void StartReading()
        {
            if (!_keepReading)
            {
                _keepReading = true;
                thread = new Thread(new ThreadStart(ReadPort));
                thread.Start();
            }
        }

        private void StopReading()
        {
            if (_keepReading)
            {
                _keepReading = false;
                thread.Join();
                thread = null;
            }
        }

        private void ReadPort()
        {
            while (_keepReading)
            {
                if (_serialPort.IsOpen)
                {
                    int count = _serialPort.BytesToRead;
                    if (count > 0)
                    {
                        byte[] readBuffer = new byte[count];
                        try
                        {
                            //MediaTypeNames.Application.DoEvents();
                            _serialPort.Read(readBuffer, 0, count);
                            if (DataReceived != null)
                                DataReceived(readBuffer);
                            Thread.Sleep(100);
                        }
                        catch (TimeoutException)
                        {
                        }
                    }
                }
            }
        }

        public bool Open()
        {
            Close();
            _serialPort.Open();
            if (_serialPort.IsOpen)
            {
                StartReading();
                return true;
            }
            else
            {
                //MessageBox.Show("串口打开失败！");
                return false;
            }
        }

        public void Close()
        {
            StopReading();
            _serialPort.Close();
        }

        public void WritePort(byte[] send, int offSet, int count)
        {
            if (IsOpen)
            {
                _serialPort.Write(send, offSet, count);
            }
        }
    }


}
