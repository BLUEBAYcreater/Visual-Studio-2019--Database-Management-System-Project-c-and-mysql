# Visual-Studio-2019--Database-Management-System-Project-c#-and-mysql

Officially licensed by the MIT Software License.
Copyrights can be done, this project as been done by Yeshwanth and Sudhvina, with the help of our great professor Chethan Sir, JNNCE Collage.

AnyBody can use the software and modify it.
This project is one of the best project with a small modification it can completly change our living style with zero cost.

Best DBMS project along with extra-ordinary simple and easy to handle Graphical User Interface. Invisible GridView that comes only when the view button is clicked makes it more solid.

### Bluebaycreaters Coffee Database Management System 
**Front End is developed by the C# , Adobe and Backend is developed by SQL Server Express**

Project is officially licensed, you can read licensed terms and condition before proceding to next step
> This project is one of the amazing adventure for me **(Yeshwanth.P)** and my partner **Sudhvina,** having such an tough break through and making much more enjoyable graphical user interface made our project to go to whole new level.

> Our Project credit also goes to **Mr. Chetan K.R (B.E,M.Tech,Ph.D) and Mr S. Sathyanarayana(B.E,M.Tech)**

> We used Visual Studio 2019 for building this Application and Project. 

> We collected this ideas from many number of other projects like coffee database management and Art gallery.

> Majority of the code are auto generated, which makes it more easy to handle.


For the sample C# command for adding the Elements in the database is

`      private void button1_Click(object sender, EventArgs e)
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
        }`


### PROJECT IS COMPLETELY DESIGNED FROM A-Z JUST DOWNLOAD THE PROJECT AND YOU CAN CHANGE THE ATTRIBUTE NAME TO ANYTHING YOU WISH FOR

**How to run our project in your system**

>  I know some of you have no idea on how to do the project. You can download our project and do required modification.

>Make Sure you have visual studio 2019, with c# plugin installed. You have to install all the plugins required for running this project. It will be available in Visual Studio 2019 Installer( If you don't know which plugin to install, when you run the project it say "Server SQL Express" is missing. Then you can install it. 

> In code you can see SQL CONNECTION. it means the location of database as to be specified when user tries to give an input it must store in database. When you move our project to your system, in order to give SQL connection. On the Right Screen you can see Server Explorer, click  and right click coffee.mdf. You can select properties, in there it says Location you copy entire row and paste it in the SQL Connection at the end by removing the existing location.

> You have entire project running smooth and fine

### Why our project is best!!

_In every Entity we gave ADD, VIEW , DELETE, SEARCH, RESET, TRIGGER FOR EMAIL AND NEGATIVE INPUT, 3 STORED PROCEDURE_

### LOGIN PAGE
The login page is given with Login and Reset.
The cursor is mushroom black for the design

![Screenshot (93)](https://user-images.githubusercontent.com/39979024/70007296-e4228780-1595-11ea-8fe0-3ffc4a81f63f.png)

### Home page
Special Thing about Our Home page is cursor is black mushroom but when cursor points other forum it turns radium color.
![Screenshot (95)](https://user-images.githubusercontent.com/39979024/70007340-05837380-1596-11ea-8f29-4337a41759ad.png)

### Customer Options on the Application

DatagridView is invisible, the color of the datagridview is black, so when you only click the view button the datagridview pops into the screen.

> Insert the customer details and the details will be stored in the database

> Best part of our project customer is , customer id is auto incremented and email must be valid, if invalid email is given in the input then the error is brought into the screen.


![Screenshot (97)](https://user-images.githubusercontent.com/39979024/70007397-31065e00-1596-11ea-85f3-a94aebe4b4a6.png)

### Employee table
![Screenshot (98)](https://user-images.githubusercontent.com/39979024/70007626-07016b80-1597-11ea-9265-71fd2844f90b.png)

> Employee data's are stored in the database of the project, it is mainly used for which employee took the billing orders.

### ADD COFFEE

![Screenshot (101)](https://user-images.githubusercontent.com/39979024/70007714-619ac780-1597-11ea-98ee-57ecffa36077.png)

> You can add which ever coffee you want into the system, so the coffee database acts like a menu, what what coffee's are available.
>Negative pricing cannot be given, if given the the PIN trigger is called.

### Product

![Screenshot (99)](https://user-images.githubusercontent.com/39979024/70007759-960e8380-1597-11ea-8698-edb4f31d98af.png)

> Datagridview is completly invisible, only view button calls it.

### DELETE COFFEE,PRODUCT,ORDER

![Screenshot (103)](https://user-images.githubusercontent.com/39979024/70008910-a2471080-1598-11ea-9aee-6ef502ee1ae0.png)

REPORT COFFEE, ORDER AND PRODUCT

![Screenshot (104)](https://user-images.githubusercontent.com/39979024/70009200-ad9a3c00-1598-11ea-89f1-79637b3fbb8b.png)


FEW SAMPLES OF IMAGE OF CODE

![Screenshot (87)](https://user-images.githubusercontent.com/39979024/70007035-fea83100-1594-11ea-9f9c-f46aff720ba5.png)
![Screenshot (86)](https://user-images.githubusercontent.com/39979024/70007036-fea83100-1594-11ea-83cc-f70b38a8ce9e.png)

### IMAGES OF DATABASE 

![Screenshot (89)](https://user-images.githubusercontent.com/39979024/70007124-3adb9180-1595-11ea-845c-5076428fb12f.png)
![Screenshot (88)](https://user-images.githubusercontent.com/39979024/70007125-3b742800-1595-11ea-82f6-cc4ad0ae509f.png)


### IMAGE OF TRIGGER 

![Screenshot (90)](https://user-images.githubusercontent.com/39979024/70007148-52b31580-1595-11ea-9474-17ffbca43b0b.png)

IMAGES OF STORED PROCEDURE

![Screenshot (92)](https://user-images.githubusercontent.com/39979024/70007186-71b1a780-1595-11ea-93cb-8dd2bcdc8065.png)
![Screenshot (91)](https://user-images.githubusercontent.com/39979024/70007187-724a3e00-1595-11ea-813d-5f9184fc917d.png)

### **IF YOU NEED MORE GUIDANCE LOOK BELOW**

_above download the docs file for more details it has ER DIAGRAM AND SCHEMA DIAGRAM
_PPT is also be given in the project
_If you still have doubts feel free to visit our website [www.bluebaycreaters.com](url) and send your doubt along with your email id. So i can talk to you personally and make your project more amazing.
_Or you can open my GitHub profile and take my LinkedIn account and contact personally guys_

**KUDOS ALL THE BEST **

_

