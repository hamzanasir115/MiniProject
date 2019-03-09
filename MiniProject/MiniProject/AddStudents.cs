using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class AddStudents : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");


        public AddStudents()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            bool IsValidFirstName = false;
            bool isValidContact = false;
            bool IsValidLastName = false;
            IsValidFirstName = IsLetters(txtfirst.Text);
            IsValidLastName = IsLetters(txtlast.Text);
            isValidContact = IsValidContact(txtcontact.Text);
            if (IsValidFirstName == true && IsValidLastName == true && isValidContact == true)
            {
                Student student = new Student();
                student.FirstName1 = txtfirst.Text;
                student.LastName1 = txtlast.Text;
                student.Contact1 = txtcontact.Text;
                student.Email1 = txtemail.Text;
                student.Registration1 = txtregister.Text;
                student.Status1 = Convert.ToInt32(txtstatus.Text);
                try
                {
                    String firstname = txtfirst.Text;
                    String lastname = txtlast.Text;
                    String contact = txtcontact.Text;
                    String email = txtemail.Text;
                    String registration = txtregister.Text;
                    int status = Convert.ToInt32(txtstatus.Text);
                    conn.Open();
                    String cmd = String.Format("INSERT INTO Student(FirstName, LastName,Contact, Email, RegistrationNumber, Status) values('{0}','{1}','{2}','{3}','{4}','{5}')", firstname, lastname, contact, email, registration, status);
                    SqlCommand command = new SqlCommand(cmd, conn);
                    command.Parameters.Add(new SqlParameter("0", 1));
                    //conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    txtfirst.Text = " ";
                    txtlast.Text = " ";
                    txtcontact.Text = " ";
                    txtemail.Text = " ";
                    txtregister.Text = " ";
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (IsValidFirstName == false)
            {
                MessageBox.Show("InValid FirstName");
            }
            if (IsValidLastName == false)
            {
                MessageBox.Show("Invalid LastName");
            }
            if (isValidContact == false)
            {
                MessageBox.Show("Invalid Contact");
            }
            //conn.Close();

        }
        /// <summary>
        /// The Function is checking that string is all letters.
        /// </summary>
        /// <param name="st"></param>
        /// <returns> Returns either true or false </returns>
        public static bool IsLetters(string name)
        {
            foreach (char i in name)
            {
                if (!Char.IsLetter(i))
                {
                    if (i == ' ')
                    {

                    }
                    else
                    {
                        return false;
                    }

                }
            }
            return true;
        }
        /// <summary>
        /// It Checks the validity of Contact of Student.
        /// </summary>
        /// <param name="Contact"></param>
        /// <returns> Returns True or False.</returns>
        public static bool IsValidContact(string Contact)
        {
            int length = 0;
            foreach (char s in Contact)
            {
                length = length + 1;
            }
            if (length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
