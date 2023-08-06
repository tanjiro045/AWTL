<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical6Student.aspx.cs" Inherits="Practical_6.Practical6Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            ID:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            NAME:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            SUBJECT:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            DEGREE:
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            RESULT:
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="submit" />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                    <asp:BoundField DataField="NAME" HeaderText="NAME" SortExpression="NAME" />
                    <asp:BoundField DataField="SUBJECT" HeaderText="SUBJECT" SortExpression="SUBJECT" />
                    <asp:BoundField DataField="DEGREE" HeaderText="DEGREE" SortExpression="DEGREE" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MCAConnectionString2 %>" ProviderName="<%$ ConnectionStrings:MCAConnectionString2.ProviderName %>" SelectCommand="SELECT * FROM [STUDENT]"></asp:SqlDataSource>

        </div>
    </form>
</body>
</html>
