using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredictMyCarAPp
{
    public partial class FormSimulationForecastingProcess : Form
    {
        public FormSimulationForecastingProcess()
        {
            InitializeComponent();
        }



        public ObservableCollection<NeededCarsData> SumTimesForecastedCarData { get; set; }
        public ObservableCollection<Person> Persons { get; set; }

        private async void FormAIForecastingProcess_Load(object sender, EventArgs e)
        {


            this.Cursor = Cursors.WaitCursor;
            this.progressBar1.Visible = true;
            this.progressBar1.Value = 0;
            var progress = new Progress<int>(value => { progressBar1.Value = value; });



            await Task.Run(() => calculate(progress));

            FormForecastingResult dlg = new FormForecastingResult();
            dlg.SumTimesForecastedCarData = SumTimesForecastedCarData;
            dlg.Persons = Persons;
            
            this.Cursor = Cursors.Default;
            //this.Visible= false;
            this.btnOk.Enabled = true;
            this.label1.Text = "Predictions were made. Press \"Show Forecasts\" for next step";
            if (!DoNotUseTimer)
            {
                timer1.Interval = 2000;
                timer1.Enabled = true;
            }
            //dlg.ShowDialog(this.Parent);
            //this.progressBar1.Visible = false;

        }

        private void calculate(IProgress<int> progress)
        {


            //ObservableCollection<NeededCarsData> timesNeedCarData = new ObservableCollection<NeededCarsData>();
            ObservableCollection<NeededCarsData> sumTimesForecastedCarData = new ObservableCollection<NeededCarsData>();
            //ObservableCollection<decimal[]> neededCarsData = new ObservableCollection<decimal[] > ();
            for (int i = 0; i < 24; i++)
            {
                sumTimesForecastedCarData.Add(new NeededCarsData(i, 0));
            }

            int pCounter = 0;
            for (var personId = 0; personId < Persons.Count; personId++)
            {
                var person = Persons[personId];
                
                //decimal[] input = PersonService.Instance.GetKnnInputForPerson(person);
                decimal[] output = Simulation.Instance.Calculate(person);
                if (output.Length != 24)
                {
                    throw new NotImplementedException("needs to be 24");
                }

                person.SetCalculatedOutParameter(output);

                for (int i = 0; i < 24; i++)
                {
                    decimal outData = output[i];
                    var sum = sumTimesForecastedCarData[i];
                    sum.Value += outData;
                }

                pCounter++;
                if (pCounter> Persons.Count / 20)
                {
                    pCounter = 0;
                    var percentComplete = (((decimal) personId / (Persons.Count - 1))) * 100;
                    progress.Report((int) percentComplete);
                }
            }
            progress.Report(100);
            for (int i = 0; i < 24; i++)
            {

                var dataNeedCar = sumTimesForecastedCarData[i];
                dataNeedCar.Value = (Math.Round(dataNeedCar.Value));
            }

            SumTimesForecastedCarData = sumTimesForecastedCarData;
        }

        

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }


        public bool DoNotUseTimer = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            DialogResult = DialogResult.OK;
        }

        private void btnShowWeights_Click_1(object sender, EventArgs e)
        {
            ShowSimulationSettings();
        }

        private void ShowSimulationSettings()
        {
            DoNotUseTimer = true;
            timer1.Enabled = false;
            MessageBox.Show(
                " - persons with no shift work:\n\r start of work: 6-9 o'clock (equally distributed)" +
                "\n\r\n\r - persons with shift work:\n\r start of work: 1 - 4 o'clock, 11-14 o'clock, or 20 - 23 o'clock (equally distributed each)" +
                "\n\r\n\r - Working time fulltime:\n\r 7 - 11 hours(equally distributed)" +
                "\n\r\n\r - Working time parttime:\n\r 3 - 5 hours(equally distributed)" +
                "\n\r\n\r - Shopping trips:\n\r 7 - 20 o'clock (equally distributed)" +
                "\n\r\n\r - Other trips:\n\r 0 - 23 o'clock (equally distributed)" +
                "\n\r\n\r - Car usage Duration(for commute, shopping or other trip):\n\r 1 hour", "Assumptions made for the simulation:");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowSimulationSettings();
        }
    }
}
