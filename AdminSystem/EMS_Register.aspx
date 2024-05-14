<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EMS_Register.aspx.cs" Inherits="EMS_Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 317px">
    <form id="form1" runat="server">
        <div id="Register" style="height: 336px; margin-left: 3px">
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 14px; top: 61px; position: absolute; " Text="Password" width="172px"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 14px; top: 29px; position: absolute; height: 19px; width: 172px" Text="Username"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 14px; top: 102px; position: absolute; right: 904px" Text="Name"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 108px; top: 58px; position: absolute" height="22px"></asp:TextBox>
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 108px; top: 99px; position: absolute" height="22px"></asp:TextBox>
            <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 108px; top: 29px; position: absolute"></asp:TextBox>
            <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 14px; top: 146px; position: absolute; height: 18px; width: 172px" Text="Salary"></asp:Label>
            <asp:TextBox ID="txtSalary" runat="server" style="z-index: 1; left: 108px; top: 149px; position: absolute" height="22px"></asp:TextBox>
            <asp:CheckBox ID="Trained" runat="server" style="z-index: 1; left: 14px; top: 193px; position: absolute" width="172px" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 291px; position: absolute" Text="lblError" width="172px"></asp:Label>
            <asp:Button ID="btnRegister" runat="server" style="z-index: 1; left: 37px; top: 241px; position: absolute; height: 26px" Text="Register" OnClick="btnRegister_Click" />
        </div>
    </form>
</body>
</html>
