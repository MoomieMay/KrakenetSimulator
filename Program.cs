using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KrakenetSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int nodo = 0;
            Red miRed = new Red(7);
            
            miRed.Conexion(0,1,20);
            miRed.Conexion(0,2,5);
            miRed.Conexion(0,3,10);
            miRed.Conexion(1,3,10);
            miRed.Conexion(1,4,5);
            miRed.Conexion(2,5,50);
            miRed.Conexion(3,2,10);
            miRed.Conexion(3,5,20);
            miRed.Conexion(3,6,5);
            miRed.Conexion(4,3,20);
            miRed.Conexion(4,6,50);
            miRed.Conexion(6,5,10);

            miRed.MuestraAdyacencia();
            miRed.CalcularIndegree();
            miRed.MostrarIndegree();

            Console.ForegroundColor = ConsoleColor.Cyan;

            do{
                //Encontramos el nodo con el indegree 0
                nodo = miRed.EncuentraIndegree0();

                if(nodo != -1)
                {
                    //Imprimimos el nodo
                    Console.Write("{0}-> ", nodo);
                    //Decrementamos los indegrees
                    miRed.DecrementaIndegree(nodo);
                }
            }while(nodo != -1);

            Console.WriteLine();

        }
    }
}
