using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cwiczenia28102024
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden; // Ukrycie przycisku
            MessageBox.Show("Witaj, świecie!");
            this.Visibility = Visibility.Visible; // Przywrócenie widoczności
        }

        private void btnActivate_Click(object sender, RoutedEventArgs e)
        {
            btnStart.IsEnabled = true; // Uaktywnienie przycisku Start
        }

        private void btnTime_MouseEnter(object sender, MouseEventArgs e)
        {
            DateTime data = DateTime.Now;
            btnTime.Content = data.ToString("T");
        }

        private void btnTime_MouseLeave(object sender, MouseEventArgs e)
        {
            btnTime.Content = "Czas";
        }

        private void btnYes_MouseEnter(object sender, MouseEventArgs e)
        {
            // Zamiana miejscami przycisków "Tak" i "Nie"
            var tempMargin = btnYes.Margin;
            btnYes.Margin = btnNo.Margin;
            btnNo.Margin = tempMargin;
        }
    }
}
