<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Upload.aspx.cs" Inherits="Upload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 137px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:DropDownList ID="DropDownListDay" runat="server">
            </asp:DropDownList>
&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownListMonth" runat="server">
            </asp:DropDownList>
&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownListYear" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Label ID="Label1" runat="server" Text="Upload สำเร็จ" Visible="False"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="อัพโหลด" />
        </div>
    </form>
</body>
</html>
