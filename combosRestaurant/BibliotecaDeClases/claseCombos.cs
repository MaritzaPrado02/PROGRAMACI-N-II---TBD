using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class claseCombos
    {
        public string[] nombres = new string[1];
        public double[] costoCombos = new double[1];

        //Método de arreglo Jagged Array
        public string[][] productosCombos = new string[1][];
        public int[][] cantidadProductos = new int[1][];

        public int nNombres;
        public int nCostos;
        public int nCombo;
        public int nProductos;

        public int totalCombos;


        public int n, x,z;


        public void almacenarNombre()
        {
            nNombres++;
            Array.Resize(ref nombres, nombres.Length + 1);       
        }

        public void definirArreglosProd()
        { 
            if (x == 0)
            {
                productosCombos[nCombo] = new string[1];
                cantidadProductos[nCombo] = new int[1];
            }
            
        }

        public void capturarProdCombo()
        {
            Array.Resize(ref productosCombos[nCombo], productosCombos[nCombo].Length + 1);
            Array.Resize(ref cantidadProductos[nCombo], cantidadProductos[nCombo].Length + 1);
            nProductos++;
        }
        public void almacenarCostosCombos()
        {
            Array.Resize(ref costoCombos, costoCombos.Length + 1);
            nCostos++;
        }

        public void crearCombo()
        {
            nProductos = 0;
            Array.Resize(ref productosCombos[nCombo], productosCombos[nCombo].Length - 1);
            Array.Resize(ref cantidadProductos[nCombo], cantidadProductos[nCombo].Length - 1);
            nCombo++;
            Array.Resize(ref productosCombos, productosCombos.Length + 1);
            Array.Resize(ref cantidadProductos, cantidadProductos.Length + 1);
        }

        
        public  static Array ResizeArray(Array arr, int[] newSizes)
         {
            if (newSizes.Length != arr.Rank)
                throw new ArgumentException("arr must have the same number of dimensions " +
                                            "as there are elements in newSizes", "newSizes");

            var temp = Array.CreateInstance(arr.GetType().GetElementType(), newSizes);
            int length = arr.Length <= temp.Length ? arr.Length : temp.Length;
            Array.ConstrainedCopy(arr, 0, temp, 0, length);
            return temp;
        }
          
        

        public void definirValores()
        {
            totalCombos = nNombres;
        }

        public void redimensionarArreglos()
        {
            if(n == 0)
            {
                Array.Resize(ref nombres, nombres.Length - 1);
                Array.Resize(ref costoCombos, costoCombos.Length - 1);
                //redimensionar jagger array ( # columns)
                Array.Resize(ref productosCombos, productosCombos.Length - 1);
                Array.Resize(ref cantidadProductos, cantidadProductos.Length - 1);
            }
        }

        #region metodoImpresion
        public string imprimirCombos()
        {
            var cadena = "";
            for (int i = 0; i < totalCombos; i++)
            {
                cadena += "Combo: " + nombres[i] + "\nProductos que incluye: " + "\n";

                for (int j = 0; j < productosCombos[i].Length; j++)
                {
                    cadena += cantidadProductos[i][j] + " " + productosCombos[i][j] + "\n";
                }
                cadena += "\nCosto combo: $" + costoCombos[i];     
            }
            return cadena;
        }

        #endregion
    }
}
