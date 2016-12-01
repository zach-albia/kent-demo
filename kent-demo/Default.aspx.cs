using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OracleClient;

namespace kent_demo
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var con = new OracleConnection("Data Source=localhost;Persist Security Info=True;User ID=demo;Password=1234;Unicode=True");
            var commandText = "INSERT INTO WORLD VALUES ('Philippines', 'Manila', 102834982)";
            con.Open();
            var command = new OracleCommand(commandText, con);
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}