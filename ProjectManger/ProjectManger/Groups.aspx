<%@ Page Title="" Language="C#" MasterPageFile="~/PMS.Master" AutoEventWireup="true" CodeBehind="Groups.aspx.cs" Inherits="ProjectManger.Groups" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>This is group page</h1>
    <div style="background-color:azure;text-align:center; width:40%; margin: 0px auto;">
    <table border="1">
        <tr>
            <td>Group Name: </td>
            <td><asp:TextBox ID="txtGrpName" runat="server" Width="100%"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Project Name: </td>
            <td><asp:DropDownList ID="dpProjects" runat="server" Width="100%" DataSourceID="ProjectData" DataTextField="ProName" DataValueField="ProName"></asp:DropDownList>
                <asp:SqlDataSource ID="ProjectData" runat="server" ConnectionString="<%$ ConnectionStrings:MyConnection %>" SelectCommand="SELECT [ProName] FROM [Projects]"></asp:SqlDataSource>
            </td>
        </tr>

        <tr>
            <td><asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="100%" OnClick="btnSubmit_Click" /></td>
            <td><asp:Label ID="lblMsg" runat="server" Text=""></asp:Label> </td>
        </tr>
    </table>
    </div>
</asp:Content>
