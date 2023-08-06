<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PracticalValidation4._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            
        </section>

        <div class="row">
            
            Name:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name is Required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
            Email:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Email-id is required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="Email-id is not valid" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            Class:
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>FYMCA-A</asp:ListItem>
                <asp:ListItem>FYMCA-B</asp:ListItem>
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="Please select class" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
            Roll No:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox3" ErrorMessage="Roll No is required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
            <br />
            Subjects:
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem>IS</asp:ListItem>
                <asp:ListItem>AIML</asp:ListItem>
                <asp:ListItem>MFCS</asp:ListItem>
            </asp:CheckBoxList>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            <asp:Button ID="Button2" runat="server" Text="Reset" />
            <br />
            
        </div>
    </main>

</asp:Content>
