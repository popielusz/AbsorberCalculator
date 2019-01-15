using System;
using System.Windows.Forms;

namespace Absorber
{
    public partial class FormMain : Form
    {
        Calculator AbsorberCalculator; // klasa kalkulatora parametrów absorbera, należy ona do okna programu

        public FormMain()
        {
            InitializeComponent();
            AbsorberCalculator = new Calculator();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearFormants();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double Height, Profile;
            string Message = "";
            readFormants();
            if (AbsorberCalculator.Calculate(out Height, out Profile))
            {
                textBoxAbsorberHeight.Text = Height.ToString();
                textBoxAbsorberProfile.Text = Profile.ToString();
                Message = "Obliczenia zakończone poprawnie.";
            }
            else
            {
                Message = "Nie można wykonać obliczeń dla podanych wartości!";
            }
            textBoxLog.Text = Message;
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            /* wczytanie zawartości pliku ustawień (INI) i zastosowanie ich 
               jako ustawień startowych w programie, wczytanie danych z pliku 
               roboczego do listy rozwijanej oraz wyczyszczenie numerycznych 
               pól edycyjnych i etykiet tekstowych */
            string Path = "D:\\Uczelnia\\Praca inżynierska\\14.01\\Absorber\\Absorber\\bin\\Debug\\FillingList.txt";
            AbsorberCalculator.LoadFillingFromFile(Path, comboBoxFilling.Items);
            clearFormants();
        }

        private void clearFormants()
        {
            /* wyczyszczenie zawartości numerycznych pól edycyjnych i etykiet
               tekstowych, ustawienie listy rozwijanej na pierwszym elemencie */
            numericUpDownMassTransferCoefficient.Value = 0;
            numericUpDownAbsorbateMolarMass.Value = 0;
            numericUpDownAbsorbentMolarMass.Value = 0;
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
            textBoxLog.Text = "";
            comboBoxFilling.SelectedIndex = 0;
            AbsorberCalculator.FillingIndex = 0;
        }

        private void readFormants()
        {
            /* odczytanie zawartości z numerycznych pół edycyjnych i umieszczenie 
               tych danych w obiekcie kalkulatora parametrów absorbera*/
            AbsorberCalculator.MassTransferCoefficient = Convert.ToDouble(numericUpDownMassTransferCoefficient.Value);
            AbsorberCalculator.AbsorbateMolarMass = Convert.ToDouble(numericUpDownAbsorbateMolarMass.Value);
            AbsorberCalculator.EquationA = Convert.ToDouble(numericUpDownEquationA.Value);
            AbsorberCalculator.EquationB = Convert.ToDouble(numericUpDownEquationB.Value);
            AbsorberCalculator.DensityA = Convert.ToDouble(numericUpDownDensityA.Value);
            AbsorberCalculator.DensityB = Convert.ToDouble(numericUpDownDensityB.Value);
            AbsorberCalculator.ViscosityA = Convert.ToDouble(numericUpDownViscosityA.Value);
            AbsorberCalculator.ViscosityB = Convert.ToDouble(numericUpDownViscosityB.Value);
            AbsorberCalculator.MassIntensityA = Convert.ToDouble(numericUpDownMassIntensityA.Value);
            AbsorberCalculator.VolumeIntensityB = Convert.ToDouble(numericUpDownVolumeIntensityB.Value);
            AbsorberCalculator.AbsorbateConcentrationA = Convert.ToDouble(numericUpDownAbsorbateConcentrationA.Value);
            AbsorberCalculator.AbsorbateConcentrationB = Convert.ToDouble(numericUpDownAbsorbateConcentrationB.Value);
            AbsorberCalculator.Efficiency = Convert.ToDouble(numericUpDownEfficiency.Value);
            AbsorberCalculator.EmulgationPercentage = Convert.ToDouble(numericUpDownEmulgationPercentage.Value);
            AbsorberCalculator.FillingIndex = comboBoxFilling.SelectedIndex;
        }

        private void comboBoxFilling_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }
    }
}
