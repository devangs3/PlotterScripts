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
            this.readTempBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.ipField = new System.Windows.Forms.TextBox();
            this.subnetField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portChamberField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.connectChamberBtn = new System.Windows.Forms.Button();
            this.tempText = new System.Windows.Forms.Label();
            this.rhText = new System.Windows.Forms.Label();
            this.readRHBtn = new System.Windows.Forms.Button();
            this.HighPt = new System.Windows.Forms.NumericUpDown();
            this.LoPt = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.linkField = new System.Windows.Forms.TextBox();
            this.userField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.connectSQLBtn = new System.Windows.Forms.Button();
            this.Ts = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.portSQLField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.HighPt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoPt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ts)).BeginInit();
            this.SuspendLayout();
            // 
            // readTempBtn
            // 
            this.readTempBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readTempBtn.Location = new System.Drawing.Point(66, 425);
            this.readTempBtn.Name = "readTempBtn";
            this.readTempBtn.Size = new System.Drawing.Size(192, 58);
            this.readTempBtn.TabIndex = 0;
            this.readTempBtn.Text = "Read T";
            this.readTempBtn.UseVisualStyleBackColor = true;
            this.readTempBtn.Click += new System.EventHandler(this.readTempBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(320, 423);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(292, 60);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start profile";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.Location = new System.Drawing.Point(320, 558);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(292, 56);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.Text = "Stop profile";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // ipField
            // 
            this.ipField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipField.Location = new System.Drawing.Point(409, 31);
            this.ipField.Name = "ipField";
            this.ipField.Size = new System.Drawing.Size(273, 47);
            this.ipField.TabIndex = 3;
            this.ipField.Text = "10.163.46.185";
            // 
            // subnetField
            // 
            this.subnetField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subnetField.Location = new System.Drawing.Point(409, 110);
            this.subnetField.Name = "subnetField";
            this.subnetField.Size = new System.Drawing.Size(273, 47);
            this.subnetField.TabIndex = 3;
            this.subnetField.Text = "255.255.254.0";
            this.subnetField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chamber IP address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subnet mask";
            // 
            // portChamberField
            // 
            this.portChamberField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portChamberField.Location = new System.Drawing.Point(409, 189);
            this.portChamberField.Name = "portChamberField";
            this.portChamberField.Size = new System.Drawing.Size(273, 47);
            this.portChamberField.TabIndex = 3;
            this.portChamberField.Text = "5025";
            this.portChamberField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port";
            // 
            // connectChamberBtn
            // 
            this.connectChamberBtn.BackColor = System.Drawing.Color.Red;
            this.connectChamberBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectChamberBtn.ForeColor = System.Drawing.Color.White;
            this.connectChamberBtn.Location = new System.Drawing.Point(194, 279);
            this.connectChamberBtn.Name = "connectChamberBtn";
            this.connectChamberBtn.Size = new System.Drawing.Size(352, 58);
            this.connectChamberBtn.TabIndex = 0;
            this.connectChamberBtn.Text = "Connect chamber";
            this.connectChamberBtn.UseVisualStyleBackColor = false;
            this.connectChamberBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // tempText
            // 
            this.tempText.AutoSize = true;
            this.tempText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempText.Location = new System.Drawing.Point(73, 486);
            this.tempText.Name = "tempText";
            this.tempText.Size = new System.Drawing.Size(41, 39);
            this.tempText.TabIndex = 4;
            this.tempText.Text = "--";
            // 
            // rhText
            // 
            this.rhText.AutoSize = true;
            this.rhText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rhText.Location = new System.Drawing.Point(73, 619);
            this.rhText.Name = "rhText";
            this.rhText.Size = new System.Drawing.Size(41, 39);
            this.rhText.TabIndex = 4;
            this.rhText.Text = "--";
            // 
            // readRHBtn
            // 
            this.readRHBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readRHBtn.Location = new System.Drawing.Point(66, 558);
            this.readRHBtn.Name = "readRHBtn";
            this.readRHBtn.Size = new System.Drawing.Size(192, 56);
            this.readRHBtn.TabIndex = 5;
            this.readRHBtn.Text = "Read RH";
            this.readRHBtn.UseVisualStyleBackColor = true;
            this.readRHBtn.Click += new System.EventHandler(this.readRHBtn_Click);
            // 
            // HighPt
            // 
            this.HighPt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighPt.Location = new System.Drawing.Point(1067, 565);
            this.HighPt.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.HighPt.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.HighPt.Name = "HighPt";
            this.HighPt.Size = new System.Drawing.Size(93, 47);
            this.HighPt.TabIndex = 6;
            this.HighPt.Value = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.HighPt.ValueChanged += new System.EventHandler(this.HighPt_ValueChanged);
            // 
            // LoPt
            // 
            this.LoPt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoPt.Location = new System.Drawing.Point(756, 565);
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
            150,
            0,
            0,
            0});
            this.LoPt.ValueChanged += new System.EventHandler(this.LoPt_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(667, 565);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 39);
            this.label4.TabIndex = 4;
            this.label4.Text = "TH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(984, 565);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "TL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(855, 565);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 39);
            this.label6.TabIndex = 7;
            this.label6.Text = "°C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1166, 565);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 39);
            this.label7.TabIndex = 8;
            this.label7.Text = "°C";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(826, 486);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 39);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1014, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 39);
            this.label9.TabIndex = 7;
            this.label9.Text = "min";
            // 
            // linkField
            // 
            this.linkField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkField.Location = new System.Drawing.Point(976, 31);
            this.linkField.Name = "linkField";
            this.linkField.Size = new System.Drawing.Size(240, 47);
            this.linkField.TabIndex = 3;
            this.linkField.Text = "rds-oitdb550.cmjkthii0kmp.us-east-1.rds.amazonaws.com";
            // 
            // userField
            // 
            this.userField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userField.Location = new System.Drawing.Point(976, 105);
            this.userField.Name = "userField";
            this.userField.Size = new System.Drawing.Size(240, 47);
            this.userField.TabIndex = 3;
            this.userField.Text = "dgs150030";
            this.userField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passField.Location = new System.Drawing.Point(976, 184);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(240, 47);
            this.passField.TabIndex = 3;
            this.passField.Text = "rTnF9_UrD8x";
            this.passField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(703, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(267, 39);
            this.label10.TabIndex = 4;
            this.label10.Text = "mySQL address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(703, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 39);
            this.label11.TabIndex = 4;
            this.label11.Text = "User name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(703, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 39);
            this.label12.TabIndex = 4;
            this.label12.Text = "Password";
            // 
            // connectSQLBtn
            // 
            this.connectSQLBtn.BackColor = System.Drawing.Color.Red;
            this.connectSQLBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectSQLBtn.ForeColor = System.Drawing.Color.White;
            this.connectSQLBtn.Location = new System.Drawing.Point(776, 354);
            this.connectSQLBtn.Name = "connectSQLBtn";
            this.connectSQLBtn.Size = new System.Drawing.Size(372, 58);
            this.connectSQLBtn.TabIndex = 9;
            this.connectSQLBtn.Text = "Connect SQL server";
            this.connectSQLBtn.UseVisualStyleBackColor = false;
            this.connectSQLBtn.Click += new System.EventHandler(this.connectSQLBtn_Click);
            // 
            // Ts
            // 
            this.Ts.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ts.Location = new System.Drawing.Point(915, 484);
            this.Ts.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Ts.Name = "Ts";
            this.Ts.Size = new System.Drawing.Size(93, 47);
            this.Ts.TabIndex = 10;
            this.Ts.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Ts.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(703, 264);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 39);
            this.label13.TabIndex = 11;
            this.label13.Text = "Port";
            // 
            // portSQLField
            // 
            this.portSQLField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portSQLField.Location = new System.Drawing.Point(976, 256);
            this.portSQLField.Name = "portSQLField";
            this.portSQLField.Size = new System.Drawing.Size(240, 47);
            this.portSQLField.TabIndex = 12;
            this.portSQLField.Text = "2445";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 691);
            this.Controls.Add(this.portSQLField);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Ts);
            this.Controls.Add(this.connectSQLBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LoPt);
            this.Controls.Add(this.HighPt);
            this.Controls.Add(this.readRHBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rhText);
            this.Controls.Add(this.tempText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.userField);
            this.Controls.Add(this.portChamberField);
            this.Controls.Add(this.linkField);
            this.Controls.Add(this.subnetField);
            this.Controls.Add(this.ipField);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.connectChamberBtn);
            this.Controls.Add(this.readTempBtn);
            this.Name = "Form1";
            this.Text = "Chamber2Gamry";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HighPt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoPt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readTempBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.TextBox ipField;
        private System.Windows.Forms.TextBox subnetField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portChamberField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button connectChamberBtn;
        private System.Windows.Forms.Label tempText;
        private System.Windows.Forms.Label rhText;
        private System.Windows.Forms.Button readRHBtn;
        private System.Windows.Forms.NumericUpDown HighPt;
        private System.Windows.Forms.NumericUpDown LoPt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox linkField;
        private System.Windows.Forms.TextBox userField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button connectSQLBtn;
        private System.Windows.Forms.NumericUpDown Ts;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox portSQLField;
    }
}

