using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam
{
    public class Searchdoesnotexist : Exception
    {
        public Searchdoesnotexist(string Massage)
            :base(Massage)
        {
        }
    }
}