using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            btnDot.Enabled = false;

        }

        //private void btnClick_dot(object sender, EventArgs e)
        //{
        //    resultBox.Text = resultBox.Text + (sender as Button).Text;
        //}

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
                valA = Convert.ToDouble(a);
            }
            //Wartość b
            else if(setAction == true)
            {
                b = b + (sender as Button).Text;
                valB = Convert.ToDouble(b);
                if(valB == 0 && (byte)act == 47)
                {
                    MessageBox.Show("Nie można dzielić przez zero!", "Błąd dzielenia.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    b = null;
                    a = null;
                    resultBox.Text = null;
                    setAction = false;
                }
            }
        }
        //Odczyt i zapis odpowiedniego znaku działania
        private void btnClick_Action(object sender, EventArgs e)
        {   //Ochrona przed zmiana znaku lub wcisnieciem znaku bez liczby
            if (setAction == true || a == null) 
                return;
            char s = Convert.ToChar((sender as Button).Text);
            act = (Action)s;
            if(s == 47) //Blokada 0 przy dzieleniu
                btn0.Enabled = false;
            setAction = true;
            resultBox.Text = resultBox.Text + " " + (sender as Button).Text + " ";
        }

        private void btnClick_Equal(object sender, EventArgs e)
        {
            try
            {
                if(a != null && b != null)
                {
                    switch(act)
                    {
                        case (Action)42: //Mnożenie
                            resultBox.Text = resultBox.Text + " = " + (valA * valB);
                            break;

                        case (Action)43: //Dodawanie
                            resultBox.Text = resultBox.Text + " = " + (valA + valB);
                            break;

                        case (Action)45: //Odejmowanie
                            resultBox.Text = resultBox.Text + " = " + (valA - valB);
                            break;

                        case (Action)47: //Dzielenie
                            resultBox.Text = resultBox.Text + " = " + (valA / valB);
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
                b = null;
                a = null;
                setAction = false;
                newMath = true;
                valA = 0;
                valB = 0;
                btn0.Enabled = true;
            }
        }
    }
}
