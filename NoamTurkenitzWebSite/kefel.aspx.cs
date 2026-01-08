using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Kefel : System.Web.UI.Page
{
    public string strKefel;

    protected void Page_Load(object sender, EventArgs e)
    {

        strKefel = "<table border= '2' >";
        for (int i = 1; i <= 10; i++)
        {

            strKefel += "<tr>";
            for (int g = 1; g <= 10; g++)
            {
                int num = i * g;

                strKefel += "<td style='";
                if ((i + g) % 2 == 0)
                    strKefel += "background-color:green";
                else
                    strKefel += "background-color:red";
                strKefel += "'>";
                strKefel += i * g;

                strKefel += "</td>";
            }
            strKefel += "</tr>";




        }
        strKefel += "</table>";
    }
}