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
            this.readTempBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.ipField = new System.Windows.Forms.TextBox();
            this.subnetField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.tempText = new System.Windows.Forms.Label();
            this.rhText = new System.Windows.Forms.Label();
            this.readRHBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readTempBtn
            // 
            this.readTempBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readTempBtn.Location = new System.Drawing.Point(66, 356);
            this.readTempBtn.Name = "readTempBtn";
            this.readTempBtn.Size = new System.Drawing.Size(341, 58);
            this.readTempBtn.TabIndex = 0;
            this.readTempBtn.Text = "Read Temperature";
            this.readTempBtn.UseVisualStyleBackColor = true;
            this.readTempBtn.Click += new System.EventHandler(this.readTempBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(467, 356);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(292, 60);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start profile";
            this.startBtn.UseVisualStyleBackColor = true;
            // 
            // stopBtn
            // 
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.Location = new System.Drawing.Point(467, 489);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(292, 56);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.Text = "Stop profile";
            this.stopBtn.UseVisualStyleBackColor = true;
            // 
            // ipField
            // 
            this.ipField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipField.Location = new System.Drawing.Point(514, 31);
            this.ipField.Name = "ipField";
            this.ipField.Size = new System.Drawing.Size(245, 47);
            this.ipField.TabIndex = 3;
            this.ipField.Text = "10.163.46.185";
            // 
            // subnetField
            // 
            this.subnetField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subnetField.Location = new System.Drawing.Point(514, 110);
            this.subnetField.Name = "subnetField";
            this.subnetField.Size = new System.Drawing.Size(245, 47);
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
            // portField
            // 
            this.portField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portField.Location = new System.Drawing.Point(514, 192);
            this.portField.Name = "portField";
            this.portField.Size = new System.Drawing.Size(245, 47);
            this.portField.TabIndex = 3;
            this.portField.Text = "5025";
            this.portField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.Color.Red;
            this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.ForeColor = System.Drawing.Color.White;
            this.connectBtn.Location = new System.Drawing.Point(320, 264);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(214, 58);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // tempText
            // 
            this.tempText.AutoSize = true;
            this.tempText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempText.Location = new System.Drawing.Point(73, 417);
            this.tempText.Name = "tempText";
            this.tempText.Size = new System.Drawing.Size(41, 39);
            this.tempText.TabIndex = 4;
            this.tempText.Text = "--";
            // 
            // rhText
            // 
            this.rhText.AutoSize = true;
            this.rhText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rhText.Location = new System.Drawing.Point(73, 550);
            this.rhText.Name = "rhText";
            this.rhText.Size = new System.Drawing.Size(41, 39);
            this.rhText.TabIndex = 4;
            this.rhText.Text = "--";
            // 
            // readRHBtn
            // 
            this.readRHBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readRHBtn.Location = new System.Drawing.Point(66, 489);
            this.readRHBtn.Name = "readRHBtn";
            this.readRHBtn.Size = new System.Drawing.Size(341, 56);
            this.readRHBtn.TabIndex = 5;
            this.readRHBtn.Text = "Read Humidity";
            this.readRHBtn.UseVisualStyleBackColor = true;
            this.readRHBtn.Click += new System.EventHandler(this.readRHBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 639);
            this.Controls.Add(this.readRHBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rhText);
            this.Controls.Add(this.tempText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portField);
            this.Controls.Add(this.subnetField);
            this.Controls.Add(this.ipField);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.readTempBtn);
            this.Name = "Form1";
            this.Text = "Chamber2Gamry";
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
        private System.Windows.Forms.TextBox portField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label tempText;
        private System.Windows.Forms.Label rhText;
        private System.Windows.Forms.Button readRHBtn;
    }
}

