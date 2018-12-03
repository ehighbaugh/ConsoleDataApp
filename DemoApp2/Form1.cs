using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DemoApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            cnn = new SqlConnection(connectionString);

            cnn.Open();

            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "Update dbo.Employees set LastName='" + "Devolio" + "' where EmployeeID=1";

            cmd = new SqlCommand(sql, cnn);

            adapter.UpdateCommand = new SqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();

            cmd.Dispose();
            cnn.Close();

            //sql = "Select EmployeeId,LastName,FirstName from dbo.Employees";

            //cmd = new SqlCommand(sql, cnn);

            //dataReader = cmd.ExecuteReader();
            //while (dataReader.Read())
            //{
            //    Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2) + "\n";
            //}

            // inserts new record into database
            //SqlCommand cmd2;
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //String sql2 = "";

            //sql = "Insert into dbo.Employees (FirstName,LastName) values('Erin'," + "'Highbaugh'" + ")";

            //cmd2 = new SqlCommand(sql2, cnn);
            //adapter.InsertCommand = new SqlCommand(sql2, cnn);
            //adapter.InsertCommand.ExecuteNonQuery();

            //cmd2.Dispose();

            //MessageBox.Show(Output);
            //dataReader.Close();
            //cmd.Dispose();
            //cnn.Close();
        }
    }
}
