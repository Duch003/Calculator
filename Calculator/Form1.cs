using System;
using System.Windows.Forms;

namespace Calculator
{
    //Tutaj trzymam wartości poszczególnych działań
    enum Action : byte
    {
        Add = 43,
        Sub = 45,
        Mult = 42,
        Div = 47,
        Perc = 37, //Pricent rozumiany jest przez następującą konstrukcję: x% z liczby y
        Pow = 94,
        Root = 0
    }

    public partial class MainCalc : Form
    {
        Action act;
        string a, b;
        bool setAction, newMath;
        double valA, valB;

        public MainCalc()
        {
            InitializeComponent();
            act = new Action();
            setAction = newMath = false;

        }

        private void btnClick(object sender, EventArgs e)
        {   //Sprawdz czy nie jest wykonywane nowe działanie
            if(newMath)
            {
                resultBox.Text = null;
                newMath = false;
            }
            //Wypisywanie kliknięć na ekranie
            resultBox.Text = resultBox.Text + (sender as Button).Text;
            //W zależności od tego którą liczbę wpisujemy, tam zapisze się wartość
            //Wartość a
            if(setAction == false)
            {
                a = a + (sender as Button).Text;               
            }
            //Wartość b
            else if(setAction == true)
            {
                b = b + (sender as Button).Text;
                if(btn0.Enabled == false)
                {
                    btn0.Enabled = true;
                }
            }
        }
        //Odczyt i zapis odpowiedniego znaku działania
        private void btnClick_Action(object sender, EventArgs e)
        {   //Ochrona przed zmiana znaku lub wcisnieciem znaku bez liczby
            char s = 'a';
            if (setAction == true || a == null)
                return;

            //NISTANDARDOWE I DODATKOWE USTAWIENIA DLA POSZCZEGOLNYCH ZNAKÓW
            if ((sender as Button).Tag.ToString().Length == 0) //Jeżeli wciśnięty znak to root to przypisz akcję 0
                act = 0;
            else if(s == 47) //Jeżeli jest to znak dzielenia, zablokuj 0 (do czasu wciśnięcia innej cyfry)
                btn0.Enabled = false;
            else //W innym przypadku postępuj standardowo
            {
                s = Convert.ToChar((sender as Button).Tag);
                act = (Action)s;
            }   
            
            setAction = true;

            //OBSŁUGA WYŚWIETLACZA
            if(s == 37) //Jeżeli znak to procent, to nie dodawaj pierwszej spacji (dla lepszego pokazania działania)
                resultBox.Text = resultBox.Text + (sender as Button).Text + " z ";
            else if(act == 0) //Jeżeli znak to pierwiastkowanie, to dodaj znak hashtag
                resultBox.Text = resultBox.Text + " # ";
            else //W innym wypadku zrób zapis standardowy
                resultBox.Text = resultBox.Text + " " + (sender as Button).Tag + " ";
        }

        private void btnClick_Clear(object sender, EventArgs e)
        {
            Clear();
            resultBox.Text = null;
        }

        private void btnClick_Equal(object sender, EventArgs e)
        {
            try
            {
                if(a != null && b != null)
                {
                    valA = Convert.ToDouble(a);
                    valB = Convert.ToDouble(b);
                    switch (act)
                    {
                        case (Action)42: //Mnożenie
                            resultBox.Text = resultBox.Text + " = \n" + (valA * valB);
                            break;

                        case (Action)43: //Dodawanie
                            resultBox.Text = resultBox.Text + " = \n" + (valA + valB);
                            break;

                        case (Action)45: //Odejmowanie
                            resultBox.Text = resultBox.Text + " = \n" + (valA - valB);
                            break;

                        case (Action)47: //Dzielenie
                            resultBox.Text = resultBox.Text + " = \n" + (valA / valB);
                            break;

                        case (Action)37: //Procent
                            resultBox.Text = resultBox.Text + " = \n" + ((valA / 100) * valB);
                            break;

                        case (Action)94: //Potęgowanie
                            double ans = 1;
                            for(int i = 0; i < valB; i++)
                            {
                                ans = ans * valA;
                            }
                            resultBox.Text = resultBox.Text + " = \n" + ans;
                            break;

                        case (Action)0: //Pierwiastkowanie
                            if(valB == 2)
                                resultBox.Text = resultBox.Text + " = \n" + Math.Sqrt(valA);
                            else
                                resultBox.Text = resultBox.Text + " = \n" + Sqrt(valB, valA);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Któraś z wartości jest pusta!", "Błąd podczas obliczeń.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                string error = string.Format("Błąd podczas wyknywania obliczeń. Treśc błędu:\n {0}\n Źródło: {1}", ex.Message, ex.Source);
                MessageBox.Show(error, "Nieznany błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Clear();
            }
        }

        private void Clear()
        {
            b = null;
            a = null;
            setAction = false;
            newMath = true;
            valA = 0;
            valB = 0;
            btn0.Enabled = true;
        }

        //ALGORYTM PIERWIASTKOWANIA
        //Źródła:
        //1. https://pl.wikipedia.org/wiki/Algorytm_obliczania_pierwiastka_n-tego_stopnia
        //2. http://www.algorytm.org/algorytmy-arytmetyczne/obliczanie-pierwiastka-n-tego-stopnia.html
        private double Sqrt(double n, double A)
        {
            double[] x = new double[1];
            x[0] = Math.Abs(A);
            for(int k = 0; ; k++)
            {
                x = DynamicTab(x);
                x[k + 1] = (1 / n) * (((n - 1) * x[k]) + (A / (Math.Pow(x[k], n - 1))));
                if ((Math.Abs(x[k] - x[k + 1]) < 1))
                    return x[k + 1];
            }
        }
        //Mechanizm dynamicznej tablicy dla potrzeb algorytmu pierwiastkowania
        private double[] DynamicTab(double[] tab)
        {
            int length = tab.Length;
            double[] temp = tab;
            tab = new double[length + 1];
            for (int i = 0; i < temp.Length; i++)
                tab[i] = temp[i];
            
            return tab;
        }
    }
}
