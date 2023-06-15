<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeDisconnected.aspx.cs" Inherits="Practical_5.EmployeeDisconnected" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="EMPID" HeaderText="EMPID" SortExpression="EMPID" />
                    <asp:BoundField DataField="EMPNAME" HeaderText="EMPNAME" SortExpression="EMPNAME" />
                    <asp:BoundField DataField="DEPT" HeaderText="DEPT" SortExpression="DEPT" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MCAConnectionString %>" SelectCommand="SELECT * FROM [EMP]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
