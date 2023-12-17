using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class UspeshnoGlasanjeaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
          if(!Page.IsPostBack)
            {
                string[] zanr = new string[]
                {
                    "drama","komedija","akcija"
                };
                zanrovi.DataSource = zanr;
                zanrovi.DataBind();

                
            }

        }

        protected void zanrovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmovi.Items.Clear();
            string[] komedijaFilmovi = new string[]
            {
                "Forest Gump","Keeping up with me","Love"
            };

            string[] komedijaCena = new string[]
            {
                "130","150","200"
            };

            string[] dramaFilmovi = new string[]
            {
                "One","Two","Three"
            };
            string[] dramaCeni = new string[]
            {
                "200","120","100"
            };
            string[] akcijaFilmovi = new string[]
            {
                "La la landa","lilu ","momo"
            };
            string[]akcijaCeni = new string[]
            {
                "150","170","155"
            };

            if(zanrovi.SelectedIndex == 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    filmovi.Items.Add(new ListItem(dramaFilmovi[i], dramaCeni[i]));
                }
                filmovi.Visible = true;
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
            }
            if (zanrovi.SelectedIndex == 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    filmovi.Items.Add(new ListItem(komedijaFilmovi[i], komedijaCena[i]));
                }
                filmovi.Visible = true;
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
            }
            if (zanrovi.SelectedIndex == 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    filmovi.Items.Add(new ListItem(akcijaFilmovi[i], akcijaCeni[i]));
                }
                filmovi.Visible = true;
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
            }

        }

        protected void kupi_Click(object sender, EventArgs e)
        {
           
            int count = 0;
            
          for (int i = 0;i < 3;i++)
            {
                if (filmovi.Items[i].Selected) {

                    int current = Convert.ToInt32(filmovi.Items[i].Value);
                    switch(i)
                    {
                        case 0:
                            current *= Convert.ToInt32(TextBox1.Text);
                            count += current;
                            break;
                        case 1:
                            current *= Convert.ToInt32(TextBox2.Text);
                           count+= current;
                            break;
                        case 2:
                            current *= Convert.ToInt32(TextBox3.Text);
                            count+= current;
                            break;
                    }
                }

            }
          cena.Text=count.ToString();
        }
    }
}