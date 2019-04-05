using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class Upload : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            SetDayDDL();
            SetMonthDDL();
            SetYearDDL();

        }
    }

    private void SetDayDDL()
    {
        for (int i = 1; i <= 31; i++)
        {
            DropDownListDay.Items.Add(new ListItem(i.ToString(), i.ToString()));
        }
    }
    private void SetMonthDDL()
    {
        for (int i = 1; i <= 12; i++)
        {
            DropDownListMonth.Items.Add(new ListItem(i.ToString(), i.ToString()));
        }
    }

    private void SetYearDDL()
    {
        int CY = DateTime.Now.Year + 543;
        for (int i = CY - 5; i <= CY + 1; i++)
        {
            DropDownListYear.Items.Add(new ListItem(i.ToString(), i.ToString()));
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Visible = true;
        if (FileUpload1.HasFile)
        {
            string OldFileName = FileUpload1.FileName;
            string Ext = System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName);
            string NewName = Guid.NewGuid().ToString();
            string cNewName = string.Format("{0}{1}", NewName, Ext);
            string Path = string.Format("Upload/{0}", cNewName);
            string cPath = Server.MapPath(Path);
            FileUpload1.SaveAs(cPath);
         

    
            InsertFileDB(OldFileName, Path);

            Label1.Text = "อัพโหลดสำเร็จ";
            Label1.ForeColor = System.Drawing.Color.Green;


        }
        else
        {
            Label1.Text = "กรุณาเลือกไฟล์";
            Label1.ForeColor = System.Drawing.Color.Red;

        }


    }

    private void InsertFileDB(string OldFileName, string cPath)
    {

        string StrConn = WebConfigurationManager.ConnectionStrings["UPPart2ConnectionString"].ConnectionString;
        using (SqlConnection ObjConn = new SqlConnection(StrConn))
        {
            ObjConn.Open();
            using (SqlCommand ObjCM = new SqlCommand())
            {
                ObjCM.Connection = ObjConn;
                ObjCM.CommandType = CommandType.StoredProcedure;
                ObjCM.CommandText = "InsertFile";
                ObjCM.Parameters.AddWithValue("@Name", OldFileName);
                ObjCM.Parameters.AddWithValue("@FilePath", cPath);
                ObjCM.Parameters.AddWithValue("@day", DropDownListDay.Text);
                ObjCM.Parameters.AddWithValue("@month", DropDownListMonth.Text);
                ObjCM.Parameters.AddWithValue("@year", DropDownListYear.Text);

                ObjCM.ExecuteNonQuery();

            }
            ObjConn.Close();
        }

    }
}