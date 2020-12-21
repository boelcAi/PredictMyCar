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
    public partial class FormAIForecastingProcess : Form
    {
        public FormAIForecastingProcess()
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
                decimal[] input = PersonService.Instance.GetKnnInputForPerson(person);

                decimal[] output = KNN.Instance.Calculate(input);
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
                if (dataNeedCar.Value < 0)
                {
                    //dataNeedCar.Value = 0;
                }
                dataNeedCar.Value = (Math.Round(dataNeedCar.Value));
            }

            SumTimesForecastedCarData = sumTimesForecastedCarData;
        }

        

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnShowWeights_Click(object sender, EventArgs e)
        {
            ShowKNN();
        }

        private void ShowKNN()
        {
            DoNotUseTimer = true;
            timer1.Enabled = false;
            ShowKnnDialog dlg = new ShowKnnDialog();
            dlg.ShowDialog(this);
        }

        public bool DoNotUseTimer = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            DialogResult = DialogResult.OK;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowKNN();
        }
    }
}
