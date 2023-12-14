<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BazaConnected.aspx.cs" Inherits="ADONETProjekt.Baza" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div>
            ID: <asp:TextBox ID="tbId" runat="server"></asp:TextBox>
            Ime: <asp:TextBox ID="tbIme" runat="server"></asp:TextBox>
            Prezime: <asp:TextBox ID="tbPrezime" runat="server"></asp:TextBox>
            Godina upisa: <asp:TextBox ID="tbGodina" runat="server"></asp:TextBox>
            <hr />
            <asp:GridView ID="gvStudents" runat="server">
            </asp:GridView>
            <hr />
            <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
            <asp:Button ID="btnDisplay" runat="server" Text="Display" OnClick="btnDisplay_Click" />
            <asp:Button ID="btnTotal" runat="server" Text="Total" OnClick="btnTotal_Click" />
            <asp:Label ID="lblTotal" runat="server"></asp:Label>
        </div>

</asp:Content>
