using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mrnjauuuu
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ljubisa lj = new ljubisa();
            string ime = TextBox2.Text;
                string prezime = TextBox3.Text;
                string jmbg = TextBox4.Text;
                lj.DodajNovogKorisnika(ime, prezime, jmbg);
            
        }
    }
}