using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class sign_up : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            string name = "name:" + Request.Form["fullname-2"];
            string Email = "Email:" + Request.Form["Email"];
            string password = "password:" + Request.Form["password"];
            string type = "type of music you like:" + Request.Form["check-1"];
            string connections = "what is your connection to music:" + Request.Form["radio-2"];
            string recommend = "recommendaitions to songs bands and singers:" + Request.Form["textarea3"];
            string age = "your age:" + Request.Form["age"];

            string str = "INSERT INTO tUsers " + "values (" + "N'" + "'," + name + "N'" + Email;

        }
    }
}