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
using SDiZO_3.Utility;

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
        private SalesmanAnnealing salesmanAnnealing;

        private Clock salesmanBruteforceClock;
        private Clock salesmanGreedyClock;
        private Clock salesmanTwoOptClock;
        private Clock salesmanAnnealingClock;

        private KnapsackData knapsackData;
        private KnapsackBruteforce knapsackBruteforce;
        private KnapsackGreedy knapsackGreedyW; // Zachłanny na wartość.
        private KnapsackGreedy knapsackGreedyR; // Zachłanny na stosunek wartość/waga.
        private KnapsackDynamic knapsackDynamic;

        private Clock knapsackBruteforceClock;
        private Clock knapsackGreedyWClock;
        private Clock knapsackGreedyRClock;
        private Clock knapsackDynamicClock;

        // Parametry wyżarzania.
        private double annealingTemperature;
        private double annealingCooling;

        // Repetycja.
        private int repeat;

        #endregion

        public FormMain()
        {
            InitializeComponent();

            //textBoxLoadDataFilename.Text = "tsp_6_2";
            //radioButtonLoadDataSalesman.Checked = true;

            //checkBoxSalesmanTwoOpt.Checked = true;
            //checkBoxSalesmanGreedy.Checked = true;
            //checkBoxSalesmanBruteforce.Checked = true;
            checkBoxSalesmanAnnealing.Checked = true;

            textBoxLoadDataFilename.Text = "ks_1";
            radioButtonLoadDataKnapsack.Checked = true;

            checkBoxKnapsackDynamic.Checked = true;
            checkBoxKnapsackGreedyW.Checked = true;
            checkBoxKnapsackGreedyR.Checked = true;
            checkBoxKnapsackBruteforce.Checked = true;

            textBoxDataGeneratorSize.Text = "100";
            textBoxDataGeneratorSizeKnapsack.Text = "100";
            radioButtonDataGeneratorKnapsack.Checked = true;

            
            annealingTemperature = 1000;
            annealingCooling = 0.99;

            textBoxSalesmanAnnealingTemperature.Text = "1000";
            textBoxSalesmanAnnealingCooling.Text = "0,99";
            textBoxSalesmanAnnealingIterations.Text = CalculateIterations(1000, 0.99).ToString();
            
            repeat = 1;
            textBoxRepeatCurrent.Text = repeat.ToString();
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
                    knapsackDynamic = new KnapsackDynamic(knapsackData);
                    knapsackDynamicClock = new Clock(knapsackDynamic);
                    for (int i = 0; i < repeat; i++)
                    {
                        knapsackDynamic = new KnapsackDynamic(knapsackData);
                        knapsackDynamicClock.Start();
                        knapsackDynamic.Work();
                        knapsackDynamicClock.Stop();
                    }
                    knapsackDynamicClock.End();
                    textBoxKnapsackDynamic.Text = knapsackDynamicClock.Average().ToString();
                }

                if (checkBoxKnapsackGreedyW.Checked)
                {
                    knapsackGreedyW = new KnapsackGreedy(knapsackData, true);
                    knapsackGreedyWClock = new Clock(knapsackGreedyW);
                    for (int i = 0; i < repeat; i++)
                    {
                        knapsackGreedyW = new KnapsackGreedy(knapsackData, true);
                        knapsackGreedyWClock.Start();
                        knapsackGreedyW.Work();
                        knapsackGreedyWClock.Stop();
                    }
                    knapsackGreedyWClock.End();
                    textBoxKnapsackGreedyW.Text = knapsackGreedyWClock.Average().ToString();
                }

                if (checkBoxKnapsackGreedyR.Checked)
                {
                    knapsackGreedyR = new KnapsackGreedy(knapsackData, false);
                    knapsackGreedyRClock = new Clock(knapsackGreedyR);
                    for (int i = 0; i < repeat; i++)
                    {
                        knapsackGreedyR = new KnapsackGreedy(knapsackData, false);
                        knapsackGreedyRClock.Start();
                        knapsackGreedyR.Work();
                        knapsackGreedyRClock.Stop();
                    }
                    knapsackGreedyRClock.End();
                    textBoxKnapsackGreedyR.Text = knapsackGreedyRClock.Average().ToString();

                }

                if (checkBoxKnapsackBruteforce.Checked)
                {
                    knapsackBruteforce = new KnapsackBruteforce(knapsackData);
                    knapsackBruteforceClock = new Clock(knapsackBruteforce);
                    for (int i = 0; i < repeat; i++)
                    {
                        knapsackBruteforce = new KnapsackBruteforce(knapsackData);
                        knapsackBruteforceClock.Start();
                        knapsackBruteforce.Work();
                        knapsackBruteforceClock.Stop();
                    }
                    knapsackBruteforceClock.End();
                    textBoxKnapsackBruteforce.Text = knapsackBruteforceClock.Average().ToString();
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
        // Wyświetlanie wyniku plecakowego - zachłanny na wartość.
        private void buttonKnapsackGreedyW_Click(object sender, EventArgs e)
        {
            if (knapsackGreedyW != null)
            {
                FormDisplay fD = new FormDisplay(knapsackGreedyW.ToString());
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
        // Wyświetlanie wyniku plecakowego - zachłanny na stosunek.
        private void buttonKnapsackGreedyR_Click(object sender, EventArgs e)
        {
            if (knapsackGreedyR != null)
            {
                FormDisplay fD = new FormDisplay(knapsackGreedyR.ToString());
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
        // Wyświetlanie wszytkich wyników - plecak.
        private void buttonKnapsackAll_Click(object sender, EventArgs e)
        {
            if (knapsackBruteforce != null)
            {
                FormDisplay fD = new FormDisplay(knapsackBruteforce.ToString());
                fD.Show();
            }
            if (knapsackGreedyW != null)
            {
                FormDisplay fD = new FormDisplay(knapsackGreedyW.ToString());
                fD.Show();
            }
            if (knapsackGreedyR != null)
            {
                FormDisplay fD = new FormDisplay(knapsackGreedyR.ToString());
                fD.Show();
            }
            if (knapsackDynamic != null)
            {
                FormDisplay fD = new FormDisplay(knapsackDynamic.ToString());
                fD.Show();
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
                        salesmanTwoOptClock = new Clock(salesmanTwoOpt);
                        salesmanTwoOptClock.Start();
                        salesmanTwoOpt.Work();
                        salesmanTwoOptClock.Stop();
                    }
                    salesmanTwoOptClock.End();
                    textBoxSalesmanTwoOpt.Text = salesmanTwoOptClock.Average().ToString();
                }

                if (checkBoxSalesmanGreedy.Checked)
                {
                    for (int i = 0; i < repeat; i++)
                    {
                        salesmanGreedy = new SalesmanGreedy(salesmanData);
                        salesmanGreedyClock = new Clock(salesmanGreedy);
                        salesmanGreedyClock.Start();
                        salesmanGreedy.Work();
                        salesmanGreedyClock.Stop();
                    }
                    salesmanGreedyClock.End();
                    textBoxSalesmanGreedy.Text = salesmanGreedyClock.Average().ToString();
                }

                if (checkBoxSalesmanBruteforce.Checked)
                {
                    for (int i = 0; i < repeat; i++)
                    {
                        salesmanBruteforce = new SalesmanBruteforce(salesmanData);
                        salesmanBruteforceClock = new Clock(salesmanBruteforce);
                        salesmanBruteforceClock.Start();
                        salesmanBruteforce.Work();
                        salesmanBruteforceClock.Stop();
                    }
                    salesmanBruteforceClock.End();
                    textBoxSalesmanBruteforce.Text = salesmanBruteforceClock.Average().ToString();
                }

                if (checkBoxSalesmanAnnealing.Checked)
                {
                    for (int i = 0; i < repeat; i++)
                    {
                        salesmanAnnealing = new SalesmanAnnealing(salesmanData, annealingTemperature, annealingCooling);
                        salesmanAnnealingClock = new Clock(salesmanAnnealing);
                        salesmanAnnealingClock.Start();
                        salesmanAnnealing.Work();
                        salesmanAnnealingClock.Stop();
                    }
                    salesmanAnnealingClock.End();
                    textBoxSalesmanAnnealing.Text = salesmanAnnealingClock.Average().ToString();
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
        // Wyświetlanie wyniku komiwojażera - wyżarzanie.
        private void buttonSalesmanAnnealing_Click(object sender, EventArgs e)
        {
            if (salesmanAnnealing != null)
            {
                FormDisplay fD = new FormDisplay(salesmanAnnealing.ToString());
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
        // Wyświetlanie wszystkich wyników - komiwjoażer.
        private void buttonSalesmanAll_Click(object sender, EventArgs e)
        {
            if (salesmanBruteforce != null)
            {
                FormDisplay fD = new FormDisplay(salesmanBruteforce.ToString());
                fD.Show();
            }
            if (salesmanTwoOpt != null)
            {
                FormDisplay fD = new FormDisplay(salesmanTwoOpt.ToString());
                fD.Show();
            }
            if (salesmanGreedy != null)
            {
                FormDisplay fD = new FormDisplay(salesmanGreedy.ToString());
                fD.Show();
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
                if (knapsackData != null)
                {
                    //knapsackData = new KnapsackData(InputList);
                    FormDisplay fD = new FormDisplay(knapsackData.ToString());
                    fD.Show();
                }
            }
            else
            {
                if (salesmanData != null)
                {
                    //salesmanData = new SalesmanData(InputList);
                    FormDisplay fD = new FormDisplay(salesmanData.ToString());
                    fD.Show();
                }
            }
        }
        //
        //
        // Zmiana koloru textBox z nazwą pliku przy zmianie tekstu.
        private void textBoxLoadDataFilename_TextChanged(object sender, EventArgs e)
        {
            textBoxLoadDataFilename.BackColor = SystemColors.Window;
        }
        #endregion
        //
        //
        // Tworzenie danych.
        private void buttonDataGenerator_Click(object sender, EventArgs e)
        {
            if (radioButtonDataGeneratorKnapsack.Checked)
            {
                int size;
                if (!int.TryParse(textBoxDataGeneratorSize.Text, out size))
                {
                    MessageBox.Show("Nieprawidłowa liczba", "Błąd",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    knapsackData = null;
                    return;
                }
                int sizeKnapsack;
                if (!int.TryParse(textBoxDataGeneratorSizeKnapsack.Text, out sizeKnapsack))
                {
                    MessageBox.Show("Nieprawidłowa liczba", "Błąd",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    knapsackData = null;
                    return;
                }

                knapsackData = new KnapsackData(DataGenerator.Knapsack(size, sizeKnapsack));
                radioButtonLoadDataKnapsack.Checked = true;
            }
            else
            {
                int size;
                if (!int.TryParse(textBoxDataGeneratorSize.Text, out size))
                {
                    MessageBox.Show("Nieprawidłowa liczba", "Błąd",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salesmanData = null;
                    return;
                }

                salesmanData = new SalesmanData(DataGenerator.Salesman(size));
                radioButtonLoadDataSalesman.Checked = true;
            }
            textBoxLoadDataFilename.BackColor = Color.MediumAquamarine;
            textBoxLoadDataFilename.Text = "RANDOM";
        }
        //
        //
        // Zmiana mnożnika
        private void buttonRepeatChange_Click(object sender, EventArgs e)
        {
            int repeatNew;
            if (!int.TryParse(textBoxRepeatNew.Text, out repeatNew))
            {
                MessageBox.Show("Nieprawidłowy mnożnik", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                InputList = null;
                return;
            }
            repeat = repeatNew;
            textBoxRepeatCurrent.Text = repeat.ToString();
            textBoxRepeatNew.Text = "";
        }
        //
        //
        // Zmiana koloru textBox z temperaturą przy zmianie tekstu.
        private void textBoxSalesmanAnnealingTemperature_TextChanged(object sender, EventArgs e)
        {
            textBoxSalesmanAnnealingTemperature.BackColor = SystemColors.Window;
            textBoxSalesmanAnnealingIterations.BackColor = SystemColors.Window;
        }
        //
        //
        // Zmiana koloru textBox z mnożnikiem chłodzenia przy zmianie tekstu.
        private void textBoxSalesmanAnnealingCooling_TextChanged(object sender, EventArgs e)
        {
            textBoxSalesmanAnnealingCooling.BackColor = SystemColors.Window;
            textBoxSalesmanAnnealingIterations.BackColor = SystemColors.Window;
        }
        //
        //
        // Zapis parametrów wyżarzania.
        private void buttonSalesmanAnnealingSave_Click(object sender, EventArgs e)
        {
            double newCooling;
            double newTemperature;
            if (!double.TryParse(textBoxSalesmanAnnealingCooling.Text, out newCooling))
            {
                MessageBox.Show("Nieprawidłowy mnożnik chłodzenia", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSalesmanAnnealingCooling.BackColor = Color.MediumVioletRed;
                newCooling = 0;
            }
            else
            {
                if (!(newCooling < 1))
                {
                    textBoxSalesmanAnnealingCooling.BackColor = Color.MediumVioletRed;
                    newCooling = 0;
                }
                textBoxSalesmanAnnealingCooling.BackColor = Color.MediumAquamarine;
            }


            if (!double.TryParse(textBoxSalesmanAnnealingTemperature.Text, out newTemperature))
            {
                MessageBox.Show("Nieprawidłowa temperatura", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSalesmanAnnealingTemperature.BackColor = Color.MediumVioletRed;
                newTemperature = 0;
            }
            else
            {
                textBoxSalesmanAnnealingTemperature.BackColor = Color.MediumAquamarine;
            }

            if (newTemperature > 0 && newCooling > 0)
            {
                annealingCooling = newCooling;
                annealingTemperature = newTemperature;
                textBoxSalesmanAnnealingIterations.Text = CalculateIterations(newTemperature, newCooling).ToString();
                textBoxSalesmanAnnealingIterations.BackColor = Color.MediumAquamarine;
            }
        }
        //
        //
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

        // Szacowanie ilości iteracji dla wyżarzania.
        private int CalculateIterations(double temperature, double cooling)
        {
            // Bardzo prymitywne.
            int counter = 0;
            while (temperature > 0.001)
            {
                temperature *= cooling;
                counter++;
            }
            return counter;
        }

        #endregion


    }
}
