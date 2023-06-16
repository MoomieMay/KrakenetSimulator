using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrakenetSimulator
{    
    class Red 
    {
        int [,] matrizAdyacencia;
        int [] indegree;
        int maquinas;
        
        public Red(int pmaquinas)
        {
            maquinas = pmaquinas;
            //Instanciamos matriz de adyacencia
            matrizAdyacencia = new int[maquinas, maquinas];

            //Instanciamos arreglo indegree
            indegree = new int[maquinas];

        }
        
        public void AdicionaArista(int pNodoInicio, int pNodoFinal, int anchoBanda)
        {
            matrizAdyacencia[pNodoInicio, pNodoFinal] = anchoBanda;
        }

        public void MuestraAdyacencia()
        {
            int n = 0;
            int m = 0;

            Console.ForegroundColor = ConsoleColor.Yellow;

            for(n = 0; n < maquinas; n++)
                Console.Write("\t{0}", n);

            Console.WriteLine();

            for(n = 0; n < maquinas; n++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(n);
                for(m = 0; m < maquinas; m++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\t{0}", matrizAdyacencia[n,m]);
                }
                Console.WriteLine();
            }
        }

        public void CalcularIndegree()
        {
            int n = 0;
            int m = 0;

            for(n = 0; n < maquinas; n++)
            {
                for(m = 0; m < maquinas; m++)
                {
                    if(matrizAdyacencia[m,n] == 1)
                        indegree[n]++; 
                }
            }
        }

        public void MostrarIndegree(){
            int n = 0;
            Console.ForegroundColor = ConsoleColor.White;
            for(n = 0; n < maquinas; n++)
                Console.WriteLine("Nodo: {0}, {1}", n, indegree[n]);
        }

        public int EncuentraIndegree0()
        {
            bool encontrado = false;
            int n = 0;

            for(n = 0;n < maquinas; n++)
            {
                if(indegree[n] == 0)
                {
                    encontrado = true;
                    break;
                }
            }
            if(encontrado)
                return n;
            else
                return -1; //Código que indica que no se ha encontrado
        }

        public void DecrementaIndegree(int pNodo)
        {
            indegree[pNodo] = -1;
            int n = 0;

            for(n = 0; n < maquinas; n++)
            {
                if(matrizAdyacencia[pNodo, n] == 1)
                    indegree[n]--;
            }
        }

    }
}