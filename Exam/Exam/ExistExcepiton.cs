using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam
{
    public class ExistExcepiton : Exception
    {
        public ExistExcepiton(string Massage)
           : base(Massage)
        {
        }
    }
}