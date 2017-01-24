<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="webCs.pages.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TextBox runat="server" ID="txtNombre"></asp:TextBox>
    <asp:Button runat="server" ID="btnBuscar" text ="Buscar" 
          onclick="btnBuscar_Click"/>
    <asp:Button runat="server" ID="btnGrabar" text ="Grabar" 
          onclick="btnGrabar_Click"/>

    <asp:GridView ID="grdIdiomas" runat="server" AutoGenerateColumns="False">
       <Columns>
          <asp:BoundField DataField="IdIdioma" HeaderText="Id" />
          <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
          <asp:TemplateField>
             <ItemTemplate>
                <asp:LinkButton ID="lnkEdit" runat="server" onclick="lnkEdit_Click">LinkButton</asp:LinkButton>
             </ItemTemplate>
          </asp:TemplateField>
       </Columns>
    </asp:GridView>
    </div>
    </form>
</body>
</html>
