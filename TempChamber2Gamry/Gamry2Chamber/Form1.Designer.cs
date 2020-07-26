using System;

namespace Gamry2Chamber
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataPathBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioLevel = new System.Windows.Forms.RadioButton();
            this.radioLevelEdge = new System.Windows.Forms.RadioButton();
            this.stopBtn = new System.Windows.Forms.Button();
            this.tsField = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.tcnField = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LoPt = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.HiPt = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rhspText = new System.Windows.Forms.Label();
            this.tspText = new System.Windows.Forms.Label();
            this.readRhspBtn = new System.Windows.Forms.Button();
            this.readTspBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.readTpvBtn = new System.Windows.Forms.Button();
            this.tpvText = new System.Windows.Forms.Label();
            this.rhpvText = new System.Windows.Forms.Label();
            this.readRhpvBtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableField = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.schemaField = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.linkField = new System.Windows.Forms.TextBox();
            this.portSQLField = new System.Windows.Forms.TextBox();
            this.userField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.connectSQLBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.connectChamberBtn = new System.Windows.Forms.Button();
            this.ipField = new System.Windows.Forms.TextBox();
            this.subnetField = new System.Windows.Forms.TextBox();
            this.portChamberField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pinsField = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.replicateField = new System.Windows.Forms.TextBox();
            this.batchField = new System.Windows.Forms.TextBox();
            this.moduleField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTipGamry = new System.Windows.Forms.ToolTip(this.components);
            this.tabPage5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcnField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoPt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HiPt)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Controls.Add(this.dataPathBtn);
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Controls.Add(this.stopBtn);
            this.tabPage5.Controls.Add(this.tsField);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.startBtn);
            this.tabPage5.Controls.Add(this.tcnField);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.LoPt);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.HiPt);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Location = new System.Drawing.Point(4, 38);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1115, 609);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "Profile";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 28);
            this.button2.TabIndex = 18;
            this.button2.Text = "test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // dataPathBtn
            // 
            this.dataPathBtn.BackColor = System.Drawing.Color.Green;
            this.dataPathBtn.Enabled = false;
            this.dataPathBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPathBtn.Location = new System.Drawing.Point(174, 216);
            this.dataPathBtn.Name = "dataPathBtn";
            this.dataPathBtn.Size = new System.Drawing.Size(223, 55);
            this.dataPathBtn.TabIndex = 17;
            this.dataPathBtn.Text = "Data path";
            this.dataPathBtn.UseVisualStyleBackColor = false;
            this.dataPathBtn.Click += new System.EventHandler(this.pathBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioLevel);
            this.groupBox1.Controls.Add(this.radioLevelEdge);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(580, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 151);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioLevel
            // 
            this.radioLevel.AutoSize = true;
            this.radioLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLevel.Location = new System.Drawing.Point(25, 44);
            this.radioLevel.Name = "radioLevel";
            this.radioLevel.Size = new System.Drawing.Size(109, 41);
            this.radioLevel.TabIndex = 16;
            this.radioLevel.Text = "Level";
            this.radioLevel.UseVisualStyleBackColor = true;
            this.radioLevel.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioLevelEdge
            // 
            this.radioLevelEdge.AutoSize = true;
            this.radioLevelEdge.Checked = true;
            this.radioLevelEdge.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLevelEdge.Location = new System.Drawing.Point(25, 91);
            this.radioLevelEdge.Name = "radioLevelEdge";
            this.radioLevelEdge.Size = new System.Drawing.Size(220, 41);
            this.radioLevelEdge.TabIndex = 15;
            this.radioLevelEdge.TabStop = true;
            this.radioLevelEdge.Text = "Level + Edge";
            this.radioLevelEdge.UseVisualStyleBackColor = true;
            // 
            // stopBtn
            // 
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.Location = new System.Drawing.Point(580, 409);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(292, 56);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.Text = "Stop profile";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // tsField
            // 
            this.tsField.DecimalPlaces = 1;
            this.tsField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsField.Location = new System.Drawing.Point(656, 36);
            this.tsField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tsField.Name = "tsField";
            this.tsField.Size = new System.Drawing.Size(93, 47);
            this.tsField.TabIndex = 10;
            this.tsField.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.tsField.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(755, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 39);
            this.label7.TabIndex = 8;
            this.label7.Text = "°C";
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(174, 409);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(292, 56);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start profile";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // tcnField
            // 
            this.tcnField.DecimalPlaces = 1;
            this.tcnField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcnField.Location = new System.Drawing.Point(354, 36);
            this.tcnField.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.tcnField.Name = "tcnField";
            this.tcnField.Size = new System.Drawing.Size(93, 47);
            this.tcnField.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(371, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 39);
            this.label6.TabIndex = 7;
            this.label6.Text = "°C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(567, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 39);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ts";
            // 
            // LoPt
            // 
            this.LoPt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoPt.Location = new System.Drawing.Point(656, 123);
            this.LoPt.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.LoPt.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.LoPt.Name = "LoPt";
            this.LoPt.Size = new System.Drawing.Size(93, 47);
            this.LoPt.TabIndex = 6;
            this.LoPt.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.LoPt.ValueChanged += new System.EventHandler(this.LoPt_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(167, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 39);
            this.label14.TabIndex = 4;
            this.label14.Text = "Start TCN";
            // 
            // HiPt
            // 
            this.HiPt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HiPt.Location = new System.Drawing.Point(254, 125);
            this.HiPt.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.HiPt.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.HiPt.Name = "HiPt";
            this.HiPt.Size = new System.Drawing.Size(93, 47);
            this.HiPt.TabIndex = 6;
            this.HiPt.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.HiPt.ValueChanged += new System.EventHandler(this.HighPt_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(567, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "TL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(755, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 39);
            this.label9.TabIndex = 7;
            this.label9.Text = "min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 39);
            this.label4.TabIndex = 4;
            this.label4.Text = "TH";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rhspText);
            this.tabPage2.Controls.Add(this.tspText);
            this.tabPage2.Controls.Add(this.readRhspBtn);
            this.tabPage2.Controls.Add(this.readTspBtn);
            this.tabPage2.Controls.Add(this.nextBtn);
            this.tabPage2.Controls.Add(this.readTpvBtn);
            this.tabPage2.Controls.Add(this.tpvText);
            this.tabPage2.Controls.Add(this.rhpvText);
            this.tabPage2.Controls.Add(this.readRhpvBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1115, 609);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Test chamber";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rhspText
            // 
            this.rhspText.AutoSize = true;
            this.rhspText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rhspText.Location = new System.Drawing.Point(848, 256);
            this.rhspText.Name = "rhspText";
            this.rhspText.Size = new System.Drawing.Size(35, 33);
            this.rhspText.TabIndex = 10;
            this.rhspText.Tag = "rhspText";
            this.rhspText.Text = "--";
            // 
            // tspText
            // 
            this.tspText.AutoSize = true;
            this.tspText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspText.Location = new System.Drawing.Point(848, 132);
            this.tspText.Name = "tspText";
            this.tspText.Size = new System.Drawing.Size(35, 33);
            this.tspText.TabIndex = 9;
            this.tspText.Tag = "tspText";
            this.tspText.Text = "--";
            this.tspText.Click += new System.EventHandler(this.label20_Click);
            // 
            // readRhspBtn
            // 
            this.readRhspBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readRhspBtn.Location = new System.Drawing.Point(555, 247);
            this.readRhspBtn.Name = "readRhspBtn";
            this.readRhspBtn.Size = new System.Drawing.Size(287, 56);
            this.readRhspBtn.TabIndex = 8;
            this.readRhspBtn.Text = "Read RHSP (%)";
            this.readRhspBtn.UseVisualStyleBackColor = true;
            this.readRhspBtn.Click += new System.EventHandler(this.readRhspBtn_Click);
            // 
            // readTspBtn
            // 
            this.readTspBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readTspBtn.Location = new System.Drawing.Point(555, 122);
            this.readTspBtn.Name = "readTspBtn";
            this.readTspBtn.Size = new System.Drawing.Size(287, 58);
            this.readTspBtn.TabIndex = 7;
            this.readTspBtn.Text = "Read TSP (°C)";
            this.readTspBtn.UseVisualStyleBackColor = true;
            this.readTspBtn.Click += new System.EventHandler(this.readTspBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Location = new System.Drawing.Point(827, 417);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(157, 59);
            this.nextBtn.TabIndex = 6;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // readTpvBtn
            // 
            this.readTpvBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readTpvBtn.Location = new System.Drawing.Point(57, 122);
            this.readTpvBtn.Name = "readTpvBtn";
            this.readTpvBtn.Size = new System.Drawing.Size(290, 58);
            this.readTpvBtn.TabIndex = 0;
            this.readTpvBtn.Text = "Read TPV (°C)";
            this.readTpvBtn.UseVisualStyleBackColor = true;
            this.readTpvBtn.Click += new System.EventHandler(this.readTempBtn_Click);
            // 
            // tpvText
            // 
            this.tpvText.AutoSize = true;
            this.tpvText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpvText.Location = new System.Drawing.Point(353, 132);
            this.tpvText.Name = "tpvText";
            this.tpvText.Size = new System.Drawing.Size(35, 33);
            this.tpvText.TabIndex = 4;
            this.tpvText.Tag = "tpvText";
            this.tpvText.Text = "--";
            this.tpvText.Click += new System.EventHandler(this.tpvText_Click);
            // 
            // rhpvText
            // 
            this.rhpvText.AutoSize = true;
            this.rhpvText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rhpvText.Location = new System.Drawing.Point(353, 256);
            this.rhpvText.Name = "rhpvText";
            this.rhpvText.Size = new System.Drawing.Size(35, 33);
            this.rhpvText.TabIndex = 4;
            this.rhpvText.Tag = "rhpvText";
            this.rhpvText.Text = "--";
            this.rhpvText.Click += new System.EventHandler(this.rhpvText_Click);
            // 
            // readRhpvBtn
            // 
            this.readRhpvBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readRhpvBtn.Location = new System.Drawing.Point(57, 247);
            this.readRhpvBtn.Name = "readRhpvBtn";
            this.readRhpvBtn.Size = new System.Drawing.Size(290, 56);
            this.readRhpvBtn.TabIndex = 5;
            this.readRhpvBtn.Text = "Read RHPV (%)";
            this.readRhpvBtn.UseVisualStyleBackColor = true;
            this.readRhpvBtn.Click += new System.EventHandler(this.readRHBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableField);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.schemaField);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.linkField);
            this.tabPage3.Controls.Add(this.portSQLField);
            this.tabPage3.Controls.Add(this.userField);
            this.tabPage3.Controls.Add(this.passField);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.connectSQLBtn);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1115, 609);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Cloud connection";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableField
            // 
            this.tableField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableField.Location = new System.Drawing.Point(322, 167);
            this.tableField.Name = "tableField";
            this.tableField.Size = new System.Drawing.Size(557, 47);
            this.tableField.TabIndex = 15;
            this.tableField.Text = "tempcycler";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(49, 170);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 39);
            this.label19.TabIndex = 14;
            this.label19.Text = "Table";
            // 
            // schemaField
            // 
            this.schemaField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schemaField.Location = new System.Drawing.Point(322, 103);
            this.schemaField.Name = "schemaField";
            this.schemaField.Size = new System.Drawing.Size(557, 47);
            this.schemaField.TabIndex = 13;
            this.schemaField.Text = "bio_semi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(267, 39);
            this.label10.TabIndex = 4;
            this.label10.Text = "mySQL address";
            // 
            // linkField
            // 
            this.linkField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkField.Location = new System.Drawing.Point(322, 34);
            this.linkField.Name = "linkField";
            this.linkField.Size = new System.Drawing.Size(557, 47);
            this.linkField.TabIndex = 3;
            this.linkField.Text = "rds-oitdb550.cmjkthii0kmp.us-east-1.rds.amazonaws.com";
            // 
            // portSQLField
            // 
            this.portSQLField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portSQLField.Location = new System.Drawing.Point(322, 364);
            this.portSQLField.Name = "portSQLField";
            this.portSQLField.Size = new System.Drawing.Size(240, 47);
            this.portSQLField.TabIndex = 12;
            this.portSQLField.Text = "2445";
            // 
            // userField
            // 
            this.userField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userField.Location = new System.Drawing.Point(322, 235);
            this.userField.Name = "userField";
            this.userField.Size = new System.Drawing.Size(240, 47);
            this.userField.TabIndex = 3;
            this.userField.Text = "dgs150030";
            this.userField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passField.Location = new System.Drawing.Point(322, 297);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(240, 47);
            this.passField.TabIndex = 3;
            this.passField.Text = "rTnF9_UrD8x";
            this.passField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(49, 367);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 39);
            this.label13.TabIndex = 11;
            this.label13.Text = "Port";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(49, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 39);
            this.label15.TabIndex = 4;
            this.label15.Text = "Schema";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(49, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 39);
            this.label11.TabIndex = 4;
            this.label11.Text = "User name";
            // 
            // connectSQLBtn
            // 
            this.connectSQLBtn.BackColor = System.Drawing.Color.Red;
            this.connectSQLBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectSQLBtn.ForeColor = System.Drawing.Color.White;
            this.connectSQLBtn.Location = new System.Drawing.Point(596, 409);
            this.connectSQLBtn.Name = "connectSQLBtn";
            this.connectSQLBtn.Size = new System.Drawing.Size(372, 58);
            this.connectSQLBtn.TabIndex = 9;
            this.connectSQLBtn.Text = "Connect SQL server";
            this.connectSQLBtn.UseVisualStyleBackColor = false;
            this.connectSQLBtn.Click += new System.EventHandler(this.connectSQLBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(49, 300);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 39);
            this.label12.TabIndex = 4;
            this.label12.Text = "Password";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.connectChamberBtn);
            this.tabPage1.Controls.Add(this.ipField);
            this.tabPage1.Controls.Add(this.subnetField);
            this.tabPage1.Controls.Add(this.portChamberField);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1115, 609);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chamber connection";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chamber IP address";
            // 
            // connectChamberBtn
            // 
            this.connectChamberBtn.BackColor = System.Drawing.Color.Red;
            this.connectChamberBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectChamberBtn.ForeColor = System.Drawing.Color.White;
            this.connectChamberBtn.Location = new System.Drawing.Point(605, 398);
            this.connectChamberBtn.Name = "connectChamberBtn";
            this.connectChamberBtn.Size = new System.Drawing.Size(352, 58);
            this.connectChamberBtn.TabIndex = 0;
            this.connectChamberBtn.Text = "Connect chamber";
            this.connectChamberBtn.UseVisualStyleBackColor = false;
            this.connectChamberBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // ipField
            // 
            this.ipField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipField.Location = new System.Drawing.Point(447, 45);
            this.ipField.Name = "ipField";
            this.ipField.Size = new System.Drawing.Size(273, 47);
            this.ipField.TabIndex = 3;
            this.ipField.Tag = "ipField";
            this.ipField.Text = "10.163.46.185";
            // 
            // subnetField
            // 
            this.subnetField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subnetField.Location = new System.Drawing.Point(447, 124);
            this.subnetField.Name = "subnetField";
            this.subnetField.Size = new System.Drawing.Size(273, 47);
            this.subnetField.TabIndex = 3;
            this.subnetField.Tag = "subnetField";
            this.subnetField.Text = "255.255.254.0";
            this.subnetField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // portChamberField
            // 
            this.portChamberField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portChamberField.Location = new System.Drawing.Point(447, 203);
            this.portChamberField.Name = "portChamberField";
            this.portChamberField.Size = new System.Drawing.Size(273, 47);
            this.portChamberField.TabIndex = 3;
            this.portChamberField.Tag = "portChamberField";
            this.portChamberField.Text = "5025";
            this.portChamberField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subnet mask";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1123, 651);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pinsField);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.replicateField);
            this.tabPage4.Controls.Add(this.batchField);
            this.tabPage4.Controls.Add(this.moduleField);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Location = new System.Drawing.Point(4, 38);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1115, 609);
            this.tabPage4.TabIndex = 6;
            this.tabPage4.Text = "Chip info";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // pinsField
            // 
            this.pinsField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.5F);
            this.pinsField.Location = new System.Drawing.Point(431, 284);
            this.pinsField.Name = "pinsField";
            this.pinsField.Size = new System.Drawing.Size(329, 47);
            this.pinsField.TabIndex = 11;
            this.pinsField.Text = "9-12";
            this.pinsField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(190, 284);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 39);
            this.label20.TabIndex = 10;
            this.label20.Text = "Pins";
            this.label20.Click += new System.EventHandler(this.label20_Click_1);
            // 
            // replicateField
            // 
            this.replicateField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replicateField.Location = new System.Drawing.Point(431, 212);
            this.replicateField.Name = "replicateField";
            this.replicateField.Size = new System.Drawing.Size(329, 47);
            this.replicateField.TabIndex = 9;
            this.replicateField.Text = "C1";
            // 
            // batchField
            // 
            this.batchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchField.Location = new System.Drawing.Point(431, 143);
            this.batchField.Name = "batchField";
            this.batchField.Size = new System.Drawing.Size(329, 47);
            this.batchField.TabIndex = 8;
            this.batchField.Text = "S1";
            // 
            // moduleField
            // 
            this.moduleField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduleField.Location = new System.Drawing.Point(431, 70);
            this.moduleField.Name = "moduleField";
            this.moduleField.Size = new System.Drawing.Size(329, 47);
            this.moduleField.TabIndex = 7;
            this.moduleField.Text = "SWR90456";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(826, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button2_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(190, 212);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(162, 39);
            this.label18.TabIndex = 1;
            this.label18.Text = "Replicate";
            this.label18.Click += new System.EventHandler(this.label17_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(190, 143);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 39);
            this.label17.TabIndex = 1;
            this.label17.Text = "Batch";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(190, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(130, 39);
            this.label16.TabIndex = 0;
            this.label16.Text = "Module";
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 38);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1115, 609);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Help";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.pictureBox2);
            this.tabPage7.Controls.Add(this.pictureBox1);
            this.tabPage7.Location = new System.Drawing.Point(4, 38);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1115, 609);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "About";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImageLocation = "C:\\Users\\dgs150030\\Documents\\GitHub\\PlotterScripts\\TempChamber2Gamry\\Gamry2Chambe" +
    "r\\TI.jpg";
            this.pictureBox2.InitialImage = global::Gamry2Chamber.Properties.Resources.TI;
            this.pictureBox2.Location = new System.Drawing.Point(438, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(524, 331);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "C:\\Users\\dgs150030\\Documents\\GitHub\\PlotterScripts\\TempChamber2Gamry\\Gamry2Chambe" +
    "r\\UTD.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(60, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toolTipGamry
            // 
            this.toolTipGamry.IsBalloon = true;
            this.toolTipGamry.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTipGamry.ToolTipTitle = "Warning!";
            this.toolTipGamry.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTipDataPath_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 651);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Chamber2Gamry";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcnField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoPt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HiPt)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void label17_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.NumericUpDown tsField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.NumericUpDown tcnField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown LoPt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown HiPt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button readTpvBtn;
        private System.Windows.Forms.Label tpvText;
        private System.Windows.Forms.Label rhpvText;
        private System.Windows.Forms.Button readRhpvBtn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox linkField;
        private System.Windows.Forms.TextBox portSQLField;
        private System.Windows.Forms.TextBox userField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button connectSQLBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectChamberBtn;
        private System.Windows.Forms.TextBox ipField;
        private System.Windows.Forms.TextBox subnetField;
        private System.Windows.Forms.TextBox portChamberField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox schemaField;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button dataPathBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioLevel;
        private System.Windows.Forms.RadioButton radioLevelEdge;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTipGamry;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox replicateField;
        private System.Windows.Forms.TextBox batchField;
        private System.Windows.Forms.TextBox moduleField;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tableField;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label tspText;
        private System.Windows.Forms.Button readRhspBtn;
        private System.Windows.Forms.Button readTspBtn;
        private System.Windows.Forms.Label rhspText;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox pinsField;
    }
}

