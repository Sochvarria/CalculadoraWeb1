
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="CalculadoraWeb1.inicio" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mi Calculadora</title>

    <style>
        body {
            background-color: #ffe0ef;
            font-family: Arial;
            text-align: center;
        }

        .caja {
            background-color: white;
            width: 400px;
            margin: 50px auto;
            padding: 25px;
            border-radius: 20px;
        }

        h1 {
            color: #cc4b91;
        }

        .entrada {
            padding: 10px;
            border: 1px solid #e8a5cb;
            border-radius: 8px;
        }

        .boton {
            background-color: #f5b5d8;
            color: #71345a;
            border: none;
            padding: 10px;
            margin: 5px;
            border-radius: 8px;
            cursor: pointer;
        }

        .boton:hover {
            background-color: #e994c4;
        }

        .resultado {
            color: #b13b83;
            font-size: 22px;
            font-weight: bold;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">

        <div class="caja">

            <h1>Mi Calculadora</h1>
            <p>Realiza tus operaciones matemáticas</p>

            <p>
                <asp:Label ID="Numero1" runat="server"
                    Text="Número 1: "></asp:Label>

                <asp:TextBox ID="Num1" runat="server"
                    CssClass="entrada"></asp:TextBox>
            </p>

            <p>
                <asp:Label ID="Numero2" runat="server"
                    Text="Número 2: "></asp:Label>

                <asp:TextBox ID="Num2" runat="server"
                    CssClass="entrada"></asp:TextBox>
            </p>

            <p>
                <asp:Label ID="Result" runat="server"
                    Text="Resultado: "></asp:Label>

                <asp:Label ID="Lresultado" runat="server"
                    Text="0" CssClass="resultado"></asp:Label>
            </p>

            <hr />

            <h3>Operaciones básicas</h3>

            <asp:Button ID="Button1" runat="server"
                Text="Sumar (+)" CssClass="boton"
                OnClick="Button1_Click" />

            <asp:Button ID="Button2" runat="server"
                Text="Restar (-)" CssClass="boton"
                OnClick="Button2_Click" />

            <asp:Button ID="Button3" runat="server"
                Text="Multiplicar (*)" CssClass="boton"
                OnClick="Button3_Click" />

            <asp:Button ID="Button4" runat="server"
                Text="Dividir (/)" CssClass="boton"
                OnClick="Button4_Click" />

            <h3>Otras operaciones</h3>

            <asp:Button ID="Button5" runat="server"
                Text="Potencia 2" CssClass="boton"
                OnClick="Button5_Click" />

            <asp:Button ID="Button6" runat="server"
                Text="Exp" CssClass="boton"
                OnClick="Button6_Click" />

            <asp:Button ID="Button7" runat="server"
                Text="10 elevado a x" CssClass="boton"
                OnClick="Button7_Click" />

        </div>

    </form>
</body>
</html>
