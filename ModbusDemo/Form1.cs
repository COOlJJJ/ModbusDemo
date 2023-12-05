using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modbus.Device;

namespace ModbusDemo
{


    //原文链接： https://blog.csdn.net/cenwenjing/article/details/129208775
    //原文链接：https://blog.csdn.net/XUMENGCAS/article/details/122305152

    public partial class Form1 : Form
    {

        /// <summary>
        /// 私有串口实例
        /// </summary>
        private SerialPort serialPort = new SerialPort();

        /// <summary>
        /// 私有ModbusRTU主站字段
        /// </summary>
        private static IModbusMaster master;

        public Form1()
        {
            InitializeComponent();
            combxMode.SelectedIndex = 0;
            //设置读写窗口默认选中项
            nudSlaveID.Minimum = 1;
            nudStartAdr.Minimum = 0;
            nudLength.Minimum = 1;
            //设置为默认输入法，即为英文半角
            rbxRWMsg.ImeMode = ImeMode.Disable;
        }

        /// <summary>
        /// 写入单个线圈
        /// </summary>
        private void WriteSingleCoil()
        {
            bool result = false;
            if (rbxRWMsg.Text.Equals("true", StringComparison.OrdinalIgnoreCase) || rbxRWMsg.Text.Equals("1", StringComparison.OrdinalIgnoreCase))
            {
                result = true;
            }
            master.WriteSingleCoil((byte)nudSlaveID.Value, (ushort)nudStartAdr.Value, result);
        }

        /// <summary>
        /// 批量写入线圈
        /// </summary>
        private void WriteArrayCoil()
        {
            List<string> strList = rbxRWMsg.Text.Split(',').ToList();

            List<bool> result = new List<bool>();

            strList.ForEach(m => result.Add(m.Equals("true", StringComparison.OrdinalIgnoreCase) || m.Equals("1", StringComparison.OrdinalIgnoreCase)));

            master.WriteMultipleCoils((byte)nudSlaveID.Value, (ushort)nudStartAdr.Value, result.ToArray());
        }

        /// <summary>
        /// 写入单个寄存器
        /// </summary>
        private void WriteSingleRegister()
        {
            ushort result = Convert.ToUInt16(rbxRWMsg.Text);

            master.WriteSingleRegister((byte)nudSlaveID.Value, (ushort)nudStartAdr.Value, result);
        }

        /// <summary>
        /// 批量写入寄存器
        /// </summary>
        private void WriteArrayRegister()
        {
            List<string> strList = rbxRWMsg.Text.Split(',').ToList();

            List<ushort> result = new List<ushort>();

            strList.ForEach(m => result.Add(Convert.ToUInt16(m)));

            master.WriteMultipleRegisters((byte)nudSlaveID.Value, (ushort)nudStartAdr.Value, result.ToArray());
        }

        /// <summary>
        /// 读取输出线圈
        /// </summary>
        /// <returns></returns>
        private bool[] ReadCoils()
        {
            return master.ReadCoils((byte)nudSlaveID.Value, (ushort)nudStartAdr.Value, (ushort)nudLength.Value);
        }

        /// <summary>
        /// 读取输入线圈
        /// </summary>
        /// <returns></returns>
        private bool[] ReadInputs()
        {
            return master.ReadInputs((byte)nudSlaveID.Value, (ushort)nudStartAdr.Value, (ushort)nudLength.Value);
        }

        /// <summary>
        /// 读取保持型寄存器
        /// </summary>
        /// <returns></returns>
        private ushort[] ReadHoldingRegisters()
        {
            return master.ReadHoldingRegisters((byte)nudSlaveID.Value, (ushort)nudStartAdr.Value, (ushort)nudLength.Value);
        }

        /// <summary>
        /// 读取输入寄存器
        /// </summary>
        /// <returns></returns>
        private ushort[] ReadInputRegisters()
        {
            return master.ReadInputRegisters((byte)nudSlaveID.Value, (ushort)nudStartAdr.Value, (ushort)nudLength.Value);
        }

        /// <summary>
        /// 界面显示读取结果
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="result"></param>
        private void SetMsg<T>(List<T> result)
        {
            string msg = string.Empty;

            result.ForEach(m => msg += $"{m} ");

            rbxRWMsg.Text = msg.Trim();
        }

        private void btnRW_Click(object sender, EventArgs e)
        {


            //根据选择的模式进行读写
            switch (combxMode.SelectedItem.ToString())
            {
                case "读取输出线圈":
                    SetMsg(ReadCoils().ToList());
                    break;
                case "读取离散输入":
                    SetMsg(ReadInputs().ToList());
                    break;
                case "读取保持型寄存器":
                    SetMsg(ReadHoldingRegisters().ToList());
                    break;
                case "读取输入寄存器":
                    SetMsg(ReadInputRegisters().ToList());
                    break;
                case "写入单个线圈":
                    if (rbxRWMsg.Text.Contains(","))
                    {
                        MessageBox.Show("输入值过多");
                        return;
                    }
                    WriteSingleCoil();
                    break;
                case "写入多个线圈":
                    WriteArrayCoil();
                    break;
                case "写入单个寄存器":
                    if (rbxRWMsg.Text.Contains(","))
                    {
                        MessageBox.Show("输入值过多");
                        return;
                    }
                    WriteSingleRegister();
                    break;
                case "写入多个寄存器":
                    WriteArrayRegister();
                    break;
                default:
                    break;
            }


        }

        private void rbxRWMsg_TextChanged(object sender, EventArgs e)
        {
            nudLength.Value = Regex.Matches(rbxRWMsg.Text, ",").Count + 1;
        }

        private void combxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbMessage.Clear();
            if (combxMode.SelectedItem.ToString().Contains("读取"))
            {
                btnRW.Text = "读取";
                rbxRWMsg.Enabled = false;
            }
            else
            {
                btnRW.Text = "写入";
                rbxRWMsg.Enabled = true;
            }


        }

        /// <summary>
        /// 建立连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Connect_Click(object sender, EventArgs e)
        {
            //设定串口参数
            serialPort.PortName = "COM1";
            serialPort.BaudRate = 9600;
            serialPort.Parity = Parity.Even;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;

            //创建ModbusRTU主站实例
            master = ModbusSerialMaster.CreateRtu(serialPort);

            //打开串口
            if (!serialPort.IsOpen) serialPort.Open();
            tbMessage.Text = "连接成功";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //关闭串口
            serialPort.Close();
        }
    }


}
