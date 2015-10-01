using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace Exam
{
    public class SearchColection
    {
        public static List<DataInput> GetCountryinfo()
        {
            List<DataInput> countrys = new List<DataInput>();

            using (StreamReader reder = new StreamReader(ConfigurationManager.AppSettings["Path"]))
            {
                string[] splitdata;
                string line = reder.ReadLine();
                do
                {
                    splitdata = line.Split('|');
                    countrys.Add(new DataInput()
                    {
                        Country = splitdata[0],
                        Capital = splitdata[1],
                        Population = splitdata[2]
                    });
                    line = reder.ReadLine();
                } while (line != null);
                
            }
            return countrys;
        } 
    }
}