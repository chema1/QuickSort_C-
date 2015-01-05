using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
     string [] arr;
     arr = txtDatos.Text.Split(' ');
     Ordenamiento var = new Ordenamiento();
     int []ord=var.ordenar(arr);
     string res = "";
     for (int i = 0; i < arr.Length; i++) {
         res += ord[i].ToString()+" ";
     }
     lblRes.Text =txtDatos.Text +"<br><h2><strong>"  + res+"</h2></strong>";
     txtDatos.Text = "";
    }
}