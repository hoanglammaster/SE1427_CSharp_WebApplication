<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListOrder.aspx.cs" Inherits="OrderController.ListOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" runat="server" media="screen" href="~/css/style.css" />
    <script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery.dynDateTime.min.js" type="text/javascript"></script>
    <script src="Scripts/calendar-en.min.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table  ID="Table1" runat="server">
               
                <%--start row--%>
                <asp:TableRow>
                    <asp:TableHeaderCell CssClass="table__field--size table__lable--small">
                        <asp:Label Text="Customer" runat="server"/>
                    </asp:TableHeaderCell>
                    <asp:TableCell CssClass="table__field--size">
                        <asp:DropDownList ID="CustomerDDL" runat="server" CssClass="row__field--fullsize"></asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <%--end row--%>
                <%--start row--%>
                <asp:TableRow>
                    <asp:TableHeaderCell CssClass="table__field--size table__lable--small">
                        <asp:Label Text="Employee" runat="server"/>
                    </asp:TableHeaderCell>
                    <asp:TableCell CssClass="table__field--size">
                        <asp:DropDownList ID="EmployeeDDL" runat="server" CssClass="row__field--fullsize"></asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <%--end row--%>
                
                <%--start row--%>
                <asp:TableRow>
                    <asp:TableHeaderCell CssClass="table__field--size table__lable--small">
                        <asp:Label Text="From" runat="server"/>
                    </asp:TableHeaderCell>

                    <asp:TableCell CssClass="table__field--size table__cell--flex">
                        <asp:TextBox ID="FromTB" Enabled="false" CssClass="row__textbox--small" runat="server" ></asp:TextBox>
                        <asp:Button ID="FromPickDateBT" Text="Pick" OnClick="FromPickDateBT_Click" CssClass="row__button--small" runat="server"/>
                        <asp:Calendar ID="FromCelendar" Visible="false"  OnSelectionChanged="FromCelendar_SelectionChanged" runat="server"></asp:Calendar>
                    </asp:TableCell>
                </asp:TableRow>
                <%--end row--%>
                <%--start row--%>
                <asp:TableRow>
                    <asp:TableHeaderCell CssClass="table__field--size table__lable--small">
                        <asp:Label Text="To" runat="server"/>
                    </asp:TableHeaderCell>
                    <asp:TableCell CssClass="table__field--size table__cell--flex">
                        <asp:TextBox ID="ToTB" Enabled="false" CssClass="row__textbox--small" runat="server"></asp:TextBox>
                        <asp:Button ID="ToPickDateBT" Text="Pick" OnClick="ToPickDateBT_Click" CssClass="row__button--small" runat="server"/>
                        <asp:Calendar ID="ToCalendar" Visible="false" OnSelectionChanged="ToCalendar_SelectionChanged" runat="server"></asp:Calendar>
                    </asp:TableCell>
                </asp:TableRow>
                <%--end row--%>
               
                <%--start row--%>
                <asp:TableRow>
                    
                    <asp:TableHeaderCell CssClass="table__field--size table__lable--small">
                        <asp:CheckBox ID="LateOrderCheck" Text="LateOrder" OnCheckedChanged="LateOrderCheck_CheckedChanged" runat="server" AutoPostBack="true"/>
                    </asp:TableHeaderCell>
                    <asp:TableCell CssClass="table__field--size table__lable--small">
                        <asp:Button ID="CreateBT" Text ="Create" runat="server"/>
                    </asp:TableCell>
                </asp:TableRow>
                <%--end row--%>
               
            </asp:Table>
        </div>
        <div>
            <asp:DataGrid ID="GridViewOrder" runat="server" EnableViewState="false">
            </asp:DataGrid>
        </div>

    </form>
</body>
</html>
