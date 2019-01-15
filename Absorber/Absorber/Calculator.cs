using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Absorber
{
    class Calculator : Object
    {
        private List<double> _FillingSurfaces; // lista przechowująca wartości liczbowe powierzchni właściwych wypełnień absorbera
        private List<double> _FillingVolumes;  // lista przechowująca wartości liczbowe objętości swobodnych wypełnień absorbera
        private int _FillingIndex;
        private double _MassTransferCoefficient;
        private double _AbsorbateMolarMass;
        private double _EquationA;
        private double _EquationB;
        private double _DensityA;
        private double _DensityB;
        private double _ViscosityA;
        private double _ViscosityB;
        private double _MassIntensityA;
        private double _VolumeIntensityB;
        private double _AbsorbateConcentrationA;
        private double _AbsorbateConcentrationB;
        private double _Efficiency;
        private double _EmulgationPercentage;
        private double _AbsorbentMolarMass;

        private double _UpperDrivingForce;

        private const double GravitationalAcceleration = 9.80665;
        private const double AbsorptionCoefficient = 0.022;

        public int FillingIndex
        {
            get { return _FillingIndex; }
            set { _FillingIndex = value; }
        }

        public double MassTransferCoefficient
        {
            get { return _MassTransferCoefficient; }
            set { _MassTransferCoefficient = value; }
        }

        public double AbsorbateMolarMass
        {
            get { return _AbsorbateMolarMass; }
            set { _AbsorbateMolarMass = value; }
        }

        public double EquationA
        {
            get { return _EquationA; }
            set { _EquationA = value; }
        }

        public double EquationB
        {
            get { return _EquationB; }
            set { _EquationB = value; }
        }

        public double DensityA
        {
            get { return _DensityA; }
            set { _DensityA = value; }
        }

        public double DensityB
        {
            get { return _DensityB; }
            set { _DensityB = value; }
        }

        public double ViscosityA
        {
            get { return _ViscosityA; }
            set { _ViscosityA = value; }
        }

        public double ViscosityB
        {
            get { return _ViscosityB; }
            set { _ViscosityB = value; }
        }

        public double MassIntensityA
        {
            get { return _MassIntensityA; }
            set { _MassIntensityA = value; }
        }

        public double VolumeIntensityB
        {
            get { return _VolumeIntensityB; }
            set { _VolumeIntensityB = value; }
        }

        public double AbsorbateConcentrationA
        {
            get { return _AbsorbateConcentrationA; }
            set { _AbsorbateConcentrationA = value; }
        }

        public double AbsorbateConcentrationB
        {
            get { return _AbsorbateConcentrationB; }
            set { _AbsorbateConcentrationB = value; }
        }

        public double Efficiency
        {
            get { return _Efficiency; }
            set { _Efficiency = value; }
        }

        public double EmulgationPercentage
        {
            get { return _EmulgationPercentage; }
            set { _EmulgationPercentage = value; }
        }

        public double AbsorbentMolarMass
        {
            get { return _AbsorbentMolarMass; }
            set { _AbsorbentMolarMass = value; }
        }        

        public Calculator()
        {
            /* konstruktor klasy, która dokonuje obliczeń parametrów absorbera,
               tu jest przydzielana pamięć na obiekty wewnętrzne kalkulatora */
            _FillingSurfaces = new List<double>();
            _FillingVolumes = new List<double>();
            Clear();
        }

        public void Clear()
        {
            /* czyści te wewnętrzne pola klasy koalkulatora, które służą do przekazywania 
               danych wejściowych do obliczeń, lista wypełnień absorbera nie jest czyszczona */
            _FillingIndex = -1;
            _MassTransferCoefficient = 0;
            _AbsorbateMolarMass = 0;
            _AbsorbentMolarMass = 0;
            _EquationA = 0;
            _EquationB = 0;
            _DensityA = 0;
            _DensityB = 0;
            _ViscosityA = 0;
            _ViscosityB = 0;
            _MassIntensityA = 0;
            _VolumeIntensityB = 0;
            _AbsorbateConcentrationA = 0;
            _AbsorbateConcentrationB = 0;
            _Efficiency = 0;
            _EmulgationPercentage = 0;
            _UpperDrivingForce = 0;
        }

        public bool Calculate(out double AbsorberHeight, out double AbsorberProfile)
        {
            /* tu wykonywane są właściwe obliczenia parametrów absorbera */
            bool Result = false;
            // zerowanie argumentów przekazanych do funkcji
            AbsorberHeight = 0;
            AbsorberProfile = 0;
            // jeśli wybrano jakieś wypełnienie to kalkulator wykonuje obliczenia
            if (_FillingIndex > -1)
            {
                double FillingSurface = _FillingSurfaces[_FillingIndex];
                double FillingVolume = _FillingVolumes[_FillingIndex];
                double AbsorbateMolarIntensity = CalculateAbsorbateMolarIntensity(_VolumeIntensityB, _AbsorbateConcentrationB, _Efficiency);
                double MassTransferSurface = CalculateMassTransferSurface(AbsorbateMolarIntensity, _VolumeIntensityB, _AbsorbateConcentrationB, _Efficiency, _MassIntensityA, _MassTransferCoefficient);
                double RequiredFillingSurface = CalculateRequiredFillingSurface(MassTransferSurface, FillingSurface);
                double MassIntensityB = ConvertIntensityVolumeToMass(_VolumeIntensityB, _DensityB, _AbsorbateMolarMass, AbsorbateMolarIntensity);

            }
            return Result;
        }

        private double CalculateAbsorbateMolarIntensity(double VolumeIntensityB, double ConcentrationB, double Efficiency)
        {
            // M
            double AbsorbateMolarIntensity = (VolumeIntensityB * ConcentrationB * Efficiency) / ((1 - ConcentrationB) * 22.4);
            return AbsorbateMolarIntensity;
        }

        private double CalculateMassTransferSurface(double AbsorbateMolarIntensity,  double VolumeIntensityB, double ConcentrationB, double Efficiency, double MassIntensityA, double MassTransferCoefficient)
        {
            double AbsorbateFinalMolarConcentrationA = AbsorbateMolarIntensity / (MassIntensityA / 18);
            double AbsorbateInitialMolarConcentrationB = ConcentrationB / (1 - ConcentrationB);
            // Y_g
            double AbsorbateFinalMolarConcentrationB = (ConcentrationB * (1 - Efficiency)) / (1 - ConcentrationB);
            // Delta Y_d
            double BottomDrivingForce = EquationA * AbsorbateFinalMolarConcentrationA + EquationB;
            // Delta Y_g (0 bo zakładamy Xw = 0 czyli że woda zraszająca skruber jest na początku czysta)
            _UpperDrivingForce = AbsorbateFinalMolarConcentrationB - 0;
            // Delta Y_śr
            double AverageDrivingForce = (BottomDrivingForce - _UpperDrivingForce) / (2.3 * Math.Log10(BottomDrivingForce / _UpperDrivingForce));
            // F
            double MassTransferSurface = AbsorbateMolarIntensity / (MassTransferCoefficient * AverageDrivingForce);
            return MassTransferSurface;
        }

        private double CalculateRequiredFillingSurface(double MassTransferSurface, double FillingValue)
        {
            double Wettability = 1;
            //Sprawdzanie czy = 1? 
            double RequiredFillingSurface = MassTransferSurface / FillingValue;
            return RequiredFillingSurface;
        }

        private double ConvertIntensityVolumeToMass(double VolumeIntensity, double Density, double MolarMass, double MolarIntensity)
        {
            //konwersja strumienia objętościowego na masowy (?)
            double MassIntensity = VolumeIntensity * Density + (MolarIntensity * MolarMass) / 2;
            return MassIntensity;
        }

        private double CalculateEmulgationVelocity(double EmulgationPercentage, double RequiredFillingSurface, double AbsorbateMolarIntensity, double MassIntensityB, double FillingValue, double DensityA, double DensityB, double ViscosityA, double MassIntensityA, double VolumeIntensityB, double AbsorbateMolarMass, double FreeVolume)
        {
            
            //objetosc swobodna w FillingList - FreeVolume
            double EmulgationVelocity = Math.Sqrt((Math.Pow(10,(AbsorptionCoefficient * 1.75  *  Math.Pow((MassIntensityA / MassIntensityB),0.25) * Math.Pow((DensityB/(DensityA-DensityB)),0.125)))) / ((RequiredFillingSurface * DensityB*Math.Pow(ViscosityA,016))/(GravitationalAcceleration*Math.Pow(FreeVolume,3)*(DensityA-DensityB))));
            double Velocity = EmulgationVelocity * EmulgationPercentage; 
            return Velocity;
        }

        private double CalculateAbsorberProfile(double MassIntensityB, double DensityB)
        {
            double AbsorberProfile = MassIntensityB / (3600 * DensityB);
            return AbsorberProfile;
        }

        private double CalculateFillingHeight(double RequiredFillingSurface, double FillingProfile)
        {
            double FillingHeight = RequiredFillingSurface / FillingProfile;
            return FillingHeight;
        }

        private bool WettabilityCheck(double VolumeIntensity, double DensityA, double AbsorberProfile)
        {
            bool SprayDensityFail = true;
            double SprayDensity = VolumeIntensity / (DensityA * AbsorberProfile);
            if (SprayDensity < 5)
            {
                SprayDensityFail = true;
            }
            return SprayDensityFail;
        }

        public void LoadFillingFromFile(String Path, IList FillingNames)
        {
            /* wczytanie z pliku tekstowego opisów i wartości liczbowych różnego
               rodzaju wypełnień dla absorbera, następnie umieszczenie opisów
               wypełnienia w liście rozwijanej oraz wartości liczbowych w liście
               wewnętrznej programu */
            if (File.Exists(Path))
            {
                StreamReader FillingDataFileReader = new StreamReader(Path, Encoding.UTF8);
                String TextLine = FillingDataFileReader.ReadToEnd();
                FillingDataFileReader.Close();
                char[] Delimiter = { '\n' };
                string[] FillingData = TextLine.Split(Delimiter, StringSplitOptions.RemoveEmptyEntries);
                char[] Separator = { ';'};
                for (int i = 0; i < FillingData.Length; i++)
                {
                    string[] TextItems = FillingData[i].Split(Separator, StringSplitOptions.None);
                    FillingNames.Add(TextItems[0]);
                    _FillingSurfaces.Add(Convert.ToDouble(TextItems[1]));
                    _FillingVolumes.Add(Convert.ToDouble(TextItems[2]));
                }
            }
        }
    }
}
