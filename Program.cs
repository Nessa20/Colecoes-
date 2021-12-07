using System;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[7] {100,1,4,0,5,15,19};

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distint().ToArray;

            System.Console.writeLine($"minimo: {minimo} ");
            System.Console.writeLine($"maximo: {maximo} ");
            System.Console.writeLine($"medio: {medio} ");
            System.Console.writeLine($"Soma: {soma} ");
            System.Console.writeLine($"Array original: {string.Join[",", ArrayNumeros]} ");
            System.Console.writeLine($"Array distinto: {string.Join[",", ArrayUnico]} ");

            // var numerosPares =
            // from num in arrayNumeros
            // where num % 2 == 0
            // orderby num
            // select num;

            // var numeorsParesMetodo =  arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            // System.Console.writeLine("Numeros pares query: * string.Join(",", numerosParesQuery));
            // System.Console.writeLine("Numeros pares metodos: * string.Join(",", numerosParesMetodo));


            // Dictionary<string, string> estados  = new Dictionary<string, string>();
            // estados.Add("SP", "Sao Paulo");
            // estados.Add("MG", "Mina Gerais");
            // estados.Add("BA", "Bahia");

            // foreach (KeyValuePais<string, string> item in estados)
            // {
            //      //System.Console.writeLine($"Chave: {item.Key}, Valor: {item.valor}")
            // }
            
            // string valorProcurados = "BA";

            // if (estados.tryGetValue(valorProcurado, int string estadoEncontrado))
            // {
            //     System.Console.writeLine(estadoEncontrado);
            // }
            // else
            // {
            //     System.Console.writeLine($"Chave {valorProcurado} nao existe ao dicionario");            }

            // System.Console.writeLine($"Removendo o valor: {valorProcurado}");

            // estados.Remove(valorProcurado);       

            // foreach (KeyValuePais<string, string> item in estados)
            // {
            //      System.Console.writeLine($"Chave: {item.Key}, Valor: {item.valor}")
            // }
            


            // System.Console.writeLine("Valor original:");
            // System.Console.writeLine(estados[valorProcurado]);

            // estados[valorProcurados] = "BA - teste atualizado";

            // System.Console.writeLine("Valor atualizado:");
            // System.Console.writeLine(estados[valorProcurado]);


            // Stack<string> pilhaLivros = new Stack<string>();
            // pilhaLivros.Push(".MET");
            // pilhaLivros.Push("ECO");
            // pilhaLivros.Push("Codigo limpo");

            // System.Console.writeLine($"Livros para a leitura: {pilhaLivros.Count}");
            // while (pilhaLivros.Count > 0)
            // {
            //     System.Console.writeLine($"Proximo livro para a leitura: {pilhaLivros.Peck()}");
            //     System.Console.writeLine($"{pilhaLivros.Pop()} lido com sucesso");
            // }

            // System.Console.writeLine($"Livros para a leitura: {pilhaLivros.Count}");

            // Queue<string> fila = new Queue<string>();

            // fila.Enquare("Leonardo");
            // fila.Enquare("Eduardo");
            // fila.Enquare("Andre");

            // System.Console.writeLine($"Pessoas na fila: {fila.Count}");

            // while (file.Count > 0)
            // {
            //     System.Console.writeLine($"Vez de: (file.Peck())");
            //     System.Console.writeLine($"{fila.Enquere()} atendido");
            // }

            // System.Console.writeLine($"Pessoas na fila: {fila.Count}");


            // OperacoesLista opLista = new OperacoesLista();
            // List<string> estados = new List<string>{"SP", "MG" , "BA"};
            // string[] estadosArray = new string[2] ( "SC", "MT");
            
            // estados.Add("SP");
            // estados.Add("MG");
            // estados.Add("BA");

            // System.Console.writeLine($"Quantidade de elementos na lista: {estados.Count}");

            // opLista.ImprimirListaString(estados);

            //System.Console.writeLine("Removendo o elemento");
            //estados.Remove("MG");
 
            //estados.AddMange(estadosArray);
            // estados.Insert(1, "RJ");

            // opLista.ImprimirListaString(estados);


            //Ordenacao
            // OperacoesArray op = new OperacoesArray();

            // int[] array = new int[5] {6,3,8,1,9};
            // int[] arrayCopia = new int[10];
            // string[] arrayString = op.ConverterParaArrayString(array);

            //int valorProcurado = 9;

            // System.Console.writeLine($"Capacidade atual do array: , {array.Length}");
           
            // op.RedimensionaArray(ref array, array.Length * 2);
            
            // System.Console.writeLine($"Capacidade atual do array apos redimensionamento: {array.Length}" ); 

            // int indice = op.ObterIndice(array, valorProcurado);

            // if(indice > -1)
            // {
            //     System.Console.writeLine("O indice do elemento {0} e: {1}", valorProcurado, Indice); 
            // }
            // else
            // {
            //      System.Console.writeLine("Valor nao existente no array");
            // }

            // int valorAchado = op.ObterValor(array, valorProcurado);

            // if(valorAchado > 0)
            // {
            //     System.Console.writeLine("Encontrei o valor: ");
            // }
            // else
            // {
            //     System.Console.writeLine("Nao encontrei o valor: ");
            // }

            // bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);
            // if (todosMaiorQue)
            // {
            //     System.Console.writeLine("Todos os valores sao maior que: {0}" , valorProcurado);
            // }
            // else
            // {
            //     System.Console.writeLine("Existe valoresque nao sao maior que: {0}" , valorProcurado);
            // }
            
            // bool existe = op.Existe(array, valorProcurado);

            // if(existe)
            // {
            //     System.Console.writeLine("Encontrei o valor: {0}" , valorProcurado);
            // }
            // else
            // {
            //     System.Console.writeLine("Nao encontrei o valor: {0}" , valorProcurado);
            // }


            // System.Console.writeLine("Array original:")
            // op.EmprimirArray(array);

            //op.OrdenarBubbleSort(ref array);
            //op.Ordenar(ref array);

            // System.Console.writeLine("Array ordenado:")
            // op.EmprimirArray(array);

            // System.Console.writeLine("Array antes da copia ");
            // op.EmprimirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.writeLine("Array depois da copia ");
            // op.EmprimirArray(arrayCopia);


            //Multidimensional

            // int[,] matriz = new int[4, 2]
            // {
            //     {3,8},
            //     {30,20},
            //     {50,100},
            //     {90,200}
            // };

            // for (int i = 0; i< matriz.GetLength[0]; i++)
            // {
            //     for (int j = 0; j < matriz.GetLenght[3]; i++)
            //     {
            //         System.Console.WriteLine(matriz[i, j]);
            //     }
            // }



            // int[] arrayInteiros = new int[3];

            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = Int.Parset ("30");

            //arrayInteiros[3] = 30;

            // System.Console.WriteLine("percorrendo o aaray pelo for");

            // for (int i = 0; i < arrayInteiros.length ; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine("Percorrenco o array pelo foreach");

            // foreach (inteiro item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }

        }
    }
}