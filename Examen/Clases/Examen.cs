using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Clases
{
    class Examen
    {
        /// <summary>
        /// Funcion que determina si un numero es primo
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static Boolean esPrimo(int num)
        {
            Boolean primo = true; 
            for (int i= 2; i <= num / 2; i++)
            {
                if(num%i==0)
                {
                    primo = false;
                    break;//abandonar bucle
                }
            }
            return primo;
        }
        public static int sumatoria(int limite)
        {
            int cont = 0;
            int num = 2, suma = 0;
            while(cont < limite)
            {
                if (esPrimo(num))
                {
                    suma += num;
                    cont++; 
                }
                num++;
            }
            return suma;
        }
        public static long factorial(int num)
        {
            long fac = 1;
            if (num == 0 || num == 1)
                return fac;
            for(int i=1;i<=num;i++)
                fac = fac * i;
            return fac;
        }
        public static double sumaFactorial(int limite)
        {
            double suma = 0;
            int j = limite;
            for(int i=1;i<=limite;i++)
            {
                suma = suma + Math.Pow(2, i) * factorial(j--);
                
            }
            return suma;
        }
    }
}
