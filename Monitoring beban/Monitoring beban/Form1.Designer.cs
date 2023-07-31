namespace Monitoring_beban
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.DigitalMeter1 = new LBSoft.IndustrialCtrls.Meters.LBDigitalMeter();
            this.DigitalMeter2 = new LBSoft.IndustrialCtrls.Meters.LBDigitalMeter();
            this.button18 = new System.Windows.Forms.Button();
            this.DigitalMeter3 = new LBSoft.IndustrialCtrls.Meters.LBDigitalMeter();
            this.button12 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.aquaGauge1 = new AquaControls.AquaGauge();
            this.button6 = new System.Windows.Forms.Button();
            this.aquaGauge2 = new AquaControls.AquaGauge();
            this.aquaGauge3 = new AquaControls.AquaGauge();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label5 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port Setting";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(6, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Connect";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM Port";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(65, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(157, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(2, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 145);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(2, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 261);
            this.button3.TabIndex = 1;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 239);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historical Data Viewer";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 61);
            this.textBox1.TabIndex = 5;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Info;
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(6, 17);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 23);
            this.button7.TabIndex = 5;
            this.button7.Text = "History location";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(257, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(614, 413);
            this.button5.TabIndex = 2;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1079, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Port_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(878, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 127);
            this.button4.TabIndex = 5;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gray;
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(889, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 109);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "History Saving setting";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(166, 238);
            this.listBox1.TabIndex = 7;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button13.Location = new System.Drawing.Point(290, 277);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(167, 27);
            this.button13.TabIndex = 12;
            this.button13.Text = "Energy";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button14.Location = new System.Drawing.Point(488, 277);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(167, 27);
            this.button14.TabIndex = 13;
            this.button14.Text = "Frequency";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // DigitalMeter1
            // 
            this.DigitalMeter1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DigitalMeter1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DigitalMeter1.Format = "0.00";
            this.DigitalMeter1.Location = new System.Drawing.Point(290, 310);
            this.DigitalMeter1.Name = "DigitalMeter1";
            this.DigitalMeter1.Renderer = null;
            this.DigitalMeter1.Signed = false;
            this.DigitalMeter1.Size = new System.Drawing.Size(111, 87);
            this.DigitalMeter1.TabIndex = 17;
            this.DigitalMeter1.Value = 0D;
            // 
            // DigitalMeter2
            // 
            this.DigitalMeter2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DigitalMeter2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DigitalMeter2.Format = "000";
            this.DigitalMeter2.Location = new System.Drawing.Point(488, 313);
            this.DigitalMeter2.Name = "DigitalMeter2";
            this.DigitalMeter2.Renderer = null;
            this.DigitalMeter2.Signed = false;
            this.DigitalMeter2.Size = new System.Drawing.Size(126, 87);
            this.DigitalMeter2.TabIndex = 18;
            this.DigitalMeter2.Value = 0D;
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button18.Location = new System.Drawing.Point(685, 277);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(167, 27);
            this.button18.TabIndex = 20;
            this.button18.Text = "Power Factor";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // DigitalMeter3
            // 
            this.DigitalMeter3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DigitalMeter3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DigitalMeter3.Format = "0.00";
            this.DigitalMeter3.Location = new System.Drawing.Point(685, 313);
            this.DigitalMeter3.Name = "DigitalMeter3";
            this.DigitalMeter3.Renderer = null;
            this.DigitalMeter3.Signed = false;
            this.DigitalMeter3.Size = new System.Drawing.Size(167, 87);
            this.DigitalMeter3.TabIndex = 21;
            this.DigitalMeter3.Value = 0D;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Location = new System.Drawing.Point(278, 267);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(191, 142);
            this.button12.TabIndex = 24;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.Location = new System.Drawing.Point(475, 267);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(191, 142);
            this.button15.TabIndex = 25;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button17.Location = new System.Drawing.Point(672, 267);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(191, 142);
            this.button17.TabIndex = 26;
            this.button17.UseVisualStyleBackColor = false;
            // 
            // aquaGauge1
            // 
            this.aquaGauge1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.aquaGauge1.DialColor = System.Drawing.Color.SkyBlue;
            this.aquaGauge1.DialText = "Volt";
            this.aquaGauge1.ForeColor = System.Drawing.Color.Black;
            this.aquaGauge1.Glossiness = 11.36364F;
            this.aquaGauge1.Location = new System.Drawing.Point(393, 59);
            this.aquaGauge1.MaxValue = 380F;
            this.aquaGauge1.MinValue = 0F;
            this.aquaGauge1.Name = "aquaGauge1";
            this.aquaGauge1.NoOfSubDivisions = 5;
            this.aquaGauge1.RecommendedValue = 0F;
            this.aquaGauge1.Size = new System.Drawing.Size(178, 178);
            this.aquaGauge1.TabIndex = 29;
            this.aquaGauge1.ThresholdPercent = 70F;
            this.aquaGauge1.Value = 0F;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button6.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Location = new System.Drawing.Point(265, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(598, 40);
            this.button6.TabIndex = 30;
            this.button6.Text = "Monitoring View";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // aquaGauge2
            // 
            this.aquaGauge2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.aquaGauge2.DialColor = System.Drawing.Color.SkyBlue;
            this.aquaGauge2.DialText = "Amp";
            this.aquaGauge2.Glossiness = 11.36364F;
            this.aquaGauge2.Location = new System.Drawing.Point(579, 59);
            this.aquaGauge2.MaxValue = 1F;
            this.aquaGauge2.MinValue = 0F;
            this.aquaGauge2.Name = "aquaGauge2";
            this.aquaGauge2.NoOfSubDivisions = 5;
            this.aquaGauge2.RecommendedValue = 0F;
            this.aquaGauge2.Size = new System.Drawing.Size(136, 136);
            this.aquaGauge2.TabIndex = 31;
            this.aquaGauge2.ThresholdPercent = 30F;
            this.aquaGauge2.Value = 0F;
            // 
            // aquaGauge3
            // 
            this.aquaGauge3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.aquaGauge3.DialColor = System.Drawing.Color.SkyBlue;
            this.aquaGauge3.DialText = "Watt";
            this.aquaGauge3.Glossiness = 11.36364F;
            this.aquaGauge3.Location = new System.Drawing.Point(709, 125);
            this.aquaGauge3.MaxValue = 50F;
            this.aquaGauge3.MinValue = 0F;
            this.aquaGauge3.Name = "aquaGauge3";
            this.aquaGauge3.NoOfSubDivisions = 5;
            this.aquaGauge3.RecommendedValue = 0F;
            this.aquaGauge3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aquaGauge3.Size = new System.Drawing.Size(136, 136);
            this.aquaGauge3.TabIndex = 33;
            this.aquaGauge3.ThresholdPercent = 50F;
            this.aquaGauge3.Value = 0F;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.guna2ImageButton1);
            this.groupBox4.Controls.Add(this.guna2ImageButton2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(276, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(100, 98);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Load Panel ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Lamp 2";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton1.Location = new System.Drawing.Point(6, 32);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(42, 53);
            this.guna2ImageButton1.TabIndex = 37;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.CheckedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton2.HoverState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton2.Location = new System.Drawing.Point(54, 32);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton2.PressedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Size = new System.Drawing.Size(39, 53);
            this.guna2ImageButton2.TabIndex = 38;
            this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Lamp 1";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Location = new System.Drawing.Point(265, 64);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(122, 112);
            this.button9.TabIndex = 35;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(398, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "KWh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(614, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 33);
            this.label4.TabIndex = 36;
            this.label4.Text = "Hz";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(878, 141);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(199, 278);
            this.button8.TabIndex = 37;
            this.button8.Text = "button1";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Gray;
            this.groupBox5.Controls.Add(this.listBox1);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Location = new System.Drawing.Point(889, 150);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(178, 259);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Log data viewer";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Info;
            this.button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Location = new System.Drawing.Point(6, 18);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(78, 23);
            this.button10.TabIndex = 6;
            this.button10.Text = "File location";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(6, 47);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(216, 186);
            this.listBox2.TabIndex = 7;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1079, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aquaGauge3);
            this.Controls.Add(this.aquaGauge2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.aquaGauge1);
            this.Controls.Add(this.DigitalMeter3);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.DigitalMeter2);
            this.Controls.Add(this.DigitalMeter1);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button5);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private LBSoft.IndustrialCtrls.Meters.LBDigitalMeter DigitalMeter1;
        private LBSoft.IndustrialCtrls.Meters.LBDigitalMeter DigitalMeter2;
        private System.Windows.Forms.Button button18;
        private LBSoft.IndustrialCtrls.Meters.LBDigitalMeter DigitalMeter3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button17;
        private AquaControls.AquaGauge aquaGauge1;
        private System.Windows.Forms.Button button6;
        private AquaControls.AquaGauge aquaGauge2;
        private AquaControls.AquaGauge aquaGauge3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

