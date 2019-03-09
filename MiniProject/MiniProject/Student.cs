using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{

    /// <summary>
    /// This Class give us firstname, lastname 
    /// contact, email, registration number and
    /// status of students.
    /// </summary>
    class Student
    {
        private string FirstName;
        private string LastName;
        private string Contact;
        private string Email;
        private string Registration;
        private int Status;
        ///<value>
        /// FirstName property sets or gets value
        /// of the string,firstname.
        ///</value>
        public string FirstName1
        {
            get
            {
                return FirstName;
            }

            set
            {
                FirstName = value;
            }
        }
        ///<value>
        /// LastName property sets or gets value
        /// of the string,lastname.
        ///</value>
        public string LastName1
        {
            get
            {
                return LastName;
            }

            set
            {
                LastName = value;
            }
        }
        ///<value>
        /// Contact property sets or gets value
        /// of the string,contact.
        ///</value>
        public string Contact1
        {
            get
            {
                return Contact;
            }

            set
            {
                Contact = value;
            }
        }
        ///<value>
        /// Email property sets or gets value
        /// of the string,email.
        ///</value>
        public string Email1
        {
            get
            {
                return Email;
            }

            set
            {
                Email = value;
            }
        }
        ///<value>
        /// Registration property sets or gets value
        /// of the string,registration.
        ///</value>
        public string Registration1
        {
            get
            {
                return Registration;
            }

            set
            {
                Registration = value;
            }
        }
        ///<value>
        /// Status property sets or gets value
        /// of the int,status.
        ///</value>
        public int Status1
        {
            get
            {
                return Status;
            }

            set
            {
                Status = value;
            }
        }
    }
}
