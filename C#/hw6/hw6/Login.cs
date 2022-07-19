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
using System.Text.RegularExpressions;

namespace hw6
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public int parsedCustomerID;
        private int parsedOrderID;

        public string return_id()
        {
            return this.textBox1.Text;
        }

        private bool IsCustomerNameValid()
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Please enter a name");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsCustomerIDValid()
        {
            // Check for input in the Order ID text box.
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please specify the Order ID.");
                return false;
            }

            // Check for characters other than integers.
            else if (Regex.IsMatch(textBox1.Text, @"^\D*$"))
            {
                // Show message and clear input.
                MessageBox.Show("Customer ID must contain only numbers.");
                textBox1.Clear();
                return false;
            }
            else
            {
                // Convert the text in the text box to an integer to send to the database.
                parsedOrderID = Int32.Parse(textBox1.Text);
                return true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new CreateAccount();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if(IsCustomerIDValid())
            {
                if (IsCustomerNameValid())
                {
                    SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString);
                    connection.Open();

                    bool login = false;
                    string id = textBox1.Text; // 로그인 ID
                    string name = textBox2.Text; // 로그인 PASSWORD

                    string sql = "SELECT * FROM Sales.Customer WHERE CustomerID =\'" + id + "\' ";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    SqlDataReader mdr = cmd.ExecuteReader();

                    int iid = Convert.ToInt32(id);

                    while (mdr.Read())
                    {
                        // 검색된 아이디와 비밀번호가 일치한 경우 로그인된 것으로 봄
                        if (iid == (int)mdr["CustomerID"] && name == (string)mdr["CustomerName"])
                            login = true;
                    }
                    if (login)
                    {
                        this.DialogResult = DialogResult.OK;
                        Order.parsedCustomerID = id;
                        Form frm = new Order();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("아이디/암호를 확인해 주세요.");
                    }
                }
            }

         
        }
    }
}
