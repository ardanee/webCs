<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WsClient.aspx.cs" Inherits="webCs.pages.WsClient" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="Stylesheet" href="../css/bootstrap.css" />
<link rel="Stylesheet" href="../css/alertify.min.css"/>

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="lista">
    
    </div>
    </form>

    <script src="../js/jquery.min.js"></script>
    <script src="../js/bootstrap.min.js"></script>
    <script src="../js/alertify.min.js"></script>
    <script>
    var parametros = JSON.stringify({'nombre':'luis'});
       $.ajax({
          url: 'WebService1.asmx/prueba',
          type: 'POST',
          data: parametros,
          dataType: "text json",
          contentType: "application/json; charset=utf-8",
          success: function (msg) {
             tabla = JSON.parse(msg.d);
             var html = '<table class="table table-condensed">';
            $.each(tabla, function (index, item) {
                   html += '<tr>' +
                              '<td>' + item['col1'] + '</td>' +
                              '<td>' + item['col2'] + '</td>' +
                              '<td>' + item['col3'] + '</td>' +
                           '</tr>';
                });
                html += '</table>';
                $('#lista').html(html);
             }
                    , error: function (xhr, status) {
                       alertify.error('Ha ocurrido un error al contactar con el servidor');

                    }

       });
    </script>

</body>
</html>
