using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PredictMyCarAPp
{
    public partial class ShowKnnDialog : Form
    {
        public ShowKnnDialog()
        {
            InitializeComponent();
           // propertyGrid1.SelectedObject = KNN.Instance;

        }

        private void btnShowSourceCode_Click(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1200,this.MinimumSize.Height);
            textBox1.Text = KNN.Instance.CreateHumanReadableWeights();
            this.btnShowSourceCode.Visible = false;
        }
    }
}
