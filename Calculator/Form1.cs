using System;
using System.Windows.Forms;

namespace Calculator
{
    //Tutaj trzymam wartości poszczególnych działań w oparciu o tablicę ascii
    enum Action : byte
    {
        Add = 43,  // +
        Sub = 45,  // -
        Mult = 42, // *
        Div = 47,  // /
        Perc = 37, // % rozumiany jest przez następującą konstrukcję: x% z liczby y
        Pow = 94,  // ^
        Sqrt = 35, // #
        Equal = 61,// =
        Clear = 126// ~
    }

    public partial class MainCalc : Form
    {
        Action act;
        string a, b;
        bool setAction, newMath; //Warunki kolejno: czy jest ustawiony znak działania, czy rozpocząto nowe działanie
        double valA, valB;

        public MainCalc()
        {
            InitializeComponent();
            act = new Action();
            setAction = newMath = false;
            KeyPreview = true;
            btnDot.Enabled = false;
            btnDot.BackColor = System.Drawing.Color.LightGray;
        }

        //PRZYCISKI W OKNIE KALKULATORA
        //TUTAJ OBOWIĄZUJE TABLICA ASCII
        private void btnClick(object sender, EventArgs e)
        {
            char value = Convert.ToChar((sender as Button).Tag);
            if ((value >= 48 && value <= 57) || value == 44)
            {
                Number(value);
            }
            else if (value == 35 || value == 43 || value == 45 || value == 42 || value == 47 || value == 37 || value == 94)
            {
                Sign(value);
            }
            else if(value == 61)
            {
                if (Convert.ToDouble(b) == 0)
                {
                    string error = string.Format("Nie można dzielić przez 0!");
                    MessageBox.Show(error, "Dzielenie przez 0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    return;
                }
                Solve();
            }
            else if(value == 126) //Znak ~
            {
                Clear();
                resultBox.Text = null;
            }
            
        }

        //PRZYCISKI NA KLAWIATURZE
        //TUTAJ OBOWIĄZUJE OZNAKOWANIE PRZYCISKÓW NA KLAWIATURZE
        //e.KeyChar zwraca znak przekonwertowany już na ascii
        //Źródło: https://www.w3.org/2002/09/tests/keys-cancel2.html
        private void KeyboardKeyClick(object sender, KeyPressEventArgs e)
        {   // 0 - 9, lub precinek
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 44)
            {
                Number(e.KeyChar);               
            }
            else if(e.KeyChar == 35 || e.KeyChar == 43 || e.KeyChar == 45 || e.KeyChar == 42 || e.KeyChar == 47 || e.KeyChar == 37 || e.KeyChar == 94)
            {
                Sign(e.KeyChar);
            }
            else if(e.KeyChar == 13) //Znaki ENTER i numENTER, są to znaki /r, nowej linii
            {
                if(Convert.ToDouble(b) == 0)
                {
                    string error = string.Format("Nie można dzielić przez 0!");
                    MessageBox.Show(error, "Dzielenie przez 0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    return;
                }
                Solve(); 
            }
            else if(e.KeyChar == 27) //Znak ESC
            {
                Clear();
                resultBox.Text = null;
            }
            e.Handled = true;
        }

        private void Sign(char value)
        {
            //Ochrona przed zmiana znaku lub wcisnieciem znaku bez liczby
            if (setAction == true || a == null)
                return;

            act = (Action)value;

            //Oznaczenie setAction powoduje że następne cyfry są traktowane jako druga wartość
            setAction = true;

            //OBSŁUGA WYŚWIETLACZA
            if (value == 37) //Jeżeli znak to procent, to nie dodawaj pierwszej spacji (dla lepszego pokazania działania)
                resultBox.Text = resultBox.Text + value + " z ";
            else //W innym wypadku zrób zapis standardowy
                resultBox.Text = resultBox.Text + " " + value + " ";
        }

        private void Number(char value)
        {
            //Zabezpeiczenie przed wciśnięciem znaku kropki przed wpisaniem pierwszej cyfry
            //Oraz przed wpisaniem zera po znaku dzielenia
            if ((btnDot.Enabled == false && (value == 44 || value == 46)) || (value == 48 && btn0.Enabled == false))
            {
                return;
            }
            //Sprawdz czy nie jest wykonywane nowe działanie
            if (newMath)
            {
                resultBox.Text = null;
                newMath = false;
            }
            //OBSŁUGA WYŚWIETLACZA
            resultBox.Text = resultBox.Text + value;

            //W zależności od tego którą liczbę wpisujemy, tam zapisze się wartość
            //Wartość a
            if (setAction == false)
            {
                a = a + value;
                if(btnDot.Enabled == false)
                {
                    btnDot.Enabled = true;
                    btnDot.BackColor = System.Drawing.Color.CornflowerBlue;
                }
            }
            //Wartość b
            else if (setAction == true)
            {
                b = b + value;
            }
        }

        private void Solve()
        {
            try
            {
                if (a != null && b != null)
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
                            for (int i = 0; i < valB; i++)
                            {
                                ans = ans * valA;
                            }
                            resultBox.Text = resultBox.Text + " = \n" + ans;
                            break;

                        case (Action)35: //Pierwiastkowanie
                            if (valB == 2)
                                resultBox.Text = resultBox.Text + " = \n" + Math.Sqrt(valA);
                            else
                                resultBox.Text = resultBox.Text + " = \n" + Sqrt(valB, valA);
                            break;
                    }
                }
                else
                {
                    string error = string.Format("Któraś z wartości jest pusta!\nWartość a: {0}\nWartość b: {1}", a, b);
                    MessageBox.Show(error, "Błąd podczas obliczeń.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                string error = string.Format("Błąd podczas wyknywania obliczeń. Treśc błędu:\n {0}\n Źródło: {1}", ex.Message, ex.Source);
                MessageBox.Show(error, "Nieznany błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Clear();
            }
        }

        private new void MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.ForestGreen;
        }

        private new void MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.CornflowerBlue;
        }

        private void ReFocus(object sender, EventArgs e)
        {
            resultBox.Focus();
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
            btnDot.Enabled = false;
            btnDot.BackColor = System.Drawing.Color.LightGray;
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
                if ((Math.Abs(x[k] - x[k + 1]) < 1)) //Dokładność obliczeń (0 = maks dokładność, nie działa)
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
