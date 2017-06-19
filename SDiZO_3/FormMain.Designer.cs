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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBoxSalesmanBruteforce = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
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
            this.radioButtonDataGeneratorSalesman = new System.Windows.Forms.RadioButton();
            this.radioButtonDataGeneratorKnapsack = new System.Windows.Forms.RadioButton();
            this.textBoxDataGeneratorSize = new System.Windows.Forms.TextBox();
            this.buttonDataGenerator = new System.Windows.Forms.Button();
            this.textBoxDataGeneratorSizeKnapsack = new System.Windows.Forms.TextBox();
            this.groupBoxRepeat = new System.Windows.Forms.GroupBox();
            this.textBoxRepeatNew = new System.Windows.Forms.TextBox();
            this.textBoxRepeatCurrent = new System.Windows.Forms.TextBox();
            this.buttonRepeatChange = new System.Windows.Forms.Button();
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
            this.groupBoxLoadData.Size = new System.Drawing.Size(260, 82);
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
            this.labelMatrix.Location = new System.Drawing.Point(175, 31);
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
            this.buttonDisplayData.Location = new System.Drawing.Point(178, 47);
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
            this.groupBoxKnapsack.Size = new System.Drawing.Size(259, 148);
            this.groupBoxKnapsack.TabIndex = 7;
            this.groupBoxKnapsack.TabStop = false;
            this.groupBoxKnapsack.Text = "Plecak";
            // 
            // buttonKnapsackGreedyR
            // 
            this.buttonKnapsackGreedyR.Location = new System.Drawing.Point(178, 66);
            this.buttonKnapsackGreedyR.Name = "buttonKnapsackGreedyR";
            this.buttonKnapsackGreedyR.Size = new System.Drawing.Size(70, 23);
            this.buttonKnapsackGreedyR.TabIndex = 23;
            this.buttonKnapsackGreedyR.Text = "Wypisz";
            this.buttonKnapsackGreedyR.UseVisualStyleBackColor = true;
            this.buttonKnapsackGreedyR.Click += new System.EventHandler(this.buttonKnapsackGreedyR_Click);
            // 
            // textBoxKnapsackGreedyR
            // 
            this.textBoxKnapsackGreedyR.Location = new System.Drawing.Point(85, 68);
            this.textBoxKnapsackGreedyR.Name = "textBoxKnapsackGreedyR";
            this.textBoxKnapsackGreedyR.Size = new System.Drawing.Size(90, 20);
            this.textBoxKnapsackGreedyR.TabIndex = 22;
            // 
            // checkBoxKnapsackGreedyR
            // 
            this.checkBoxKnapsackGreedyR.AutoSize = true;
            this.checkBoxKnapsackGreedyR.Location = new System.Drawing.Point(12, 70);
            this.checkBoxKnapsackGreedyR.Name = "checkBoxKnapsackGreedyR";
            this.checkBoxKnapsackGreedyR.Size = new System.Drawing.Size(71, 17);
            this.checkBoxKnapsackGreedyR.TabIndex = 21;
            this.checkBoxKnapsackGreedyR.Text = "Greedy R";
            this.checkBoxKnapsackGreedyR.UseVisualStyleBackColor = true;
            // 
            // buttonKnapsackAll
            // 
            this.buttonKnapsackAll.Location = new System.Drawing.Point(178, 117);
            this.buttonKnapsackAll.Name = "buttonKnapsackAll";
            this.buttonKnapsackAll.Size = new System.Drawing.Size(70, 23);
            this.buttonKnapsackAll.TabIndex = 20;
            this.buttonKnapsackAll.Text = "Wszystkie";
            this.buttonKnapsackAll.UseVisualStyleBackColor = true;
            this.buttonKnapsackAll.Click += new System.EventHandler(this.buttonKnapsackAll_Click);
            // 
            // textBoxKnapsackBruteforce
            // 
            this.textBoxKnapsackBruteforce.Location = new System.Drawing.Point(85, 94);
            this.textBoxKnapsackBruteforce.Name = "textBoxKnapsackBruteforce";
            this.textBoxKnapsackBruteforce.Size = new System.Drawing.Size(90, 20);
            this.textBoxKnapsackBruteforce.TabIndex = 17;
            // 
            // checkBoxKnapsackBruteforce
            // 
            this.checkBoxKnapsackBruteforce.AutoSize = true;
            this.checkBoxKnapsackBruteforce.Location = new System.Drawing.Point(12, 94);
            this.checkBoxKnapsackBruteforce.Name = "checkBoxKnapsackBruteforce";
            this.checkBoxKnapsackBruteforce.Size = new System.Drawing.Size(75, 17);
            this.checkBoxKnapsackBruteforce.TabIndex = 16;
            this.checkBoxKnapsackBruteforce.Text = "Bruteforce";
            this.checkBoxKnapsackBruteforce.UseVisualStyleBackColor = true;
            // 
            // buttonKnapsackBruteforce
            // 
            this.buttonKnapsackBruteforce.Location = new System.Drawing.Point(178, 92);
            this.buttonKnapsackBruteforce.Name = "buttonKnapsackBruteforce";
            this.buttonKnapsackBruteforce.Size = new System.Drawing.Size(70, 23);
            this.buttonKnapsackBruteforce.TabIndex = 15;
            this.buttonKnapsackBruteforce.Text = "Wypisz";
            this.buttonKnapsackBruteforce.UseVisualStyleBackColor = true;
            this.buttonKnapsackBruteforce.Click += new System.EventHandler(this.buttonKnapsackBruteforce_Click);
            // 
            // textBoxKnapsackGreedyW
            // 
            this.textBoxKnapsackGreedyW.Location = new System.Drawing.Point(85, 42);
            this.textBoxKnapsackGreedyW.Name = "textBoxKnapsackGreedyW";
            this.textBoxKnapsackGreedyW.Size = new System.Drawing.Size(90, 20);
            this.textBoxKnapsackGreedyW.TabIndex = 14;
            // 
            // checkBoxKnapsackGreedyW
            // 
            this.checkBoxKnapsackGreedyW.AutoSize = true;
            this.checkBoxKnapsackGreedyW.Location = new System.Drawing.Point(12, 44);
            this.checkBoxKnapsackGreedyW.Name = "checkBoxKnapsackGreedyW";
            this.checkBoxKnapsackGreedyW.Size = new System.Drawing.Size(74, 17);
            this.checkBoxKnapsackGreedyW.TabIndex = 13;
            this.checkBoxKnapsackGreedyW.Text = "Greedy W";
            this.checkBoxKnapsackGreedyW.UseVisualStyleBackColor = true;
            // 
            // checkBoxKnapsackDynamic
            // 
            this.checkBoxKnapsackDynamic.AutoSize = true;
            this.checkBoxKnapsackDynamic.Location = new System.Drawing.Point(12, 16);
            this.checkBoxKnapsackDynamic.Name = "checkBoxKnapsackDynamic";
            this.checkBoxKnapsackDynamic.Size = new System.Drawing.Size(67, 17);
            this.checkBoxKnapsackDynamic.TabIndex = 12;
            this.checkBoxKnapsackDynamic.Text = "Dynamic";
            this.checkBoxKnapsackDynamic.UseVisualStyleBackColor = true;
            // 
            // buttonKnapsackGreedyW
            // 
            this.buttonKnapsackGreedyW.Location = new System.Drawing.Point(178, 40);
            this.buttonKnapsackGreedyW.Name = "buttonKnapsackGreedyW";
            this.buttonKnapsackGreedyW.Size = new System.Drawing.Size(70, 23);
            this.buttonKnapsackGreedyW.TabIndex = 11;
            this.buttonKnapsackGreedyW.Text = "Wypisz";
            this.buttonKnapsackGreedyW.UseVisualStyleBackColor = true;
            this.buttonKnapsackGreedyW.Click += new System.EventHandler(this.buttonKnapsackGreedyW_Click);
            // 
            // textBoxKnapsackDynamic
            // 
            this.textBoxKnapsackDynamic.Location = new System.Drawing.Point(85, 16);
            this.textBoxKnapsackDynamic.Name = "textBoxKnapsackDynamic";
            this.textBoxKnapsackDynamic.Size = new System.Drawing.Size(90, 20);
            this.textBoxKnapsackDynamic.TabIndex = 10;
            // 
            // buttonKnapsackDynamic
            // 
            this.buttonKnapsackDynamic.Location = new System.Drawing.Point(178, 14);
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
            this.groupBoxSalesman.Controls.Add(this.buttonSalesmanAll);
            this.groupBoxSalesman.Controls.Add(this.textBox4);
            this.groupBoxSalesman.Controls.Add(this.checkBox3);
            this.groupBoxSalesman.Controls.Add(this.checkBoxSalesmanBruteforce);
            this.groupBoxSalesman.Controls.Add(this.button3);
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
            this.groupBoxSalesman.Size = new System.Drawing.Size(259, 148);
            this.groupBoxSalesman.TabIndex = 15;
            this.groupBoxSalesman.TabStop = false;
            this.groupBoxSalesman.Text = "Komiwojażer";
            // 
            // buttonSalesmanAll
            // 
            this.buttonSalesmanAll.Location = new System.Drawing.Point(178, 117);
            this.buttonSalesmanAll.Name = "buttonSalesmanAll";
            this.buttonSalesmanAll.Size = new System.Drawing.Size(70, 23);
            this.buttonSalesmanAll.TabIndex = 21;
            this.buttonSalesmanAll.Text = "Wszystkie";
            this.buttonSalesmanAll.UseVisualStyleBackColor = true;
            this.buttonSalesmanAll.Click += new System.EventHandler(this.buttonSalesmanAll_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(85, 95);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(90, 20);
            this.textBox4.TabIndex = 20;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 95);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(40, 17);
            this.checkBox3.TabIndex = 19;
            this.checkBox3.Text = "XX";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBoxSalesmanBruteforce
            // 
            this.checkBoxSalesmanBruteforce.AutoSize = true;
            this.checkBoxSalesmanBruteforce.Location = new System.Drawing.Point(12, 69);
            this.checkBoxSalesmanBruteforce.Name = "checkBoxSalesmanBruteforce";
            this.checkBoxSalesmanBruteforce.Size = new System.Drawing.Size(75, 17);
            this.checkBoxSalesmanBruteforce.TabIndex = 18;
            this.checkBoxSalesmanBruteforce.Text = "Bruteforce";
            this.checkBoxSalesmanBruteforce.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(178, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Wypisz";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBoxSalesmanBruteforce
            // 
            this.textBoxSalesmanBruteforce.Location = new System.Drawing.Point(85, 69);
            this.textBoxSalesmanBruteforce.Name = "textBoxSalesmanBruteforce";
            this.textBoxSalesmanBruteforce.Size = new System.Drawing.Size(90, 20);
            this.textBoxSalesmanBruteforce.TabIndex = 16;
            // 
            // buttonSalesmanBruteforce
            // 
            this.buttonSalesmanBruteforce.Location = new System.Drawing.Point(178, 67);
            this.buttonSalesmanBruteforce.Name = "buttonSalesmanBruteforce";
            this.buttonSalesmanBruteforce.Size = new System.Drawing.Size(70, 23);
            this.buttonSalesmanBruteforce.TabIndex = 15;
            this.buttonSalesmanBruteforce.Text = "Wypisz";
            this.buttonSalesmanBruteforce.UseVisualStyleBackColor = true;
            this.buttonSalesmanBruteforce.Click += new System.EventHandler(this.buttonSalesmanBruteforce_Click);
            // 
            // textBoxSalesmanGreedy
            // 
            this.textBoxSalesmanGreedy.Location = new System.Drawing.Point(85, 42);
            this.textBoxSalesmanGreedy.Name = "textBoxSalesmanGreedy";
            this.textBoxSalesmanGreedy.Size = new System.Drawing.Size(90, 20);
            this.textBoxSalesmanGreedy.TabIndex = 14;
            // 
            // checkBoxSalesmanGreedy
            // 
            this.checkBoxSalesmanGreedy.AutoSize = true;
            this.checkBoxSalesmanGreedy.Location = new System.Drawing.Point(12, 42);
            this.checkBoxSalesmanGreedy.Name = "checkBoxSalesmanGreedy";
            this.checkBoxSalesmanGreedy.Size = new System.Drawing.Size(60, 17);
            this.checkBoxSalesmanGreedy.TabIndex = 13;
            this.checkBoxSalesmanGreedy.Text = "Greedy";
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
            this.buttonSalesmanGreedy.Location = new System.Drawing.Point(178, 40);
            this.buttonSalesmanGreedy.Name = "buttonSalesmanGreedy";
            this.buttonSalesmanGreedy.Size = new System.Drawing.Size(70, 23);
            this.buttonSalesmanGreedy.TabIndex = 11;
            this.buttonSalesmanGreedy.Text = "Wypisz";
            this.buttonSalesmanGreedy.UseVisualStyleBackColor = true;
            this.buttonSalesmanGreedy.Click += new System.EventHandler(this.buttonSalesmanGreedy_Click);
            // 
            // textBoxSalesmanTwoOpt
            // 
            this.textBoxSalesmanTwoOpt.Location = new System.Drawing.Point(85, 16);
            this.textBoxSalesmanTwoOpt.Name = "textBoxSalesmanTwoOpt";
            this.textBoxSalesmanTwoOpt.Size = new System.Drawing.Size(90, 20);
            this.textBoxSalesmanTwoOpt.TabIndex = 10;
            // 
            // buttonSalesmanTwoOpt
            // 
            this.buttonSalesmanTwoOpt.Location = new System.Drawing.Point(178, 14);
            this.buttonSalesmanTwoOpt.Name = "buttonSalesmanTwoOpt";
            this.buttonSalesmanTwoOpt.Size = new System.Drawing.Size(70, 23);
            this.buttonSalesmanTwoOpt.TabIndex = 6;
            this.buttonSalesmanTwoOpt.Text = "Wypisz";
            this.buttonSalesmanTwoOpt.UseVisualStyleBackColor = true;
            this.buttonSalesmanTwoOpt.Click += new System.EventHandler(this.buttonSalesmanTwoOpt_Click);
            // 
            // buttonSalesman
            // 
            this.buttonSalesman.Location = new System.Drawing.Point(6, 117);
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
            this.groupBoxCreate.Location = new System.Drawing.Point(12, 408);
            this.groupBoxCreate.Name = "groupBoxCreate";
            this.groupBoxCreate.Size = new System.Drawing.Size(259, 82);
            this.groupBoxCreate.TabIndex = 16;
            this.groupBoxCreate.TabStop = false;
            this.groupBoxCreate.Text = "Tworzenie danych";
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
            // textBoxDataGeneratorSizeKnapsack
            // 
            this.textBoxDataGeneratorSizeKnapsack.Location = new System.Drawing.Point(82, 19);
            this.textBoxDataGeneratorSizeKnapsack.Name = "textBoxDataGeneratorSizeKnapsack";
            this.textBoxDataGeneratorSizeKnapsack.Size = new System.Drawing.Size(70, 20);
            this.textBoxDataGeneratorSizeKnapsack.TabIndex = 16;
            // 
            // groupBoxRepeat
            // 
            this.groupBoxRepeat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxRepeat.Controls.Add(this.textBoxRepeatNew);
            this.groupBoxRepeat.Controls.Add(this.textBoxRepeatCurrent);
            this.groupBoxRepeat.Controls.Add(this.buttonRepeatChange);
            this.groupBoxRepeat.Location = new System.Drawing.Point(12, 496);
            this.groupBoxRepeat.Name = "groupBoxRepeat";
            this.groupBoxRepeat.Size = new System.Drawing.Size(259, 51);
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 561);
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBoxSalesmanBruteforce;
        private System.Windows.Forms.Button button3;
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
    }
}

