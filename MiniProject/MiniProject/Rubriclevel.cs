using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    class Rubriclevel
    {
        private string Details;
        private int measurementlevel;
        public string Details1
        {
            get
            {
                return Details;
            }

            set
            {
                Details = value;
            }
        }

        public int Measurementlevel
        {
            get
            {
                return measurementlevel;
            }

            set
            {
                measurementlevel = value;
            }
        }
    }
}
