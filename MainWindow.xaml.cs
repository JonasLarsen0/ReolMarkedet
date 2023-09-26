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
using ReolMarkedet.Application;

namespace ReolMarkedet
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
        RenterRepository renterRepository = new RenterRepository();


        private void CreateRenter_Click(object sender, RoutedEventArgs e)
        {

            renterRepository.CreateRenter(nameTextBox.Text, tlfNrTextBox.Text, emailTextBox.Text, regnrTextBox.Text+kontoNrTextBox.Text);
            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            nameTextBox.Clear();
            tlfNrTextBox.Clear();
            emailTextBox.Clear();
            regnrTextBox.Clear();
            kontoNrTextBox.Clear();
        }

        private void UpdateRenterButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    public class ControllerClass
    {
    
        public void test()
        {

        }
    }
    
   }
