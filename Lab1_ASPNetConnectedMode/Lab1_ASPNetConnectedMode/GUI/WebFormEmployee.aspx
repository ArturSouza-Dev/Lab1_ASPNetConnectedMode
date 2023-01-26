<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormEmployee.aspx.cs" Inherits="Lab1_ASPNetConnectedMode.GUI.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 444px;
        }
        .auto-style5 {
            width: 277px;
        }
        .auto-style7 {
            width: 277px;
            height: 26px;
        }
        .auto-style9 {
            height: 26px;
        }
        .auto-style11 {
            width: 277px;
            height: 33px;
        }
        .auto-style13 {
            height: 33px;
        }
        .auto-style14 {
            width: 129px;
        }
        .auto-style15 {
            width: 129px;
            height: 33px;
            text-align: right;
        }
        .auto-style16 {
            width: 129px;
            height: 26px;
        }
        .auto-style17 {
            text-align: center;
            height: 61px;
        }
        .auto-style18 {
            height: 593px;
        }
        .auto-style20 {
            width: 129px;
            text-align: right;
        }
        .auto-style21 {
            width: 278px;
        }
        .auto-style22 {
            width: 278px;
            height: 33px;
        }
        .auto-style23 {
            width: 278px;
            height: 26px;
        }
        .auto-style24 {
            margin-left: 3px;
            margin-top: 0px;
        }
        .auto-style25 {
            width: 129px;
            height: 23px;
        }
        .auto-style26 {
            width: 277px;
            height: 23px;
        }
        .auto-style27 {
            width: 278px;
            height: 23px;
        }
        .auto-style28 {
            height: 23px;
        }
        .auto-style29 {
            width: 129px;
            height: 6px;
        }
        .auto-style30 {
            width: 277px;
            height: 6px;
        }
        .auto-style31 {
            width: 278px;
            height: 6px;
        }
        .auto-style32 {
            height: 6px;
        }
    </style>
</head>
<body style="height: 489px; width: 878px">
    <form id="form1" runat="server">
        <div class="auto-style18">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style17" colspan="4">Employee Maintenance</td>
                </tr>
                <tr>
                    <td class="auto-style20">Employee ID</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtEmployeeID" runat="server" Width="260px"></asp:TextBox>
                    </td>
                    <td class="auto-style21">
                        <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" Width="157px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style20">First Name</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtFirstName" runat="server" Width="260px"></asp:TextBox>
                    </td>
                    <td class="auto-style21">
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" Width="157px" OnClick="btnUpdate_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style15">Last Name</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtLastName" runat="server" Width="260px"></asp:TextBox>
                    </td>
                    <td class="auto-style22">
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="157px" />
                    </td>
                    <td class="auto-style13"></td>
                </tr>
                <tr>
                    <td class="auto-style20">Job Title</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtJobTitle" runat="server" Width="260px"></asp:TextBox>
                    </td>
                    <td class="auto-style21">
                        <asp:Button ID="btnListAll" runat="server" Text="List All" Width="157px" OnClick="btnListAll_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style16"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style23"></td>
                    <td class="auto-style9"></td>
                </tr>
                <tr>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style21">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style16"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style23"></td>
                    <td class="auto-style9"></td>
                </tr>
                <tr>
                    <td class="auto-style20">Search By</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlSearchCriteria" runat="server" Width="245px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style21">
                        <asp:TextBox ID="txtSearch" runat="server" Width="260px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnSearch" runat="server" Text="Search" Width="157px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style25">&nbsp;</td>
                    <td class="auto-style26"></td>
                    <td class="auto-style27"></td>
                    <td class="auto-style28"></td>
                </tr>
                <tr>
                    <td class="auto-style25">&nbsp;</td>
                    <td class="auto-style26">&nbsp;</td>
                    <td class="auto-style27">&nbsp;</td>
                    <td class="auto-style28">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style25">&nbsp;</td>
                    <td class="auto-style26">&nbsp;</td>
                    <td class="auto-style27">&nbsp;</td>
                    <td class="auto-style28">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style25">Employee List</td>
                    <td class="auto-style26">&nbsp;</td>
                    <td class="auto-style27">&nbsp;</td>
                    <td class="auto-style28">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style29"></td>
                    <td class="auto-style30"></td>
                    <td class="auto-style31"></td>
                    <td class="auto-style32"></td>
                </tr>
            </table>
            <asp:GridView ID="gvEmployees" runat="server" Height="166px" Width="874px" CssClass="auto-style24">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
