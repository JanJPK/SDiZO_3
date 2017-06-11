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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxKnapsackBruteforce = new System.Windows.Forms.TextBox();
            this.checkBoxKnapsackBruteforce = new System.Windows.Forms.CheckBox();
            this.buttonKnapsackBruteforce = new System.Windows.Forms.Button();
            this.textBoxKnapsackGreedy = new System.Windows.Forms.TextBox();
            this.checkBoxKnapsackGreedy = new System.Windows.Forms.CheckBox();
            this.checkBoxKnapsackDynamic = new System.Windows.Forms.CheckBox();
            this.buttonKnapsackGreedy = new System.Windows.Forms.Button();
            this.textBoxKnapsackDynamic = new System.Windows.Forms.TextBox();
            this.buttonKnapsackDynamic = new System.Windows.Forms.Button();
            this.buttonKnapsackStart = new System.Windows.Forms.Button();
            this.groupBoxSalesman = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBoxSalesmanBruteforce = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxSalesmanBruteforce = new System.Windows.Forms.TextBox();
            this.buttonSalesmanBruteforce = new System.Windows.Forms.Button();
            this.textBoxSalesmanGreedy = new System.Windows.Forms.TextBox();
            this.checkBoxSalesmanGreedy = new System.Windows.Forms.CheckBox();
            this.checkBoxSalesmanDynamic = new System.Windows.Forms.CheckBox();
            this.buttonSalesmanGreedy = new System.Windows.Forms.Button();
            this.textBoxSalesmanDynamic = new System.Windows.Forms.TextBox();
            this.buttonSalesmanDynamic = new System.Windows.Forms.Button();
            this.buttonSalesman = new System.Windows.Forms.Button();
            this.groupBoxCreate = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxCreateGraphDirected = new System.Windows.Forms.CheckBox();
            this.buttonCreateNewGraph = new System.Windows.Forms.Button();
            this.groupBoxLoadData.SuspendLayout();
            this.groupBoxKnapsack.SuspendLayout();
            this.groupBoxSalesman.SuspendLayout();
            this.groupBoxCreate.SuspendLayout();
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
            // 
            // groupBoxKnapsack
            // 
            this.groupBoxKnapsack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxKnapsack.Controls.Add(this.textBox3);
            this.groupBoxKnapsack.Controls.Add(this.checkBox2);
            this.groupBoxKnapsack.Controls.Add(this.button2);
            this.groupBoxKnapsack.Controls.Add(this.textBoxKnapsackBruteforce);
            this.groupBoxKnapsack.Controls.Add(this.checkBoxKnapsackBruteforce);
            this.groupBoxKnapsack.Controls.Add(this.buttonKnapsackBruteforce);
            this.groupBoxKnapsack.Controls.Add(this.textBoxKnapsackGreedy);
            this.groupBoxKnapsack.Controls.Add(this.checkBoxKnapsackGreedy);
            this.groupBoxKnapsack.Controls.Add(this.checkBoxKnapsackDynamic);
            this.groupBoxKnapsack.Controls.Add(this.buttonKnapsackGreedy);
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(84, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(90, 20);
            this.textBox3.TabIndex = 20;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(11, 94);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(40, 17);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "XX";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Wypisz";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBoxKnapsackBruteforce
            // 
            this.textBoxKnapsackBruteforce.Location = new System.Drawing.Point(84, 68);
            this.textBoxKnapsackBruteforce.Name = "textBoxKnapsackBruteforce";
            this.textBoxKnapsackBruteforce.Size = new System.Drawing.Size(90, 20);
            this.textBoxKnapsackBruteforce.TabIndex = 17;
            // 
            // checkBoxKnapsackBruteforce
            // 
            this.checkBoxKnapsackBruteforce.AutoSize = true;
            this.checkBoxKnapsackBruteforce.Location = new System.Drawing.Point(11, 68);
            this.checkBoxKnapsackBruteforce.Name = "checkBoxKnapsackBruteforce";
            this.checkBoxKnapsackBruteforce.Size = new System.Drawing.Size(75, 17);
            this.checkBoxKnapsackBruteforce.TabIndex = 16;
            this.checkBoxKnapsackBruteforce.Text = "Bruteforce";
            this.checkBoxKnapsackBruteforce.UseVisualStyleBackColor = true;
            // 
            // buttonKnapsackBruteforce
            // 
            this.buttonKnapsackBruteforce.Location = new System.Drawing.Point(177, 66);
            this.buttonKnapsackBruteforce.Name = "buttonKnapsackBruteforce";
            this.buttonKnapsackBruteforce.Size = new System.Drawing.Size(70, 23);
            this.buttonKnapsackBruteforce.TabIndex = 15;
            this.buttonKnapsackBruteforce.Text = "Wypisz";
            this.buttonKnapsackBruteforce.UseVisualStyleBackColor = true;
            this.buttonKnapsackBruteforce.Click += new System.EventHandler(this.buttonKnapsackBruteforce_Click);
            // 
            // textBoxKnapsackGreedy
            // 
            this.textBoxKnapsackGreedy.Location = new System.Drawing.Point(85, 42);
            this.textBoxKnapsackGreedy.Name = "textBoxKnapsackGreedy";
            this.textBoxKnapsackGreedy.Size = new System.Drawing.Size(90, 20);
            this.textBoxKnapsackGreedy.TabIndex = 14;
            // 
            // checkBoxKnapsackGreedy
            // 
            this.checkBoxKnapsackGreedy.AutoSize = true;
            this.checkBoxKnapsackGreedy.Location = new System.Drawing.Point(12, 42);
            this.checkBoxKnapsackGreedy.Name = "checkBoxKnapsackGreedy";
            this.checkBoxKnapsackGreedy.Size = new System.Drawing.Size(60, 17);
            this.checkBoxKnapsackGreedy.TabIndex = 13;
            this.checkBoxKnapsackGreedy.Text = "Greedy";
            this.checkBoxKnapsackGreedy.UseVisualStyleBackColor = true;
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
            // buttonKnapsackGreedy
            // 
            this.buttonKnapsackGreedy.Location = new System.Drawing.Point(178, 40);
            this.buttonKnapsackGreedy.Name = "buttonKnapsackGreedy";
            this.buttonKnapsackGreedy.Size = new System.Drawing.Size(70, 23);
            this.buttonKnapsackGreedy.TabIndex = 11;
            this.buttonKnapsackGreedy.Text = "Wypisz";
            this.buttonKnapsackGreedy.UseVisualStyleBackColor = true;
            this.buttonKnapsackGreedy.Click += new System.EventHandler(this.buttonKnapsackGreedy_Click);
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
            this.groupBoxSalesman.Controls.Add(this.textBox4);
            this.groupBoxSalesman.Controls.Add(this.checkBox3);
            this.groupBoxSalesman.Controls.Add(this.checkBoxSalesmanBruteforce);
            this.groupBoxSalesman.Controls.Add(this.button3);
            this.groupBoxSalesman.Controls.Add(this.textBoxSalesmanBruteforce);
            this.groupBoxSalesman.Controls.Add(this.buttonSalesmanBruteforce);
            this.groupBoxSalesman.Controls.Add(this.textBoxSalesmanGreedy);
            this.groupBoxSalesman.Controls.Add(this.checkBoxSalesmanGreedy);
            this.groupBoxSalesman.Controls.Add(this.checkBoxSalesmanDynamic);
            this.groupBoxSalesman.Controls.Add(this.buttonSalesmanGreedy);
            this.groupBoxSalesman.Controls.Add(this.textBoxSalesmanDynamic);
            this.groupBoxSalesman.Controls.Add(this.buttonSalesmanDynamic);
            this.groupBoxSalesman.Controls.Add(this.buttonSalesman);
            this.groupBoxSalesman.Location = new System.Drawing.Point(12, 254);
            this.groupBoxSalesman.Name = "groupBoxSalesman";
            this.groupBoxSalesman.Size = new System.Drawing.Size(259, 148);
            this.groupBoxSalesman.TabIndex = 15;
            this.groupBoxSalesman.TabStop = false;
            this.groupBoxSalesman.Text = "Komiwojażer";
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
            // checkBoxSalesmanDynamic
            // 
            this.checkBoxSalesmanDynamic.AutoSize = true;
            this.checkBoxSalesmanDynamic.Location = new System.Drawing.Point(12, 16);
            this.checkBoxSalesmanDynamic.Name = "checkBoxSalesmanDynamic";
            this.checkBoxSalesmanDynamic.Size = new System.Drawing.Size(67, 17);
            this.checkBoxSalesmanDynamic.TabIndex = 12;
            this.checkBoxSalesmanDynamic.Text = "Dynamic";
            this.checkBoxSalesmanDynamic.UseVisualStyleBackColor = true;
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
            // textBoxSalesmanDynamic
            // 
            this.textBoxSalesmanDynamic.Location = new System.Drawing.Point(85, 16);
            this.textBoxSalesmanDynamic.Name = "textBoxSalesmanDynamic";
            this.textBoxSalesmanDynamic.Size = new System.Drawing.Size(90, 20);
            this.textBoxSalesmanDynamic.TabIndex = 10;
            // 
            // buttonSalesmanDynamic
            // 
            this.buttonSalesmanDynamic.Location = new System.Drawing.Point(178, 14);
            this.buttonSalesmanDynamic.Name = "buttonSalesmanDynamic";
            this.buttonSalesmanDynamic.Size = new System.Drawing.Size(70, 23);
            this.buttonSalesmanDynamic.TabIndex = 6;
            this.buttonSalesmanDynamic.Text = "Wypisz";
            this.buttonSalesmanDynamic.UseVisualStyleBackColor = true;
            this.buttonSalesmanDynamic.Click += new System.EventHandler(this.buttonSalesmanDynamic_Click);
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
            this.groupBoxCreate.Controls.Add(this.textBox1);
            this.groupBoxCreate.Controls.Add(this.checkBoxCreateGraphDirected);
            this.groupBoxCreate.Controls.Add(this.buttonCreateNewGraph);
            this.groupBoxCreate.Location = new System.Drawing.Point(12, 408);
            this.groupBoxCreate.Name = "groupBoxCreate";
            this.groupBoxCreate.Size = new System.Drawing.Size(259, 82);
            this.groupBoxCreate.TabIndex = 16;
            this.groupBoxCreate.TabStop = false;
            this.groupBoxCreate.Text = "Tworzenie danych";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 20);
            this.textBox1.TabIndex = 15;
            // 
            // checkBoxCreateGraphDirected
            // 
            this.checkBoxCreateGraphDirected.AutoSize = true;
            this.checkBoxCreateGraphDirected.Location = new System.Drawing.Point(124, 21);
            this.checkBoxCreateGraphDirected.Name = "checkBoxCreateGraphDirected";
            this.checkBoxCreateGraphDirected.Size = new System.Drawing.Size(81, 17);
            this.checkBoxCreateGraphDirected.TabIndex = 6;
            this.checkBoxCreateGraphDirected.Text = "Skierowany";
            this.checkBoxCreateGraphDirected.UseVisualStyleBackColor = true;
            // 
            // buttonCreateNewGraph
            // 
            this.buttonCreateNewGraph.Location = new System.Drawing.Point(6, 45);
            this.buttonCreateNewGraph.Name = "buttonCreateNewGraph";
            this.buttonCreateNewGraph.Size = new System.Drawing.Size(70, 23);
            this.buttonCreateNewGraph.TabIndex = 4;
            this.buttonCreateNewGraph.Text = "Twórz";
            this.buttonCreateNewGraph.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 503);
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
        private System.Windows.Forms.TextBox textBoxKnapsackGreedy;
        private System.Windows.Forms.CheckBox checkBoxKnapsackGreedy;
        private System.Windows.Forms.CheckBox checkBoxKnapsackDynamic;
        private System.Windows.Forms.Button buttonKnapsackGreedy;
        private System.Windows.Forms.TextBox textBoxKnapsackDynamic;
        private System.Windows.Forms.Button buttonKnapsackDynamic;
        private System.Windows.Forms.Button buttonKnapsackStart;
        private System.Windows.Forms.GroupBox groupBoxSalesman;
        private System.Windows.Forms.TextBox textBoxSalesmanGreedy;
        private System.Windows.Forms.CheckBox checkBoxSalesmanGreedy;
        private System.Windows.Forms.CheckBox checkBoxSalesmanDynamic;
        private System.Windows.Forms.Button buttonSalesmanGreedy;
        private System.Windows.Forms.TextBox textBoxSalesmanDynamic;
        private System.Windows.Forms.Button buttonSalesmanDynamic;
        private System.Windows.Forms.Button buttonSalesman;
        private System.Windows.Forms.GroupBox groupBoxCreate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxCreateGraphDirected;
        private System.Windows.Forms.Button buttonCreateNewGraph;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxKnapsackBruteforce;
        private System.Windows.Forms.CheckBox checkBoxKnapsackBruteforce;
        private System.Windows.Forms.Button buttonKnapsackBruteforce;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBoxSalesmanBruteforce;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxSalesmanBruteforce;
        private System.Windows.Forms.Button buttonSalesmanBruteforce;
    }
}

