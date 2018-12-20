namespace Absorber
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxInputData = new System.Windows.Forms.GroupBox();
            this.labelSystem = new System.Windows.Forms.Label();
            this.labelFilling = new System.Windows.Forms.Label();
            this.comboBoxSystem = new System.Windows.Forms.ComboBox();
            this.comboBoxFilling = new System.Windows.Forms.ComboBox();
            this.groupBoxAbsorbent = new System.Windows.Forms.GroupBox();
            this.labelTemperatureA = new System.Windows.Forms.Label();
            this.labelMassIntensityA = new System.Windows.Forms.Label();
            this.numericUpDownTemperatureA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMassIntensityA = new System.Windows.Forms.NumericUpDown();
            this.labelTemperatureUnitA = new System.Windows.Forms.Label();
            this.labelMassIntensityUnitA = new System.Windows.Forms.Label();
            this.labelViscosityA = new System.Windows.Forms.Label();
            this.numericUpViscosityA = new System.Windows.Forms.NumericUpDown();
            this.labelViscosityUnitA = new System.Windows.Forms.Label();
            this.labelDensityA = new System.Windows.Forms.Label();
            this.numericUpDownDensityA = new System.Windows.Forms.NumericUpDown();
            this.labelDensityUnitA = new System.Windows.Forms.Label();
            this.groupBoxInert = new System.Windows.Forms.GroupBox();
            this.labelTemperatureB = new System.Windows.Forms.Label();
            this.labelPressureB = new System.Windows.Forms.Label();
            this.labelDenistyB = new System.Windows.Forms.Label();
            this.labelVolumeIntensityB = new System.Windows.Forms.Label();
            this.labelViscosityB = new System.Windows.Forms.Label();
            this.numericUpDownPressureB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTemperatureB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDensityB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownViscosityB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVolumeIntensityB = new System.Windows.Forms.NumericUpDown();
            this.labelDensityUnitDensityB = new System.Windows.Forms.Label();
            this.labelTemperatureUnitB = new System.Windows.Forms.Label();
            this.labelViscosityUnitB = new System.Windows.Forms.Label();
            this.labelPressureUnitB = new System.Windows.Forms.Label();
            this.labelVolumeIntensityUnitB = new System.Windows.Forms.Label();
            this.labelAbsorbateConcentrationA = new System.Windows.Forms.Label();
            this.numericUpDownAbsorbateConcentrationA = new System.Windows.Forms.NumericUpDown();
            this.labelAbsorbateConcentrationUnitA = new System.Windows.Forms.Label();
            this.labelAbsorbateConcentrationUnitB = new System.Windows.Forms.Label();
            this.numericUpDownAbsorbateConcentrationB = new System.Windows.Forms.NumericUpDown();
            this.labelAbsorbateConcentrationB = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBoxInputData.SuspendLayout();
            this.groupBoxAbsorbent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemperatureA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMassIntensityA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpViscosityA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDensityA)).BeginInit();
            this.groupBoxInert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPressureB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemperatureB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDensityB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownViscosityB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolumeIntensityB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAbsorbateConcentrationA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAbsorbateConcentrationB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInputData
            // 
            this.groupBoxInputData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxInputData.AutoSize = true;
            this.groupBoxInputData.Controls.Add(this.groupBoxInert);
            this.groupBoxInputData.Controls.Add(this.groupBoxAbsorbent);
            this.groupBoxInputData.Controls.Add(this.comboBoxFilling);
            this.groupBoxInputData.Controls.Add(this.comboBoxSystem);
            this.groupBoxInputData.Controls.Add(this.labelFilling);
            this.groupBoxInputData.Controls.Add(this.labelSystem);
            this.groupBoxInputData.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxInputData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInputData.Name = "groupBoxInputData";
            this.groupBoxInputData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxInputData.Size = new System.Drawing.Size(630, 407);
            this.groupBoxInputData.TabIndex = 0;
            this.groupBoxInputData.TabStop = false;
            this.groupBoxInputData.Text = "Dane wejściowe";
            // 
            // labelSystem
            // 
            this.labelSystem.AutoSize = true;
            this.labelSystem.Location = new System.Drawing.Point(7, 26);
            this.labelSystem.Name = "labelSystem";
            this.labelSystem.Size = new System.Drawing.Size(47, 16);
            this.labelSystem.TabIndex = 0;
            this.labelSystem.Text = "Układ:";
            this.labelSystem.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelFilling
            // 
            this.labelFilling.AutoSize = true;
            this.labelFilling.Location = new System.Drawing.Point(7, 56);
            this.labelFilling.Name = "labelFilling";
            this.labelFilling.Size = new System.Drawing.Size(89, 16);
            this.labelFilling.TabIndex = 1;
            this.labelFilling.Text = "Wypełnienie:";
            this.labelFilling.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxSystem
            // 
            this.comboBoxSystem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSystem.FormattingEnabled = true;
            this.comboBoxSystem.Location = new System.Drawing.Point(108, 23);
            this.comboBoxSystem.Name = "comboBoxSystem";
            this.comboBoxSystem.Size = new System.Drawing.Size(514, 24);
            this.comboBoxSystem.TabIndex = 2;
            // 
            // comboBoxFilling
            // 
            this.comboBoxFilling.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFilling.FormattingEnabled = true;
            this.comboBoxFilling.Location = new System.Drawing.Point(108, 53);
            this.comboBoxFilling.Name = "comboBoxFilling";
            this.comboBoxFilling.Size = new System.Drawing.Size(514, 24);
            this.comboBoxFilling.TabIndex = 3;
            // 
            // groupBoxAbsorbent
            // 
            this.groupBoxAbsorbent.Controls.Add(this.numericUpDown1);
            this.groupBoxAbsorbent.Controls.Add(this.labelAbsorbateConcentrationUnitA);
            this.groupBoxAbsorbent.Controls.Add(this.numericUpDownAbsorbateConcentrationA);
            this.groupBoxAbsorbent.Controls.Add(this.labelAbsorbateConcentrationA);
            this.groupBoxAbsorbent.Controls.Add(this.labelDensityUnitA);
            this.groupBoxAbsorbent.Controls.Add(this.numericUpDownDensityA);
            this.groupBoxAbsorbent.Controls.Add(this.labelDensityA);
            this.groupBoxAbsorbent.Controls.Add(this.labelViscosityUnitA);
            this.groupBoxAbsorbent.Controls.Add(this.numericUpViscosityA);
            this.groupBoxAbsorbent.Controls.Add(this.labelViscosityA);
            this.groupBoxAbsorbent.Controls.Add(this.labelMassIntensityUnitA);
            this.groupBoxAbsorbent.Controls.Add(this.labelTemperatureUnitA);
            this.groupBoxAbsorbent.Controls.Add(this.numericUpDownMassIntensityA);
            this.groupBoxAbsorbent.Controls.Add(this.numericUpDownTemperatureA);
            this.groupBoxAbsorbent.Controls.Add(this.labelMassIntensityA);
            this.groupBoxAbsorbent.Controls.Add(this.labelTemperatureA);
            this.groupBoxAbsorbent.Location = new System.Drawing.Point(10, 83);
            this.groupBoxAbsorbent.Name = "groupBoxAbsorbent";
            this.groupBoxAbsorbent.Size = new System.Drawing.Size(300, 231);
            this.groupBoxAbsorbent.TabIndex = 4;
            this.groupBoxAbsorbent.TabStop = false;
            this.groupBoxAbsorbent.Text = "Absorbent";
            this.groupBoxAbsorbent.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelTemperatureA
            // 
            this.labelTemperatureA.AutoSize = true;
            this.labelTemperatureA.Location = new System.Drawing.Point(6, 26);
            this.labelTemperatureA.Name = "labelTemperatureA";
            this.labelTemperatureA.Size = new System.Drawing.Size(92, 16);
            this.labelTemperatureA.TabIndex = 0;
            this.labelTemperatureA.Text = "Temperatura ";
            this.labelTemperatureA.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelMassIntensityA
            // 
            this.labelMassIntensityA.AutoSize = true;
            this.labelMassIntensityA.Location = new System.Drawing.Point(5, 145);
            this.labelMassIntensityA.Name = "labelMassIntensityA";
            this.labelMassIntensityA.Size = new System.Drawing.Size(153, 16);
            this.labelMassIntensityA.TabIndex = 1;
            this.labelMassIntensityA.Text = "Masowe nat. przepływu";
            this.labelMassIntensityA.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // numericUpDownTemperatureA
            // 
            this.numericUpDownTemperatureA.Location = new System.Drawing.Point(165, 23);
            this.numericUpDownTemperatureA.Name = "numericUpDownTemperatureA";
            this.numericUpDownTemperatureA.Size = new System.Drawing.Size(76, 24);
            this.numericUpDownTemperatureA.TabIndex = 2;
            // 
            // numericUpDownMassIntensityA
            // 
            this.numericUpDownMassIntensityA.Location = new System.Drawing.Point(164, 143);
            this.numericUpDownMassIntensityA.Name = "numericUpDownMassIntensityA";
            this.numericUpDownMassIntensityA.Size = new System.Drawing.Size(76, 24);
            this.numericUpDownMassIntensityA.TabIndex = 3;
            // 
            // labelTemperatureUnitA
            // 
            this.labelTemperatureUnitA.AutoSize = true;
            this.labelTemperatureUnitA.Location = new System.Drawing.Point(245, 26);
            this.labelTemperatureUnitA.Name = "labelTemperatureUnitA";
            this.labelTemperatureUnitA.Size = new System.Drawing.Size(24, 16);
            this.labelTemperatureUnitA.TabIndex = 4;
            this.labelTemperatureUnitA.Text = "°C";
            this.labelTemperatureUnitA.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // labelMassIntensityUnitA
            // 
            this.labelMassIntensityUnitA.AutoSize = true;
            this.labelMassIntensityUnitA.Location = new System.Drawing.Point(245, 145);
            this.labelMassIntensityUnitA.Name = "labelMassIntensityUnitA";
            this.labelMassIntensityUnitA.Size = new System.Drawing.Size(35, 16);
            this.labelMassIntensityUnitA.TabIndex = 5;
            this.labelMassIntensityUnitA.Text = "kg/h";
            this.labelMassIntensityUnitA.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // labelViscosityA
            // 
            this.labelViscosityA.AutoSize = true;
            this.labelViscosityA.Location = new System.Drawing.Point(5, 117);
            this.labelViscosityA.Name = "labelViscosityA";
            this.labelViscosityA.Size = new System.Drawing.Size(152, 16);
            this.labelViscosityA.TabIndex = 6;
            this.labelViscosityA.Text = "Lepkość w danej temp.";
            // 
            // numericUpViscosityA
            // 
            this.numericUpViscosityA.Location = new System.Drawing.Point(164, 113);
            this.numericUpViscosityA.Name = "numericUpViscosityA";
            this.numericUpViscosityA.Size = new System.Drawing.Size(77, 24);
            this.numericUpViscosityA.TabIndex = 7;
            // 
            // labelViscosityUnitA
            // 
            this.labelViscosityUnitA.AutoSize = true;
            this.labelViscosityUnitA.Location = new System.Drawing.Point(245, 117);
            this.labelViscosityUnitA.Name = "labelViscosityUnitA";
            this.labelViscosityUnitA.Size = new System.Drawing.Size(37, 16);
            this.labelViscosityUnitA.TabIndex = 8;
            this.labelViscosityUnitA.Text = "Pa*s";
            // 
            // labelDensityA
            // 
            this.labelDensityA.AutoSize = true;
            this.labelDensityA.Location = new System.Drawing.Point(5, 87);
            this.labelDensityA.Name = "labelDensityA";
            this.labelDensityA.Size = new System.Drawing.Size(151, 16);
            this.labelDensityA.TabIndex = 9;
            this.labelDensityA.Text = "Gęstość w danej temp.";
            // 
            // numericUpDownDensityA
            // 
            this.numericUpDownDensityA.Location = new System.Drawing.Point(164, 83);
            this.numericUpDownDensityA.Name = "numericUpDownDensityA";
            this.numericUpDownDensityA.Size = new System.Drawing.Size(76, 24);
            this.numericUpDownDensityA.TabIndex = 10;
            // 
            // labelDensityUnitA
            // 
            this.labelDensityUnitA.AutoSize = true;
            this.labelDensityUnitA.Location = new System.Drawing.Point(245, 87);
            this.labelDensityUnitA.Name = "labelDensityUnitA";
            this.labelDensityUnitA.Size = new System.Drawing.Size(43, 16);
            this.labelDensityUnitA.TabIndex = 11;
            this.labelDensityUnitA.Text = "kg/m³";
            this.labelDensityUnitA.Click += new System.EventHandler(this.label1_Click_5);
            // 
            // groupBoxInert
            // 
            this.groupBoxInert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInert.Controls.Add(this.labelAbsorbateConcentrationUnitB);
            this.groupBoxInert.Controls.Add(this.labelVolumeIntensityUnitB);
            this.groupBoxInert.Controls.Add(this.numericUpDownAbsorbateConcentrationB);
            this.groupBoxInert.Controls.Add(this.labelAbsorbateConcentrationB);
            this.groupBoxInert.Controls.Add(this.labelPressureUnitB);
            this.groupBoxInert.Controls.Add(this.labelViscosityUnitB);
            this.groupBoxInert.Controls.Add(this.labelTemperatureUnitB);
            this.groupBoxInert.Controls.Add(this.labelDensityUnitDensityB);
            this.groupBoxInert.Controls.Add(this.numericUpDownVolumeIntensityB);
            this.groupBoxInert.Controls.Add(this.numericUpDownViscosityB);
            this.groupBoxInert.Controls.Add(this.numericUpDownDensityB);
            this.groupBoxInert.Controls.Add(this.numericUpDownTemperatureB);
            this.groupBoxInert.Controls.Add(this.numericUpDownPressureB);
            this.groupBoxInert.Controls.Add(this.labelViscosityB);
            this.groupBoxInert.Controls.Add(this.labelVolumeIntensityB);
            this.groupBoxInert.Controls.Add(this.labelDenistyB);
            this.groupBoxInert.Controls.Add(this.labelPressureB);
            this.groupBoxInert.Controls.Add(this.labelTemperatureB);
            this.groupBoxInert.Location = new System.Drawing.Point(316, 84);
            this.groupBoxInert.Name = "groupBoxInert";
            this.groupBoxInert.Size = new System.Drawing.Size(306, 230);
            this.groupBoxInert.TabIndex = 5;
            this.groupBoxInert.TabStop = false;
            this.groupBoxInert.Text = "Gaz obojętny";
            this.groupBoxInert.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // labelTemperatureB
            // 
            this.labelTemperatureB.AutoSize = true;
            this.labelTemperatureB.Location = new System.Drawing.Point(7, 25);
            this.labelTemperatureB.Name = "labelTemperatureB";
            this.labelTemperatureB.Size = new System.Drawing.Size(88, 16);
            this.labelTemperatureB.TabIndex = 0;
            this.labelTemperatureB.Text = "Temperatura";
            // 
            // labelPressureB
            // 
            this.labelPressureB.AutoSize = true;
            this.labelPressureB.Location = new System.Drawing.Point(7, 54);
            this.labelPressureB.Name = "labelPressureB";
            this.labelPressureB.Size = new System.Drawing.Size(66, 16);
            this.labelPressureB.TabIndex = 1;
            this.labelPressureB.Text = "Ciśnienie";
            // 
            // labelDenistyB
            // 
            this.labelDenistyB.AutoSize = true;
            this.labelDenistyB.Location = new System.Drawing.Point(6, 84);
            this.labelDenistyB.Name = "labelDenistyB";
            this.labelDenistyB.Size = new System.Drawing.Size(151, 16);
            this.labelDenistyB.TabIndex = 2;
            this.labelDenistyB.Text = "Gęstość w danej temp.";
            // 
            // labelVolumeIntensityB
            // 
            this.labelVolumeIntensityB.AutoSize = true;
            this.labelVolumeIntensityB.Location = new System.Drawing.Point(7, 144);
            this.labelVolumeIntensityB.Name = "labelVolumeIntensityB";
            this.labelVolumeIntensityB.Size = new System.Drawing.Size(128, 16);
            this.labelVolumeIntensityB.TabIndex = 3;
            this.labelVolumeIntensityB.Text = "Obj. nat. przepływu";
            // 
            // labelViscosityB
            // 
            this.labelViscosityB.AutoSize = true;
            this.labelViscosityB.Location = new System.Drawing.Point(7, 114);
            this.labelViscosityB.Name = "labelViscosityB";
            this.labelViscosityB.Size = new System.Drawing.Size(152, 16);
            this.labelViscosityB.TabIndex = 4;
            this.labelViscosityB.Text = "Lepkość w danej temp.";
            this.labelViscosityB.Click += new System.EventHandler(this.label1_Click_6);
            // 
            // numericUpDownPressureB
            // 
            this.numericUpDownPressureB.Location = new System.Drawing.Point(165, 52);
            this.numericUpDownPressureB.Name = "numericUpDownPressureB";
            this.numericUpDownPressureB.Size = new System.Drawing.Size(75, 24);
            this.numericUpDownPressureB.TabIndex = 5;
            // 
            // numericUpDownTemperatureB
            // 
            this.numericUpDownTemperatureB.Location = new System.Drawing.Point(165, 22);
            this.numericUpDownTemperatureB.Name = "numericUpDownTemperatureB";
            this.numericUpDownTemperatureB.Size = new System.Drawing.Size(75, 24);
            this.numericUpDownTemperatureB.TabIndex = 5;
            // 
            // numericUpDownDensityB
            // 
            this.numericUpDownDensityB.Location = new System.Drawing.Point(165, 82);
            this.numericUpDownDensityB.Name = "numericUpDownDensityB";
            this.numericUpDownDensityB.Size = new System.Drawing.Size(75, 24);
            this.numericUpDownDensityB.TabIndex = 6;
            // 
            // numericUpDownViscosityB
            // 
            this.numericUpDownViscosityB.Location = new System.Drawing.Point(165, 112);
            this.numericUpDownViscosityB.Name = "numericUpDownViscosityB";
            this.numericUpDownViscosityB.Size = new System.Drawing.Size(75, 24);
            this.numericUpDownViscosityB.TabIndex = 7;
            // 
            // numericUpDownVolumeIntensityB
            // 
            this.numericUpDownVolumeIntensityB.Location = new System.Drawing.Point(165, 142);
            this.numericUpDownVolumeIntensityB.Name = "numericUpDownVolumeIntensityB";
            this.numericUpDownVolumeIntensityB.Size = new System.Drawing.Size(75, 24);
            this.numericUpDownVolumeIntensityB.TabIndex = 8;
            // 
            // labelDensityUnitDensityB
            // 
            this.labelDensityUnitDensityB.AutoSize = true;
            this.labelDensityUnitDensityB.Location = new System.Drawing.Point(245, 86);
            this.labelDensityUnitDensityB.Name = "labelDensityUnitDensityB";
            this.labelDensityUnitDensityB.Size = new System.Drawing.Size(43, 16);
            this.labelDensityUnitDensityB.TabIndex = 12;
            this.labelDensityUnitDensityB.Text = "kg/m³";
            // 
            // labelTemperatureUnitB
            // 
            this.labelTemperatureUnitB.AutoSize = true;
            this.labelTemperatureUnitB.Location = new System.Drawing.Point(245, 25);
            this.labelTemperatureUnitB.Name = "labelTemperatureUnitB";
            this.labelTemperatureUnitB.Size = new System.Drawing.Size(24, 16);
            this.labelTemperatureUnitB.TabIndex = 12;
            this.labelTemperatureUnitB.Text = "°C";
            // 
            // labelViscosityUnitB
            // 
            this.labelViscosityUnitB.AutoSize = true;
            this.labelViscosityUnitB.Location = new System.Drawing.Point(245, 114);
            this.labelViscosityUnitB.Name = "labelViscosityUnitB";
            this.labelViscosityUnitB.Size = new System.Drawing.Size(37, 16);
            this.labelViscosityUnitB.TabIndex = 12;
            this.labelViscosityUnitB.Text = "Pa*s";
            // 
            // labelPressureUnitB
            // 
            this.labelPressureUnitB.AutoSize = true;
            this.labelPressureUnitB.Location = new System.Drawing.Point(245, 54);
            this.labelPressureUnitB.Name = "labelPressureUnitB";
            this.labelPressureUnitB.Size = new System.Drawing.Size(25, 16);
            this.labelPressureUnitB.TabIndex = 13;
            this.labelPressureUnitB.Text = "Pa";
            this.labelPressureUnitB.Click += new System.EventHandler(this.label1_Click_7);
            // 
            // labelVolumeIntensityUnitB
            // 
            this.labelVolumeIntensityUnitB.AutoSize = true;
            this.labelVolumeIntensityUnitB.Location = new System.Drawing.Point(246, 144);
            this.labelVolumeIntensityUnitB.Name = "labelVolumeIntensityUnitB";
            this.labelVolumeIntensityUnitB.Size = new System.Drawing.Size(36, 16);
            this.labelVolumeIntensityUnitB.TabIndex = 14;
            this.labelVolumeIntensityUnitB.Text = "m³/h";
            // 
            // labelAbsorbateConcentrationA
            // 
            this.labelAbsorbateConcentrationA.AutoSize = true;
            this.labelAbsorbateConcentrationA.Location = new System.Drawing.Point(6, 175);
            this.labelAbsorbateConcentrationA.Name = "labelAbsorbateConcentrationA";
            this.labelAbsorbateConcentrationA.Size = new System.Drawing.Size(130, 16);
            this.labelAbsorbateConcentrationA.TabIndex = 12;
            this.labelAbsorbateConcentrationA.Text = "Stężenie absorbatu";
            // 
            // numericUpDownAbsorbateConcentrationA
            // 
            this.numericUpDownAbsorbateConcentrationA.Location = new System.Drawing.Point(164, 173);
            this.numericUpDownAbsorbateConcentrationA.Name = "numericUpDownAbsorbateConcentrationA";
            this.numericUpDownAbsorbateConcentrationA.Size = new System.Drawing.Size(76, 24);
            this.numericUpDownAbsorbateConcentrationA.TabIndex = 13;
            // 
            // labelAbsorbateConcentrationUnitA
            // 
            this.labelAbsorbateConcentrationUnitA.AutoSize = true;
            this.labelAbsorbateConcentrationUnitA.Location = new System.Drawing.Point(245, 175);
            this.labelAbsorbateConcentrationUnitA.Name = "labelAbsorbateConcentrationUnitA";
            this.labelAbsorbateConcentrationUnitA.Size = new System.Drawing.Size(20, 16);
            this.labelAbsorbateConcentrationUnitA.TabIndex = 14;
            this.labelAbsorbateConcentrationUnitA.Text = "%";
            // 
            // labelAbsorbateConcentrationUnitB
            // 
            this.labelAbsorbateConcentrationUnitB.AutoSize = true;
            this.labelAbsorbateConcentrationUnitB.Location = new System.Drawing.Point(246, 174);
            this.labelAbsorbateConcentrationUnitB.Name = "labelAbsorbateConcentrationUnitB";
            this.labelAbsorbateConcentrationUnitB.Size = new System.Drawing.Size(20, 16);
            this.labelAbsorbateConcentrationUnitB.TabIndex = 17;
            this.labelAbsorbateConcentrationUnitB.Text = "%";
            // 
            // numericUpDownAbsorbateConcentrationB
            // 
            this.numericUpDownAbsorbateConcentrationB.Location = new System.Drawing.Point(165, 172);
            this.numericUpDownAbsorbateConcentrationB.Name = "numericUpDownAbsorbateConcentrationB";
            this.numericUpDownAbsorbateConcentrationB.Size = new System.Drawing.Size(76, 24);
            this.numericUpDownAbsorbateConcentrationB.TabIndex = 16;
            // 
            // labelAbsorbateConcentrationB
            // 
            this.labelAbsorbateConcentrationB.AutoSize = true;
            this.labelAbsorbateConcentrationB.Location = new System.Drawing.Point(6, 174);
            this.labelAbsorbateConcentrationB.Name = "labelAbsorbateConcentrationB";
            this.labelAbsorbateConcentrationB.Size = new System.Drawing.Size(130, 16);
            this.labelAbsorbateConcentrationB.TabIndex = 15;
            this.labelAbsorbateConcentrationB.Text = "Stężenie absorbatu";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(164, 53);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(76, 24);
            this.numericUpDown1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 469);
            this.Controls.Add(this.groupBoxInputData);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.groupBoxInputData.ResumeLayout(false);
            this.groupBoxInputData.PerformLayout();
            this.groupBoxAbsorbent.ResumeLayout(false);
            this.groupBoxAbsorbent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemperatureA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMassIntensityA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpViscosityA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDensityA)).EndInit();
            this.groupBoxInert.ResumeLayout(false);
            this.groupBoxInert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPressureB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemperatureB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDensityB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownViscosityB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolumeIntensityB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAbsorbateConcentrationA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAbsorbateConcentrationB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInputData;
        private System.Windows.Forms.Label labelFilling;
        private System.Windows.Forms.Label labelSystem;
        private System.Windows.Forms.GroupBox groupBoxAbsorbent;
        private System.Windows.Forms.ComboBox comboBoxFilling;
        private System.Windows.Forms.ComboBox comboBoxSystem;
        private System.Windows.Forms.Label labelTemperatureA;
        private System.Windows.Forms.Label labelMassIntensityA;
        private System.Windows.Forms.NumericUpDown numericUpDownMassIntensityA;
        private System.Windows.Forms.NumericUpDown numericUpDownTemperatureA;
        private System.Windows.Forms.Label labelTemperatureUnitA;
        private System.Windows.Forms.Label labelMassIntensityUnitA;
        private System.Windows.Forms.NumericUpDown numericUpViscosityA;
        private System.Windows.Forms.Label labelViscosityA;
        private System.Windows.Forms.Label labelDensityUnitA;
        private System.Windows.Forms.NumericUpDown numericUpDownDensityA;
        private System.Windows.Forms.Label labelDensityA;
        private System.Windows.Forms.Label labelViscosityUnitA;
        private System.Windows.Forms.GroupBox groupBoxInert;
        private System.Windows.Forms.Label labelVolumeIntensityB;
        private System.Windows.Forms.Label labelDenistyB;
        private System.Windows.Forms.Label labelPressureB;
        private System.Windows.Forms.Label labelTemperatureB;
        private System.Windows.Forms.Label labelViscosityB;
        private System.Windows.Forms.NumericUpDown numericUpDownViscosityB;
        private System.Windows.Forms.NumericUpDown numericUpDownDensityB;
        private System.Windows.Forms.NumericUpDown numericUpDownTemperatureB;
        private System.Windows.Forms.NumericUpDown numericUpDownPressureB;
        private System.Windows.Forms.Label labelPressureUnitB;
        private System.Windows.Forms.Label labelViscosityUnitB;
        private System.Windows.Forms.Label labelTemperatureUnitB;
        private System.Windows.Forms.Label labelDensityUnitDensityB;
        private System.Windows.Forms.NumericUpDown numericUpDownVolumeIntensityB;
        private System.Windows.Forms.Label labelVolumeIntensityUnitB;
        private System.Windows.Forms.Label labelAbsorbateConcentrationUnitB;
        private System.Windows.Forms.NumericUpDown numericUpDownAbsorbateConcentrationB;
        private System.Windows.Forms.Label labelAbsorbateConcentrationB;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelAbsorbateConcentrationUnitA;
        private System.Windows.Forms.NumericUpDown numericUpDownAbsorbateConcentrationA;
        private System.Windows.Forms.Label labelAbsorbateConcentrationA;
    }
}

