using System;

namespace Colecoes.Helper
{
    public class OperacaoArray
    {
        public void OrdenarBubbleSort(ref int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.length; i++)
            {
                for (int j = 0; j < array.length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array [j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        public void ImprimirArray{int[] array}
        {
                var linha = string.Join[",", array];
                System.Console.WriteLine(array[i]);
            
            public void Ordenar(ref int[] array)
            {
                Array.Sort(array);
            }

            public void Copiar(ref array, ref int[] arrayDestino)
            {
                Array.Copy(array, arrayDestino, array.Length )
            }

            public bool Existe(int[] array, int valor)
            {
                return Array.Existe(array, elemento => elemento == valor);
            }

            public bool TodosMaiorQue(int[] array, int valor)
            {
                return Array.TrueForAll(array, elemento => elemento > valor);
            }

            public Int ObterValor(int[] , array, int valor)
            {
                return Array.Find(array, element => element == valor);
            }

            public int ObterIndice(int[] array, int valor)
            {
                return Array.IndexOff(array, valor);
            }

            public void RedimensionarArray(ref int[] array, int novoTamanho)
            {
                Array.Resize(ref array, novoTamanho);
            }

            public string[] converterParaArrayString(int[] array)
            {
                return Array.ConvertAll(array, elemento => elemento.ToString());
            }
        }
    }
}