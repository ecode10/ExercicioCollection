using System;
using System.Collections;
using System.Collections.Generic;

namespace ExercicioCollection
{
    class Program
    {
        static void Main(string[] args)
        {

            TrabalhandoComArray();
            Console.WriteLine();

            TrabalhandoComDictionary();
            Console.WriteLine();

            TrabalhandoComQueue();
            Console.WriteLine();

            TrabalhandoComStack();

            Console.ReadLine();
        }

        static void TrabalhandoComStack()
        {
            //o ultimo adicionado é o primeiro da lista de saída
            Stack stack = new Stack();

            //adicionar na lista
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            //pega mais nao remove da lista
            Console.WriteLine($"Peek: {stack.Peek()}");

            //remove o item
            Console.WriteLine($"Pop: {stack.Pop()}");

            //verifica se contain
            Console.WriteLine($"Contain: {stack.Contains(1)}");

            //copia o stack para um array
            object[] array = stack.ToArray();

            //imprime o array
            Console.WriteLine(string.Join(", ", array));

            //apaga o stack
            stack.Clear();
        }


        static void TrabalhandoComQueue()
        {
            //o primeiro que aparece é o primeiro que sai
            Queue queue = new Queue();

            //adicionando valores
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            //saber se tem alguma queue
            Console.WriteLine(queue.Contains(1));

            //remover o primeiro item da lista
            Console.WriteLine(queue.Dequeue());

            //copia a queue para um array
            object[] array = queue.ToArray();

            //imprimir o array
            Console.WriteLine(string.Join(",", array));

            //apagar a queue
            queue.Clear();
        }


        static void TrabalhandoComDictionary()
        {
            //chave e valor
            Dictionary<string, string> myDic = new Dictionary<string, string>
            {
                { "Mauricio", "40" },
                { "Junior", "38" },
                { "Rafael", "45" }
            };

            foreach (var item in myDic)
            {
                Console.WriteLine(item);
            }

            myDic.Remove("Rafael");

            foreach (var item in myDic)
            {
                Console.WriteLine(item);
            }

            //conta quantas chaves
            Console.WriteLine($"Numero das chaves: {myDic.Count}");

            //verifica se a chave está presente
            Console.WriteLine(myDic.ContainsKey("Junior"));

            //verifica se tem a chave e guarda na string
            myDic.TryGetValue("Junior", out string chave);

            Console.WriteLine($"Junior: {chave}");

            //loop para pegar chave e valor
            foreach (KeyValuePair<string, string> item in myDic)
            {
                Console.WriteLine($"chave {item.Key} value {item.Value} ");
            }

            //apagar o dicionario
            myDic.Clear();



            Console.WriteLine();

        }


        static void TrabalhandoComArray()
        {
            #region "Array"
            //array mutável que pode colocar qualquer tipo de dado
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Mauricio Junior");
            arrayList.Add(40);

            //pega o numero que tem na lista
            Console.WriteLine($"numero: {arrayList.Count}");

            //o comando capacity incrementa automaticamente os itens adicionados
            Console.WriteLine($"Capacity {arrayList.Capacity}");

            ArrayList arrayList1 = new ArrayList();
            arrayList1.AddRange(new object[] { "Mike", "Sally", "Egg" });

            //adicionar um array list no outro
            arrayList.AddRange(arrayList1);

            //voce pode ordenar a lista
            arrayList1.Sort();

            //order ao contrário
            arrayList1.Reverse();

            //inserir algo na segunda posicao
            arrayList1.Insert(1, "Turkey");

            //pega algumas posicoes da lista
            ArrayList range = arrayList1.GetRange(0, 2);

            //remove o primeiro da lista
            //arrayList1.RemoveAt(0);

            //remove o primeiro e segundo da lista
            //arrayList1.RemoveRange(0, 2);

            //busca pelo acerto começando pelo index
            //voce pode encontrar o ultimo index com o LastIndexOf
            Console.WriteLine($"Turkey Index {arrayList1.IndexOf("Turkey", 0)}");

            foreach (var item in arrayList1)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine();

            //convert um arraylist em um array de string
            string[] stringArray = (string[])arrayList1.ToArray(typeof(string));

            foreach (var item in stringArray)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine();

            //convert string array em array list
            string[] clientes = { "Marcos", "Marcio", "Junior" };
            ArrayList arrayClientes = new ArrayList();
            arrayClientes.AddRange(clientes);

            foreach (var item in arrayClientes)
            {
                Console.WriteLine($"{item}");
            }

            #endregion
        }
    }
}
