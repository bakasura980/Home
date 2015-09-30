using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Exam
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            if (CountryTxtBox.Text != null && CapitalTxtBox.Text != null && PopulationTxtBox.Text != string.Empty)
            {
                if (Convert.ToInt32(PopulationTxtBox.Text) > 20000000)
                {
                    ExistLabel.Text = "Няма толкова много хора в една държава!";
                }
                else
                {
                    DataInput inp = new DataInput();
                    inp.Country = CapitalTxtBox.Text;
                    inp.Capital = CountryTxtBox.Text;
                    inp.Population = int.Parse(PopulationTxtBox.Text);
                    if (File.Exists("C:/Users/lubo/Desktop/Exam/Exam/bin/Data.txt"))
                    {
                        try
                        {
                            using (StreamReader reader = new StreamReader("C:/Users/lubo/Desktop/Exam/Exam/bin/Data.txt"))
                            {
                                string line = reader.ReadLine();
                                do
                                {
                                    string[] country = line.Split('|');
                                    if (country[0] == CountryTxtBox.Text)
                                    {
                                        throw new ExistExcepiton("This country exist!");
                                    }
                                    line = reader.ReadLine();
                                } while (line != null);

                            }
                            using (StreamWriter write = new StreamWriter("C:/Users/lubo/Desktop/Exam/Exam/bin/Data.txt", true))
                            {
                                write.WriteLine(inp);
                            }
                            CountryTxtBox.Text = null;
                            CapitalTxtBox.Text = null;
                            PopulationTxtBox.Text = null;
                            ExistLabel.Text = "This does not exist. Your add is successful!";
                        }
                        catch (ExistExcepiton exp)
                        {
                            ExistLabel.Text = exp.Message;
                        }
                    }
                    else
                    {
                        using (StreamWriter write = new StreamWriter("C:/Users/lubo/Desktop/Exam/Exam/bin/Data.txt", true))
                        {
                        }
                    }
                }
            }
            else
            {
                ExistLabel.Text = "Some input field is empty";
            }
        }
    }
}
