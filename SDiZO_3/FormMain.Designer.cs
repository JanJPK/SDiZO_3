namespace SDiZO_3
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxLoadData = new System.Windows.Forms.GroupBox();
            this.radioButtonLoadDataSalesman = new System.Windows.Forms.RadioButton();
            this.labelMatrix = new System.Windows.Forms.Label();
            this.radioButtonLoadDataKnapsack = new System.Windows.Forms.RadioButton();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.buttonDisplayData = new System.Windows.Forms.Button();
            this.textBoxLoadDataFilename = new System.Windows.Forms.TextBox();
            this.groupBoxKnapsack = new System.Windows.Forms.GroupBox();
            this.buttonKnapsackGreedyR = new System.Windows.Forms.Button();
            this.textBoxKnapsackGreedyR = new System.Windows.Forms.TextBox();
            this.checkBoxKnapsackGreedyR = new System.Windows.Forms.CheckBox();
            this.buttonKnapsackAll = new System.Windows.Forms.Button();
            this.textBoxKnapsackBruteforce = new System.Windows.Forms.TextBox();
            this.checkBoxKnapsackBruteforce = new System.Windows.Forms.CheckBox();
            this.buttonKnapsackBruteforce = new System.Windows.Forms.Button();
            this.textBoxKnapsackGreedyW = new System.Windows.Forms.TextBox();
            this.checkBoxKnapsackGreedyW = new System.Windows.Forms.CheckBox();
            this.checkBoxKnapsackDynamic = new System.Windows.Forms.CheckBox();
            this.buttonKnapsackGreedyW = new System.Windows.Forms.Button();
            this.textBoxKnapsackDynamic = new System.Windows.Forms.TextBox();
            this.buttonKnapsackDynamic = new System.Windows.Forms.Button();
            this.buttonKnapsackStart = new System.Windows.Forms.Button();
            this.groupBoxSalesman = new System.Windows.Forms.GroupBox();
            this.buttonSalesmanAll = new System.Windows.Forms.Button();
            this.textBoxSalesmanAnnealing = new System.Windows.Forms.TextBox();
            this.checkBoxSalesmanAnnealing = new System.Windows.Forms.CheckBox();
            this.checkBoxSalesmanBruteforce = new System.Windows.Forms.CheckBox();
            this.buttonSalesmanAnnealing = new System.Windows.Forms.Button();
            this.textBoxSalesmanBruteforce = new System.Windows.Forms.TextBox();
            this.buttonSalesmanBruteforce = new System.Windows.Forms.Button();
            this.textBoxSalesmanGreedy = new System.Windows.Forms.TextBox();
            this.checkBoxSalesmanGreedy = new System.Windows.Forms.CheckBox();
            this.checkBoxSalesmanTwoOpt = new System.Windows.Forms.CheckBox();
            this.buttonSalesmanGreedy = new System.Windows.Forms.Button();
            this.textBoxSalesmanTwoOpt = new System.Windows.Forms.TextBox();
            this.buttonSalesmanTwoOpt = new System.Windows.Forms.Button();
            this.buttonSalesman = new System.Windows.Forms.Button();
            this.groupBoxCreate = new System.Windows.Forms.GroupBox();
            this.textBoxDataGeneratorSizeKnapsack = new System.Windows.Forms.TextBox();
            this.radioButtonDataGeneratorSalesman = new System.Windows.Forms.RadioButton();
            this.radioButtonDataGeneratorKnapsack = new System.Windows.Forms.RadioButton();
            this.textBoxDataGeneratorSize = new System.Windows.Forms.TextBox();
            this.buttonDataGenerator = new System.Windows.Forms.Button();
            this.groupBoxRepeat = new System.Windows.Forms.GroupBox();
            this.textBoxRepeatNew = new System.Windows.Forms.TextBox();
            this.textBoxRepeatCurrent = new System.Windows.Forms.TextBox();
            this.buttonRepeatChange = new System.Windows.Forms.Button();
            this.textBoxSalesmanAnnealingIterations = new System.Windows.Forms.TextBox();
            this.textBoxSalesmanAnnealingTemperature = new System.Windows.Forms.TextBox();
            this.textBoxSalesmanAnnealingCooling = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSalesmanAnnealingSave = new System.Windows.Forms.Button();
            this.groupBoxLoadData.SuspendLayout();
            this.groupBoxKnapsack.SuspendLayout();
            this.groupBoxSalesman.SuspendLayout();
            this.groupBoxCreate.SuspendLayout();
            this.groupBoxRepeat.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLoadData
            // 
            this.groupBoxLoadData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxLoadData.Controls.Add(this.radioButtonLoadDataSalesman);
            this.groupBoxLoadData.Controls.Add(this.labelMatrix);
            this.groupBoxLoadData.Controls.Add(this.radioButtonLoadDataKnapsack);
            this.groupBoxLoadData.Controls.Add(this.buttonLoadData);
            this.groupBoxLoadData.Controls.Add(this.buttonDisplayData);
            this.groupBoxLoadData.Controls.Add(this.textBoxLoadDataFilename);
            this.groupBoxLoadData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLoadData.Name = "groupBoxLoadData";
            this.groupBoxLoadData.Size = new System.Drawing.Size(304, 82);
            this.groupBoxLoadData.TabIndex = 5;
            this.groupBoxLoadData.TabStop = false;
            this.groupBoxLoadData.Text = "Wczytywanie danych";
            // 
            // radioButtonLoadDataSalesman
            // 
            this.radioButtonLoadDataSalesman.AutoSize = true;
            this.radioButtonLoadDataSalesman.Location = new System.Drawing.Point(85, 44);
            this.radioButtonLoadDataSalesman.Name = "radioButtonLoadDataSalesman";
            this.radioButtonLoadDataSalesman.Size = new System.Drawing.Size(84, 17);
            this.radioButtonLoadDataSalesman.TabIndex = 6;
            this.radioButtonLoadDataSalesman.TabStop = true;
            this.radioButtonLoadDataSalesman.Text = "Komiwojażer";
            this.radioButtonLoadDataSalesman.UseVisualStyleBackColor = true;
            // 
            // labelMatrix
            // 
            this.labelMatrix.AutoSize = true;
            this.labelMatrix.Location = new System.Drawing.Point(220, 31);
            this.labelMatrix.Name = "labelMatrix";
            this.labelMatrix.Size = new System.Drawing.Size(84, 13);
            this.labelMatrix.TabIndex = 2;
            this.labelMatrix.Text = "Podgląd danych";
            // 
            // radioButtonLoadDataKnapsack
            // 
            this.radioButtonLoadDataKnapsack.AutoSize = true;
            this.radioButtonLoadDataKnapsack.Location = new System.Drawing.Point(85, 21);
            this.radioButtonLoadDataKnapsack.Name = "radioButtonLoadDataKnapsack";
            this.radioButtonLoadDataKnapsack.Size = new System.Drawing.Size(58, 17);
            this.radioButtonLoadDataKnapsack.TabIndex = 5;
            this.radioButtonLoadDataKnapsack.TabStop = true;
            this.radioButtonLoadDataKnapsack.Text = "Plecak";
            this.radioButtonLoadDataKnapsack.UseVisualStyleBackColor = true;
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(6, 47);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(70, 23);
            this.buttonLoadData.TabIndex = 4;
            this.buttonLoadData.Text = "Wczytaj";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // buttonDisplayData
            // 
            this.buttonDisplayData.Location = new System.Drawing.Point(225, 47);
            this.buttonDisplayData.Name = "buttonDisplayData";
            this.buttonDisplayData.Size = new System.Drawing.Size(70, 23);
            this.buttonDisplayData.TabIndex = 0;
            this.buttonDisplayData.Text = "Wypisz";
            this.buttonDisplayData.UseVisualStyleBackColor = true;
            this.buttonDisplayData.Click += new System.EventHandler(this.buttonDisplayData_Click);
            // 
            // textBoxLoadDataFilename
            // 
            this.textBoxLoadDataFilename.Location = new System.Drawing.Point(6, 21);
            this.textBoxLoadDataFilename.Name = "textBoxLoadDataFilename";
            this.textBoxLoadDataFilename.Size = new System.Drawing.Size(70, 20);
            this.textBoxLoadDataFilename.TabIndex = 0;
            this.textBoxLoadDataFilename.TextChanged += new System.EventHandler(this.textBoxLoadDataFilename_TextChanged);
            // 
            // groupBoxKnapsack
            // 
            this.groupBoxKnapsack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxKnapsack.Controls.Add(this.buttonKnapsackGreedyR);
            this.groupBoxKnapsack.Controls.Add(this.textBoxKnapsackGreedyR);
            this.groupBoxKnapsack.Controls.Add(this.checkBoxKnapsackGreedyR);
            this.groupBoxKnapsack.Controls.Add(this.buttonKnapsackAll);
            this.groupBoxKnapsack.Controls.Add(this.textBoxKnapsackBruteforce);
            this.groupBoxKnapsack.Controls.Add(this.checkBoxKnapsackBruteforce);
            this.groupBoxKnapsack.Controls.Add(this.buttonKnapsackBruteforce);
            this.groupBoxKnapsack.Controls.Add(this.textBoxKnapsackGreedyW);
            this.groupBoxKnapsack.Controls.Add(this.checkBoxKnapsackGreedyW);
            this.groupBoxKnapsack.Controls.Add(this.checkBoxKnapsackDynamic);
            this.groupBoxKnapsack.Controls.Add(this.buttonKnapsackGreedyW);
            this.groupBoxKnapsack.Controls.Add(this.textBoxKnapsackDynamic);
            this.groupBoxKnapsack.Controls.Add(this.buttonKnapsackDynamic);
            this.groupBoxKnapsack.Controls.Add(this.buttonKnapsackStart);
            this.groupBoxKnapsack.Location = new System.Drawing.Point(12, 100);
            this.groupBoxKnapsack.Name = "groupBoxKnapsack";
            this.groupBoxKnapsack.Size = new System.Drawing.Size(304, 148);
            this.groupBoxKnapsack.TabIndex = 7;
            this.groupBoxKnapsack.TabStop = false;
            this.groupBoxKnapsack.Text = "Plecak";
            // 
            // buttonKnapsackGreedyR
            // 
            this.buttonKnapsackGreedyR.Location = new System.Drawing.Point(225, 64);
            this.buttonKnapsackGreedyR.Name = "buttonKnapsackGreedyR";
            this.buttonKnapsackGreedyR.Size = new System.Drawing.Size(70, 23);
            this.buttonKnapsackGreedyR.TabIndex = 23;
            this.buttonKnapsackGreedyR.Text = "Wypisz";
            this.buttonKnapsackGreedyR.UseVisualStyleBackColor = true;
            this.buttonKnapsackGreedyR.Click += new System.EventHandler(this.buttonKnapsackGreedyR_Click);
            // 
            // textBoxKnapsackGreedyR
            // 
            this.textBoxKnapsackGreedyR.Location = new System.Drawing.Point(132, 66);
            this.textBoxKnapsackGreedyR.Name = "textBoxKnapsackGreedyR";
            this.textBoxKnapsackGreedyR.Size = new System.Drawing.Size(90, 20);
            this.textBoxKnapsackGreedyR.TabIndex = 22;
            // 
            // checkBoxKnapsackGreedyR
            // 
            this.checkBoxKnapsackGreedyR.AutoSize = true;
            this.checkBoxKnapsackGreedyR.Location = new System.Drawing.Point(12, 70);
            this.checkBoxKnapsackGreedyR.Name = "checkBoxKnapsackGreedyR";
            this.checkBoxKnapsackGreedyR.Size = new System.Drawing.Size(105, 17);
            this.checkBoxKnapsackGreedyR.TabIndex = 21;
            this.checkBoxKnapsackGreedyR.Text = "Zachłanny W/R";
            this.checkBoxKnapsackGreedyR.UseVisualStyleBackColor = true;
            // 
            // buttonKnapsackAll
            // 
            this.buttonKnapsackAll.Location = new System.Drawing.Point(225, 115);
            this.buttonKnapsackAll.Name = "buttonKnapsackAll";
            this.buttonKnapsackAll.Size = new System.Drawing.Size(70, 23);
            this.buttonKnapsackAll.TabIndex = 20;
            this.buttonKnapsackAll.Text = "Wszystkie";
            this.buttonKnapsackAll.UseVisualStyleBackColor = true;
            this.buttonKnapsackAll.Click += new System.EventHandler(this.buttonKnapsackAll_Click);
            // 
            // textBoxKnapsackBruteforce
            // 
            this.textBoxKnapsackBruteforce.Location = new System.Drawing.Point(132, 92);
            this.textBoxKnapsackBruteforce.Name = "textBoxKnapsackBruteforce";
            this.textBoxKnapsackBruteforce.Size = new System.Drawing.Size(90, 20);
            this.textBoxKnapsackBruteforce.TabIndex = 17;
            // 
            // checkBoxKnapsackBruteforce
            // 
            this.checkBoxKnapsackBruteforce.AutoSize = true;
            this.checkBoxKnapsackBruteforce.Location = new System.Drawing.Point(12, 94);
            this.checkBoxKnapsackBruteforce.Name = "checkBoxKnapsackBruteforce";
            this.checkBoxKnapsackBruteforce.Size = new System.Drawing.Size(67, 17);
            this.checkBoxKnapsackBruteforce.TabIndex = 16;
            this.checkBoxKnapsackBruteforce.Text = "Przegląd";
            this.checkBoxKnapsackBruteforce.UseVisualStyleBackColor = true;
            // 
            // buttonKnapsackBruteforce
            // 
            this.buttonKnapsackBruteforce.Location = new System.Drawing.Point(225, 90);
            this.buttonKnapsackBruteforce.Name = "buttonKnapsackBruteforce";
            this.buttonKnapsackBruteforce.Size = new System.Drawing.Size(70, 23);
            this.buttonKnapsackBruteforce.TabIndex = 15;
            this.buttonKnapsackBruteforce.Text = "Wypisz";
            this.buttonKnapsackBruteforce.UseVisualStyleBackColor = true;
            this.buttonKnapsackBruteforce.Click += new System.EventHandler(this.buttonKnapsackBruteforce_Click);
            // 
            // textBoxKnapsackGreedyW
            // 
            this.textBoxKnapsackGreedyW.Location = new System.Drawing.Point(132, 40);
            this.textBoxKnapsackGreedyW.Name = "textBoxKnapsackGreedyW";
            this.textBoxKnapsackGreedyW.Size = new System.Drawing.Size(90, 20);
            this.textBoxKnapsackGreedyW.TabIndex = 14;
            // 
            // checkBoxKnapsackGreedyW
            // 
            this.checkBoxKnapsackGreedyW.AutoSize = true;
            this.checkBoxKnapsackGreedyW.Location = new System.Drawing.Point(12, 44);
            this.checkBoxKnapsackGreedyW.Name = "checkBoxKnapsackGreedyW";
            this.checkBoxKnapsackGreedyW.Size = new System.Drawing.Size(92, 17);
            this.checkBoxKnapsackGreedyW.TabIndex = 13;
            this.checkBoxKnapsackGreedyW.Text = "Zachłanny W";
            this.checkBoxKnapsackGreedyW.UseVisualStyleBackColor = true;
            // 
            // checkBoxKnapsackDynamic
            // 
            this.checkBoxKnapsackDynamic.AutoSize = true;
            this.checkBoxKnapsackDynamic.Location = new System.Drawing.Point(12, 16);
            this.checkBoxKnapsackDynamic.Name = "checkBoxKnapsackDynamic";
            this.checkBoxKnapsackDynamic.Size = new System.Drawing.Size(59, 17);
            this.checkBoxKnapsackDynamic.TabIndex = 12;
            this.checkBoxKnapsackDynamic.Text = "Dynam";
            this.checkBoxKnapsackDynamic.UseVisualStyleBackColor = true;
            // 
            // buttonKnapsackGreedyW
            // 
            this.buttonKnapsackGreedyW.Location = new System.Drawing.Point(225, 38);
            this.buttonKnapsackGreedyW.Name = "buttonKnapsackGreedyW";
            this.buttonKnapsackGreedyW.Size = new System.Drawing.Size(70, 23);
            this.buttonKnapsackGreedyW.TabIndex = 11;
            this.buttonKnapsackGreedyW.Text = "Wypisz";
            this.buttonKnapsackGreedyW.UseVisualStyleBackColor = true;
            this.buttonKnapsackGreedyW.Click += new System.EventHandler(this.buttonKnapsackGreedyW_Click);
            // 
            // textBoxKnapsackDynamic
            // 
            this.textBoxKnapsackDynamic.Location = new System.Drawing.Point(132, 14);
            this.textBoxKnapsackDynamic.Name = "textBoxKnapsackDynamic";
            this.textBoxKnapsackDynamic.Size = new System.Drawing.Size(90, 20);
            this.textBoxKnapsackDynamic.TabIndex = 10;
            // 
            // buttonKnapsackDynamic
            // 
            this.buttonKnapsackDynamic.Location = new System.Drawing.Point(225, 12);
            this.buttonKnapsackDynamic.Name = "buttonKnapsackDynamic";
            this.buttonKnapsackDynamic.Size = new System.Drawing.Size(70, 23);
            this.buttonKnapsackDynamic.TabIndex = 6;
            this.buttonKnapsackDynamic.Text = "Wypisz";
            this.buttonKnapsackDynamic.UseVisualStyleBackColor = true;
            this.buttonKnapsackDynamic.Click += new System.EventHandler(this.buttonKnapsackDynamic_Click);
            // 
            // buttonKnapsackStart
            // 
            this.buttonKnapsackStart.Location = new System.Drawing.Point(6, 117);
            this.buttonKnapsackStart.Name = "buttonKnapsackStart";
            this.buttonKnapsackStart.Size = new System.Drawing.Size(70, 23);
            this.buttonKnapsackStart.TabIndex = 4;
            this.buttonKnapsackStart.Text = "Start";
            this.buttonKnapsackStart.UseVisualStyleBackColor = true;
            this.buttonKnapsackStart.Click += new System.EventHandler(this.buttonKnapsackStart_Click);
            // 
            // groupBoxSalesman
            // 
            this.groupBoxSalesman.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxSalesman.Controls.Add(this.buttonSalesmanAnnealingSave);
            this.groupBoxSalesman.Controls.Add(this.label4);
            this.groupBoxSalesman.Controls.Add(this.label3);
            this.groupBoxSalesman.Controls.Add(this.label2);
            this.groupBoxSalesman.Controls.Add(this.label1);
            this.groupBoxSalesman.Controls.Add(this.textBoxSalesmanAnnealingCooling);
            this.groupBoxSalesman.Controls.Add(this.textBoxSalesmanAnnealingTemperature);
            this.groupBoxSalesman.Controls.Add(this.textBoxSalesmanAnnealingIterations);
            this.groupBoxSalesman.Controls.Add(this.buttonSalesmanAll);
            this.groupBoxSalesman.Controls.Add(this.textBoxSalesmanAnnealing);
            this.groupBoxSalesman.Controls.Add(this.checkBoxSalesmanAnnealing);
            this.groupBoxSalesman.Controls.Add(this.checkBoxSalesmanBruteforce);
            this.groupBoxSalesman.Controls.Add(this.buttonSalesmanAnnealing);
            this.groupBoxSalesman.Controls.Add(this.textBoxSalesmanBruteforce);
            this.groupBoxSalesman.Controls.Add(this.buttonSalesmanBruteforce);
            this.groupBoxSalesman.Controls.Add(this.textBoxSalesmanGreedy);
            this.groupBoxSalesman.Controls.Add(this.checkBoxSalesmanGreedy);
            this.groupBoxSalesman.Controls.Add(this.checkBoxSalesmanTwoOpt);
            this.groupBoxSalesman.Controls.Add(this.buttonSalesmanGreedy);
            this.groupBoxSalesman.Controls.Add(this.textBoxSalesmanTwoOpt);
            this.groupBoxSalesman.Controls.Add(this.buttonSalesmanTwoOpt);
            this.groupBoxSalesman.Controls.Add(this.buttonSalesman);
            this.groupBoxSalesman.Location = new System.Drawing.Point(12, 254);
            this.groupBoxSalesman.Name = "groupBoxSalesman";
            this.groupBoxSalesman.Size = new System.Drawing.Size(304, 235);
            this.groupBoxSalesman.TabIndex = 15;
            this.groupBoxSalesman.TabStop = false;
            this.groupBoxSalesman.Text = "Komiwojażer";
            // 
            // buttonSalesmanAll
            // 
            this.buttonSalesmanAll.Location = new System.Drawing.Point(225, 206);
            this.buttonSalesmanAll.Name = "buttonSalesmanAll";
            this.buttonSalesmanAll.Size = new System.Drawing.Size(70, 23);
            this.buttonSalesmanAll.TabIndex = 21;
            this.buttonSalesmanAll.Text = "Wszystkie";
            this.buttonSalesmanAll.UseVisualStyleBackColor = true;
            this.buttonSalesmanAll.Click += new System.EventHandler(this.buttonSalesmanAll_Click);
            // 
            // textBoxSalesmanAnnealing
            // 
            this.textBoxSalesmanAnnealing.Location = new System.Drawing.Point(132, 97);
            this.textBoxSalesmanAnnealing.Name = "textBoxSalesmanAnnealing";
            this.textBoxSalesmanAnnealing.Size = new System.Drawing.Size(90, 20);
            this.textBoxSalesmanAnnealing.TabIndex = 20;
            // 
            // checkBoxSalesmanAnnealing
            // 
            this.checkBoxSalesmanAnnealing.AutoSize = true;
            this.checkBoxSalesmanAnnealing.Location = new System.Drawing.Point(12, 95);
            this.checkBoxSalesmanAnnealing.Name = "checkBoxSalesmanAnnealing";
            this.checkBoxSalesmanAnnealing.Size = new System.Drawing.Size(81, 17);
            this.checkBoxSalesmanAnnealing.TabIndex = 19;
            this.checkBoxSalesmanAnnealing.Text = "Wyżarzanie";
            this.checkBoxSalesmanAnnealing.UseVisualStyleBackColor = true;
            // 
            // checkBoxSalesmanBruteforce
            // 
            this.checkBoxSalesmanBruteforce.AutoSize = true;
            this.checkBoxSalesmanBruteforce.Location = new System.Drawing.Point(12, 69);
            this.checkBoxSalesmanBruteforce.Name = "checkBoxSalesmanBruteforce";
            this.checkBoxSalesmanBruteforce.Size = new System.Drawing.Size(67, 17);
            this.checkBoxSalesmanBruteforce.TabIndex = 18;
            this.checkBoxSalesmanBruteforce.Text = "Przegląd";
            this.checkBoxSalesmanBruteforce.UseVisualStyleBackColor = true;
            // 
            // buttonSalesmanAnnealing
            // 
            this.buttonSalesmanAnnealing.Location = new System.Drawing.Point(225, 95);
            this.buttonSalesmanAnnealing.Name = "buttonSalesmanAnnealing";
            this.buttonSalesmanAnnealing.Size = new System.Drawing.Size(70, 23);
            this.buttonSalesmanAnnealing.TabIndex = 17;
            this.buttonSalesmanAnnealing.Text = "Wypisz";
            this.buttonSalesmanAnnealing.UseVisualStyleBackColor = true;
            this.buttonSalesmanAnnealing.Click += new System.EventHandler(this.buttonSalesmanAnnealing_Click);
            // 
            // textBoxSalesmanBruteforce
            // 
            this.textBoxSalesmanBruteforce.Location = new System.Drawing.Point(132, 71);
            this.textBoxSalesmanBruteforce.Name = "textBoxSalesmanBruteforce";
            this.textBoxSalesmanBruteforce.Size = new System.Drawing.Size(90, 20);
            this.textBoxSalesmanBruteforce.TabIndex = 16;
            // 
            // buttonSalesmanBruteforce
            // 
            this.buttonSalesmanBruteforce.Location = new System.Drawing.Point(225, 69);
            this.buttonSalesmanBruteforce.Name = "buttonSalesmanBruteforce";
            this.buttonSalesmanBruteforce.Size = new System.Drawing.Size(70, 23);
            this.buttonSalesmanBruteforce.TabIndex = 15;
            this.buttonSalesmanBruteforce.Text = "Wypisz";
            this.buttonSalesmanBruteforce.UseVisualStyleBackColor = true;
            this.buttonSalesmanBruteforce.Click += new System.EventHandler(this.buttonSalesmanBruteforce_Click);
            // 
            // textBoxSalesmanGreedy
            // 
            this.textBoxSalesmanGreedy.Location = new System.Drawing.Point(132, 44);
            this.textBoxSalesmanGreedy.Name = "textBoxSalesmanGreedy";
            this.textBoxSalesmanGreedy.Size = new System.Drawing.Size(90, 20);
            this.textBoxSalesmanGreedy.TabIndex = 14;
            // 
            // checkBoxSalesmanGreedy
            // 
            this.checkBoxSalesmanGreedy.AutoSize = true;
            this.checkBoxSalesmanGreedy.Location = new System.Drawing.Point(12, 42);
            this.checkBoxSalesmanGreedy.Name = "checkBoxSalesmanGreedy";
            this.checkBoxSalesmanGreedy.Size = new System.Drawing.Size(78, 17);
            this.checkBoxSalesmanGreedy.TabIndex = 13;
            this.checkBoxSalesmanGreedy.Text = "Zachłanny";
            this.checkBoxSalesmanGreedy.UseVisualStyleBackColor = true;
            // 
            // checkBoxSalesmanTwoOpt
            // 
            this.checkBoxSalesmanTwoOpt.AutoSize = true;
            this.checkBoxSalesmanTwoOpt.Location = new System.Drawing.Point(12, 16);
            this.checkBoxSalesmanTwoOpt.Name = "checkBoxSalesmanTwoOpt";
            this.checkBoxSalesmanTwoOpt.Size = new System.Drawing.Size(64, 17);
            this.checkBoxSalesmanTwoOpt.TabIndex = 12;
            this.checkBoxSalesmanTwoOpt.Text = "TwoOpt";
            this.checkBoxSalesmanTwoOpt.UseVisualStyleBackColor = true;
            // 
            // buttonSalesmanGreedy
            // 
            this.buttonSalesmanGreedy.Location = new System.Drawing.Point(225, 42);
            this.buttonSalesmanGreedy.Name = "buttonSalesmanGreedy";
            this.buttonSalesmanGreedy.Size = new System.Drawing.Size(70, 23);
            this.buttonSalesmanGreedy.TabIndex = 11;
            this.buttonSalesmanGreedy.Text = "Wypisz";
            this.buttonSalesmanGreedy.UseVisualStyleBackColor = true;
            this.buttonSalesmanGreedy.Click += new System.EventHandler(this.buttonSalesmanGreedy_Click);
            // 
            // textBoxSalesmanTwoOpt
            // 
            this.textBoxSalesmanTwoOpt.Location = new System.Drawing.Point(132, 18);
            this.textBoxSalesmanTwoOpt.Name = "textBoxSalesmanTwoOpt";
            this.textBoxSalesmanTwoOpt.Size = new System.Drawing.Size(90, 20);
            this.textBoxSalesmanTwoOpt.TabIndex = 10;
            // 
            // buttonSalesmanTwoOpt
            // 
            this.buttonSalesmanTwoOpt.Location = new System.Drawing.Point(225, 16);
            this.buttonSalesmanTwoOpt.Name = "buttonSalesmanTwoOpt";
            this.buttonSalesmanTwoOpt.Size = new System.Drawing.Size(70, 23);
            this.buttonSalesmanTwoOpt.TabIndex = 6;
            this.buttonSalesmanTwoOpt.Text = "Wypisz";
            this.buttonSalesmanTwoOpt.UseVisualStyleBackColor = true;
            this.buttonSalesmanTwoOpt.Click += new System.EventHandler(this.buttonSalesmanTwoOpt_Click);
            // 
            // buttonSalesman
            // 
            this.buttonSalesman.Location = new System.Drawing.Point(9, 206);
            this.buttonSalesman.Name = "buttonSalesman";
            this.buttonSalesman.Size = new System.Drawing.Size(70, 23);
            this.buttonSalesman.TabIndex = 4;
            this.buttonSalesman.Text = "Start";
            this.buttonSalesman.UseVisualStyleBackColor = true;
            this.buttonSalesman.Click += new System.EventHandler(this.buttonSalesman_Click);
            // 
            // groupBoxCreate
            // 
            this.groupBoxCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxCreate.Controls.Add(this.textBoxDataGeneratorSizeKnapsack);
            this.groupBoxCreate.Controls.Add(this.radioButtonDataGeneratorSalesman);
            this.groupBoxCreate.Controls.Add(this.radioButtonDataGeneratorKnapsack);
            this.groupBoxCreate.Controls.Add(this.textBoxDataGeneratorSize);
            this.groupBoxCreate.Controls.Add(this.buttonDataGenerator);
            this.groupBoxCreate.Location = new System.Drawing.Point(12, 495);
            this.groupBoxCreate.Name = "groupBoxCreate";
            this.groupBoxCreate.Size = new System.Drawing.Size(304, 82);
            this.groupBoxCreate.TabIndex = 16;
            this.groupBoxCreate.TabStop = false;
            this.groupBoxCreate.Text = "Tworzenie danych";
            // 
            // textBoxDataGeneratorSizeKnapsack
            // 
            this.textBoxDataGeneratorSizeKnapsack.Location = new System.Drawing.Point(82, 19);
            this.textBoxDataGeneratorSizeKnapsack.Name = "textBoxDataGeneratorSizeKnapsack";
            this.textBoxDataGeneratorSizeKnapsack.Size = new System.Drawing.Size(70, 20);
            this.textBoxDataGeneratorSizeKnapsack.TabIndex = 16;
            // 
            // radioButtonDataGeneratorSalesman
            // 
            this.radioButtonDataGeneratorSalesman.AutoSize = true;
            this.radioButtonDataGeneratorSalesman.Location = new System.Drawing.Point(169, 45);
            this.radioButtonDataGeneratorSalesman.Name = "radioButtonDataGeneratorSalesman";
            this.radioButtonDataGeneratorSalesman.Size = new System.Drawing.Size(84, 17);
            this.radioButtonDataGeneratorSalesman.TabIndex = 8;
            this.radioButtonDataGeneratorSalesman.TabStop = true;
            this.radioButtonDataGeneratorSalesman.Text = "Komiwojażer";
            this.radioButtonDataGeneratorSalesman.UseVisualStyleBackColor = true;
            // 
            // radioButtonDataGeneratorKnapsack
            // 
            this.radioButtonDataGeneratorKnapsack.AutoSize = true;
            this.radioButtonDataGeneratorKnapsack.Location = new System.Drawing.Point(169, 22);
            this.radioButtonDataGeneratorKnapsack.Name = "radioButtonDataGeneratorKnapsack";
            this.radioButtonDataGeneratorKnapsack.Size = new System.Drawing.Size(58, 17);
            this.radioButtonDataGeneratorKnapsack.TabIndex = 7;
            this.radioButtonDataGeneratorKnapsack.TabStop = true;
            this.radioButtonDataGeneratorKnapsack.Text = "Plecak";
            this.radioButtonDataGeneratorKnapsack.UseVisualStyleBackColor = true;
            // 
            // textBoxDataGeneratorSize
            // 
            this.textBoxDataGeneratorSize.Location = new System.Drawing.Point(6, 19);
            this.textBoxDataGeneratorSize.Name = "textBoxDataGeneratorSize";
            this.textBoxDataGeneratorSize.Size = new System.Drawing.Size(70, 20);
            this.textBoxDataGeneratorSize.TabIndex = 15;
            // 
            // buttonDataGenerator
            // 
            this.buttonDataGenerator.Location = new System.Drawing.Point(6, 45);
            this.buttonDataGenerator.Name = "buttonDataGenerator";
            this.buttonDataGenerator.Size = new System.Drawing.Size(70, 23);
            this.buttonDataGenerator.TabIndex = 4;
            this.buttonDataGenerator.Text = "Twórz";
            this.buttonDataGenerator.UseVisualStyleBackColor = true;
            this.buttonDataGenerator.Click += new System.EventHandler(this.buttonDataGenerator_Click);
            // 
            // groupBoxRepeat
            // 
            this.groupBoxRepeat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxRepeat.Controls.Add(this.textBoxRepeatNew);
            this.groupBoxRepeat.Controls.Add(this.textBoxRepeatCurrent);
            this.groupBoxRepeat.Controls.Add(this.buttonRepeatChange);
            this.groupBoxRepeat.Location = new System.Drawing.Point(12, 583);
            this.groupBoxRepeat.Name = "groupBoxRepeat";
            this.groupBoxRepeat.Size = new System.Drawing.Size(304, 51);
            this.groupBoxRepeat.TabIndex = 17;
            this.groupBoxRepeat.TabStop = false;
            this.groupBoxRepeat.Text = "Mnożnik";
            // 
            // textBoxRepeatNew
            // 
            this.textBoxRepeatNew.Location = new System.Drawing.Point(82, 19);
            this.textBoxRepeatNew.Name = "textBoxRepeatNew";
            this.textBoxRepeatNew.Size = new System.Drawing.Size(70, 20);
            this.textBoxRepeatNew.TabIndex = 16;
            // 
            // textBoxRepeatCurrent
            // 
            this.textBoxRepeatCurrent.Location = new System.Drawing.Point(6, 19);
            this.textBoxRepeatCurrent.Name = "textBoxRepeatCurrent";
            this.textBoxRepeatCurrent.ReadOnly = true;
            this.textBoxRepeatCurrent.Size = new System.Drawing.Size(70, 20);
            this.textBoxRepeatCurrent.TabIndex = 15;
            // 
            // buttonRepeatChange
            // 
            this.buttonRepeatChange.Location = new System.Drawing.Point(157, 19);
            this.buttonRepeatChange.Name = "buttonRepeatChange";
            this.buttonRepeatChange.Size = new System.Drawing.Size(70, 23);
            this.buttonRepeatChange.TabIndex = 4;
            this.buttonRepeatChange.Text = "Zmień";
            this.buttonRepeatChange.UseVisualStyleBackColor = true;
            this.buttonRepeatChange.Click += new System.EventHandler(this.buttonRepeatChange_Click);
            // 
            // textBoxSalesmanAnnealingIterations
            // 
            this.textBoxSalesmanAnnealingIterations.Location = new System.Drawing.Point(240, 142);
            this.textBoxSalesmanAnnealingIterations.Name = "textBoxSalesmanAnnealingIterations";
            this.textBoxSalesmanAnnealingIterations.Size = new System.Drawing.Size(55, 20);
            this.textBoxSalesmanAnnealingIterations.TabIndex = 22;
            // 
            // textBoxSalesmanAnnealingTemperature
            // 
            this.textBoxSalesmanAnnealingTemperature.Location = new System.Drawing.Point(88, 142);
            this.textBoxSalesmanAnnealingTemperature.Name = "textBoxSalesmanAnnealingTemperature";
            this.textBoxSalesmanAnnealingTemperature.Size = new System.Drawing.Size(73, 20);
            this.textBoxSalesmanAnnealingTemperature.TabIndex = 23;
            this.textBoxSalesmanAnnealingTemperature.TextChanged += new System.EventHandler(this.textBoxSalesmanAnnealingTemperature_TextChanged);
            // 
            // textBoxSalesmanAnnealingCooling
            // 
            this.textBoxSalesmanAnnealingCooling.Location = new System.Drawing.Point(88, 167);
            this.textBoxSalesmanAnnealingCooling.Name = "textBoxSalesmanAnnealingCooling";
            this.textBoxSalesmanAnnealingCooling.Size = new System.Drawing.Size(73, 20);
            this.textBoxSalesmanAnnealingCooling.TabIndex = 24;
            this.textBoxSalesmanAnnealingCooling.TextChanged += new System.EventHandler(this.textBoxSalesmanAnnealingCooling_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Parametry wyżarzania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "T startowa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 26);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mnożnik \r\nochładzania";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 26);
            this.label4.TabIndex = 28;
            this.label4.Text = "Oszacowana \r\nilość iteracji";
            // 
            // buttonSalesmanAnnealingSave
            // 
            this.buttonSalesmanAnnealingSave.Location = new System.Drawing.Point(240, 164);
            this.buttonSalesmanAnnealingSave.Name = "buttonSalesmanAnnealingSave";
            this.buttonSalesmanAnnealingSave.Size = new System.Drawing.Size(55, 23);
            this.buttonSalesmanAnnealingSave.TabIndex = 29;
            this.buttonSalesmanAnnealingSave.Text = "Zapisz";
            this.buttonSalesmanAnnealingSave.UseVisualStyleBackColor = true;
            this.buttonSalesmanAnnealingSave.Click += new System.EventHandler(this.buttonSalesmanAnnealingSave_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 646);
            this.Controls.Add(this.groupBoxRepeat);
            this.Controls.Add(this.groupBoxCreate);
            this.Controls.Add(this.groupBoxSalesman);
            this.Controls.Add(this.groupBoxKnapsack);
            this.Controls.Add(this.groupBoxLoadData);
            this.Name = "FormMain";
            this.Text = "Algorytmy optymalizacyjne";
            this.groupBoxLoadData.ResumeLayout(false);
            this.groupBoxLoadData.PerformLayout();
            this.groupBoxKnapsack.ResumeLayout(false);
            this.groupBoxKnapsack.PerformLayout();
            this.groupBoxSalesman.ResumeLayout(false);
            this.groupBoxSalesman.PerformLayout();
            this.groupBoxCreate.ResumeLayout(false);
            this.groupBoxCreate.PerformLayout();
            this.groupBoxRepeat.ResumeLayout(false);
            this.groupBoxRepeat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLoadData;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.TextBox textBoxLoadDataFilename;
        private System.Windows.Forms.RadioButton radioButtonLoadDataSalesman;
        private System.Windows.Forms.RadioButton radioButtonLoadDataKnapsack;
        private System.Windows.Forms.Label labelMatrix;
        private System.Windows.Forms.Button buttonDisplayData;
        private System.Windows.Forms.GroupBox groupBoxKnapsack;
        private System.Windows.Forms.TextBox textBoxKnapsackGreedyW;
        private System.Windows.Forms.CheckBox checkBoxKnapsackGreedyW;
        private System.Windows.Forms.CheckBox checkBoxKnapsackDynamic;
        private System.Windows.Forms.Button buttonKnapsackGreedyW;
        private System.Windows.Forms.TextBox textBoxKnapsackDynamic;
        private System.Windows.Forms.Button buttonKnapsackDynamic;
        private System.Windows.Forms.Button buttonKnapsackStart;
        private System.Windows.Forms.GroupBox groupBoxSalesman;
        private System.Windows.Forms.TextBox textBoxSalesmanGreedy;
        private System.Windows.Forms.CheckBox checkBoxSalesmanGreedy;
        private System.Windows.Forms.CheckBox checkBoxSalesmanTwoOpt;
        private System.Windows.Forms.Button buttonSalesmanGreedy;
        private System.Windows.Forms.TextBox textBoxSalesmanTwoOpt;
        private System.Windows.Forms.Button buttonSalesmanTwoOpt;
        private System.Windows.Forms.Button buttonSalesman;
        private System.Windows.Forms.GroupBox groupBoxCreate;
        private System.Windows.Forms.TextBox textBoxDataGeneratorSize;
        private System.Windows.Forms.Button buttonDataGenerator;
        private System.Windows.Forms.TextBox textBoxKnapsackBruteforce;
        private System.Windows.Forms.CheckBox checkBoxKnapsackBruteforce;
        private System.Windows.Forms.Button buttonKnapsackBruteforce;
        private System.Windows.Forms.TextBox textBoxSalesmanAnnealing;
        private System.Windows.Forms.CheckBox checkBoxSalesmanAnnealing;
        private System.Windows.Forms.CheckBox checkBoxSalesmanBruteforce;
        private System.Windows.Forms.Button buttonSalesmanAnnealing;
        private System.Windows.Forms.TextBox textBoxSalesmanBruteforce;
        private System.Windows.Forms.Button buttonSalesmanBruteforce;
        private System.Windows.Forms.Button buttonKnapsackAll;
        private System.Windows.Forms.Button buttonSalesmanAll;
        private System.Windows.Forms.RadioButton radioButtonDataGeneratorSalesman;
        private System.Windows.Forms.RadioButton radioButtonDataGeneratorKnapsack;
        private System.Windows.Forms.Button buttonKnapsackGreedyR;
        private System.Windows.Forms.TextBox textBoxKnapsackGreedyR;
        private System.Windows.Forms.CheckBox checkBoxKnapsackGreedyR;
        private System.Windows.Forms.TextBox textBoxDataGeneratorSizeKnapsack;
        private System.Windows.Forms.GroupBox groupBoxRepeat;
        private System.Windows.Forms.TextBox textBoxRepeatNew;
        private System.Windows.Forms.TextBox textBoxRepeatCurrent;
        private System.Windows.Forms.Button buttonRepeatChange;
        private System.Windows.Forms.Button buttonSalesmanAnnealingSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSalesmanAnnealingCooling;
        private System.Windows.Forms.TextBox textBoxSalesmanAnnealingTemperature;
        private System.Windows.Forms.TextBox textBoxSalesmanAnnealingIterations;
    }
}

