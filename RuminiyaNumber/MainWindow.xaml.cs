using RuminiyaNumberLibrary;
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

namespace RuminiyaNumber
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        RuminiyaNumberClass obj = new RuminiyaNumberClass();
        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            GeneratedCNP.Text = obj.ReturnNumber(Convert.ToDateTime(BirthDatePicker.SelectedDate), 10, Convert.ToBoolean(MaleRadio.IsChecked), SurnameTextBox.Text, Convert.ToBoolean(ResidentRadio.IsChecked));
        }
    }
}
