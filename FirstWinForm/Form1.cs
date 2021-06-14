using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinForm
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            
            if (rectangleButton.Checked)
            {

                try
                {

                    double baseLength = double.Parse(baseBox.Text);
                    double heightLength = double.Parse(heightBox.Text);

                    outputLabel.Text = (baseLength * heightLength).ToString("n3");

                }
                catch (Exception ex)
                {
                    outputLabel.Text = "N/A";
                    MessageBox.Show(ex.Message);
                }

            }
            else if (triangleButton.Checked)
            {

                try
                {

                    double baseLength = double.Parse(baseBox.Text);
                    double heightLength = double.Parse(heightBox.Text);

                    outputLabel.Text = (baseLength * heightLength * 0.5).ToString("n3");

                }
                catch (Exception ex)
                {
                    outputLabel.Text = "N/A";
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                outputLabel.Text = "N/A";
            }

        }// end calculateButton click handler
    }
}
