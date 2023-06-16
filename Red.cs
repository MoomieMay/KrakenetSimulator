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
        int maquinas; //es la cantidad de nodos que hay
        
        public Red(int pmaquinas)
        {
            maquinas = pmaquinas;
            //Instanciamos matriz de adyacencia
            matrizAdyacencia = new int[maquinas, maquinas];

            //Instanciamos arreglo indegree
            indegree = new int[maquinas];

            //Creamos el administrador

        }
        
        public void Conexion(int pNodoInicio, int pNodoFinal, int anchoBanda)
        {
            //Se agrega la conexión colocando el ancho de banda
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


        //Calculo del camino más corto
        //REVISAR
        // Función para encontrar el vértice con la distancia mínima no visitada
    private int MinDistance(int[] dist, bool[] visited)
    {
        int min = int.MaxValue;
        int minIndex = -1;

        for (int v = 0; v < maquinas; v++)
        {
            if (!visited[v] && dist[v] <= min)
            {
                min = dist[v];
                minIndex = v;
            }
        }

        return minIndex;
    }

    // Función para imprimir el camino más corto desde el origen hasta el vértice dado
    private void PrintPath(int[] parent, int j)
    {
        if (parent[j] == -1)
        {
            Console.Write(j);
            return;
        }

        PrintPath(parent, parent[j]);
        Console.Write(" -> " + j);
    }

    // Función para calcular el camino más corto desde el origen hasta todos los vértices utilizando el algoritmo de Dijkstra
    public void DijkstraShortestPath(int source)
    {
        int[] dist = new int[maquinas]; // Almacena la distancia más corta desde el origen hasta cada vértice
        bool[] visited = new bool[maquinas]; // Almacena si un vértice ha sido visitado o no
        int[] parent = new int[maquinas]; // Almacena el camino más corto desde el origen hasta cada vértice

        for (int i = 0; i < maquinas; i++)
        {
            dist[i] = int.MaxValue;
            visited[i] = false;
            parent[i] = -1;
        }

        dist[source] = 0;

        for (int count = 0; count < maquinas - 1; count++)
        {
            int u = MinDistance(dist, visited);
            visited[u] = true;

            for (int v = 0; v < maquinas; v++)
            {
                if (!visited[v] && matrizAdyacencia[u, v] != 0 && dist[u] != int.MaxValue && dist[u] + matrizAdyacencia[u, v] < dist[v])
                {
                    dist[v] = dist[u] + matrizAdyacencia[u, v];
                    parent[v] = u;
                }
            }
            
        }

        // Imprimir los caminos más cortos desde el origen hasta todos los vértices
        for (int i = 0; i < maquinas; i++)
        {
            Console.Write("Camino más corto desde el origen hasta el vértice " + i + ": ");
            PrintPath(parent, i);
            Console.WriteLine(", Distancia = " + dist[i]);
        }
    }

    }
}