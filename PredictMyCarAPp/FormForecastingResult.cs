using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PredictMyCarAPp
{
    public partial class FormForecastingResult : Form
    {
        public bool UsedAI { get; set; }

        public FormForecastingResult()
        {
            InitializeComponent();
            pnlResultOverlay.Visible = true;
            DisableResult();
        }

        private void DisableResult()
        {
            pnlResultOverlay.BringToFront();
            pnlResultOverlay.Visible = true;

        }

        public ObservableCollection<NeededCarsData> SumTimesForecastedCarData { get; set; }
        public ObservableCollection<Person> Persons { get; set; }
        public ObservableCollection<NeededCarsData> SumTimesSafetyMarginCarData { get; set; }

        public ObservableCollection<NeededCarsData> SumTimesNeededCarsData { get; set; }

        private void FormForecastingResult_Load(object sender, EventArgs e)
        {
            dgVTime.DataSource = SumTimesForecastedCarData;
            CreateForecastGraph();
            if (UsedAI)
            {
                lblCarsForecastTitle.Text = $"AI Cars forecast for {Persons.Count} people";
            }
            else
            {
                lblCarsForecastTitle.Text = $"Simulation Cars forecast for {Persons.Count} people";
            }
            

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateCarPool();
            //SetSafetyMargin();
            CalculateCarPoolSafetyMargin();
            InsertCarPoolGraph();
            InsertComparision();
            pnlResultOverlay.Visible = false;

        }

        private void InsertComparision()
        {
            int averageCustom = (int)Math.Round(Persons.Count * 0.55);
            lblOwnershipComparison.Text =
                $"On average, {Persons.Count} people own {averageCustom.ToString()} cars.";
            //lblComparisionCars.Text = $"your region can save\n{averageCustom - CarPoolValue} cars.";
            var diff = averageCustom - CarPoolValue;
            this.SavedCars = diff;
            lblComparisionCars.Text =
                $"With the use of the carpool, your region can save {diff} cars.";



            if (diff>0)
            {
                panel6.BackColor = Color.Chartreuse;
                panel7.BackColor = Color.White;
                pictureBox3.Visible = true;

                this.lbPercentageSave.Visible = true;
                this.PercentageSave = (int)decimal.Round(diff / averageCustom * 100);
                this.lbPercentageSave.Text = $"You saved {PercentageSave}% of cars";
            }
            else
            {
                panel6.BackColor = Color.DarkRed;
                panel7.BackColor = Color.White;
                pictureBox3.Visible  = false;
                this.lbPercentageSave.Visible = false;
            }
            
        }

        public decimal SavedCars { get; set; }

        public int PercentageSave { get; set; }

        private void CalculateCarPool()
        {//mit carpoolgröße 0 starten -> anschließend den negativsten Wert als Carpool nehmen.
            

            SumTimesNeededCarsData = new ObservableCollection<NeededCarsData>();
            for (var index = 0; index < SumTimesForecastedCarData.Count; index++)
            {
                SumTimesNeededCarsData.Add(new NeededCarsData(index, 0));
            }
            decimal calculation = 0;
            decimal min = 0;
            for (var index = 0; index < SumTimesForecastedCarData.Count; index++)
            {
                calculation -= SumTimesForecastedCarData[index].Value;

                var carsBackToPool = GetCarsBackToPool(index, SumTimesForecastedCarData);
                calculation = calculation + carsBackToPool;
                SumTimesNeededCarsData[index].Value = calculation;
                if (calculation < min)
                {
                    min = calculation;
                }
            }

            decimal carpool = -min;

            calculation = carpool;

            for (var index = 0; index < SumTimesForecastedCarData.Count; index++)
            {
                calculation -= SumTimesForecastedCarData[index].Value;

                var carsBackToPool = GetCarsBackToPool(index, SumTimesForecastedCarData);
                calculation = calculation + carsBackToPool;
                SumTimesNeededCarsData[index].Value = calculation;
            }

            //lblCarPool.Text = carpool.ToString();
            CarPoolValueWithOutMargin = carpool;
            //dgVCarPool.DataSource = SumTimesNeededCarsData;


        }

        private void InsertCarPoolGraph()
        {
            var data = new Dictionary<string, decimal>()
            {

            };
            foreach (NeededCarsData neededCarsData in SumTimesNeededCarsData)
            {
                data.Add(neededCarsData.Hour.ToString(), neededCarsData.Value);
            }


            using (var chart = new Chart()
            {
                Height = pictureBox2.Height,
                Width = pictureBox2.Width
            })
            {
                // Konfiguration
                chart.Titles.Add("Carpool capacity forecast ");

                chart.ChartAreas.Add(new ChartArea("statistic")
                {
                    AxisX = new Axis()
                    {
                        MajorGrid = new Grid()
                        {
                            Enabled = false
                        },
                        Title = "Time of day"
                    },
                    AxisY = new Axis()
                    {
                        MajorGrid = new Grid()
                        {
                            LineColor = Color.LightGray,
                            LineDashStyle = ChartDashStyle.Dot
                        },
                        Title = "cars"
                    }
                });

                chart.Series.Add(new Series("data")
                {
                    ChartType = SeriesChartType.Column
                });

                // Daten
                foreach (KeyValuePair<string, decimal> entry in data)
                {
                    chart.Series["data"].Points.Add(new DataPoint()
                    {
                        AxisLabel = entry.Key,
                        YValues = new double[] { (double)entry.Value }
                    });
                }

                var bmp = new Bitmap(chart.Width, chart.Height);
                var rec = new Rectangle(0, 0, chart.Width, chart.Height);

                chart.DrawToBitmap(bmp, rec);
                pictureBox2.BackgroundImage = bmp;
                pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;


            }
        }

        public decimal CarPoolValueWithOutMargin { get; set; }
        public decimal CarPoolValue { get; set; }


        private void CalculateCarPoolSafetyMargin()
        {
            
            //Sicherheits Aufschlag addieren, dann aber nur Forecast abziehen

            var carpoolWithMargin = Decimal.Round(CarPoolValueWithOutMargin * (1 + (nmSafetyMargin.Value / 100)));

            lblCarPoolSafetyMargin.Text = carpoolWithMargin.ToString();
            //carpool erhalten jetzt normalen Forecast abziehen
            //
            CarPoolValue = carpoolWithMargin;

            SumTimesNeededCarsData = new ObservableCollection<NeededCarsData>();
            for (var index = 0; index < SumTimesForecastedCarData.Count; index++)
            {
                SumTimesNeededCarsData.Add(new NeededCarsData(index, 0));
            }

            var calculation = carpoolWithMargin;
            for (var index = 0; index < SumTimesForecastedCarData.Count; index++)
            {
                calculation -= SumTimesForecastedCarData[index].Value;

                var carsBackToPool = GetCarsBackToPool(index, SumTimesForecastedCarData);
                calculation = calculation + carsBackToPool;
                SumTimesNeededCarsData[index].Value = Decimal.Round(calculation);
            }



            dgVCarPoolMargin.DataSource = SumTimesNeededCarsData;
        }
        

        private decimal GetCarsBackToPool(int index, ObservableCollection<NeededCarsData> list)
        {
            int indexBack = index - (int)nmWaitTillNextUsage.Value-1;
            if (indexBack < 0)
            {
                return 0;
            } 
            return list[indexBack].Value;
        }



        private void btnDefaults_Click(object sender, EventArgs e)
        {
            nmSafetyMargin.Value = 15;
            nmWaitTillNextUsage.Value = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CreateForecastGraph()
        {
            var data = new Dictionary<string, decimal>()
            {

            };
            foreach (NeededCarsData neededCarsData in SumTimesForecastedCarData)
            {
                data.Add(neededCarsData.Hour.ToString(), neededCarsData.Value);
            }


            using (var chart = new Chart()
            {
                Height = pictureBox1.Height,
                Width = pictureBox1.Width
            })
            {
                // Konfiguration
                chart.Titles.Add("Forecast of requested cars");

                chart.ChartAreas.Add(new ChartArea("statistic")
                {
                    AxisX = new Axis()
                    {
                        MajorGrid = new Grid()
                        {
                            Enabled = false
                        },
                        Title = "Time of day"
                    },
                    AxisY = new Axis()
                    {
                        MajorGrid = new Grid()
                        {
                            LineColor = Color.LightGray,
                            LineDashStyle = ChartDashStyle.Dot
                        },
                        Title = "cars"
                    }
                });

                chart.Series.Add(new Series("data")
                {
                    ChartType = SeriesChartType.Column
                });

                // Daten
                foreach (KeyValuePair<string, decimal> entry in data)
                {
                    chart.Series["data"].Points.Add(new DataPoint()
                    {
                        AxisLabel = entry.Key,
                        YValues = new double[] { (double)entry.Value }
                    });
                }

                var bmp = new Bitmap(chart.Width, chart.Height);
                var rec = new Rectangle(0, 0, chart.Width, chart.Height);

                chart.DrawToBitmap(bmp, rec);
                pictureBox1.BackgroundImage = bmp;
                pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;


            }
        }

        private void nmSafetyMargin_ValueChanged(object sender, EventArgs e)
        {
            DisableResult();
        }

        private void nmWaitTillNextUsage_ValueChanged(object sender, EventArgs e)
        {
            DisableResult();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PercentageSavedCarsDialog dialog = new PercentageSavedCarsDialog();
            dialog.PercentageSaved = this.PercentageSave;
            dialog.SavedCars = (int)decimal.Round(this.SavedCars);
            dialog.CarpoolCars = (int) decimal.Round(CarPoolValue);
            dialog.ShowDialog();

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(toolTip1.GetToolTip(btnInfo), "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            foreach (var person in Persons)
            {
                

            }
        }
    }
}
