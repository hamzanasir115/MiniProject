using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class AddStudents : Form
    {

        public AddStudents()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Here we add student in the database using queries.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnadd_Click_1(object sender, EventArgs e)
        {
            if(btnadd.Text=="Update")
            {
                SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
                bool IsValidFirstName = false;
                bool isValidContact = false;
                bool isValidContactDigit = false;
                bool IsValidLastName = false;
                bool Email = false;
                bool isValidRegistration;
                IsValidFirstName = IsString(txtfirst.Text);
                IsValidLastName = IsString(txtlast.Text);
                isValidContact = IsValidContactLength(txtcontact.Text);
                isValidContactDigit = IsValidContactDigit(txtcontact.Text);
                Email = IsEmail(txtemail.Text);
                isValidRegistration = isValidStudent(txtregister.Text);

                if (IsValidFirstName == true && IsValidLastName == true && isValidContactDigit == true && isValidContact == true && Email == true && isValidRegistration == true)
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
                        int Id = Convert.ToInt32(empty.Text);
                        conn.Open();
                        String cmd = String.Format("UPDATE Student SET FirstName = @firstname, LastName=@lastname,Contact=@contact, Email=@email, RegistrationNumber=@registration, Status=@status WHERE Id=@Id");
                        SqlCommand command = new SqlCommand(cmd, conn);
                        command.Parameters.Add(new SqlParameter("@Id", Id));
                        command.Parameters.Add(new SqlParameter("@firstname", firstname));
                        command.Parameters.Add(new SqlParameter("@lastname", lastname));
                        command.Parameters.Add(new SqlParameter("@contact", contact));
                        command.Parameters.Add(new SqlParameter("@email", email));
                        command.Parameters.Add(new SqlParameter("@registration", registration));
                        command.Parameters.Add(new SqlParameter("@status", status));
                        //conn.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        txtfirst.Text = " ";
                        txtlast.Text = " ";
                        txtcontact.Text = " ";
                        txtemail.Text = " ";
                        txtregister.Text = " ";
                        txtstatus.Text = null;
                        conn.Close();
                        tabPage1.Hide();
                        tabPage2.Show();
                        //SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
                        cmd = "SELECT * FROM Student";
                        command = new SqlCommand(cmd, conn);
                        command.Parameters.Add(new SqlParameter("0", 1));
                        conn.Open();
                        reader = command.ExecuteReader();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
                        DataTable view = new DataTable();
                        adapter.Fill(view);
                        datastudent.DataSource = view;
                        conn.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (IsValidFirstName == false)
                {
                    MessageBox.Show("Invalid FirstName");
                }
                if (IsValidLastName == false)
                {
                    MessageBox.Show("Invalid LastName");
                }
                if (isValidContact == false)
                {
                    MessageBox.Show("Invalid Contact Length");
                }
                if (isValidContactDigit == false)
                {
                    MessageBox.Show("Invalid Contact");
                }
                if (Email == false)
                {
                    MessageBox.Show("Invalid Email");
                }
                if (isValidRegistration == false)
                {
                    MessageBox.Show("Invalid Registration Number");
                }
            }
            else if(btnadd.Text== "Add Students")
            {
                SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
                bool IsValidFirstName = false;
                bool isValidContact = false;
                bool isValidContactDigit = false;
                bool IsValidLastName = false;
                bool Email = false;
                bool isValidRegistration;
                bool isValidStatus = false;
                IsValidFirstName = IsString(txtfirst.Text);
                IsValidLastName = IsString(txtlast.Text);
                isValidContact = IsValidContactLength(txtcontact.Text);
                isValidContactDigit = IsValidContactDigit(txtcontact.Text);
                Email = IsEmail(txtemail.Text);
                isValidRegistration = isValidStudent(txtregister.Text);
                isValidStatus = IsValidContactDigit(txtstatus.Text);
                if (IsValidFirstName == true && IsValidLastName == true && isValidContactDigit == true && isValidContact == true && Email == true && isValidRegistration == true && isValidStatus == true)
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
                        txtstatus.Text = null;
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (IsValidFirstName == false)
                {
                    MessageBox.Show("Invalid FirstName");
                }
                if (IsValidLastName == false)
                {
                    MessageBox.Show("Invalid LastName");
                }
                if (isValidContact == false)
                {
                    MessageBox.Show("Invalid Contact Length");
                }
                if (isValidContactDigit == false)
                {
                    MessageBox.Show("Invalid Contact");
                }
                if (Email == false)
                {
                    MessageBox.Show("Invalid Email");
                }
                if (isValidRegistration == false)
                {
                    MessageBox.Show("Invalid Registration Number");
                }
                if(isValidStatus == false)
                {
                    MessageBox.Show("Invalid Status");
                }
            }
            
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
        public static bool IsValidContactLength(string Contact)
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
        /// <summary>
        /// This Function returns that input of
        /// contacts should be digit.
        /// </summary>
        /// <param name="digit"></param>
        /// <returns> It returns true or false</returns>
        public static bool IsValidContactDigit(string digit)
        {
            bool number = false;
            foreach (char no in digit)
            {
                    if (char.IsNumber(no))
                    {
                        number = true;
                    }
                    else
                    {
                        number = false;
                    }
            }
            return number;
        }
        /// <summary>
        /// The Function is checking that string is valid 
        /// email address.
        /// </summary>
        /// <param name="emailaddress"></param>
        /// <returns> Returns either true or false </returns>
        public bool IsEmail(string emailaddress)
        {
            bool Valid;
            Valid = false;
            string pattren;
            pattren = @"^([\w\d.]+)@((\w+\.\w+)(\.\w+\.?)?)";
            if (Regex.IsMatch(txtemail.Text, pattren))
            {
                Valid = true;
            }
            else
            {
                Valid = false;
            }
            return Valid;
        }
        /// <summary>
        /// The Function is checking that string is all letters and
        /// First letter should be capital.
        /// </summary>
        /// <param name="Capital"></param>
        /// <returns> Returns either true or false </returns>
        bool IsString(String Capital)
        {
            string path;
            path = @"^(([A-Z][a-z]+[\s]{1}[A-za-z]+)|([A-Z][a-z]+))$";
            bool Isstring;
            Isstring = false;
            if (!Regex.IsMatch(Capital, path))
            {
                Isstring = false;
            }
            else
            {
                Isstring = true;
            }
            return Isstring;
        }
        /// <summary>
        /// The Function is checking that registration
        /// number is valid or not.
        /// </summary>
        /// <param name="Reg"></param>
        /// <returns> Returns either true or false </returns>
        bool isValidStudent(string Reg)
        {
            string path = @"[\d]{4}[-][A-Z|a-z][A-Z|a-z][-][\d]+";
            if (Regex.IsMatch(Reg, path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtfirst_Leave(object sender, EventArgs e)
        {
            string path;
            path = @"^(([A-Z][a-z]+[\s]{1}[A-za-z]+)|([A-Z][a-z]+))$";
            if (Regex.IsMatch(txtfirst.Text, path))
            {
                errorfirst.Clear();
            }
            else
            {
                errorfirst.SetError(txtfirst, "Invalid First Name");
            }
        }

        private void txtlast_Leave(object sender, EventArgs e)
        {
            string path;
            path = @"^(([A-Z][a-z]+[\s]{1}[A-za-z]+)|([A-Z][a-z]+))$";
            if (Regex.IsMatch(txtlast.Text, path))
            {
                errorlast.Clear();
            }
            else
            {
                errorlast.SetError(txtlast, "Invalid Last Name");
            }
        }

        private void txtcontact_Leave(object sender, EventArgs e)
        {
            bool contactlength = IsValidContactLength(txtcontact.Text);
            bool contact = IsValidContactDigit(txtcontact.Text);
            if (contactlength && contact == true)
            {
                errorcontact.Clear();
            }
            else
            {
                errorcontact.SetError(txtcontact, "Invalid Contact");
            } 
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            string path;
            path = @"^([\w\d.]+)@((\w+\.\w+)(\.\w+\.?)?)";
            if (Regex.IsMatch(txtemail.Text, path))
            {
                erroremail.Clear();
            }
            else
            {
                erroremail.SetError(txtemail, "Invalid Email");
            }
        }

        private void txtregister_Leave(object sender, EventArgs e)
        {
            string path = @"[\d]{4}[-][A-Z|a-z][A-Z|a-z][-][\d]+";
            if (Regex.IsMatch(txtregister.Text, path))
            {
                errorreg.Clear();
            }
            else
            {
                errorreg.SetError(txtregister, "Invalid Registration Number");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            String cmd = "SELECT * FROM Student";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("0", 1));
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
            DataTable view = new DataTable();
            adapter.Fill(view);
            datastudent.DataSource = view;
            conn.Close();
        }

        private void datastudent_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void datastudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void AddStudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectBDataSet.Student);
            empty.Hide();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void datastudent_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var Id = datastudent.Rows[e.RowIndex].Cells[0].Value;
            SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            conn.Open();
            if (e.ColumnIndex == datastudent.Columns["delete"].Index)
            {
                //this.datastudent.Rows.RemoveAt(e.RowIndex);
                int row = e.RowIndex;
               // int id = Convert.ToInt32(datastudent.Rows[row].Cells[0].Value);
                //var id = datastudent.Rows[e.RowIndex].Cells[0].Value;
                string query = "Delete from Student where Id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.ExecuteReader();
                MessageBox.Show("Data Deleted Succesfully");
                conn.Close();
            }
            else 
            {               
                String cmd;
                //var Id = datastudent.Rows[e.RowIndex].Cells[0].Value;
                cmd = "SELECT * FROM Student WHERE Id = @Id";

                SqlCommand command;
                command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("@Id", Id));
                

                SqlDataReader reader;
                reader = command.ExecuteReader();
                string first;
                string last;
                string contact;
                string registrationNumber;
                string email;
                int status;
                int id;
                while (reader.Read())
                {
                    first = Convert.ToString(reader[1]);
                    last = Convert.ToString(reader[2]);
                    contact = Convert.ToString(reader[3]);
                    email = Convert.ToString(reader[4]);
                    registrationNumber = Convert.ToString(reader[5]);
                    status = Convert.ToInt32(reader[6]);
                    id = Convert.ToInt32(reader[0]);
                    empty.Text = Convert.ToString(id);
                    txtfirst.Text = first;
                    txtlast.Text = last;
                    txtemail.Text = email;
                    txtregister.Text = registrationNumber;
                    txtcontact.Text = contact;
                    txtstatus.Text = Convert.ToString(status);
                }
                btnadd.Text = "Update";
                tabPage1.Show();
                conn.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void studentBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void tablelstudent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnstudent_Click(object sender, EventArgs e)
        {

        }

        private void btnclo_Click(object sender, EventArgs e)
        {

        }

        private void btnrubric_Click(object sender, EventArgs e)
        {

        }

        private void tablelst_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void empty_Click(object sender, EventArgs e)
        {

        }

        private void txtstatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblstatus_Click(object sender, EventArgs e)
        {

        }

        

        private void lblregistration_Click(object sender, EventArgs e)
        {

        }

        private void lblemail_Click(object sender, EventArgs e)
        {

        }

        private void lblcontact_Click(object sender, EventArgs e)
        {

        }

        private void lblsecond_Click(object sender, EventArgs e)
        {

        }

        private void lblfirst_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

       
        
    }
}
