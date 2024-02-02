using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mrnjauuuu
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ljubisa lj = new ljubisa();
                DropDownList1.DataSource = lj.ProcitajSveKorisnike();
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ljubisa lj = new ljubisa();

            string imePrezime = DropDownList1.SelectedValue;
            string[] parts = imePrezime.Split('|');
            string jmbg = lj.ProcitajJmbg(parts[0], parts[1]);
            Label1.Text = jmbg;
        }
    }
}