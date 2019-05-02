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

                if (IsValidFirstName == true   && Email == true && isValidRegistration == true )
                {
                    if(IsValidLastName == true || txtlast.Text.Length == 0)
                    {
                        if ((isValidContactDigit == true && isValidContact == true) || txtcontact.Text.Length == 0)
                        {
                            Student student = new Student();
                            student.FirstName1 = txtfirst.Text;
                            student.LastName1 = txtlast.Text;
                            student.Contact1 = txtcontact.Text;
                            student.Email1 = txtemail.Text;
                            student.Registration1 = txtregister.Text;
                            student.Status1 = Convert.ToInt32(cmbstatus.Text);
                            try
                            {
                                String firstname = txtfirst.Text;
                                String lastname = txtlast.Text;
                                String contact = txtcontact.Text;
                                String email = txtemail.Text;
                                String registration = txtregister.Text;
                                int status = Convert.ToInt32(cmbstatus.Text);
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
                                SqlDataReader reader = command.ExecuteReader();
                                txtfirst.Text = "";
                                txtlast.Text = "";
                                txtcontact.Text = "";
                                txtemail.Text = "";
                                txtregister.Text = "";
                                cmbstatus.Text = null;
                                conn.Close();
                                tabPage1.Hide();
                                tabPage2.Show();
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
                                btnadd.Text = "Add Students";
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Contact");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid last name");
                        if ((isValidContactDigit == true && isValidContact == true) || txtcontact.Text.Length == 0)
                        {
                            MessageBox.Show("Invalid Contact");
                        }
                    }
                    
                    
                }
                if (IsValidFirstName == false)
                {
                    MessageBox.Show("Invalid FirstName");
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
                isValidStatus = IsValidContactDigit(cmbstatus.Text);
                if (IsValidFirstName == true && Email == true && isValidRegistration == true && isValidStatus == true)
                {
                    if(IsValidLastName == true  || txtlast.Text.Length == 0)
                    {
                        if ((isValidContactDigit == true  && isValidContact == true)|| txtcontact.Text.Length == 0 )
                        {
                            Student student = new Student();
                            student.FirstName1 = txtfirst.Text;
                            student.LastName1 = txtlast.Text;
                            student.Contact1 = txtcontact.Text;
                            student.Email1 = txtemail.Text;
                            student.Registration1 = txtregister.Text;
                            student.Status1 = Convert.ToInt32(cmbstatus.Text);
                            try
                            {
                                String firstname = txtfirst.Text;
                                String lastname = txtlast.Text;
                                String contact = txtcontact.Text;
                                String email = txtemail.Text;
                                String registration = txtregister.Text;
                                int status = Convert.ToInt32(cmbstatus.Text);
                                conn.Open();
                                String cmd = String.Format("INSERT INTO Student(FirstName, LastName,Contact, Email, RegistrationNumber, Status) values('{0}','{1}','{2}','{3}','{4}','{5}')", firstname, lastname, contact, email, registration, status);
                                SqlCommand command = new SqlCommand(cmd, conn);
                                command.Parameters.Add(new SqlParameter("0", 1));
                                SqlDataReader reader = command.ExecuteReader();
                                MessageBox.Show("Student has been added");
                                txtfirst.Text = "";
                                txtlast.Text = "";
                                txtcontact.Text = "";
                                txtemail.Text = "";
                                txtregister.Text = "";
                                cmbstatus.Text = null;
                                conn.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Contact");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid last name");
                        if ((isValidContactDigit == true && isValidContact == true) || txtcontact.Text.Length == 0)
                        {
                            MessageBox.Show("Invalid Contact");
                        }
                    }
                    
                }
                if (IsValidFirstName == false)
                {
                    MessageBox.Show("Invalid FirstName");
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
        /// <summary>
        /// Provides Error when first name is not valid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Provides Error when last name is not valid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtlast_Leave(object sender, EventArgs e)
        {
            string path;
            path = @"^(([A-Z][a-z]+[\s]{1}[A-za-z]+)|([A-Z][a-z]+))$";
            if (Regex.IsMatch(txtlast.Text, path) || txtlast.Text.Length == 0)
            {
                errorlast.Clear();
            }
            else
            {
                errorlast.SetError(txtlast, "Invalid Last Name");
            }
        }
        /// <summary>
        /// Provides Error when contact is not valid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtcontact_Leave(object sender, EventArgs e)
        {
            bool contactlength = IsValidContactLength(txtcontact.Text);
            bool contact = IsValidContactDigit(txtcontact.Text);
            if (contactlength && contact == true || txtcontact.Text.Length == 0)
            {
                errorcontact.Clear();
            }
            else
            {
                errorcontact.SetError(txtcontact, "Invalid Contact");
            } 
        }
        /// <summary>
        /// Provides Error when email is not valid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Provides Error when registration number
        /// is not valid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// To Show Data in the grid. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            conn.Open();
            String cmd = "SELECT LookupId from Lookup";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            { 
                cmbstatus.Items.Add(reader[0]);
            }
            conn.Close();
            this.studentTableAdapter.Fill(this.projectBDataSet.Student);
            empty.Hide();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }
        /// <summary>
        /// Updation and deletion of students here.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void datastudent_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var Id = datastudent.Rows[e.RowIndex].Cells[0].Value;
            SqlConnection conn = new SqlConnection("Data Source =HAMZA; Initial Catalog =ProjectB; User ID =sa; Password =hamza; MultipleActiveResultSets = True");
            conn.Open();
            if (e.ColumnIndex == datastudent.Columns["delete"].Index)
            {
                int row = e.RowIndex;
                string query1 = "Delete from StudentAttendance where StudentId = @id";
                SqlCommand command1 = new SqlCommand(query1, conn);
                command1.Parameters.Add(new SqlParameter("@Id", Id));
                command1.ExecuteReader();

                string query2 = "Delete from StudentResult where Id = @id";
                SqlCommand command2 = new SqlCommand(query2, conn);
                command2.Parameters.Add(new SqlParameter("@Id", Id));
                command2.ExecuteReader();


                string query = "Delete from Student where Id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.ExecuteReader();
                MessageBox.Show("Data Deleted Succesfully");

                String cmd = "SELECT * FROM Student";
                command.Parameters.Add(new SqlParameter("0", 1));
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
                DataTable view = new DataTable();
                adapter.Fill(view);
                datastudent.DataSource = view;
                conn.Close();
            }
            else if (e.ColumnIndex == datastudent.Columns["Edit"].Index)
            {               
                String cmd;
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
                    cmbstatus.Text = Convert.ToString(status);
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
            AddStudents student = new AddStudents();
            this.Hide();
            student.Show();
        }

        private void btnclo_Click(object sender, EventArgs e)
        {
            Add_CLOs clo = new Add_CLOs();
            this.Hide();
            clo.Show();
        }

        private void btnrubric_Click(object sender, EventArgs e)
        {
            AddRubrics rubric = new AddRubrics();
            this.Hide();
            rubric.Show();
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

        private void txtlast_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnStudent_Click(object sender, EventArgs e)
        {
            AddStudents stu = new AddStudents();
            this.Hide();
            stu.Show();
        }

        private void btnCLO_Click(object sender, EventArgs e)
        {
            Add_CLOs clo = new Add_CLOs();
            this.Hide();
            clo.Show();
        }

        private void btnRubric_Click(object sender, EventArgs e)
        {
            AddRubrics rub = new AddRubrics();
            this.Hide();
            rub.Show();
        }

        private void btnAssessment_Click(object sender, EventArgs e)
        {
            Assesment ass = new Assesment();
            this.Hide();
            ass.Show();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            AddAttendance att = new AddAttendance();
            this.Hide();
            att.Show();
        }

        private void btnStudentResult_Click(object sender, EventArgs e)
        {
            StudentResults att = new StudentResults();
            this.Hide();
            att.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report att = new Report();
            this.Hide();
            att.Show();
        }
    }
}
