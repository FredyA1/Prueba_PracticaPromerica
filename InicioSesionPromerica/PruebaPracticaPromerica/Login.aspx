<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PruebaPracticaPromerica.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />

    <script type="text/javascript">
        function validateForm() {
            var username = document.getElementById('<%= txtUsuario.ClientID %>').value;
            var password = document.getElementById('<%= txtPass.ClientID %>').value;
            if (username === "" || password === "") {
                // alert("Todos los campos son obligatorios.");
                //return false;
            }
            return true;
        }
    </script>

    <style>
        .centrar-imagen {
            text-align: center;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server" onsubmit="return validateForm();" class="container">
        <div class="row justify-content-center">
            <div class="col-md-6">
                <div class="card mt-5">
                    <div class="card-header text-center">
                        <h2>Iniciar Sesión</h2>
                    </div>
                    <div class="card-body">
                        <div class="form-group">
                            <label for="txtUsername">Nombre de usuario:</label>
                            <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <asp:Label ID="Label1" runat="server" Visible="false" Text="El campo es obligatorio"></asp:Label>
                        <br />
                        <div class="form-group">
                            <label for="txtPassword">Contraseña:</label>
                            <asp:TextBox ID="txtPass" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                        </div>
                        <asp:Label ID="Label2" runat="server" Visible="false" Text="El campo es obligatorio"></asp:Label>
                        <br />

                        <div class="form-group text-center">
                            <asp:Button ID="Button1" runat="server" Text="Ingresar" class="btn btn-success" OnClick="Button1_Click" />

                        </div>
                    </div>
                </div>
            </div>
        </div>
        <p>
        </p>
    </form>

    <div class="container">
        <div class="row">
            <div class="col">
                <div class="centrar-imagen">
                    <%--<img src="ruta_de_tu_imagen.jpg" class="img-fluid" alt="Imagen centrada">--%>
                    <asp:Image ID="Image1" ImageUrl="~/Content/Logo.png" class="img-fluid" runat="server" Width="540px" Height="200" />
                </div>
            </div>
        </div>
    </div>
</body>
</html>
