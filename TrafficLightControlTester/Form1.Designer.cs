﻿namespace TrafficLightControlTester
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trafficLightControl1 = new CustomControls.TrafficLightControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoNone = new System.Windows.Forms.RadioButton();
            this.rdoBad = new System.Windows.Forms.RadioButton();
            this.rdoWarning = new System.Windows.Forms.RadioButton();
            this.rdoGood = new System.Windows.Forms.RadioButton();
            this.lblControlStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.trafficLightControl1);
            this.groupBox1.Location = new System.Drawing.Point(225, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Traffic Light Control";
            // 
            // trafficLightControl1
            // 
            this.trafficLightControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trafficLightControl1.Location = new System.Drawing.Point(37, 24);
            this.trafficLightControl1.Name = "trafficLightControl1";
            this.trafficLightControl1.Size = new System.Drawing.Size(131, 53);
            this.trafficLightControl1.State = CustomControls.TrafficLightControlState.None;
            this.trafficLightControl1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoNone);
            this.groupBox2.Controls.Add(this.rdoBad);
            this.groupBox2.Controls.Add(this.rdoWarning);
            this.groupBox2.Controls.Add(this.rdoGood);
            this.groupBox2.Location = new System.Drawing.Point(24, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 162);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // rdoNone
            // 
            this.rdoNone.AutoSize = true;
            this.rdoNone.Checked = true;
            this.rdoNone.Location = new System.Drawing.Point(21, 27);
            this.rdoNone.Name = "rdoNone";
            this.rdoNone.Size = new System.Drawing.Size(51, 17);
            this.rdoNone.TabIndex = 3;
            this.rdoNone.TabStop = true;
            this.rdoNone.Text = "None";
            this.rdoNone.UseVisualStyleBackColor = true;
            this.rdoNone.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdoBad
            // 
            this.rdoBad.AutoSize = true;
            this.rdoBad.Location = new System.Drawing.Point(21, 121);
            this.rdoBad.Name = "rdoBad";
            this.rdoBad.Size = new System.Drawing.Size(44, 17);
            this.rdoBad.TabIndex = 2;
            this.rdoBad.Text = "Bad";
            this.rdoBad.UseVisualStyleBackColor = true;
            this.rdoBad.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdoWarning
            // 
            this.rdoWarning.AutoSize = true;
            this.rdoWarning.Location = new System.Drawing.Point(21, 89);
            this.rdoWarning.Name = "rdoWarning";
            this.rdoWarning.Size = new System.Drawing.Size(65, 17);
            this.rdoWarning.TabIndex = 1;
            this.rdoWarning.Text = "Warning";
            this.rdoWarning.UseVisualStyleBackColor = true;
            this.rdoWarning.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdoGood
            // 
            this.rdoGood.AutoSize = true;
            this.rdoGood.Location = new System.Drawing.Point(21, 58);
            this.rdoGood.Name = "rdoGood";
            this.rdoGood.Size = new System.Drawing.Size(51, 17);
            this.rdoGood.TabIndex = 0;
            this.rdoGood.Text = "Good";
            this.rdoGood.UseVisualStyleBackColor = true;
            this.rdoGood.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblControlStatus
            // 
            this.lblControlStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblControlStatus.AutoSize = true;
            this.lblControlStatus.Location = new System.Drawing.Point(225, 146);
            this.lblControlStatus.Name = "lblControlStatus";
            this.lblControlStatus.Size = new System.Drawing.Size(35, 13);
            this.lblControlStatus.TabIndex = 2;
            this.lblControlStatus.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 211);
            this.Controls.Add(this.lblControlStatus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Traffic Light Control Tester";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoGood;
        private System.Windows.Forms.RadioButton rdoBad;
        private System.Windows.Forms.RadioButton rdoWarning;
        private CustomControls.TrafficLightControl trafficLightControl1;
        private System.Windows.Forms.RadioButton rdoNone;
        private System.Windows.Forms.Label lblControlStatus;
    }
}

