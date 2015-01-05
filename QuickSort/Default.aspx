<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<center>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Método QuickSort</h1>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Ingrese cada número seguido de un espacio"></asp:Label>
        </p>
        
        <asp:TextBox ID="txtDatos"  runat="server" required Width="372px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnOrdenar" runat="server" OnClick="Button1_Click" Text="Ordenar" />
        <br />
        <br />
        <asp:Label ID="lblRes" runat="server"></asp:Label>
        <br />
        
    </div>
    </form>
</body>
</center>
</html>
