<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical6c.aspx.cs" Inherits="Practical_6.Practical6c" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Parameterized Stored Procedure<br />
            EMPID:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            EMPNAME:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            DEPT:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
            <br />
            Result: <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
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
