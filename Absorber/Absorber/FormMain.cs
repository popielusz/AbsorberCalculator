using System;
using System.Windows.Forms;

namespace Absorber
{
    public partial class FormMain : Form
    {
        const string FillingFileName = "FillingList.txt";
        Calculator AbsorberCalculator; // Klasa kalkulatora parametrów absorbera, należy ona do okna programu

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
            int Warning = 0;
            readFormants();
            Warning = AbsorberCalculator.WarningCheck();
            switch(Warning)
                {
                    case 0:
                        AbsorberCalculator.Calculate(out Height, out Profile);
                        textBoxAbsorberHeight.Text = Height.ToString("N4");
                        textBoxAbsorberProfile.Text = Profile.ToString("N4");
                        textBoxLog.Text = "Obliczenia zakończone pomyślnie.";
                    break;
                    case 1:
                        textBoxLog.Text = "Wystąpił błąd: Nieprawidłowo wybrany rodzaj wypełnienia.";
                        break;
                    case 2:
                        textBoxLog.Text = "Wystąpił błąd: Nie wszystkie dane są wprowadzone prawidłowo.";
                        break;
                    case 3:
                        textBoxLog.Text = "Wystąpił błąd: Nieprawidłowy współczynnik zwilżalności.";
                        break;
                    default:
                        textBoxLog.Text = "Wystąpił błąd: Nieznana przyczyna.";
                        break;
                }
         }

        private void formMain_Load(object sender, EventArgs e)
        {
            /* Wczytanie zawartości pliku ustawień (INI) i zastosowanie ich 
               jako ustawień startowych w programie, wczytanie danych z pliku 
               roboczego do listy rozwijanej oraz wyczyszczenie numerycznych 
               pól edycyjnych i etykiet tekstowych */
            string ExecutableName = System.AppDomain.CurrentDomain.FriendlyName;
            string ExecutablePath = System.Reflection.Assembly.GetEntryAssembly().Location;
            string Path = ExecutablePath.Replace(ExecutableName, "");
            Path += FillingFileName;
            AbsorberCalculator.LoadFillingFromFile(Path, comboBoxFilling.Items);
            clearFormants();
        }

        private void clearFormants()
        {
            /* Wyczyszczenie zawartości numerycznych pól edycyjnych i etykiet
               tekstowych, ustawienie listy rozwijanej na pierwszym elemencie */
            numericUpDownMassTransferCoefficient.Value = 0;
            numericUpDownAbsorbateMolarMass.Value = 0;
            numericUpDownAbsorbentMolarMass.Value = 0;
            numericUpDownEquationA.Value = 1;
            numericUpDownDensityA.Value = 1;
            numericUpDownDensityB.Value = 1;
            numericUpDownDensityNormalB.Value = 1;
            numericUpDownViscosityA.Value = 0;
            numericUpDownMassIntensityA.Value = 0;
            numericUpDownVolumeIntensityB.Value = 0;
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
            /* Odczytanie zawartości z numerycznych pół edycyjnych i umieszczenie 
               tych danych w obiekcie kalkulatora parametrów absorbera*/
            AbsorberCalculator.MassTransferCoefficient = Convert.ToDouble(numericUpDownMassTransferCoefficient.Value);
            AbsorberCalculator.AbsorbateMolarMass = Convert.ToDouble(numericUpDownAbsorbateMolarMass.Value);
            AbsorberCalculator.EquationA = Convert.ToDouble(numericUpDownEquationA.Value);
            AbsorberCalculator.DensityA = Convert.ToDouble(numericUpDownDensityA.Value);
            AbsorberCalculator.DensityB = Convert.ToDouble(numericUpDownDensityB.Value);
            AbsorberCalculator.DensityNormalB = Convert.ToDouble(numericUpDownDensityNormalB.Value);
            AbsorberCalculator.ViscosityA = Convert.ToDouble(numericUpDownViscosityA.Value);
            AbsorberCalculator.MassIntensityA = Convert.ToDouble(numericUpDownMassIntensityA.Value);
            AbsorberCalculator.VolumeIntensityB = Convert.ToDouble(numericUpDownVolumeIntensityB.Value);
            AbsorberCalculator.AbsorbateConcentrationB = Convert.ToDouble(numericUpDownAbsorbateConcentrationB.Value);
            AbsorberCalculator.Efficiency = Convert.ToDouble(numericUpDownEfficiency.Value);
            AbsorberCalculator.AbsorbentMolarMass = Convert.ToDouble(numericUpDownAbsorbentMolarMass.Value);
            AbsorberCalculator.EmulgationPercentage = Convert.ToDouble(numericUpDownEmulgationPercentage.Value);
            AbsorberCalculator.FillingIndex = comboBoxFilling.SelectedIndex;
        }

        private void comboBoxFilling_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
