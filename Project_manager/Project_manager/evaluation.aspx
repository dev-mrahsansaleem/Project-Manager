<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="evaluation.aspx.cs" Inherits="Project_manager.evaluation" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <table style="padding-left:35%">
        <tr>
                <td class="auto-style1" style="padding-bottom: 5%">
                    <strong>Group ID</strong>
                </td>
                <td style="padding-bottom: 5%">
                    <asp:DropDownList ID="DropDownList1" DataTextField="id" DataValueField="id" runat="server" Width="150px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="padding-bottom: 5%">
                    <strong>Total Marks</strong>
                </td>
                <td style="padding-bottom: 5%">
                    <asp:TextBox ID="totalmarks" runat="server" Width="145px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="padding-bottom: 5%">
                    <strong>Obtained Marks</strong>
                </td>
                <td style="padding-bottom: 5%">
                    <asp:TextBox ID="obtainedmarks" runat="server" Width="145px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="padding-bottom: 5%">
                    <asp:Button ID="Submit" runat="server" Font-Size="Medium" Text="Submit" OnClick="Insert_Click" />
                </td>
            </tr>
    </table>           
    </div>

</asp:Content>
