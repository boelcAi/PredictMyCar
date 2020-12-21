
namespace PredictMyCarAPp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCreate = new System.Windows.Forms.Button();
            this.nmNumberOfPersons = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDummy = new System.Windows.Forms.Panel();
            this.pnRadButtons = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rBtnSimulate = new System.Windows.Forms.RadioButton();
            this.rBtnUseAI = new System.Windows.Forms.RadioButton();
            this.btnForecasting = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnDefaults = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.nmNumberOfOtherTrips = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.nmOtherTrips = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.nmNumberOfShoppingTrips = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.nmShoppingTripsWithCars = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.nmCommuteWithCar = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.nmSickDays = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.nmHolidays = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.nmHomeOffice = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nmPartTimeJob = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nmShiftWork = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmPensioner = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nmUnEmployed = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nmEmployed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pBStadt = new System.Windows.Forms.PictureBox();
            this.pBDorf = new System.Windows.Forms.PictureBox();
            this.pBKaff = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmNumberOfPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnRadButtons.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNumberOfOtherTrips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmOtherTrips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmNumberOfShoppingTrips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmShoppingTripsWithCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCommuteWithCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSickDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHolidays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHomeOffice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPartTimeJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmShiftWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPensioner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUnEmployed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmEmployed)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBStadt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDorf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBKaff)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(3, 49);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(253, 33);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Generate Persons";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // nmNumberOfPersons
            // 
            this.nmNumberOfPersons.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmNumberOfPersons.Location = new System.Drawing.Point(152, 21);
            this.nmNumberOfPersons.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmNumberOfPersons.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmNumberOfPersons.Name = "nmNumberOfPersons";
            this.nmNumberOfPersons.Size = new System.Drawing.Size(120, 23);
            this.nmNumberOfPersons.TabIndex = 1;
            this.nmNumberOfPersons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmNumberOfPersons.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmNumberOfPersons.ValueChanged += new System.EventHandler(this.nmNumberOfPersons_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of persons\r\nin region";
            // 
            // dgvPersons
            // 
            this.dgvPersons.AllowUserToAddRows = false;
            this.dgvPersons.AllowUserToDeleteRows = false;
            this.dgvPersons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvPersons.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersons.Location = new System.Drawing.Point(0, 0);
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.ReadOnly = true;
            this.dgvPersons.RowHeadersVisible = false;
            this.dgvPersons.RowTemplate.Height = 25;
            this.dgvPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersons.Size = new System.Drawing.Size(712, 684);
            this.dgvPersons.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nmNumberOfPersons);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(11, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 684);
            this.panel1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panelDummy);
            this.flowLayoutPanel1.Controls.Add(this.btnCreate);
            this.flowLayoutPanel1.Controls.Add(this.pnRadButtons);
            this.flowLayoutPanel1.Controls.Add(this.btnForecasting);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 546);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(266, 138);
            this.flowLayoutPanel1.TabIndex = 10;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panelDummy
            // 
            this.panelDummy.Location = new System.Drawing.Point(3, 3);
            this.panelDummy.Name = "panelDummy";
            this.panelDummy.Size = new System.Drawing.Size(253, 40);
            this.panelDummy.TabIndex = 11;
            // 
            // pnRadButtons
            // 
            this.pnRadButtons.BackColor = System.Drawing.Color.Silver;
            this.pnRadButtons.Controls.Add(this.panel5);
            this.pnRadButtons.Location = new System.Drawing.Point(3, 88);
            this.pnRadButtons.Name = "pnRadButtons";
            this.pnRadButtons.Padding = new System.Windows.Forms.Padding(2);
            this.pnRadButtons.Size = new System.Drawing.Size(253, 56);
            this.pnRadButtons.TabIndex = 10;
            this.pnRadButtons.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.rBtnSimulate);
            this.panel5.Controls.Add(this.rBtnUseAI);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(249, 52);
            this.panel5.TabIndex = 9;
            // 
            // rBtnSimulate
            // 
            this.rBtnSimulate.AutoSize = true;
            this.rBtnSimulate.Location = new System.Drawing.Point(13, 26);
            this.rBtnSimulate.Name = "rBtnSimulate";
            this.rBtnSimulate.Size = new System.Drawing.Size(147, 19);
            this.rBtnSimulate.TabIndex = 9;
            this.rBtnSimulate.Text = "forcast with Simulation";
            this.rBtnSimulate.UseVisualStyleBackColor = true;
            // 
            // rBtnUseAI
            // 
            this.rBtnUseAI.AutoSize = true;
            this.rBtnUseAI.Checked = true;
            this.rBtnUseAI.Location = new System.Drawing.Point(13, 4);
            this.rBtnUseAI.Name = "rBtnUseAI";
            this.rBtnUseAI.Size = new System.Drawing.Size(198, 19);
            this.rBtnUseAI.TabIndex = 8;
            this.rBtnUseAI.TabStop = true;
            this.rBtnUseAI.Text = "forcast with Artificial Intelligence";
            this.rBtnUseAI.UseVisualStyleBackColor = true;
            // 
            // btnForecasting
            // 
            this.btnForecasting.Enabled = false;
            this.btnForecasting.Location = new System.Drawing.Point(3, 150);
            this.btnForecasting.Name = "btnForecasting";
            this.btnForecasting.Size = new System.Drawing.Size(253, 32);
            this.btnForecasting.TabIndex = 6;
            this.btnForecasting.Text = "Forecasting";
            this.btnForecasting.UseVisualStyleBackColor = true;
            this.btnForecasting.Click += new System.EventHandler(this.btnForecasting_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInfo);
            this.groupBox1.Controls.Add(this.btnDefaults);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.nmNumberOfOtherTrips);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.nmOtherTrips);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.nmNumberOfShoppingTrips);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.nmShoppingTripsWithCars);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.nmCommuteWithCar);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.nmSickDays);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.nmHolidays);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.nmHomeOffice);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nmPartTimeJob);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.nmShiftWork);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nmPensioner);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nmUnEmployed);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nmEmployed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(19, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 475);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Region Statistics";
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.SystemColors.Control;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInfo.Location = new System.Drawing.Point(222, 12);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(26, 26);
            this.btnInfo.TabIndex = 49;
            this.btnInfo.Text = "?";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnDefaults
            // 
            this.btnDefaults.Location = new System.Drawing.Point(165, 447);
            this.btnDefaults.Name = "btnDefaults";
            this.btnDefaults.Size = new System.Drawing.Size(83, 22);
            this.btnDefaults.TabIndex = 6;
            this.btnDefaults.Text = "set defaults";
            this.btnDefaults.UseVisualStyleBackColor = true;
            this.btnDefaults.Click += new System.EventHandler(this.btnDefaults_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "pensioner";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(6, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 2);
            this.panel3.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(6, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 2);
            this.panel2.TabIndex = 47;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(14, 392);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(125, 30);
            this.label23.TabIndex = 46;
            this.label23.Text = "Number of other trips \r\nduring the week";
            // 
            // nmNumberOfOtherTrips
            // 
            this.nmNumberOfOtherTrips.DecimalPlaces = 1;
            this.nmNumberOfOtherTrips.Location = new System.Drawing.Point(165, 397);
            this.nmNumberOfOtherTrips.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmNumberOfOtherTrips.Name = "nmNumberOfOtherTrips";
            this.nmNumberOfOtherTrips.Size = new System.Drawing.Size(65, 23);
            this.nmNumberOfOtherTrips.TabIndex = 45;
            this.nmNumberOfOtherTrips.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmNumberOfOtherTrips.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nmNumberOfOtherTrips.ValueChanged += new System.EventHandler(this.nmNumberOfOtherTrips_ValueChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(16, 368);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(106, 15);
            this.label24.TabIndex = 44;
            this.label24.Text = "other trips with car";
            // 
            // nmOtherTrips
            // 
            this.nmOtherTrips.DecimalPlaces = 1;
            this.nmOtherTrips.Location = new System.Drawing.Point(145, 366);
            this.nmOtherTrips.Name = "nmOtherTrips";
            this.nmOtherTrips.Size = new System.Drawing.Size(65, 23);
            this.nmOtherTrips.TabIndex = 42;
            this.nmOtherTrips.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmOtherTrips.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
            this.nmOtherTrips.ValueChanged += new System.EventHandler(this.nmOtherTrips_ValueChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(217, 209);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(17, 15);
            this.label25.TabIndex = 43;
            this.label25.Text = "%";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(16, 323);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(147, 30);
            this.label22.TabIndex = 41;
            this.label22.Text = "Number of shopping trips \r\nduring the week";
            // 
            // nmNumberOfShoppingTrips
            // 
            this.nmNumberOfShoppingTrips.DecimalPlaces = 1;
            this.nmNumberOfShoppingTrips.Location = new System.Drawing.Point(173, 325);
            this.nmNumberOfShoppingTrips.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmNumberOfShoppingTrips.Name = "nmNumberOfShoppingTrips";
            this.nmNumberOfShoppingTrips.Size = new System.Drawing.Size(65, 23);
            this.nmNumberOfShoppingTrips.TabIndex = 39;
            this.nmNumberOfShoppingTrips.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmNumberOfShoppingTrips.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmNumberOfShoppingTrips.ValueChanged += new System.EventHandler(this.nmNumberOfShoppingTrips_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 297);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(128, 15);
            this.label20.TabIndex = 38;
            this.label20.Text = "shopping trips with car";
            // 
            // nmShoppingTripsWithCars
            // 
            this.nmShoppingTripsWithCars.DecimalPlaces = 1;
            this.nmShoppingTripsWithCars.Location = new System.Drawing.Point(149, 295);
            this.nmShoppingTripsWithCars.Name = "nmShoppingTripsWithCars";
            this.nmShoppingTripsWithCars.Size = new System.Drawing.Size(65, 23);
            this.nmShoppingTripsWithCars.TabIndex = 36;
            this.nmShoppingTripsWithCars.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmShoppingTripsWithCars.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nmShoppingTripsWithCars.ValueChanged += new System.EventHandler(this.nmShoppingTripsWithCars_ValueChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(221, 300);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 15);
            this.label21.TabIndex = 37;
            this.label21.Text = "%";
            // 
            // nmCommuteWithCar
            // 
            this.nmCommuteWithCar.DecimalPlaces = 1;
            this.nmCommuteWithCar.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nmCommuteWithCar.Location = new System.Drawing.Point(144, 203);
            this.nmCommuteWithCar.Name = "nmCommuteWithCar";
            this.nmCommuteWithCar.Size = new System.Drawing.Size(65, 23);
            this.nmCommuteWithCar.TabIndex = 33;
            this.nmCommuteWithCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmCommuteWithCar.Value = new decimal(new int[] {
            677,
            0,
            0,
            65536});
            this.nmCommuteWithCar.ValueChanged += new System.EventHandler(this.nmCommuteWithCar_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(220, 370);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 15);
            this.label18.TabIndex = 34;
            this.label18.Text = "%";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(34, 206);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 15);
            this.label19.TabIndex = 35;
            this.label19.Text = "goes to work by car";
            // 
            // nmSickDays
            // 
            this.nmSickDays.DecimalPlaces = 1;
            this.nmSickDays.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nmSickDays.Location = new System.Drawing.Point(92, 169);
            this.nmSickDays.Name = "nmSickDays";
            this.nmSickDays.Size = new System.Drawing.Size(65, 23);
            this.nmSickDays.TabIndex = 30;
            this.nmSickDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmSickDays.Value = new decimal(new int[] {
            109,
            0,
            0,
            65536});
            this.nmSickDays.ValueChanged += new System.EventHandler(this.nmSickDays_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(166, 174);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 15);
            this.label16.TabIndex = 31;
            this.label16.Text = "days / year";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(33, 173);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 15);
            this.label17.TabIndex = 32;
            this.label17.Text = "sick days";
            // 
            // nmHolidays
            // 
            this.nmHolidays.DecimalPlaces = 1;
            this.nmHolidays.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nmHolidays.Location = new System.Drawing.Point(92, 140);
            this.nmHolidays.Name = "nmHolidays";
            this.nmHolidays.Size = new System.Drawing.Size(65, 23);
            this.nmHolidays.TabIndex = 27;
            this.nmHolidays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmHolidays.Value = new decimal(new int[] {
            309,
            0,
            0,
            65536});
            this.nmHolidays.ValueChanged += new System.EventHandler(this.nmHolidays_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(166, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 15);
            this.label14.TabIndex = 28;
            this.label14.Text = "days / year";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 15);
            this.label15.TabIndex = 29;
            this.label15.Text = "holidays";
            // 
            // nmHomeOffice
            // 
            this.nmHomeOffice.DecimalPlaces = 1;
            this.nmHomeOffice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nmHomeOffice.Location = new System.Drawing.Point(143, 111);
            this.nmHomeOffice.Name = "nmHomeOffice";
            this.nmHomeOffice.Size = new System.Drawing.Size(65, 23);
            this.nmHomeOffice.TabIndex = 24;
            this.nmHomeOffice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmHomeOffice.Value = new decimal(new int[] {
            35,
            0,
            0,
            65536});
            this.nmHomeOffice.ValueChanged += new System.EventHandler(this.nmHomeOffice_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(214, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 15);
            this.label13.TabIndex = 26;
            this.label13.Text = "home office";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "shift work";
            // 
            // nmPartTimeJob
            // 
            this.nmPartTimeJob.DecimalPlaces = 1;
            this.nmPartTimeJob.Location = new System.Drawing.Point(142, 82);
            this.nmPartTimeJob.Name = "nmPartTimeJob";
            this.nmPartTimeJob.Size = new System.Drawing.Size(65, 23);
            this.nmPartTimeJob.TabIndex = 21;
            this.nmPartTimeJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmPartTimeJob.Value = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.nmPartTimeJob.ValueChanged += new System.EventHandler(this.nmPartTimeJob_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(213, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "%";
            // 
            // nmShiftWork
            // 
            this.nmShiftWork.DecimalPlaces = 1;
            this.nmShiftWork.Location = new System.Drawing.Point(142, 53);
            this.nmShiftWork.Name = "nmShiftWork";
            this.nmShiftWork.Size = new System.Drawing.Size(65, 23);
            this.nmShiftWork.TabIndex = 18;
            this.nmShiftWork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmShiftWork.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nmShiftWork.ValueChanged += new System.EventHandler(this.nmShiftWork_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(214, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "part time job";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "unemployed";
            // 
            // nmPensioner
            // 
            this.nmPensioner.Location = new System.Drawing.Point(96, 259);
            this.nmPensioner.Name = "nmPensioner";
            this.nmPensioner.Size = new System.Drawing.Size(65, 23);
            this.nmPensioner.TabIndex = 15;
            this.nmPensioner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmPensioner.Value = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.nmPensioner.ValueChanged += new System.EventHandler(this.nmPensioner_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "%";
            // 
            // nmUnEmployed
            // 
            this.nmUnEmployed.Location = new System.Drawing.Point(96, 231);
            this.nmUnEmployed.Name = "nmUnEmployed";
            this.nmUnEmployed.Size = new System.Drawing.Size(65, 23);
            this.nmUnEmployed.TabIndex = 12;
            this.nmUnEmployed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmUnEmployed.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nmUnEmployed.ValueChanged += new System.EventHandler(this.nmUnEmployed_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "employed";
            // 
            // nmEmployed
            // 
            this.nmEmployed.DecimalPlaces = 1;
            this.nmEmployed.Location = new System.Drawing.Point(96, 24);
            this.nmEmployed.Name = "nmEmployed";
            this.nmEmployed.Size = new System.Drawing.Size(65, 23);
            this.nmEmployed.TabIndex = 9;
            this.nmEmployed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmEmployed.Value = new decimal(new int[] {
            54,
            0,
            0,
            0});
            this.nmEmployed.ValueChanged += new System.EventHandler(this.nmEmployed_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "%";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.pBStadt);
            this.panel4.Controls.Add(this.pBDorf);
            this.panel4.Controls.Add(this.pBKaff);
            this.panel4.Controls.Add(this.dgvPersons);
            this.panel4.Location = new System.Drawing.Point(310, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(712, 684);
            this.panel4.TabIndex = 5;
            // 
            // pBStadt
            // 
            this.pBStadt.BackColor = System.Drawing.SystemColors.Control;
            this.pBStadt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBStadt.BackgroundImage")));
            this.pBStadt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pBStadt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBStadt.Location = new System.Drawing.Point(0, 0);
            this.pBStadt.Name = "pBStadt";
            this.pBStadt.Size = new System.Drawing.Size(712, 684);
            this.pBStadt.TabIndex = 6;
            this.pBStadt.TabStop = false;
            // 
            // pBDorf
            // 
            this.pBDorf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBDorf.BackgroundImage")));
            this.pBDorf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pBDorf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBDorf.Location = new System.Drawing.Point(0, 0);
            this.pBDorf.Name = "pBDorf";
            this.pBDorf.Size = new System.Drawing.Size(712, 684);
            this.pBDorf.TabIndex = 5;
            this.pBDorf.TabStop = false;
            // 
            // pBKaff
            // 
            this.pBKaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBKaff.BackgroundImage")));
            this.pBKaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pBKaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBKaff.Location = new System.Drawing.Point(0, 0);
            this.pBKaff.Name = "pBKaff";
            this.pBKaff.Size = new System.Drawing.Size(712, 684);
            this.pBKaff.TabIndex = 4;
            this.pBKaff.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 709);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1050, 713);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PredictMyCar V1.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmNumberOfPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnRadButtons.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNumberOfOtherTrips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmOtherTrips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmNumberOfShoppingTrips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmShoppingTripsWithCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCommuteWithCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSickDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHolidays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHomeOffice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPartTimeJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmShiftWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPensioner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUnEmployed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmEmployed)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBStadt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDorf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBKaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.NumericUpDown nmNumberOfPersons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPersons;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmUnEmployed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmEmployed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmPartTimeJob;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmShiftWork;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nmPensioner;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmHomeOffice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nmCommuteWithCar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown nmSickDays;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nmHolidays;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown nmNumberOfOtherTrips;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown nmOtherTrips;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown nmNumberOfShoppingTrips;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown nmShoppingTripsWithCars;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDefaults;
        private System.Windows.Forms.Button btnForecasting;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pBStadt;
        private System.Windows.Forms.PictureBox pBDorf;
        private System.Windows.Forms.PictureBox pBKaff;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rBtnSimulate;
        private System.Windows.Forms.RadioButton rBtnUseAI;
        private System.Windows.Forms.Panel pnRadButtons;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelDummy;
    }
}

