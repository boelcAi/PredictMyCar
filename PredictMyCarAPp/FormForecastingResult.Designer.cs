
namespace PredictMyCarAPp
{
    partial class FormForecastingResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForecastingResult));
            this.dgVTime = new System.Windows.Forms.DataGridView();
            this.lblCarsForecastTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.nmWaitTillNextUsage = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDefaults = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.nmSafetyMargin = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.dgVCarPoolMargin = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCarPoolSafetyMargin = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbPercentageSave = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblComparisionCars = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblOwnershipComparison = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlResultOverlay = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgVTime)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmWaitTillNextUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSafetyMargin)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVCarPoolMargin)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.pnlResultOverlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgVTime
            // 
            this.dgVTime.AllowUserToAddRows = false;
            this.dgVTime.AllowUserToDeleteRows = false;
            this.dgVTime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgVTime.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgVTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVTime.Location = new System.Drawing.Point(8, 46);
            this.dgVTime.Name = "dgVTime";
            this.dgVTime.ReadOnly = true;
            this.dgVTime.RowHeadersVisible = false;
            this.dgVTime.RowTemplate.Height = 25;
            this.dgVTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVTime.Size = new System.Drawing.Size(125, 690);
            this.dgVTime.TabIndex = 6;
            // 
            // lblCarsForecastTitle
            // 
            this.lblCarsForecastTitle.AutoSize = true;
            this.lblCarsForecastTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCarsForecastTitle.Location = new System.Drawing.Point(8, 16);
            this.lblCarsForecastTitle.Name = "lblCarsForecastTitle";
            this.lblCarsForecastTitle.Size = new System.Drawing.Size(230, 21);
            this.lblCarsForecastTitle.TabIndex = 8;
            this.lblCarsForecastTitle.Text = "Cars forecast for 1000 people";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInfo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.nmWaitTillNextUsage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDefaults);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nmSafetyMargin);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 196);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Business Manager Decision";
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.SystemColors.Control;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInfo.Location = new System.Drawing.Point(363, 13);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(26, 26);
            this.btnInfo.TabIndex = 53;
            this.btnInfo.Text = "?";
            this.toolTip1.SetToolTip(this.btnInfo, resources.GetString("btnInfo.ToolTip"));
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 51;
            this.label9.Text = "hour(s)";
            // 
            // nmWaitTillNextUsage
            // 
            this.nmWaitTillNextUsage.Location = new System.Drawing.Point(155, 106);
            this.nmWaitTillNextUsage.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nmWaitTillNextUsage.Name = "nmWaitTillNextUsage";
            this.nmWaitTillNextUsage.Size = new System.Drawing.Size(65, 23);
            this.nmWaitTillNextUsage.TabIndex = 50;
            this.nmWaitTillNextUsage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmWaitTillNextUsage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmWaitTillNextUsage.ValueChanged += new System.EventHandler(this.nmWaitTillNextUsage_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 30);
            this.label3.TabIndex = 49;
            this.label3.Text = "Waiting time \r\nuntil next usage\r\n";
            // 
            // btnDefaults
            // 
            this.btnDefaults.Location = new System.Drawing.Point(306, 168);
            this.btnDefaults.Name = "btnDefaults";
            this.btnDefaults.Size = new System.Drawing.Size(83, 22);
            this.btnDefaults.TabIndex = 6;
            this.btnDefaults.Text = "set defaults";
            this.btnDefaults.UseVisualStyleBackColor = true;
            this.btnDefaults.Click += new System.EventHandler(this.btnDefaults_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Additional safety margin";
            // 
            // nmSafetyMargin
            // 
            this.nmSafetyMargin.DecimalPlaces = 2;
            this.nmSafetyMargin.Location = new System.Drawing.Point(193, 50);
            this.nmSafetyMargin.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.nmSafetyMargin.Name = "nmSafetyMargin";
            this.nmSafetyMargin.Size = new System.Drawing.Size(65, 23);
            this.nmSafetyMargin.TabIndex = 18;
            this.nmSafetyMargin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmSafetyMargin.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nmSafetyMargin.ValueChanged += new System.EventHandler(this.nmSafetyMargin_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(262, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "%";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCalculate);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(143, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 263);
            this.panel1.TabIndex = 10;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(9, 214);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(395, 35);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate Carpool";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // dgVCarPoolMargin
            // 
            this.dgVCarPoolMargin.AllowUserToAddRows = false;
            this.dgVCarPoolMargin.AllowUserToDeleteRows = false;
            this.dgVCarPoolMargin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgVCarPoolMargin.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgVCarPoolMargin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVCarPoolMargin.Location = new System.Drawing.Point(10, 38);
            this.dgVCarPoolMargin.Name = "dgVCarPoolMargin";
            this.dgVCarPoolMargin.ReadOnly = true;
            this.dgVCarPoolMargin.RowHeadersVisible = false;
            this.dgVCarPoolMargin.RowTemplate.Height = 25;
            this.dgVCarPoolMargin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVCarPoolMargin.Size = new System.Drawing.Size(125, 667);
            this.dgVCarPoolMargin.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(66, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Carpool size:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCarPoolSafetyMargin
            // 
            this.lblCarPoolSafetyMargin.BackColor = System.Drawing.Color.White;
            this.lblCarPoolSafetyMargin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCarPoolSafetyMargin.Location = new System.Drawing.Point(6, 54);
            this.lblCarPoolSafetyMargin.Name = "lblCarPoolSafetyMargin";
            this.lblCarPoolSafetyMargin.Size = new System.Drawing.Size(234, 21);
            this.lblCarPoolSafetyMargin.TabIndex = 13;
            this.lblCarPoolSafetyMargin.Text = "-";
            this.lblCarPoolSafetyMargin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(139, 46);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3);
            this.panel4.Size = new System.Drawing.Size(424, 421);
            this.panel4.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 413);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.dgVCarPoolMargin);
            this.panel2.Controls.Add(this.pnlResultOverlay);
            this.panel2.Location = new System.Drawing.Point(571, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 724);
            this.panel2.TabIndex = 20;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(155, 560);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5);
            this.panel6.Size = new System.Drawing.Size(424, 146);
            this.panel6.TabIndex = 23;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbPercentageSave);
            this.panel7.Controls.Add(this.pictureBox3);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.lblComparisionCars);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.lblOwnershipComparison);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(5, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(414, 136);
            this.panel7.TabIndex = 3;
            // 
            // lbPercentageSave
            // 
            this.lbPercentageSave.AutoSize = true;
            this.lbPercentageSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPercentageSave.Location = new System.Drawing.Point(127, 95);
            this.lbPercentageSave.Name = "lbPercentageSave";
            this.lbPercentageSave.Size = new System.Drawing.Size(177, 21);
            this.lbPercentageSave.TabIndex = 4;
            this.lbPercentageSave.Text = "You saved 68% of cars";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(358, 76);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Click here to visualize saving percentage");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Private Car Ownership vs. Carpool Comparison";
            // 
            // lblComparisionCars
            // 
            this.lblComparisionCars.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComparisionCars.Location = new System.Drawing.Point(218, 23);
            this.lblComparisionCars.Name = "lblComparisionCars";
            this.lblComparisionCars.Size = new System.Drawing.Size(190, 57);
            this.lblComparisionCars.TabIndex = 1;
            this.lblComparisionCars.Text = "With the use of the carpool, you can save 10 cars.";
            this.lblComparisionCars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(207, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(4, 50);
            this.panel5.TabIndex = 2;
            // 
            // lblOwnershipComparison
            // 
            this.lblOwnershipComparison.Location = new System.Drawing.Point(11, 25);
            this.lblOwnershipComparison.Name = "lblOwnershipComparison";
            this.lblOwnershipComparison.Size = new System.Drawing.Size(190, 55);
            this.lblOwnershipComparison.TabIndex = 0;
            this.lblOwnershipComparison.Text = "On average, 1000 people own 550 cars.\r\n";
            this.lblOwnershipComparison.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Carpool result";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(156, 124);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(424, 421);
            this.panel3.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(416, 413);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblCarPoolSafetyMargin);
            this.groupBox2.Location = new System.Drawing.Point(244, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 100);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // pnlResultOverlay
            // 
            this.pnlResultOverlay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlResultOverlay.Controls.Add(this.label5);
            this.pnlResultOverlay.Controls.Add(this.label4);
            this.pnlResultOverlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResultOverlay.Location = new System.Drawing.Point(0, 0);
            this.pnlResultOverlay.Name = "pnlResultOverlay";
            this.pnlResultOverlay.Size = new System.Drawing.Size(603, 724);
            this.pnlResultOverlay.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(449, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "please select your buisness manager decisions and press \"Calculate Carpool\" butto" +
    "n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(191, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Carpool Calculation";
            // 
            // FormForecastingResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCarsForecastTitle);
            this.Controls.Add(this.dgVTime);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "FormForecastingResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forecasting";
            this.Load += new System.EventHandler(this.FormForecastingResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVTime)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmWaitTillNextUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSafetyMargin)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVCarPoolMargin)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlResultOverlay.ResumeLayout(false);
            this.pnlResultOverlay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVTime;
        private System.Windows.Forms.DataGridView dgvPersons;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDefaults;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmSafetyMargin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmWaitTillNextUsage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridView dgVCarPoolMargin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCarPoolSafetyMargin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlResultOverlay;
        private System.Windows.Forms.Label lblCarsForecastTitle;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblComparisionCars;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOwnershipComparison;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbPercentageSave;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}