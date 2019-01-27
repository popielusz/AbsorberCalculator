using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;

// Właściwości: MassIntensityA; Efficiency, EmulgationPercentage są przyjmowane i zwracane w procentach 

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
        private double _DensityA;
        private double _DensityB;
        private double _DensityNormalB;
        private double _ViscosityA;
        private double _MassIntensityA;
        private double _VolumeIntensityB;
        private double _AbsorbateConcentrationB;
        private double _Efficiency;
        private double _EmulgationPercentage;
        private double _AbsorbentMolarMass;

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

        public double DensityNormalB
        {
            get { return _DensityNormalB; }
            set { _DensityNormalB = value; }
        }

        public double ViscosityA
        {
            get { return _ViscosityA; }
            set { _ViscosityA = value; }
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

        public double AbsorbateConcentrationB
        {
            get { return _AbsorbateConcentrationB * 100; }
            set { _AbsorbateConcentrationB = value / 100; }
        }

        public double Efficiency
        {
            get { return _Efficiency * 100; }
            set { _Efficiency = value / 100; }
        }

        public double EmulgationPercentage
        {
            get { return _EmulgationPercentage * 100; }
            set { _EmulgationPercentage = value / 100; }
        }

        public double AbsorbentMolarMass
        {
            get { return _AbsorbentMolarMass; }
            set { _AbsorbentMolarMass = value; }
        }

        public Calculator()
        {
            /* Konstruktor klasy, która dokonuje obliczeń parametrów absorbera,
               tu jest przydzielana pamięć na obiekty wewnętrzne kalkulatora */
            _FillingSurfaces = new List<double>();
            _FillingVolumes = new List<double>();
            Clear();
        }

        public void Clear()
        {
            /* Czyści te wewnętrzne pola klasy koalkulatora, które służą do przekazywania 
               danych wejściowych do obliczeń, lista wypełnień absorbera nie jest czyszczona */
            _FillingIndex = -1;
            _MassTransferCoefficient = 0;
            _AbsorbateMolarMass = 0;
            _AbsorbentMolarMass = 0;
            _EquationA = 1;
            _DensityA = 1;
            _DensityB = 1;
            _DensityNormalB = 1;
            _ViscosityA = 0;
            _MassIntensityA = 0;
            _VolumeIntensityB = 0;
            _AbsorbateConcentrationB = 0;
            _Efficiency = 0;
            _EmulgationPercentage = 0;
        }

        public bool InvalidValuesCheck(double EquationA, double MassTransferCoefficient, double AbsorbateMolarMass, double AbsorbentMolarMass, double ViscosityA, double MassIntensityA, double VolumeIntensityB, double AbsorbateConcentrationB, double Efficiency, double EmulgationPercentage)
        {
            bool Result = (EquationA == 0)
                            || (MassTransferCoefficient == 0)
                            || (AbsorbateMolarMass == 0)
                            || (AbsorbentMolarMass == 0)
                            || (ViscosityA == 0)
                            || (MassIntensityA == 0)
                            || (VolumeIntensityB == 0)
                            || (AbsorbateConcentrationB == 0)
                            || (Efficiency == 0)
                            || (Efficiency == 100)
                            || (EmulgationPercentage == 0);
            return Result;
        }

        public int WarningCheck()
        {
            int WarningCode = 0;
            // Sprawdzenie czy nie zostały wprowadzone nieprawidłowe dane
            if (InvalidValuesCheck(_EquationA, _MassTransferCoefficient, _AbsorbateMolarMass, _AbsorbentMolarMass, _ViscosityA, _MassIntensityA, _VolumeIntensityB, _AbsorbateConcentrationB, _Efficiency, _EmulgationPercentage))
            {
                // Błąd: wpisane dane są nieprawidłowe (np. wsp. A = 0)
                WarningCode = 2;
                return WarningCode;
            }
            else
            {
                // Sprawdzenie czy zostało wybrane wypełnienie z listy rozwijanej
                if (_FillingIndex > -1)
                {
                        // !!! Czy można to zrobić w bardziej elegancki sposób? (podawanie zwenętrznej zmiennej Profile do funckji WettabilityCheck) i podobnie wyżej
                        double Height = 0;
                        double Profile = 0;
                        Calculate(out Height, out Profile);
                        if (WettabilityCheck(_MassIntensityA, _DensityA, Profile))
                        {
                            // Obliczenia przebiegły pomyślnie
                            WarningCode = 0;
                            return WarningCode;
                        }
                        else
                        {
                            // Błąd: Niepoprawnie dobrany wsp. zwilżalności (Taki, że gęstość zraszania jest =< 5)
                            WarningCode = 3;
                            return WarningCode;
                        }
                }
                else
                {
                    // Błąd: nieprawidłowo wybrany FillingIndex (pusty)
                    WarningCode = 1;
                    return WarningCode;
                }
            }
        }

        public bool Calculate(out double AbsorberHeight, out double AbsorberProfile)
        {
            /* Właściwe obliczenia parametrów absorbera */
            bool Result = false;
            // Zerowanie argumentów przekazanych do funkcji
            AbsorberHeight = 0;
            AbsorberProfile = 0;
            double FillingSurface = _FillingSurfaces[_FillingIndex];
            double FillingVolume = _FillingVolumes[_FillingIndex];
            double AbsorbateMolarIntensity = CalculateAbsorbateMolarIntensity(_VolumeIntensityB, _AbsorbateConcentrationB, _Efficiency);
            double MassTransferSurface = CalculateMassTransferSurface(AbsorbateMolarIntensity, _AbsorbentMolarMass, _VolumeIntensityB, _AbsorbateConcentrationB, _Efficiency, _MassIntensityA, _MassTransferCoefficient);
            double RequiredFillingSurface = CalculateRequiredFillingSurface(MassTransferSurface, FillingSurface);
            double MassIntensityB = ConvertIntensityVolumeToMass(_VolumeIntensityB, _DensityNormalB, _AbsorbateMolarMass, AbsorbateMolarIntensity);
            double Velocity = CalculateVelocity(FillingSurface,_DensityB,_DensityA,_ViscosityA,GravitationalAcceleration,FillingVolume,AbsorptionCoefficient,_MassIntensityA,MassIntensityB,_EmulgationPercentage);
            AbsorberProfile = CalculateAbsorberProfile(MassIntensityB, _DensityB, Velocity);
            AbsorberHeight = CalculateFillingHeight(RequiredFillingSurface, AbsorberProfile);
            return Result;
        }
        private double CalculateAbsorbateMolarIntensity(double VolumeIntensityB, double ConcentrationB, double Efficiency)
        {
            // M
            double AbsorbateMolarIntensity = (VolumeIntensityB * ConcentrationB * Efficiency) / ((1 - ConcentrationB) * 22.4);
            return AbsorbateMolarIntensity;
        }

        private double CalculateMassTransferSurface(double AbsorbateMolarIntensity, double AbsorbentMolarMass, double VolumeIntensityB, double ConcentrationB, double Efficiency, double MassIntensityA, double MassTransferCoefficient)
        {
            // X_d
            double AbsorbateFinalMolarConcentrationA = AbsorbateMolarIntensity / (MassIntensityA / AbsorbentMolarMass);
            // Y_d
            double AbsorbateInitialMolarConcentrationB = ConcentrationB / (1 - ConcentrationB);
            // Y_g
            double AbsorbateFinalMolarConcentrationB = (ConcentrationB * (1 - Efficiency)) / (1 - ConcentrationB);
            // Y_d*
            double AbsorbateEquilibrumConcentrationB = EquationA * AbsorbateFinalMolarConcentrationA;
            // Delta Y_d
            double BottomDrivingForce = AbsorbateInitialMolarConcentrationB - AbsorbateEquilibrumConcentrationB;
            // Delta Y_g ( Xw = 0 => woda zraszająca skruber jest na wlocie czysta)
            double UpperDrivingForce = AbsorbateFinalMolarConcentrationB;
            // Delta Y_śr
            double AverageDrivingForce = (BottomDrivingForce - UpperDrivingForce) / (2.3 * Math.Log10(BottomDrivingForce / UpperDrivingForce));
            // F
            double MassTransferSurface = AbsorbateMolarIntensity / (MassTransferCoefficient * AverageDrivingForce);
            return MassTransferSurface;
        }

        private double CalculateRequiredFillingSurface(double MassTransferSurface, double FillingValue)
        {
            // Dla współczynnika zwilżalności = 1
            double RequiredFillingSurface = MassTransferSurface / FillingValue;
            return RequiredFillingSurface;
        }

        private double ConvertIntensityVolumeToMass(double VolumeIntensity, double DensityNormal, double MolarMass, double MolarIntensity)
        {
            // Konwersja strumienia objętościowego na masowy - wzór empiryczny
            double MassIntensity = VolumeIntensity * DensityNormal + (MolarIntensity * MolarMass) / 2;
            return MassIntensity;
        }

        private double CalculateVelocity(double FillingValue, double DensityB, double DensityA, double ViscosityA, double GravitationalAcceleration, double FillingVolume, double AbsorptionCoefficient, double MassIntensityA, double MassIntensityB, double EmulgationPercentage)
        {
            // d oraz f - współczynniki pomocnicze przy obliczaniu prędkości przepływu gazu, wprowadzone w celu polepszenia czytelności kodu i ułatwienia debuggowania
            double d = (FillingValue*DensityB*Math.Pow((ViscosityA),0.16))/(GravitationalAcceleration*Math.Pow(FillingVolume,3)*(DensityA-DensityB));
            double f = (AbsorptionCoefficient - 1.75 * Math.Pow((MassIntensityA/MassIntensityB),0.25)*Math.Pow((DensityB/(DensityA-DensityB)),0.125));
            double EmulgationVelocity = Math.Sqrt(Math.Pow(10,(f-Math.Log10(d))));
            double Velocity = EmulgationVelocity * EmulgationPercentage; 
            return Velocity;
        }

        private double CalculateAbsorberProfile(double MassIntensityB, double DensityB, double Velocity)
        {
            double AbsorberProfile = MassIntensityB / (3600 * Velocity * DensityB);
            return AbsorberProfile;
        }

        private double CalculateFillingHeight(double RequiredFillingSurface, double FillingProfile)
        {
            double FillingHeight = RequiredFillingSurface / FillingProfile;
            return FillingHeight;
        }

        private bool WettabilityCheck(double VolumeIntensity, double DensityA, double AbsorberProfile)
        {
            bool ValidSprayDensity = false;
            double SprayDensity = VolumeIntensity / (DensityA * AbsorberProfile);
            if (SprayDensity > 5)
            {
                ValidSprayDensity = true;
            }
            return ValidSprayDensity;
        }

        public void LoadFillingFromFile(String Path, IList FillingNames)
        {
            /* Wczytanie z pliku tekstowego opisów i wartości liczbowych różnego
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
