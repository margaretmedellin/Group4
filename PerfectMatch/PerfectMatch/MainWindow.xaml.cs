using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Data.SqlClient;

namespace PerfectMatch
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool match = false;
        DB_128040_group4Entities db = new DB_128040_group4Entities();
        UserInfo user = new UserInfo();
        public MainWindow()
        {
            InitializeComponent();
        }
        public void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            CreateNewUser();

            foreach (var u in db.UserInfoes)
            {
                if (user.Gender != u.Gender && user.HomeState == u.HomeState)
                {
                    lstMatches.Items.Add(u);
                    match = true;
                }
            }
        }

        private void CreateNewUser()
        {
            string firstName, gender, homeState, phone, university, profilePic;
            int age;

            firstName = firstNameTextBox.Text;
            gender = genderTextBox.Text;
            homeState = homeStateTextBox.Text;
            university = universityTextBox.Text;
            phone = phoneTextBox.Text;
            age = Convert.ToInt32(ageTextBox.Text);
            profilePic = urlprofile.Text;

            user.Age = age;
            user.FirstName = firstName;
            user.Gender = gender;
            user.HomeState = homeState;
            user.Phone = phone;
            user.ProfilePic = profilePic;

          //  db.UserInfoes.Add(user);

           // db.SaveChanges();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void LstMatches_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
          
                MatchWindow window = new MatchWindow();
            UserInfo u = (UserInfo)lstMatches.SelectedItem;
            window.txtMatchName.Text = u.FirstName;
            window.txtUniversity.Text = u.University;
            window.txtHometown.Text = u.HomeState;
            window.txtGender.Text = u.Gender;
            window.txtContact.Text = u.Phone;
            //u.Age = Convert.ToInt32(window.txtAge.);
            //window.imgMatch.Source = u.ProfilePic;

            window.Show();
            }
        }
    }















