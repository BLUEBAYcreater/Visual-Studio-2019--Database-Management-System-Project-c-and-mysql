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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(textBox1.Text) <= 0)
                {
                    return;
                }
            }
            catch(Exception e1)
            {
                MessageBox.Show("should be positive");
            }
            try
            {
                new System.Net.Mail.MailAddress(this.textBox6.Text);
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

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sudhvina A.S\Downloads\CoffeeBluebay\CoffeShopManegementSystemCSharp\CoffeShopManegementSystemCSharp\coffee.mdf;Integrated Security=True");
            con.Open();

            try
            {
                string str = " INSERT INTO cust(Id,name,addr,city,contact,email) VALUES(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                //-------------------------------------------//

                string str1 = "select max(Id) from cust;";

                SqlCommand cmd1 = new SqlCommand(str1, con);


                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Customers Information Registered Successfully..");

                }
                this.Close();
            }
            catch (SqlException ee)
            {
                MessageBox.Show(ee.Message);
            }



            con.Close();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sudhvina A.S\Downloads\CoffeeBluebay\CoffeShopManegementSystemCSharp\CoffeShopManegementSystemCSharp\coffee.mdf;Integrated Security=True");
            con.Open();
            string str1 = "select max(id) from cust;";

            SqlCommand cmd1 = new SqlCommand(str1, con);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    textBox1.Text = "1";
                }
                else
                {
                    int a;
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    textBox1.Text = a.ToString();
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sudhvina A.S\Downloads\CoffeeBluebay\CoffeShopManegementSystemCSharp\CoffeShopManegementSystemCSharp\coffee.mdf;Integrated Security=True");
            string str5 = "SELECT * from cust";
            SqlCommand cmd5 = new SqlCommand(str5, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd5);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = new BindingSource(dt, null);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sudhvina A.S\Downloads\CoffeeBluebay\CoffeShopManegementSystemCSharp\CoffeShopManegementSystemCSharp\coffee.mdf;Integrated Security=True");
                con.Open();
                String id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                MessageBox.Show(id);

                string str = "DELETE FROM cust WHERE Id = '" + id + "'";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" Customer Information is Removed Succefully");

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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                new System.Net.Mail.MailAddress(this.textBox6.Text);
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



            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sudhvina A.S\Downloads\CoffeeBluebay\CoffeShopManegementSystemCSharp\CoffeShopManegementSystemCSharp\coffee.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("CustomerUpdate", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@addr", textBox3.Text);
            cmd.Parameters.AddWithValue("@city ", textBox4.Text);
            cmd.Parameters.AddWithValue("@contact ", textBox5.Text);
            cmd.Parameters.AddWithValue("@email ", textBox6.Text);



            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("<<Invalid SQL OPERATION>>" + ex);
            }
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(textBox1.Text) <= 0)
                {
                    
                    return;
                }
            }
            catch (Exception e1)
            {
                textBox1.Text = "";
                label1.Show();
                // MessageBox.Show("should be positive");
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sudhvina A.S\Downloads\CoffeeBluebay\CoffeShopManegementSystemCSharp\CoffeShopManegementSystemCSharp\coffee.mdf;Integrated Security=True");
            con.Open();
            if(textBox1.Text=="-")
            {
                return;
            }
            if (textBox1.Text != "")
            {
                try
                {
                    label1.Hide();
                    string getCust = "select name,addr,city,contact,email from cust where Id=" + textBox1.Text + " ;";

                    SqlCommand cmd = new SqlCommand(getCust, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {

                        textBox2.Text = dr.GetValue(0).ToString();
                        textBox3.Text = dr.GetValue(1).ToString();
                        textBox4.Text = dr.GetValue(2).ToString();
                        textBox5.Text = dr.GetValue(3).ToString();
                        textBox6.Text = dr.GetValue(4).ToString();

                    }
                    else
                    {
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                       
                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

           
        }

    }
}