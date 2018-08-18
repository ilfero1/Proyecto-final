using System;

namespace josis
{
    class Program
    {
        static void Main(string[] args)
        {
            int voto1=0;
   int voto2=0;
   int voto3=0;
   Console.Write("Bienvenido a la elecciones\n");
   Console.Write("Escribar el nombre del candidato 1:");
   String candidato1=Console.ReadLine();
   Console.Write("Escribar el nombre del candidato 2:");
   String candidato2=Console.ReadLine();
   Console.Write("Escribar el nombre del candidato 3:");
   String candidato3=Console.ReadLine();
   for(int i=0;i<5750250;i++)
   {
        Console.Write("Eliga un canditato\n1-{0}\n2-{1}\n3-{2}\nEscriba el numero del candidato para votar:",candidato1,candidato2,candidato3);
        int voto = int.Parse(Console.ReadLine());
        if(voto==1)
        {
          voto1=voto1+1;
        }
        if(voto==2)
        {
          voto2=voto2+1;
        }
        if(voto==3)
        {
          voto3=voto3+1;
        }
        Console.WriteLine("{0},{1},{2}",voto1,voto2,voto3);

   }
   int mayor=voto1;
   if(mayor<voto2)
     mayor=voto2;
   if(mayor<voto3)
     mayor=voto3;
   if (mayor==voto1)
    Console.Write("Candidato {0} es el ganador de los votos con una cantidad de voto de:{1}",candidato1,voto1);
   if (mayor==voto2)
    Console.Write("Candidato {0} es el ganador de los votos con una cantidad de voto de:{1}",candidato2,voto2);
   if (mayor==voto3)
    Console.Write("Candidato {0} es el ganador de los votos con una cantidad de voto de:{1}",candidato3,voto3);
   
        }
    }
}
