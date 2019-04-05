<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Detail.aspx.cs" Inherits="Detail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 69px;
        }
    </style>
</head>
<body style="height: 436px">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" ForeColor="Red" Text=" Detail "></asp:Label>
        </div>
        <br />
        <asp:GridView ID="GridView1" runat="server" Height="216px" Width="690px">
        </asp:GridView>
    </form>
</body>
</html>
