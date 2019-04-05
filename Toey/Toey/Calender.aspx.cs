using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {

    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        string[] AttData = Calendar1.SelectedDate.ToString().Split(' ');
        string[] AttDate = AttData[0].Split('/');
        string URL = string.Format("Detail.aspx?d={0}&m={1}&y={2}", AttDate[0], AttDate[1], AttDate[2]);
        Response.Redirect(URL);
    }

   
}