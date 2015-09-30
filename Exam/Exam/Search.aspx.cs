using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            if (PopulationSTxtBox.Text != string.Empty)
            {
                if (Convert.ToInt32(PopulationSTxtBox.Text) > 20000000)
                {
                    SearchExist.Text = "Няма толкова много хора в една държава!";
                    SearchBtn.Enabled = false;
                }
            }
           
            else
            {
                bool iscontain = false;
                if (File.Exists("C:/Users/lubo/Desktop/Exam1/Home/Exam/Exam/bin/Data.txt"))
                {
                    using (StreamReader reader = new StreamReader("C:/Users/lubo/Desktop/Exam1/Home/Exam/Exam/bin/Data.txt"))
                    {
                        if (CountrySTxtBox.Text != null)
                        {
                            string line = reader.ReadLine();

                            do
                            {
                                string[] printexists = line.Split('|');

                                if (printexists[0] == (CountrySTxtBox.Text))
                                {
                                    iscontain = true;
                                    PrintCountryLabel.Text = printexists[0];
                                    PrintCapitalLabel.Text = printexists[1];
                                    PrintPopulationLabel.Text = printexists[2];
                                }
                                else
                                {
                                    line = reader.ReadLine();
                                }
                            } while (line != null);
                        }
                        else if (CapitalSTxtBox.Text != null)
                        {
                            string line = reader.ReadLine();
                            do
                            {
                                string[] printexists = line.Split('|');
                                if (printexists[1] == CapitalSTxtBox.Text)
                                {
                                    iscontain = true;
                                    PrintCountryLabel.Text = printexists[0];
                                    PrintCapitalLabel.Text = printexists[1];
                                    PrintPopulationLabel.Text = printexists[2];
                                    
                                }
                                else
                                {
                                    line = reader.ReadLine();
                                }
                            } while (line != null);
                        }
                        else if (PopulationSTxtBox.Text != null)
                        {
                            string line = reader.ReadLine();
                            do
                            {
                                string[] printexists = line.Split('|');

                                if (printexists[2] == (PopulationSTxtBox.Text))
                                {
                                    iscontain = true;
                                    PrintCountryLabel.Text = printexists[0];
                                    PrintCapitalLabel.Text = printexists[1];
                                    PrintPopulationLabel.Text = printexists[2];
                                    break;
                                }
                                else
                                {
                                    line = reader.ReadLine();
                                }
                            } while (line != null);
                        }
                        if (iscontain == false)
                        {
                            SearchExist.Text = "Търсенето не съществува, моля добавете вашето търсене";
                        }
                    }
                }
            }
        }

        protected void Selectitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Selectitem.Text == "Държава")
            {
                CountrySTxtBox.Enabled = true;
                CapitalSTxtBox.Enabled = false;
                PopulationSTxtBox.Enabled = false;
                CapitalSTxtBox.Text = null;
                PopulationSTxtBox.Text = null;
            }else if(Selectitem.Text == "Столица")
            {
                CapitalSTxtBox.Enabled = true;
                CountrySTxtBox.Enabled = false;
                PopulationSTxtBox.Enabled = false;
                CountrySTxtBox.Text = null;
                PopulationSTxtBox.Text = null;
            }
            else { 
                PopulationSTxtBox.Enabled = true;
                CapitalSTxtBox.Enabled = false;
                CountrySTxtBox.Enabled = false;
                CapitalSTxtBox.Text = null;
                CountrySTxtBox.Text = null;
            }    
        }
    }
}