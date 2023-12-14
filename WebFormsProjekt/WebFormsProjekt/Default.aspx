<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsProjekt.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Employee information</h2>
            <br />
            <br />
            Name:
            <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="NameValidator" runat="server" ControlToValidate="tbName" ErrorMessage="Ime je obavezan podatak"></asp:RequiredFieldValidator>
            <br />
            <br />
            Select office: <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                <asp:ListItem>Select...</asp:ListItem>
                <asp:ListItem>Zagreb</asp:ListItem>
                <asp:ListItem>Split</asp:ListItem>
                <asp:ListItem>Rijeka</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Department:<br />
            <asp:RadioButton ID="rbMarketing" runat="server" GroupName="DepartmentGroup" Text="Marketing" />
            <br />
            <asp:RadioButton ID="rbAccounting" runat="server" GroupName="DepartmentGroup" Text="Accounting" />
            <br />
            <asp:RadioButton ID="rbHR" runat="server" GroupName="DepartmentGroup" Text="HR" />
            <br />
            <br />
            Qualifications:<br />
            <asp:CheckBox ID="cbBA" runat="server" Text="BA" />
            <br />
            <asp:CheckBox ID="cbMA" runat="server" Text="MA" />
            <br />
            <asp:CheckBox ID="cbPhd" runat="server" Text="PHD" />
            <br />
            <br />
            <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
            <br />
            <br />
            <asp:Label ID="lblResult" runat="server" Text="[Result]" Visible="False"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
