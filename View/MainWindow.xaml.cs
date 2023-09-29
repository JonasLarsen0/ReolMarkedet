using System;
using System.Collections.Generic;
using System.Data;
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
using Microsoft.Data.SqlClient;
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
        Controller controller = new Controller();


        private void CreateRenter_Click(object sender, RoutedEventArgs e)
        {
            
            controller.AddRenter(nameTextBox.Text, tlfNrTextBox.Text, emailTextBox.Text, regnrTextBox.Text+kontoNrTextBox.Text);

            using (SqlConnection con = new SqlConnection(controller.ConnectionString)) 
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"spAddRenter", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RenterName", nameTextBox.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", tlfNrTextBox.Text);
                cmd.Parameters.AddWithValue("@Email", emailTextBox.Text);
                cmd.Parameters.AddWithValue("@BankAccountDetails", regnrTextBox.Text + kontoNrTextBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();

            }
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

    }

    
    
   }
