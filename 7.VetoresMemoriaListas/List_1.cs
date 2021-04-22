
//LISTAS

using System;
using System.Collections.Generic;


namespace Course{
    class Program{
        static void Main(string[] args){

            List<string> list = new List<string>();

            //add elementos sempre na última posicao
            list.Add("Levi");
            list.Add("Brady");
            list.Add("Vintage");
            list.Add("John");

            //add elementos em posicoes especificas
            list.Insert(2, "Oasis");

            foreach (string obj in list){
                Console.WriteLine(obj)
            }

            //verificando qtd de elementos
            Console.WriteLine("List Count: " + list.Count());

            //encontrar 1º ou nº elemento que satisfaca um predicado
            //predicado = funcao que retorna o valor quando for true 

            string s1 = list.Find(x => x[0] == 'A');  //Expressao lambda = funcao anonima
            Console.WriteLine("First 'A': " + s1);
            
            string s1 = list.FindLast(x => x[0] == 'A');  //Expressao lambda
            Console.WriteLine("Last 'A': " + s1);

            //encontrar 1º ou nº posicao que satisfaca um predicado

            int pos1 = list.FindIndex(x => x[0] == 'A')
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A')
            Console.WriteLine("Last position 'A': " + pos2);

            //Filtrar lista = filtrar lista, criando outra, baseado em um predicado

            List<string> list2 = list.FindAll(x => x.Length == 5);

            foreach (string obj in list2){
                Console.WriteLine(obj);
            }

            //remover elementos da lista
            
            list.Remove("Oasis");

            list.RemoveAll(x ==> x[0] == 'M');

            //remove baseado na posicao
            list.RemoveAt(2);

            //rmeover elementos de um faixa = posicao, contagem
            list.RemoveRange(2,2);           

        }
    }
}