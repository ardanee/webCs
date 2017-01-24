<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="webCs._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to ASP.NET!
    </h2>
    <p>
        To learn more about ASP.NET visit <a href="http://www.asp.net" title="ASP.NET Website">www.asp.net</a>.
    </p>
    <p>
        You can also find <a href="http://go.microsoft.com/fwlink/?LinkID=152368&amp;clcid=0x409"
            title="MSDN ASP.NET Docs">documentation on ASP.NET at MSDN</a>.
    </p>

    <asp:TextBox class="form-control" runat="server" ID="txt1"></asp:TextBox>
    <asp:DropDownList class="form-control" runat="server" ID="cb1"></asp:DropDownList>
     <asp:TextBox class="form-control" runat="server" ID="TextBox1"></asp:TextBox>
      <asp:TextBox  runat="server" ID="TextBox2" CssClass="form-control numeric"></asp:TextBox>


    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />


</asp:Content>
