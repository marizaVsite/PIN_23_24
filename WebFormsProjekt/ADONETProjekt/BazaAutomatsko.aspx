<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BazaAutomatsko.aspx.cs" Inherits="ADONETProjekt.BazaAutomatsko" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" PageSize="1">
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
        <asp:BoundField DataField="Ime" HeaderText="Ime" SortExpression="Ime" />
        <asp:BoundField DataField="Prezime" HeaderText="Prezime" SortExpression="Prezime" />
        <asp:BoundField DataField="GodinaUpisa" HeaderText="GodinaUpisa" SortExpression="GodinaUpisa" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AdoNetConnectionString %>" 
    DeleteCommand="DELETE FROM [Student] WHERE [Id] = @Id" 
    InsertCommand="INSERT INTO [Student] ([Ime], [Prezime], [GodinaUpisa]) VALUES (@Ime, @Prezime, @GodinaUpisa)" 
    SelectCommand="SELECT * FROM [Student]" 
    UpdateCommand="UPDATE [Student] SET [Ime] = @Ime, [Prezime] = @Prezime, [GodinaUpisa] = @GodinaUpisa WHERE [Id] = @Id">
    <DeleteParameters>
        <asp:Parameter Name="Id" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="Ime" Type="String" />
        <asp:Parameter Name="Prezime" Type="String" />
        <asp:Parameter Name="GodinaUpisa" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="Ime" Type="String" />
        <asp:Parameter Name="Prezime" Type="String" />
        <asp:Parameter Name="GodinaUpisa" Type="Int32" />
        <asp:Parameter Name="Id" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>
</asp:Content>
