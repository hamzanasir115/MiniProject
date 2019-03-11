using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    class CLO
    {
        private string Name;
        private DateTime DateCreated;
        private DateTime DateUpdated;
        public string Name1
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public DateTime DateCreated1
        {
            get
            {
                return DateCreated;
            }

            set
            {
                DateCreated = value;
            }
        }

        public DateTime DateUpdated1
        {
            get
            {
                return DateUpdated;
            }

            set
            {
                DateUpdated = value;
            }
        }
    }
}
