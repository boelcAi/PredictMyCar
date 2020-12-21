using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredictMyCarAPp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetWelcomeImageAndDisableForecast();
        }

        public void RemoveWelcomeImage()
        {
            pBKaff.Visible = false;
            pBDorf.Visible = false;
            pBStadt.Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            RegionStatistics regionStatistics = new RegionStatistics(employed: nmEmployed.Value,
                shiftWork: nmShiftWork.Value,
                partTimeJob: nmPartTimeJob.Value,
                homeOffice: nmHomeOffice.Value,
                holidays: nmHolidays.Value,
                sickDays: nmSickDays.Value,
                commuteWithCar: nmCommuteWithCar.Value,
                unEmployed: nmUnEmployed.Value,
                pensioner: nmPensioner.Value,
                shoppingTripsWithCars: nmShoppingTripsWithCars.Value,
                numberOfShoppingTripsPer5Days:nmNumberOfShoppingTrips.Value,
                otherTrips:nmOtherTrips.Value,
                numberOfOtherTripsPer5Days:nmNumberOfOtherTrips.Value);

            
            var number = nmNumberOfPersons.Value;
            
            (var persons, var featureCounter) = PersonService.Instance.CreatePersons(number, regionStatistics);

            dgvPersons.DataSource = persons;

            dgvPersons.Columns[nameof(Person.ID)].DisplayIndex = 0;
            SetDgVToolTipsCounter(featureCounter);

            btnForecasting.Enabled = persons.Count > 0;
            pnRadButtons.Enabled = persons.Count > 0;
            this.Persons = persons;
            this.FeatureCounter = featureCounter;
            RemoveWelcomeImage();
            this.Cursor = Cursors.Default;
        }

        public FeatureCounter FeatureCounter { get; set; }

        public ObservableCollection<Person> Persons { get; set; }

        /*
        public int IDCounter { get; set; }
        public int IsEmployedCounter { get; set; }
        public int IsUnEmployedCounter { get; set; }
        public int IsPensionerCounter { get; set; }
        public int IsOtherCounter { get; set; }
        public int HasShiftWorkCounter { get; set; }
        public int HasPartTimeJobCounter { get; set; }
        public int IsSickCounter { get; set; }
        public int  IsOnVacationCounter { get; set; }
        public int IsInHomeOfficeCounter { get; set; }
        public int WorksInTheCompanyCounter { get; set; }
        public int NeedsCarToCommuteToCompanyCounter { get; set; }
        public int  NeedsCarForShoppingTripCounter { get; set; }
        public int  NeedsCarForOtherTripCounter { get; set; }

         */
        private void SetDgVToolTipsCounter(FeatureCounter featureCounter)
        {
            dgvPersons.Columns[nameof(Person.ID)].ToolTipText = featureCounter.IDCounter.ToString();
            dgvPersons.Columns[nameof(Person.IsEmployed)].ToolTipText = featureCounter.IsEmployedCounter.ToString();
            dgvPersons.Columns[nameof(Person.IsUnEmployed)].ToolTipText = featureCounter.IsUnEmployedCounter.ToString();
            dgvPersons.Columns[nameof(Person.IsPensioner)].ToolTipText = featureCounter.IsPensionerCounter.ToString();
            dgvPersons.Columns[nameof(Person.IsOther)].ToolTipText = featureCounter.IsOtherCounter.ToString();
            dgvPersons.Columns[nameof(Person.HasShiftWork)].ToolTipText = featureCounter.HasShiftWorkCounter.ToString();
            dgvPersons.Columns[nameof(Person.WorksFrom9Till5)].ToolTipText = featureCounter.WorksFrom9Till5Counter.ToString();
            dgvPersons.Columns[nameof(Person.HasPartTimeJob)].ToolTipText = featureCounter.HasPartTimeJobCounter.ToString();
            dgvPersons.Columns[nameof(Person.HasFullTimeJob)].ToolTipText = featureCounter.HasFullTimeJobCounter.ToString();
            dgvPersons.Columns[nameof(Person.IsSick)].ToolTipText = featureCounter.IsSickCounter.ToString();
            dgvPersons.Columns[nameof(Person.IsOnVacation)].ToolTipText = featureCounter.IsOnVacationCounter.ToString();
            dgvPersons.Columns[nameof(Person.IsInHomeOffice)].ToolTipText = featureCounter.IsInHomeOfficeCounter.ToString();
            dgvPersons.Columns[nameof(Person.WorksInTheCompany)].ToolTipText = featureCounter.WorksInTheCompanyCounter.ToString();
            dgvPersons.Columns[nameof(Person.NeedsCarToCommuteToCompany)].ToolTipText = featureCounter.NeedsCarToCommuteToCompanyCounter.ToString();
            dgvPersons.Columns[nameof(Person.NeedsCarForShoppingTrip)].ToolTipText = featureCounter.NeedsCarForShoppingTripCounter.ToString();
            dgvPersons.Columns[nameof(Person.NeedsCarForOtherTrip)].ToolTipText = featureCounter.NeedsCarForOtherTripCounter.ToString();


            dgvPersons.Columns[nameof(Person.Name)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnDefaults_Click(object sender, EventArgs e)
        {
            RegionStatistics regionStatistics = new RegionStatistics();
            nmEmployed.Value = regionStatistics.Employed;
            nmShiftWork.Value = regionStatistics.ShiftWork;
            nmPartTimeJob.Value = regionStatistics.PartTimeJob;
            nmHomeOffice.Value = regionStatistics.HomeOffice;
            nmHolidays.Value = regionStatistics.Holidays;
            nmSickDays.Value = regionStatistics.SickDays;
            nmCommuteWithCar.Value = regionStatistics.CommuteWithCar;
            nmUnEmployed.Value = regionStatistics.UnEmployed;
            nmPensioner.Value = regionStatistics.Pensioner;
            nmShoppingTripsWithCars.Value = regionStatistics.ShoppingTripsWithCars;
            nmNumberOfShoppingTrips.Value = regionStatistics.NumberOfShoppingTripsPer5Days;
            nmOtherTrips.Value = regionStatistics.OtherTrips;
            nmNumberOfOtherTrips.Value = regionStatistics.NumberOfOtherTripsPer5Days;
            SetWelcomeImageAndDisableForecast();
        }

        private FormAIForecastingProcess frmAiForecastingProcess;
        private FormSimulationForecastingProcess _frmSSimulationForecastingProcess;

        private async void btnForecasting_Click(object sender, EventArgs e)
        {
            if (rBtnUseAI.Checked)
            {// use AI
                frmAiForecastingProcess = new FormAIForecastingProcess();
                frmAiForecastingProcess.Persons = Persons;
                var ret = frmAiForecastingProcess.ShowDialog(this);
                if (ret == DialogResult.OK)
                {
                    FormForecastingResult dlg = new FormForecastingResult();
                    dlg.SumTimesForecastedCarData = frmAiForecastingProcess.SumTimesForecastedCarData;
                    dlg.Persons = frmAiForecastingProcess.Persons;
                    dlg.UsedAI = true;
                    dlg.ShowDialog();
                }
                return;
            }

            // use Simulation
            var frmSimulationForecastingProcess = new FormSimulationForecastingProcess();
            frmSimulationForecastingProcess.Persons = Persons;
            var ret2 = frmSimulationForecastingProcess.ShowDialog(this);
            if (ret2 == DialogResult.OK)
            {
                FormForecastingResult dlg = new FormForecastingResult();
                dlg.SumTimesForecastedCarData = frmSimulationForecastingProcess.SumTimesForecastedCarData;
                dlg.Persons = frmSimulationForecastingProcess.Persons;
                dlg.UsedAI = false;
                dlg.ShowDialog();
            }
            return;
        }
        
        private void nmNumberOfPersons_ValueChanged(object sender, EventArgs e)
        {
            SetWelcomeImageAndDisableForecast();
        }

        private void SetWelcomeImageAndDisableForecast()
        {
  
            this.btnForecasting.Enabled = false;
            this.pnRadButtons.Enabled = false;
            if (nmNumberOfPersons.Value <= 2050)
            {
                pBKaff.Visible = true;
                pBDorf.Visible = false;
                pBStadt.Visible = false;
                return;
            }
            if (nmNumberOfPersons.Value < 50000)
            {
                pBKaff.Visible = false;
                pBDorf.Visible = true;
                pBStadt.Visible = false;
                return;
            }
            
            pBKaff.Visible = false;
            pBDorf.Visible = false;
            pBStadt.Visible = true;

        }

        private void nmEmployed_ValueChanged(object sender, EventArgs e)
        {
            SetWelcomeImageAndDisableForecast();
        }

        private void nmShiftWork_ValueChanged(object sender, EventArgs e)
        {
            SetWelcomeImageAndDisableForecast();
        }

        private void nmPartTimeJob_ValueChanged(object sender, EventArgs e)
        {
            SetWelcomeImageAndDisableForecast();
        }

        private void nmHomeOffice_ValueChanged(object sender, EventArgs e)
        {
            SetWelcomeImageAndDisableForecast();
        }

        private void nmHolidays_ValueChanged(object sender, EventArgs e)
        {
            SetWelcomeImageAndDisableForecast();
        }

        private void nmSickDays_ValueChanged(object sender, EventArgs e)
        {
            SetWelcomeImageAndDisableForecast();
        }

        private void nmCommuteWithCar_ValueChanged(object sender, EventArgs e)
        {
            SetWelcomeImageAndDisableForecast();
        }

        private void nmUnEmployed_ValueChanged(object sender, EventArgs e)
        {
            SetWelcomeImageAndDisableForecast();
        }

        private void nmPensioner_ValueChanged(object sender, EventArgs e)
        {
            SetWelcomeImageAndDisableForecast();
        }

        private void nmShoppingTripsWithCars_ValueChanged(object sender, EventArgs e)
        {
            SetWelcomeImageAndDisableForecast();
        }

        private void nmNumberOfShoppingTrips_ValueChanged(object sender, EventArgs e)
        {
            SetWelcomeImageAndDisableForecast();
        }

        private void nmOtherTrips_ValueChanged(object sender, EventArgs e)
        {
            SetWelcomeImageAndDisableForecast();
        }

        private void nmNumberOfOtherTrips_ValueChanged(object sender, EventArgs e)
        {
            SetWelcomeImageAndDisableForecast();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            HelpParamsDialog fDialog = new HelpParamsDialog();

            fDialog.ShowDialog(); 

            if (fDialog.EnableSimulation)
            {
                panelDummy.Visible = false;
                pnRadButtons.Visible = true;
            }
        }
    }
}
