using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class Glasaj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                string[] lbPredmeti = new string[]
                {
                "IT","SKIT","DNICK","OOP"
                };

                string[] Lbkrediti = new string[]
                {
                "5","5.5","6","4"
                };

                string[] lbprofesori = new string[]
                {
                "RIste","Vlatko","Matej","Ivona"
                };

                for (int i = 0; i < lbPredmeti.Length; i++)
                {
                    predmeti.Items.Add(new ListItem(lbPredmeti[i], "0"));
                }
                foreach (string item in Lbkrediti)
                {
                    krediti.Items.Add(item);
                }
            }

        }

        protected void predmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = predmeti.SelectedIndex;
            krediti.SelectedIndex = index;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {



            if (predmeti.SelectedIndex != -1 && krediti.SelectedIndex != -1)
            {
                predmeti.SelectedItem.Value = predmeti.SelectedItem.Value + 1;
                Session["predmet"] = predmeti.SelectedItem;
                Response.Redirect("UspeshnoGlasanjeapsx.apsx");
                

            }

        }

        protected void dodadi_Click(object sender, EventArgs e)
        {
            if (imePredmet.Text != "" && kreditVrednost.Text != "")
            {
                predmeti.Items.Add(imePredmet.Text);
                krediti.Items.Add(kreditVrednost.Text);
            }
        }

        protected void izbrisi_Click(object sender, EventArgs e)
        {
            if (predmeti.SelectedIndex != -1)
            {
                int index = predmeti.SelectedIndex;
                predmeti.Items.RemoveAt(index);
                krediti.Items.RemoveAt(index);
            }
        }
    }
}