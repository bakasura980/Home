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

        private static List<DataInput> colect = SearchColection.GetCountryinfo();

        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchExist.Text = null;
            bool exist = false;
            List<DataInput> data = new List<DataInput>();
            foreach (var item in colect)
            {
                if (CountrySTxtBox.Enabled == true)
                {
                    if (item.Country.Contains(CountrySTxtBox.Text))
                    {
                        exist = true;
                        data.Add(item);
                    }
                }
                else if (CapitalSTxtBox.Enabled == true)
                {
                    if (item.Capital.Contains(CapitalSTxtBox.Text))
                    {
                        exist = true;
                        data.Add(item);
                    }
                }
                else if (PopulationSTxtBox.Enabled == true)
                {
                    if (item.Population.Contains(PopulationSTxtBox.Text))
                    {
                        exist = true;
                        data.Add(item);
                    }
                }
                
            }
            if (exist == false)
            {
                SearchExist.Text = "Не е създадена подобна държава със столица и население!";
            }
            else
            {
                dataRepeater.DataSource = data;
                dataRepeater.DataBind();
            }
            
        }
    
        

        protected void Selectitem_TextChanged(object sender, EventArgs e)
        {
            if (Selectitem.Text == "Държава")
            {
                
                CapitalSTxtBox.Enabled = false;
                CountrySTxtBox.Enabled = true;
                PopulationSTxtBox.Enabled = false;
                CapitalSTxtBox.Text = null;
                PopulationSTxtBox.Text = null;
            }
            if (Selectitem.Text == "Столица")
            {
                CapitalSTxtBox.Enabled = true;
                CountrySTxtBox.Enabled = false;
                PopulationSTxtBox.Enabled = false;
                CountrySTxtBox.Text = null;
                PopulationSTxtBox.Text = null;
            }
            if (Selectitem.Text == "Население")
            {
                PopulationSTxtBox.Enabled = true;
                CapitalSTxtBox.Enabled = false;
                CountrySTxtBox.Enabled = false;
                CapitalSTxtBox.Text = null;
                CountrySTxtBox.Text = null;
            }

        }
    }
}