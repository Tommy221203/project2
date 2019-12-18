using System;
using System.Collections.Generic;
using System.IO;
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

namespace project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private const string file_name = "txtfile";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var nome = txtnome.Text;
            var cognome = txtcognome.Text;
            var data = date.SelectedDate;

            if (string.IsNullOrWhiteSpace(txtnome.Text)||string.IsNullOrWhiteSpace (txtcognome.Text)||date.SelectedDate ==null)
                {
                    MessageBox.Show("Inserire tutti i campi");
                }
            else if (data < DateTime.Now)
            {
                MessageBox.Show($"Ciao {nome} {cognome}, nato il é {data}");
               
            }
            else
            {
                MessageBox.Show("Non puoi essere nato nel futuro");
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            btnprint.IsEnabled = true;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            btnprint.IsEnabled = false;
        }

        private void btnprint_Click(object sender, RoutedEventArgs e)
        {
            var nome = txtnome.Text;
            var cognome = txtcognome.Text;
            var data = date.SelectedDate;
            using (StreamWriter c = new StreamWriter(file_name, true))
            {
                c.WriteLine($"{nome} {cognome} {data}");
            }
        }
    }
}
