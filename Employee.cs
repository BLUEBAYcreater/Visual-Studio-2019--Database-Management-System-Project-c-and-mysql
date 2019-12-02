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

namespace CoffeShopManegementSystemCSharp
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sudhvina A.S\Downloads\CoffeeBluebay\CoffeShopManegementSystemCSharp\CoffeShopManegementSystemCSharp\coffee.mdf;Integrated Security=True");
            con.Open();


            try
            {
                new System.Net.Mail.MailAddress(this.textBox3.Text);
                // return;
            }
            catch (ArgumentException e1)
            {
                MessageBox.Show("empty");
                return;
            }
            catch (FormatException e2)
            {
                MessageBox.Show("invalid email");
                return;
            }

            string gen = string.Empty;
            if (radioButton1.Checked)
            {
                gen = "Male";
            }
            else if (radioButton2.Checked)
            {
                gen = "Female";
            }
            try
            {
                string str = " INSERT INTO emp(Id,name,addr,city,contact,gender,email,doj,salary) VALUES('" + textBox9.Text + "','" + textBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox2.Text + "','" + gen + "','" + textBox3.Text + "','" + textBox6.Text + "','" + textBox7.Text + "'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                //-------------------------------------------//

                string str1 = "select Max(Id) from emp;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Employee Information Registered Successfully..");

                }
                this.Close();
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sudhvina A.S\Downloads\CoffeeBluebay\CoffeShopManegementSystemCSharp\CoffeShopManegementSystemCSharp\coffee.mdf;Integrated Security=True");
            string str5 = "SELECT * from emp";
            SqlCommand cmd5 = new SqlCommand(str5, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd5);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = new BindingSource(dt, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sudhvina A.S\Downloads\CoffeeBluebay\CoffeShopManegementSystemCSharp\CoffeShopManegementSystemCSharp\coffee.mdf;Integrated Security=True");
                con.Open();

                string str = "DELETE FROM emp WHERE Id = '" + textBox8.Text + "'";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" Employer Deleted Succesfully");

                SqlCommand cmd5 = new SqlCommand(str, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd5);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);


            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Please Enter Customer Id..");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
