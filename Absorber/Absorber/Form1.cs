using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Absorber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void label1_Click_5(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_6(object sender, EventArgs e)
        {

        }

        private void label1_Click_7(object sender, EventArgs e)
        {

        }

        private void groupBoxAbsorber_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            numericUpDownMassTransferCoefficient.Value = 0;
            numericUpDownAbsorbateMolarMass.Value = 0;
            numericUpDownEquationA.Value = 1;
            numericUpDownEquationB.Value = 0;
            numericUpDownDensityA.Value = 1;
            numericUpDownDensityB.Value = 1;
            numericUpDownViscosityA.Value = 0;
            numericUpDownViscosityB.Value = 0;
            numericUpDownMassIntensityA.Value = 0;
            numericUpDownVolumeIntensityB.Value = 0;
            numericUpDownAbsorbateConcentrationA.Value = 0;
            numericUpDownAbsorbateConcentrationB.Value = 0;
            numericUpDownEfficiency.Value = 100;
            numericUpDownEmulgationPercentage.Value = 100;
            textBoxAbsorberHeight.Text = "0";
            textBoxAbsorberProfile.Text = "0";
            textBoxLog.Text = " ";
        }

        private void Abc(object sender, EventArgs e)
        {
            textBoxAbsorberHeight.Text = "Abc!";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_2(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
