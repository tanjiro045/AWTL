<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataBound.aspx.cs" Inherits="Practical6a.DataBound" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>STUDENT DATA</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>STUDENT INFO</h2>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
                CellPadding="6" OnRowCancelingEdit="GridView1_RowCancelingEdit"
                OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btn_Edit" runat="server" Text="Edit" CommandName="Edit" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Button ID="btn_Update" runat="server" Text="Update"
                                CommandName="Update" />
                            <asp:Button ID="btn_Cancel" runat="server" Text="Cancel"
                                CommandName="Cancel" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ID">
                        <ItemTemplate>
                            <asp:Label ID="lbl_ID" runat="server" Text='<%#Eval("ID") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="NAME">
                        <ItemTemplate>
                            <asp:Label ID="lbl_Name" runat="server" Text='<%#Eval("NAME") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_Name" runat="server" Text='<%#Eval("NAME") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="COURSE">
                        <ItemTemplate>
                            <asp:Label ID="lbl_Course" runat="server" Text='<%#Eval("DEGREE") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_Course" runat="server" Text='<%#Eval("DEGREE") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="SUBJECT">
                        <ItemTemplate>
                            <asp:Label ID="lbl_Subject" runat="server" Text='<%#Eval("SUBJECT") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_Subject" runat="server" Text='<%#Eval("SUBJECT") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <HeaderStyle BackColor="#FBB917" ForeColor="#000" />
                <RowStyle BackColor="#e7ceb6" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
