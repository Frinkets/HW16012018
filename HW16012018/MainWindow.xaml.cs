using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
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

namespace HW16012018
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _connectionString = "";
       

        public MainWindow()
        {
            InitializeComponent();
            _connectionString = @"Initial Catalog=AFStudio;Data Source=AF-PC\SQLEXPRESS;Integrated Security=SSPI;";
        }

        private void GetUsers_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(_connectionString);

            SqlDataAdapter da = new SqlDataAdapter("Select * from dic_Model", con);

            //DataSet ds = new DataSet();

            //da.Fill(ds);
            //da.Fill(ds, "ModelId");
           

            //ModelListView.ItemsSource = ds.Tables["Table"].Rows;
            foreach(var item in ds.Tables["Table"].Rows)
            {
             s sn = new s();
                  sn.svoistvo1 = item.Array[2]; 
            }
            
            DataTableMapping tblMap;
            DataColumnMapping colMap;
            tblMap = da.TableMappings.Add("Table", "dic_Model");

            colMap = tblMap.ColumnMappings.Add("ModelId", "ModelId");
            

       

          

        }
        public class s
        {   
            int svoistvo1;
            int svoistvo2;
        
        }

    }
}
