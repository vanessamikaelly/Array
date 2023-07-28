using System;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

class URI
{
    static void Main(string[] args)
    {

        List<string> lista1 = new List<string>(); //aqui eu crio uma lista string e estancio ela 

        lista1.Add("Vanessa");  //adicionar o elemento na lista
        lista1.Add("Giovanninha");  //add ta inserindo no final da lista 
        lista1.Add("Elias");

        lista1.Insert(0, "lulu"); // precisa especficar a posição que quer inserir (insert)

        lista1.Remove("Alex"); //para remover o alex
        lista1.RemoveAt(1);


        Console.WriteLine(lista1[2]); //aqui eu chamo o elias que é da posição de 2

        Console.WriteLine(lista1.Count); //mostra a quantidade de itens

        foreach(string s in lista1)
        {
            Console.WriteLine(s);
        }

        //array lista de percorrer 
       




        
       /* int[] notas = new int[3];

        Console.WriteLine("Digite sua primeira nota: ");
        notas[0] = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite sua segunda nota: ");
        notas[1] = Convert.ToInt32(Console.ReadLine());

        notas[2] = (notas[1] + notas[2]) / 2;

        Console.WriteLine($"Sua média final é {notas[2]}");

        if(notas[2] < 60)
        {
            Console.WriteLine("Reprovado");
        }
        else
        {
            Console.WriteLine("Aprovado");
        } */


        
        Console.ReadKey();
    }
}










//list
//vetores
