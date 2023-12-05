namespace ModbusDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnRW = new System.Windows.Forms.Button();
            this.rbxRWMsg = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudStartAdr = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSlaveID = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combxMode = new System.Windows.Forms.ComboBox();
            this.Connect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartAdr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSlaveID)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRW
            // 
            this.btnRW.Location = new System.Drawing.Point(6, 305);
            this.btnRW.Name = "btnRW";
            this.btnRW.Size = new System.Drawing.Size(121, 23);
            this.btnRW.TabIndex = 0;
            this.btnRW.Text = "读取";
            this.btnRW.UseVisualStyleBackColor = true;
            this.btnRW.Click += new System.EventHandler(this.btnRW_Click);
            // 
            // rbxRWMsg
            // 
            this.rbxRWMsg.Location = new System.Drawing.Point(285, 28);
            this.rbxRWMsg.Multiline = true;
            this.rbxRWMsg.Name = "rbxRWMsg";
            this.rbxRWMsg.Size = new System.Drawing.Size(378, 300);
            this.rbxRWMsg.TabIndex = 1;
            this.rbxRWMsg.TextChanged += new System.EventHandler(this.rbxRWMsg_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudLength);
            this.groupBox1.Controls.Add(this.btnRW);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudStartAdr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudSlaveID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbxRWMsg);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.combxMode);
            this.groupBox1.Location = new System.Drawing.Point(248, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 345);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "读写";
            // 
            // nudLength
            // 
            this.nudLength.Location = new System.Drawing.Point(8, 259);
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(120, 21);
            this.nudLength.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "地址长度";
            // 
            // nudStartAdr
            // 
            this.nudStartAdr.Location = new System.Drawing.Point(8, 191);
            this.nudStartAdr.Name = "nudStartAdr";
            this.nudStartAdr.Size = new System.Drawing.Size(120, 21);
            this.nudStartAdr.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "起始地址";
            // 
            // nudSlaveID
            // 
            this.nudSlaveID.Location = new System.Drawing.Point(8, 121);
            this.nudSlaveID.Name = "nudSlaveID";
            this.nudSlaveID.Size = new System.Drawing.Size(120, 21);
            this.nudSlaveID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "从站地址";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "读写模式选择";
            // 
            // combxMode
            // 
            this.combxMode.FormattingEnabled = true;
            this.combxMode.Items.AddRange(new object[] {
            "读取输出线圈",
            "读取离散输入",
            "读取保持型寄存器",
            "读取输入寄存器",
            "写入单个线圈",
            "写入多个线圈",
            "写入单个寄存器",
            "写入多个寄存器"});
            this.combxMode.Location = new System.Drawing.Point(6, 46);
            this.combxMode.Name = "combxMode";
            this.combxMode.Size = new System.Drawing.Size(121, 20);
            this.combxMode.TabIndex = 0;
            this.combxMode.SelectedIndexChanged += new System.EventHandler(this.combxMode_SelectedIndexChanged);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(42, 131);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(134, 61);
            this.Connect.TabIndex = 3;
            this.Connect.Text = "启动连接";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbMessage);
            this.groupBox2.Location = new System.Drawing.Point(21, 392);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(917, 118);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "通讯信息";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(21, 21);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(858, 80);
            this.tbMessage.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 61);
            this.button1.TabIndex = 5;
            this.button1.Text = "关闭连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 522);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartAdr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSlaveID)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnRW;
        private System.Windows.Forms.TextBox rbxRWMsg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudStartAdr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSlaveID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combxMode;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button button1;
    }
}

