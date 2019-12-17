<%@ Page Title="" Language="C#" MasterPageFile="~/PMS.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="ProjectManger.Users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>This is user page</h1>
    <div style="background-color:azure;text-align:center; width:50%">

    <table border="1">
        <tr>
            <td>User Name: </td>
            <td style="width:70%"><asp:TextBox ID="txtUserName" runat="server" Width="100%"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Roll No: </td>
            <td><asp:TextBox ID="txtRollNo" runat="server" Width="100%"></asp:TextBox></td>
        </tr>ss
        <tr>
            <td>User Group: </td>
            <td><asp:DropDownList ID="dbUserGroup" runat="server" Width="100%" DataSourceID="UserGroupData" DataTextField="GrpName" DataValueField="GrpName" OnTextChanged="dbUserGroup_TextChanged" OnSelectedIndexChanged="dbUserGroup_SelectedIndexChanged"></asp:DropDownList>
                <asp:SqlDataSource ID="UserGroupData" runat="server" ConnectionString="<%$ ConnectionStrings:MyConnection %>" SelectCommand="SELECT [GrpName] FROM [Groups]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>User Type: </td>
            <td><asp:DropDownList ID="dbUserType" runat="server" Width="100%" DataSourceID="UserTypesData" DataTextField="TypeName" DataValueField="TypeName"></asp:DropDownList>
                <asp:SqlDataSource ID="UserTypesData" runat="server" ConnectionString="<%$ ConnectionStrings:MyConnection %>" SelectCommand="SELECT DISTINCT [TypeName] FROM [UserTypes]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>User Project: </td>
            <td><asp:TextBox ID="txtUserProject" runat="server" Width="100%"></asp:TextBox></td>
            
        </tr>



        <tr>
            <td><asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="100%" OnClick="btnSubmit_Click" /></td>
            <td><asp:Label ID="lblMsg" runat="server" Text=""></asp:Label> </td>
        </tr>
    </table>

    </div>
</asp:Content>
