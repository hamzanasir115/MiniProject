using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    class AddAssesment
    {
        private string Title;
        private DateTime DateCreated;
        private int TotalMarks;
        private int TotalWeightage;

        public string Title1
        {
            get
            {
                return Title;
            }

            set
            {
                Title = value;
            }
        }

        public int TotalMarks1
        {
            get
            {
                return TotalMarks;
            }

            set
            {
                TotalMarks = value;
            }
        }

        public int TotalWeightage1
        {
            get
            {
                return TotalWeightage;
            }

            set
            {
                TotalWeightage = value;
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
    }
}