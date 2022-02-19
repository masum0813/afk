namespace AFK
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grpBoxInterval = new System.Windows.Forms.GroupBox();
            this.lblMilisecond = new System.Windows.Forms.Label();
            this.txtMiliSecond = new System.Windows.Forms.TextBox();
            this.lblSecond = new System.Windows.Forms.Label();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.lblHour = new System.Windows.Forms.Label();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.grpBoxClickOptions = new System.Windows.Forms.GroupBox();
            this.cmbBoxClickType = new System.Windows.Forms.ComboBox();
            this.lblClickType = new System.Windows.Forms.Label();
            this.cmbBoxMouseButton = new System.Windows.Forms.ComboBox();
            this.lblMouseButton = new System.Windows.Forms.Label();
            this.grpBoxClickRepeat = new System.Windows.Forms.GroupBox();
            this.nmrcUpDownRepeatCount = new System.Windows.Forms.NumericUpDown();
            this.radioBtnRepeatForever = new System.Windows.Forms.RadioButton();
            this.radioBtnRepeatCount = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.grpBoxInterval.SuspendLayout();
            this.grpBoxClickOptions.SuspendLayout();
            this.grpBoxClickRepeat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownRepeatCount)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxInterval
            // 
            this.grpBoxInterval.Controls.Add(this.lblMilisecond);
            this.grpBoxInterval.Controls.Add(this.txtMiliSecond);
            this.grpBoxInterval.Controls.Add(this.lblSecond);
            this.grpBoxInterval.Controls.Add(this.txtSecond);
            this.grpBoxInterval.Controls.Add(this.label1);
            this.grpBoxInterval.Controls.Add(this.txtMinute);
            this.grpBoxInterval.Controls.Add(this.lblHour);
            this.grpBoxInterval.Controls.Add(this.txtHour);
            this.grpBoxInterval.Location = new System.Drawing.Point(12, 12);
            this.grpBoxInterval.Name = "grpBoxInterval";
            this.grpBoxInterval.Size = new System.Drawing.Size(562, 60);
            this.grpBoxInterval.TabIndex = 0;
            this.grpBoxInterval.TabStop = false;
            this.grpBoxInterval.Text = "Click Interval";
            // 
            // lblMilisecond
            // 
            this.lblMilisecond.AutoSize = true;
            this.lblMilisecond.Location = new System.Drawing.Point(470, 25);
            this.lblMilisecond.Name = "lblMilisecond";
            this.lblMilisecond.Size = new System.Drawing.Size(78, 15);
            this.lblMilisecond.TabIndex = 8;
            this.lblMilisecond.Text = "Milisecond(s)";
            // 
            // txtMiliSecond
            // 
            this.txtMiliSecond.Location = new System.Drawing.Point(403, 22);
            this.txtMiliSecond.Name = "txtMiliSecond";
            this.txtMiliSecond.Size = new System.Drawing.Size(61, 23);
            this.txtMiliSecond.TabIndex = 7;
            this.txtMiliSecond.Text = "100";
            this.txtMiliSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMiliSecond.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(338, 25);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(38, 15);
            this.lblSecond.TabIndex = 6;
            this.lblSecond.Text = "Sec(s)";
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(271, 22);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(61, 23);
            this.txtSecond.TabIndex = 5;
            this.txtSecond.Text = "0";
            this.txtSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSecond.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Min(s)";
            // 
            // txtMinute
            // 
            this.txtMinute.Location = new System.Drawing.Point(141, 22);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(61, 23);
            this.txtMinute.TabIndex = 3;
            this.txtMinute.Text = "0";
            this.txtMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMinute.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(73, 25);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(47, 15);
            this.lblHour.TabIndex = 2;
            this.lblHour.Text = "Hour(s)";
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(6, 22);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(61, 23);
            this.txtHour.TabIndex = 1;
            this.txtHour.Text = "0";
            this.txtHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHour.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // grpBoxClickOptions
            // 
            this.grpBoxClickOptions.Controls.Add(this.cmbBoxClickType);
            this.grpBoxClickOptions.Controls.Add(this.lblClickType);
            this.grpBoxClickOptions.Controls.Add(this.cmbBoxMouseButton);
            this.grpBoxClickOptions.Controls.Add(this.lblMouseButton);
            this.grpBoxClickOptions.Location = new System.Drawing.Point(12, 78);
            this.grpBoxClickOptions.Name = "grpBoxClickOptions";
            this.grpBoxClickOptions.Size = new System.Drawing.Size(258, 116);
            this.grpBoxClickOptions.TabIndex = 1;
            this.grpBoxClickOptions.TabStop = false;
            this.grpBoxClickOptions.Text = "Click Options";
            // 
            // cmbBoxClickType
            // 
            this.cmbBoxClickType.FormattingEnabled = true;
            this.cmbBoxClickType.Location = new System.Drawing.Point(94, 66);
            this.cmbBoxClickType.Name = "cmbBoxClickType";
            this.cmbBoxClickType.Size = new System.Drawing.Size(121, 23);
            this.cmbBoxClickType.TabIndex = 3;
            // 
            // lblClickType
            // 
            this.lblClickType.AutoSize = true;
            this.lblClickType.Location = new System.Drawing.Point(6, 69);
            this.lblClickType.Name = "lblClickType";
            this.lblClickType.Size = new System.Drawing.Size(60, 15);
            this.lblClickType.TabIndex = 2;
            this.lblClickType.Text = "Click Type";
            // 
            // cmbBoxMouseButton
            // 
            this.cmbBoxMouseButton.FormattingEnabled = true;
            this.cmbBoxMouseButton.Location = new System.Drawing.Point(94, 26);
            this.cmbBoxMouseButton.Name = "cmbBoxMouseButton";
            this.cmbBoxMouseButton.Size = new System.Drawing.Size(121, 23);
            this.cmbBoxMouseButton.TabIndex = 1;
            // 
            // lblMouseButton
            // 
            this.lblMouseButton.AutoSize = true;
            this.lblMouseButton.Location = new System.Drawing.Point(6, 29);
            this.lblMouseButton.Name = "lblMouseButton";
            this.lblMouseButton.Size = new System.Drawing.Size(82, 15);
            this.lblMouseButton.TabIndex = 0;
            this.lblMouseButton.Text = "Mouse Button";
            // 
            // grpBoxClickRepeat
            // 
            this.grpBoxClickRepeat.Controls.Add(this.nmrcUpDownRepeatCount);
            this.grpBoxClickRepeat.Controls.Add(this.radioBtnRepeatForever);
            this.grpBoxClickRepeat.Controls.Add(this.radioBtnRepeatCount);
            this.grpBoxClickRepeat.Location = new System.Drawing.Point(283, 78);
            this.grpBoxClickRepeat.Name = "grpBoxClickRepeat";
            this.grpBoxClickRepeat.Size = new System.Drawing.Size(291, 116);
            this.grpBoxClickRepeat.TabIndex = 4;
            this.grpBoxClickRepeat.TabStop = false;
            this.grpBoxClickRepeat.Text = "Click Repeat";
            // 
            // nmrcUpDownRepeatCount
            // 
            this.nmrcUpDownRepeatCount.Location = new System.Drawing.Point(165, 25);
            this.nmrcUpDownRepeatCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrcUpDownRepeatCount.Name = "nmrcUpDownRepeatCount";
            this.nmrcUpDownRepeatCount.Size = new System.Drawing.Size(87, 23);
            this.nmrcUpDownRepeatCount.TabIndex = 2;
            this.nmrcUpDownRepeatCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmrcUpDownRepeatCount.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // radioBtnRepeatForever
            // 
            this.radioBtnRepeatForever.AutoSize = true;
            this.radioBtnRepeatForever.Location = new System.Drawing.Point(11, 65);
            this.radioBtnRepeatForever.Name = "radioBtnRepeatForever";
            this.radioBtnRepeatForever.Size = new System.Drawing.Size(136, 19);
            this.radioBtnRepeatForever.TabIndex = 1;
            this.radioBtnRepeatForever.TabStop = true;
            this.radioBtnRepeatForever.Text = "Repeat Until Stopped";
            this.radioBtnRepeatForever.UseVisualStyleBackColor = true;
            // 
            // radioBtnRepeatCount
            // 
            this.radioBtnRepeatCount.AutoSize = true;
            this.radioBtnRepeatCount.Location = new System.Drawing.Point(11, 25);
            this.radioBtnRepeatCount.Name = "radioBtnRepeatCount";
            this.radioBtnRepeatCount.Size = new System.Drawing.Size(61, 19);
            this.radioBtnRepeatCount.TabIndex = 0;
            this.radioBtnRepeatCount.TabStop = true;
            this.radioBtnRepeatCount.Text = "Repeat";
            this.radioBtnRepeatCount.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 209);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(258, 45);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start (F8)";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(316, 209);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(258, 45);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop (F8)";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 337);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpBoxClickRepeat);
            this.Controls.Add(this.grpBoxClickOptions);
            this.Controls.Add(this.grpBoxInterval);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AFK - AutoClicker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpBoxInterval.ResumeLayout(false);
            this.grpBoxInterval.PerformLayout();
            this.grpBoxClickOptions.ResumeLayout(false);
            this.grpBoxClickOptions.PerformLayout();
            this.grpBoxClickRepeat.ResumeLayout(false);
            this.grpBoxClickRepeat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownRepeatCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpBoxInterval;
        private Label lblHour;
        private TextBox txtHour;
        private Label lblMilisecond;
        private TextBox txtMiliSecond;
        private Label lblSecond;
        private TextBox txtSecond;
        private Label label1;
        private TextBox txtMinute;
        private GroupBox grpBoxClickOptions;
        private Label lblMouseButton;
        private ComboBox cmbBoxMouseButton;
        private ComboBox cmbBoxClickType;
        private Label lblClickType;
        private GroupBox grpBoxClickRepeat;
        private RadioButton radioBtnRepeatForever;
        private RadioButton radioBtnRepeatCount;
        private NumericUpDown nmrcUpDownRepeatCount;
        private Button btnStart;
        private Button btnStop;
    }
}