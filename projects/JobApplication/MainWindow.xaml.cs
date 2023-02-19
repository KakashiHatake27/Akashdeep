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
using System.IO;

namespace JobApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Job j = new Job();


        public MainWindow()
        {
            InitializeComponent();

            //j.surName = "Marston";
            j.email = "user@example.com";

            this.DataContext = j;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            if ((tbName == null) || (tbSurname == null) || (tbEmail == null) || (cmbEdu.SelectedIndex==0))
            { MessageBox.Show("Please enter all details"); }
            else
            {

                getCampus();

                string message = "\nStudent name: " + j.name
                             + "\nStudent Surname: " + j.surName
                             + "\nEmail: " + j.email
                             + "\nEducation: " + j.education
                             + "\nCampus: " + j.campus;

                saveData(message);

                MessageBox.Show("The Data has been Saved!");
            }
        }

        private void cmbEdu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbEdu.SelectedItem != null)
            {
                ComboBoxItem cbi = (ComboBoxItem)cmbEdu.SelectedItem;
                j.education = cbi.Content.ToString();


            }
        }

        private void getCampus() {

            if (chkDurban.IsChecked == true)
            {

                j.campus = "Durban";
            }
            else if (chkEL.IsChecked == true) { j.campus = "East London"; }

            else if (chkPE.IsChecked == true) { j.campus = "Port Elizabeth"; }

            else if (chkPretoria.IsChecked == true) { j.campus = "Pretoria"; }

            else if (chkSandton.IsChecked == true) { j.campus = "Sandton"; }

            else if (chkWestville.IsChecked == true) { j.campus = "Westville"; }

        }


        private void saveData(string data) {
            File.WriteAllText("Applicant.txt", data);

        }



    }
}
