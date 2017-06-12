using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDiZO_3.Knapsack;
using SDiZO_3.Salesman;

namespace SDiZO_3
{
    public partial class FormMain : Form
    {
        // ######## ######## ######## ######## Zmienne
        #region

        // Lista zawierająca dane wejściowe.
        public List<int> InputList { get; private set; }

        // Boolean określający czy wczytane dane są dla plecaka czy dla komiwojażera.
        // True     -> plecak
        // False    -> komiwojażer
        private bool inputKnapsack;

        // Algorytmy, ich zegary i dane.
        private SalesmanData salesmanData;
        private SalesmanBruteforce salesmanBruteforce;
        private SalesmanGreedy salesmanGreedy;
        private SalesmanTwoOpt salesmanTwoOpt;

        private KnapsackData knapsackData;
        private KnapsackBruteforce knapsackBruteforce;
        private KnapsackGreedy knapsackGreedy;
        private KnapsackDynamic knapsackDynamic;

        // Repetycja.
        private int repeat;

        #endregion

        public FormMain()
        {
            InitializeComponent();
            textBoxLoadDataFilename.Text = "tsp_6_2";
            //radioButtonLoadDataKnapsack.Checked = true;
            radioButtonLoadDataSalesman.Checked = true;
            //checkBoxKnapsackDynamic.Checked = true;
            //checkBoxKnapsackGreedy.Checked = true;
            checkBoxSalesmanTwoOpt.Checked = true;
            checkBoxSalesmanGreedy.Checked = true;
            checkBoxSalesmanBruteforce.Checked = true;
            repeat = 1;
        }

        // ######## ######## ######## ######## Przyciski
        #region
        // Start plecakowego.
        private void buttonKnapsackStart_Click(object sender, EventArgs e)
        {
            if (knapsackData != null)
            {
                if (checkBoxKnapsackDynamic.Checked)
                {
                    for (int i = 0; i < repeat; i++)
                    {
                        knapsackDynamic = new KnapsackDynamic(knapsackData);
                        knapsackDynamic.Work();
                    }

                }

                if (checkBoxKnapsackGreedy.Checked)
                {
                    bool mode;
                    if (radioButtonKnapsackGreedyWeight.Checked)
                    {
                        mode = true;
                    }
                    else
                    {
                        mode = false;
                    }
                    for (int i = 0; i < repeat; i++)
                    {
                        knapsackGreedy = new KnapsackGreedy(knapsackData, mode);
                        knapsackGreedy.Work();
                    }

                }

                if (checkBoxKnapsackBruteforce.Checked)
                {
                    for (int i = 0; i < repeat; i++)
                    {
                        knapsackBruteforce = new KnapsackBruteforce(knapsackData);
                        knapsackBruteforce.Work();
                    }
                }
            }
            else
            {
                MessageBox.Show("Dane nie zostały wczytane!", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        //
        // Wyświetlanie wyniku plecakowego - przegląd zupełny.
        private void buttonKnapsackBruteforce_Click(object sender, EventArgs e)
        {
            if (knapsackBruteforce != null)
            {
                FormDisplay fD = new FormDisplay(knapsackBruteforce.ToString());
                fD.Show();
            }
            else
            {
                MessageBox.Show("Nie ma czego wyświetlać!", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        //
        // Wyświetlanie wyniku plecakowego - zachłanny.
        private void buttonKnapsackGreedy_Click(object sender, EventArgs e)
        {
            if (knapsackGreedy != null)
            {
                FormDisplay fD = new FormDisplay(knapsackGreedy.ToString());
                fD.Show();
            }
            else
            {
                MessageBox.Show("Nie ma czego wyświetlać!", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        //
        // Wyświetlanie wyniku plecakowego - programowanie dynamiczne.
        private void buttonKnapsackDynamic_Click(object sender, EventArgs e)
        {
            if (knapsackDynamic != null)
            {
                FormDisplay fD = new FormDisplay(knapsackDynamic.ToString());
                fD.Show();
            }
            else
            {
                MessageBox.Show("Nie ma czego wyświetlać!", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        //
        // Start komiwojażera.
        private void buttonSalesman_Click(object sender, EventArgs e)
        {
            if (salesmanData != null)
            {
                if (checkBoxSalesmanTwoOpt.Checked)
                {
                    for (int i = 0; i < repeat; i++)
                    {
                        salesmanTwoOpt = new SalesmanTwoOpt(salesmanData);
                        salesmanTwoOpt.Work();
                    }
                }

                if (checkBoxSalesmanGreedy.Checked)
                {
                    for (int i = 0; i < repeat; i++)
                    {
                        salesmanGreedy = new SalesmanGreedy(salesmanData);
                        salesmanGreedy.Work();
                    }
                }

                if (checkBoxSalesmanBruteforce.Checked)
                {
                    for (int i = 0; i < repeat; i++)
                    {
                        salesmanBruteforce = new SalesmanBruteforce(salesmanData);
                        salesmanBruteforce.Work();
                    }
                }

            }
            else
            {
                MessageBox.Show("Dane nie zostały wczytane!", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        //
        // Wyświetlanie wyniku komiwojażera - przegląd zupełny.
        private void buttonSalesmanBruteforce_Click(object sender, EventArgs e)
        {
            if (salesmanBruteforce != null)
            {
                FormDisplay fD = new FormDisplay(salesmanBruteforce.ToString());
                fD.Show();
            }
            else
            {
                MessageBox.Show("Nie ma czego wyświetlać!", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        //
        // Wyświetlanie wyniku komiwojażera - zachłanny.
        private void buttonSalesmanGreedy_Click(object sender, EventArgs e)
        {
            if (salesmanGreedy != null)
            {
                FormDisplay fD = new FormDisplay(salesmanGreedy.ToString());
                fD.Show();
            }
            else
            {
                MessageBox.Show("Nie ma czego wyświetlać!", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        //
        // Wyświetlanie wyniku komiwojażera - programowanie dynamiczne.
        private void buttonSalesmanTwoOpt_Click(object sender, EventArgs e)
        {
            if (salesmanTwoOpt != null)
            {
                FormDisplay fD = new FormDisplay(salesmanTwoOpt.ToString());
                fD.Show();
            }
            else
            {
                MessageBox.Show("Nie ma czego wyświetlać!", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        //
        // Wczytywanie danych.
        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            ReadFile(textBoxLoadDataFilename.Text);
            if (radioButtonLoadDataKnapsack.Checked)
            {
                knapsackData = new KnapsackData(InputList);
            }
            else
            {
                salesmanData = new SalesmanData(InputList);
            }
        }
        //
        //
        // Wyświetlanie wczytanych danych.
        private void buttonDisplayData_Click(object sender, EventArgs e)
        {
            if (radioButtonLoadDataKnapsack.Checked)
            {

                knapsackData = new KnapsackData(InputList);
                FormDisplay fD = new FormDisplay(knapsackData.ToString());
                fD.Show();
            }
            else
            {

                salesmanData = new SalesmanData(InputList);
                FormDisplay fD = new FormDisplay(salesmanData.ToString());
                fD.Show();
            }
        }
        #endregion





        // ######## ######## ######## ######## Funkcje
        #region

        // Wczytywanie z pliku.
        private void ReadFile(string filename)
        {
            try
            {
                using (StreamReader sr = new StreamReader(@".\" + filename + ".txt"))
                {
                    //  ASCII   symbol
                    //  48      0
                    //  57      9
                    InputList = new List<int>();
                    int amount = 0;
                    while (!sr.EndOfStream)
                    {
                        string number = "";
                        int character = sr.Read();
                        while (character >= 48 && character <= 57)
                        {
                            number += (char)character;
                            character = sr.Read();
                        }

                        if (number != "")
                        {
                            int intNumber;
                            if (!int.TryParse(number, out intNumber))
                            {
                                MessageBox.Show("Nieprawidłowa liczba", "Błąd",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                InputList = null;
                                return;
                            }
                            InputList.Add(intNumber);
                        }

                    }

                    // Plik załadowany -> zielony kolor.
                    textBoxLoadDataFilename.BackColor = Color.MediumAquamarine;
                    inputKnapsack = radioButtonLoadDataKnapsack.Checked;

                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString(), "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Plik nie został załadowany -> czerwony kolor.
                this.BackColor = Color.MediumVioletRed;
                throw;
            }

        }

        #endregion


    }
}
