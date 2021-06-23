<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="OrderWebsite.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
        </div>
        <asp:DropDownList ID="DropDownList1" runat="server" Height="30px" Width="200px">
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Click Me!" />
        <asp:Button ID="btnPage2" Text="Call Page2" runat="server" width="132px" PostBackUrl="~/WebForm2.aspx" />
        <asp:GridView ID="GridView1" runat ="server" Height="245px" Width="810px">
        </asp:GridView>
    </form>
</body>
</html>
