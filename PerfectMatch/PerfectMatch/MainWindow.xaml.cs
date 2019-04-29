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
        //private const string V = "Data Source=tcp:s19.winhost.com;Initial Catalog=DB_128040_group4;User ID=DB_128040_group4_user;Password=Group4%;Integrated Security=False;";
        DB_128040_group4DataSet db = new DB_128040_group4DataSet();
       
        bool flag = false;
        public MainWindow()
        {
            DB_128040_group4DataSet dB_128040_group4DataSet = (DB_128040_group4DataSet)FindResource("DB_128040_group4DataSet");
            DB_128040_group4DataSetTableAdapters.UserInfo1_TableAdapter dB_128040_group4DataSetUserInfo1_TableAdapter = new DB_128040_group4DataSetTableAdapters.UserInfo1_TableAdapter();
            dB_128040_group4DataSetUserInfo1_TableAdapter.Fill(dB_128040_group4DataSet._UserInfo1_);
            InitializeComponent();



        }




        public void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string firstName, gender, homeState, phone, university;
            int age;

            firstName = firstNameTextBox.Text;
            gender = genderTextBox.Text;
            homeState = homeStateTextBox.Text;
            university = universityTextBox.Text;
            phone = phoneTextBox.Text;
           age = Convert.ToInt32(ageTextBox.Text);
            //DB_128040_group4DataSet dB_128040_group4DataSet = (DB_128040_group4DataSet)FindResource("dB_128040_group4DataSet");
            // DB_128040_group4DataSetTableAdapters.UserInfo1_TableAdapter dB_128040_group4DataSetUserInfo1_TableAdapter = new DB_128040_group4DataSetTableAdapters.UserInfo1_TableAdapter();
            //dB_128040_group4DataSetUserInfo1_TableAdapter.Fill(dB_128040_group4DataSet._UserInfo1_);
            string connectionString;
            SqlConnection con;
            connectionString= @"Data Source=tcp:s19.winhost.com;Initial Catalog=DB_128040_group4;User ID=DB_128040_group4_user;Password=Group4%;Integrated Security=False";
            con = new SqlConnection(connectionString);




            List<DB_128040_group4DataSet> listUserInputs = new List<DB_128040_group4DataSet>();
            if (homeStateTextBox.Text==homeState)
            {

                CollectionViewSource _UserInfo1_ViewSource = (CollectionViewSource)FindResource("_UserInfo1_ViewSource");
                _UserInfo1_ViewSource.View.MoveCurrentToFirst();
            }

            //SqlConnection con = new SqlConnection(connectionString);

            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "select*from[UserModel]";
            //cmd.Connection = con;


            //SqlDataReader rd = cmd.ExecuteReader();
            //while (rd.Read())
            //{
            //    if (rd[1].ToString()==homeStateTextBox.Text)
            //    {
            //        flag = true;
            //        MessageBox.Show($"{_UserInfo1_DataGrid}");
            //        break;
            //    }

            //}
            //if (flag==true)
            //{

            //}

        }
        }
                
   

            
            //var userInformation = db.UserInfo1_.Include(UI.FirstName);
            //userInformation = db.UserInfo1_.Include(UI.Gender);
            //userInformation = db.UserInfo1_.Include(UI.HomeState);
            //userInformation = db.UserInfo1_.Include(UI.Phone);
            //userInformation = db.UserInfo1_.Include(UI.University);
            //        dataGridMatches.ItemsSource = user;
            //        dataGridMatches.Items.Add(UI.FirstName);
            //        dataGridMatches.Items.Add(UI.HomeState);
            //        dataGridMatches.Items.Add(UI.Phone);
            //        dataGridMatches.Items.Add(UI.Age);
            //        dataGridMatches.Items.Add(UI.University);
            //DB_128040_group4DataSet dB_128040_group4DataSet = (DB_128040_group4DataSet)FindResource("dB_128040_group4DataSet");
            //DB_128040_group4DataSetTableAdapters.UserInfo1_TableAdapter dB_128040_group4DataSetUserInfo1_TableAdapter = new DB_128040_group4DataSetTableAdapters.UserInfo1_TableAdapter();
            //dB_128040_group4DataSetUserInfo1_TableAdapter.Fill(dB_128040_group4DataSet._UserInfo1_);
            // CollectionViewSource _UserInfo1_ViewSource = (CollectionViewSource)FindResource("_UserInfo1_ViewSource");
            // _UserInfo1_ViewSource.View.MoveCurrentToFirst();
        }

  


        //PerfectMatch.DB_128040_group4DataSet dB_128040_group4DataSet = PerfectMatch.DB_128040_group4DataSet.FindResources("db_128040_group4DataSet"));
        //// Load data into the table _UserInfo1_. 
        //DB_128040_group4DataSetTableAdapters.UserInfo1_TableAdapter dB_128040_group4DataSetUserInfo1_TableAdapter = new DB_128040_group4DataSetTableAdapters.UserInfo1_TableAdapter();
        //dB_128040_group4DataSetUserInfo1_TableAdapter.Fill(dB_128040_group4DataSet._UserInfo1_);
        //CollectionViewSource _UserInfo1_ViewSource = (CollectionViewSource)FindResource("_UserInfo1_ViewSource");
        //_UserInfo1_ViewSource.View.MoveCurrentToFirst();
    
    
   





