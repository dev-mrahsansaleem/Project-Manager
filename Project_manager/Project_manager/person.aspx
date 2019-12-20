<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="person.aspx.cs" Inherits="Project_manager.person" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
     <div>
            <table style="padding-left:35%;padding-top:10%">
                <tr>
                <td style="padding-bottom: 5%">
                    Name
                </td>
                <td style="padding-bottom: 5%">
                    <asp:TextBox ID="name" runat="server" Width="145px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="padding-bottom: 5%">
                    Father Name
                </td>
                <td style="padding-bottom: 5%">
                    <asp:TextBox ID="fathername" runat="server" Width="145px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="padding-bottom: 5%">
                    Registration No.
                </td>
                <td style="padding-bottom: 5%">
                    <asp:TextBox ID="regNo" runat="server" Width="145px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="padding-bottom: 5%">
                    Type
                </td>
                <td style="padding-bottom: 5%">
                    <asp:DropDownList ID="type" runat="server" OnSelectedIndexChanged="type_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="padding-bottom: 5%">
                    <asp:Button ID="Submit" runat="server" Font-Size="Medium" Text="Submit" OnClick="Insert_Click" />
                </td>
                <td style="padding-bottom: 5%">
                    <asp:Button ID="Clear" runat="server" Font-Size="Medium" Text="Clear" OnClick="Delete_Click" />
                </td>            
            </tr>
        </table>         
    </div>
</asp:Content>
