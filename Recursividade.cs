using System;

namespace EstudoAlgortimos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write(fatorial(5));
            //Console.Read();

            //Console.WriteLine(fibonacci(5));            
            //Console.ReadKey();

            //Console.WriteLine(subtrair(5));
            //Console.ReadKey();

            int[] elementos = {8,4,3,1,70,1,9};
            Console.WriteLine(buscaBinaria(elementos,77));
            Console.ReadKey();
        }


        static int fatorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Fatorial(n - 1);
        }

        static int fibonacci(int n)  
        {            
            if (n <= 2)
            {
                return n;
            }            
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static int buscaBinaria(int[] lista, int elemento, int min = 0, int max= 0)
        {
            int meio;

            if (max == 0)
            {
                max = lista.Length - 1;
            }

            if (max < min)
            {
                return -1;
            }
            else
            {
                meio = (max + min) / 2;
            }

            if(lista[meio] > elemento)
            {
                return BuscaBinaria(lista, elemento, min, meio - 1);
            }
            else if (lista[meio] < elemento)
            {
                return BuscaBinaria(lista, elemento, meio + 1, max);
            }
            else
            {
                return meio;
            }
        }

        static int[] mergeSort(int[] lista)
        {
            int meio;
           

            if (lista.Length <= 1)
                return lista;

            meio = lista.Length / 2;

            //pegar array da esquerda
            int[] ladoEsquerdo = new int[meio];
            for (int i = 0; i < meio; i++)
            {
                ladoEsquerdo[i] = lista[i];
            }

            //pegar array da esquerda
            int[] ladoDireito = new int[meio-lista.Length];
            for (int i = 0; i < meio; i++)
            {
                ladoDireito[i] = lista[i];
            }

            return merge(ladoEsquerdo, ladoDireito);


        }

        private static int[] merge(int[] ladoEsquerdo, int[] ladoDireito)
        {
            if(ladoDireito.Length <=0 || ladoDireito ==null)
            {
                return ladoEsquerdo;
            }
            else if (ladoEsquerdo.Length <= 0 || ladoEsquerdo == null)
            {
                return ladoDireito;
            }
        }

        static int subtrair(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            Console.WriteLine("Subtracao: " + x.ToString());

            return Subtrair(x - 1);
        }


    }
}
