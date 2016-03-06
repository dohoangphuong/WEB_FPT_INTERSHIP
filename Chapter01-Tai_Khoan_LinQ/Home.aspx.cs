using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chapter01_Tai_Khoan_LinQ
{
    public partial class Home : System.Web.UI.Page
    {
        protected AccountLinQDataContext ac = new AccountLinQDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = ac.Accounts;
            GridView1.DataBind();
        }


        protected void gridselect(object sender, EventArgs e)
        {
           
        }

        protected void Reset(object sender, EventArgs e)
        {
            GridView1.DataSource = ac.Accounts;
            GridView1.DataBind();
        }

        protected void Delete(object sender, EventArgs e)
        {
            string index = GridView1.Rows[GridView1.SelectedIndex].Cells[1].Text;


            var acc_delete = (from a in ac.Accounts 
                              where a.ACCOUNTID == index
                              select a).First();                                    //loại 1
           

           // var acc_de = ac.Accounts.Where(m => m.ACCOUNTID == index).First();    //loại 2


            ac.Accounts.DeleteOnSubmit(acc_delete);
            ac.SubmitChanges();
        }
    }
}