using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using PredictMyCarAPp.Properties;

namespace PredictMyCarAPp
{
    public partial class PercentageSavedCarsDialog : Form
    {
        public PercentageSavedCarsDialog()
        {
            InitializeComponent();
        }
        public int CarpoolCars { get; set; }
        public int SavedCars { get; set; }
        public int PercentageSaved { get; set; }

        private void PercentageSavedCarsDialog_Load(object sender, EventArgs e)
        {
            this.Text = $"Visualization Car Savings of {PercentageSaved}%";
            this.lbSaved.Text = $"{SavedCars} saved cars";
            this.lbCarpool.Text = $"{CarpoolCars} carpool cars";
        }



        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if ((sender as PictureBox).Image == null) e.Graphics.Clear(Color.White);

            //e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            //foreach (var line in lines)
            //{
            //    e.Graphics.DrawLine(pen, line.Item1, line.Item2);
            //}
            Image car = Resources.carCarpool;
            Image savedCar = Resources.saved4car;
            int counter = 100;
            int imagewidth = 50;
            int imageheight = 40;
            int distx0= 35;
            int disty0 = 35;
            int distx = 55;
            int disty = 45;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10;j++)
                {
                    counter--;
                    if (counter >= PercentageSaved)
                    {
                        e.Graphics.DrawImage(car, distx0 + j * distx, disty0 + i * disty, imagewidth, imageheight);
                    }
                    else
                    {
                        e.Graphics.DrawImage(savedCar, distx0 + j * distx, disty0 + i * disty, imagewidth, imageheight);
                    }
                }
            }

        }
    }
}
