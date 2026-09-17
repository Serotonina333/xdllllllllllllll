using System;
using System.Windows;
using System.Windows.Controls;

namespace kalkulator
{
    public partial class MainWindow : Window
    {
        private double _pierwszaLiczba = 0;
        private string _operator = "";
        private bool czyNowaLiczba = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string cyfra = button.Content.ToString();

            if (txtWynik.Text == "0" || czyNowaLiczba)
            {
                txtWynik.Text = cyfra;
                czyNowaLiczba = false;
            }
            else
            {
                txtWynik.Text += cyfra;
            }
        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (!czyNowaLiczba && _operator != "")
            {
                Oblicz();
            }

            double.TryParse(txtWynik.Text, out _pierwszaLiczba);
            _operator = button.Content.ToString();
            czyNowaLiczba = true;
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            Oblicz();
            _operator = "";
            czyNowaLiczba = true;
        }

        private void Oblicz()
        {
            double drugaLiczba;
            double.TryParse(txtWynik.Text, out drugaLiczba);
            double wynik = 0;

            switch (_operator)
            {
                case "+": wynik = _pierwszaLiczba + drugaLiczba; break;
                case "-": wynik = _pierwszaLiczba - drugaLiczba; break;
                case "*": wynik = _pierwszaLiczba * drugaLiczba; break;
                case "/":
                    if (drugaLiczba == 0)
                    {
                        MessageBox.Show("Nie można dzielić przez zero!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                        ClearAll();
                        return;
                    }
                    wynik = _pierwszaLiczba / drugaLiczba;
                    break;
                default: return;
            }

            txtWynik.Text = wynik.ToString();
            _pierwszaLiczba = wynik;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtWynik.Text = "0";
            _pierwszaLiczba = 0;
            _operator = "";
            czyNowaLiczba = true;
        }

        private void ClearEntry_Click(object sender, RoutedEventArgs e)
        {
            txtWynik.Text = "0";
            czyNowaLiczba = true;
        }

        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            if (txtWynik.Text.Length > 1)
            {
                txtWynik.Text = txtWynik.Text.Substring(0, txtWynik.Text.Length - 1);
            }
            else
            {
                txtWynik.Text = "0";
                czyNowaLiczba = true;
            }
        }

        private void Sign_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtWynik.Text, out double liczba))
            {
                liczba = -liczba;
                txtWynik.Text = liczba.ToString();
            }
        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            if (czyNowaLiczba)
            {
                txtWynik.Text = "0,";
                czyNowaLiczba = false;
            }
            else if (!txtWynik.Text.Contains(","))
            {
                txtWynik.Text += ",";
            }
        }
    }
}
