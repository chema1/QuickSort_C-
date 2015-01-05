using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Ordenamiento
/// </summary>
public class Ordenamiento
{
	public Ordenamiento(){}


    public int[] ordenar(string[] datos)
    {
       
            int tam = 0;
            int[] a = null;
            int[] arreglo = null;
            tam = datos.Length;
            arreglo = new int[tam];
            try
            {
            for (int i = 0; i < tam; i++)
            {
                arreglo[i] = int.Parse(datos[i]);
            }
            a = quick_sort(arreglo, 0, tam - 1);
            return a;
            }
        catch(Exception){
            return a;
         }
        

}




    public int [] quick_sort(int []array, int low, int n) {
        int bajo = low;
        int alto = n;
        if (bajo >= n) {
            return array;
        }
        int mitad = array[(bajo + alto) / 2];
        while (bajo < alto) {
            while (bajo < alto && array[bajo] < mitad) {//jugamos con cada mitad
                bajo++;
            }
            while (bajo < alto && array[alto] > mitad) {//jugamos con cada mitad
                alto--;
            }
            if (bajo < alto) {//aca ocurre lo que se ve en la animacion con las 2 flechas y los saltos
                int T = array[bajo];
                array[bajo] = array[alto];
                array[alto] = T;
            }
        }
        if (alto < bajo) {//aca ocurre lo que se ve en la animacion con las 2 flechas y los saltos
            int T = alto;
            alto = bajo;
            bajo = T;
        }
        quick_sort(array, low, bajo);
        quick_sort(array, bajo == low ? bajo + 1 : bajo, n);//aca esta lo explicado anteriormente en una sola linea
        return array;
    }
   
}
