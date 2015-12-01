using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static ServerClass serverInstance;

        protected void Page_Load(object sender, EventArgs e)
        {
            serverInstance = new ServerClass();
        }

        protected void GetMessanges_Click(object sender, EventArgs e)
        {
            DBConnection dbConnection = new DBConnection();
            dbConnection.DatabaseConnection();
            dbConnection.getMessages();
        }
    }
}