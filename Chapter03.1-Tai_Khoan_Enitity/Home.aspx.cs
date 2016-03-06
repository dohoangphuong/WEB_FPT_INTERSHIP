using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chapter03._1_Tai_Khoan_Enitity
{
    public partial class Home : System.Web.UI.Page
    {
        public ACCOUNT_LINQEntities1 acc = new ACCOUNT_LINQEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = acc.Account.ToList();
            GridView1.DataBind();
        }
        protected void Loadgrid(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(GridView1.Rows[GridView1.SelectedIndex].Cells[4].Text.ToString());
            GridView2.DataSource = acc.AccountType.Where(m => m.ACCOUNTTYPE == index).ToList();
            GridView2.DataBind();
        }
    }
}