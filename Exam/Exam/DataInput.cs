using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam
{
    public class DataInput
    {
        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        private string capital;

        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }

        private int population;

        public int Population
        {
            get { return population; }
            set { population = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}", this.country, this.capital, this.population);
        }
    }
}