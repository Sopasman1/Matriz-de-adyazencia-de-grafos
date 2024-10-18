using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_de_adyazencia_de_grafos
{
    internal class Graph
    {
        public List<Nodo> Nodes { get; set; }
        public List<Edge> Edges { get; set; }

        public int[,] Matrix { get; set; }


        public Graph()
        {
            Nodes = new List<Nodo>();
            Edges = new List<Edge>();
            Matrix = new int[0, 0];

        }

        public void AddNode(string name)
        {
            Nodo newNode = new Nodo(name);
            Nodes.Add(newNode);

            // Expandir la matriz de adyacencia al agregar un nuevo nodo
            int newSize = Nodes.Count;
            int[,] newMatrix = new int[newSize, newSize];

            // Copiar los valores de la matriz antigua a la nueva
            for (int i = 0; i < newSize - 1; i++)
            {
                for (int j = 0; j < newSize - 1; j++)
                {
                    newMatrix[i, j] = Matrix[i, j];
                }
            }

            // Asignar la nueva matriz a Matrix
            Matrix = newMatrix;

        }

        public void AddEdge(string origin, string destination)
        {
            AddEdge(origin, destination, 1); // Por defecto, el peso es 1
        }

        public void AddEdge(string origin, string destination, int weight)
        {
            Nodo nodoOrigin = Nodes.Find(n => n.Name == origin);
            Nodo nodoDestination = Nodes.Find(n => n.Name == destination);

            if (nodoOrigin != null && nodoDestination != null)
            {
                Edges.Add(new Edge(nodoOrigin, nodoDestination, weight));

                // Actualizar la matriz de adyacencia
                int indexOrigin = Nodes.IndexOf(nodoOrigin);
                int indexDestination = Nodes.IndexOf(nodoDestination);

                Matrix[indexOrigin, indexDestination] = weight;
                Matrix[indexDestination, indexOrigin] = weight;  // Si el grafo es no dirigido
            }
        }

        public void AddEdge2(string origin2, string destination2)
        {
            AddEdge2(origin2, destination2, 1); // Por defecto, el peso es 1
        }

        public void AddEdge2(string origin2, string destination2, int weight2)
        {
            Nodo nodoOrigin2 = Nodes.Find(n => n.Name == origin2);
            Nodo nodoDestination2 = Nodes.Find(n => n.Name == destination2);

            if (nodoOrigin2 != null && nodoDestination2 != null)
            {
                Edges.Add(new Edge(nodoOrigin2, nodoDestination2, weight2));

                // Actualizar solo la celda [origen, destino] en la matriz de adyacencia
                int indexOrigin2 = Nodes.IndexOf(nodoOrigin2);
                int indexDestination2 = Nodes.IndexOf(nodoDestination2);

                Matrix[indexOrigin2, indexDestination2] = weight2;  // Solo de origen a destino
            }
        }

        // Método BFS (Recorrido en anchura)
        public List<string> BFS(string startNodeName)
        {
            // Buscar el nodo inicial por su nombre
            Nodo startNode = Nodes.Find(n => n.Name == startNodeName);
            if (startNode == null)
            {
                return new List<string>();  // Si el nodo no existe, retorna una lista vacía
            }

            // Crear una lista para almacenar los nodos visitados
            List<string> visited = new List<string>();

            // Crear una cola para el recorrido BFS
            Queue<Nodo> queue = new Queue<Nodo>();

            // Crear un array para marcar los nodos visitados
            bool[] visitedArray = new bool[Nodes.Count];

            // Obtener el índice del nodo inicial
            int startIndex = Nodes.IndexOf(startNode);

            // Marcar el nodo inicial como visitado y agregarlo a la cola
            visitedArray[startIndex] = true;
            queue.Enqueue(startNode);

            while (queue.Count > 0)
            {
                // Obtener el nodo al frente de la cola
                Nodo currentNode = queue.Dequeue();

                // Agregar el nodo actual a la lista de visitados
                visited.Add(currentNode.Name);

                // Obtener el índice del nodo actual
                int currentIndex = Nodes.IndexOf(currentNode);

                // Explorar todos los nodos adyacentes (vecinos)
                for (int i = 0; i < Nodes.Count; i++)
                {
                    // Si hay una conexión y el nodo no ha sido visitado
                    if (Matrix[currentIndex, i] != 0 && !visitedArray[i])
                    {
                        visitedArray[i] = true;  // Marcar el nodo como visitado
                        queue.Enqueue(Nodes[i]);  // Encolar el nodo vecino
                    }
                }
            }

            return visited;  // Retornar la lista de nodos visitados
        }

        // Método DFS recursivo (Recorrido en profundidad)
        public List<string> DFS(string startNodeName)
        {
            // Buscar el nodo inicial por su nombre
            Nodo startNode = Nodes.Find(n => n.Name == startNodeName);
            if (startNode == null)
            {
                return new List<string>();  // Si el nodo no existe, retorna una lista vacía
            }

            // Crear una lista para almacenar los nodos visitados
            List<string> visited = new List<string>();

            // Crear un array para marcar los nodos visitados
            bool[] visitedArray = new bool[Nodes.Count];

            // Obtener el índice del nodo inicial
            int startIndex = Nodes.IndexOf(startNode);

            // Llamada inicial a la función recursiva
            DFSRecursivo(startIndex, visited, visitedArray);

            return visited;
        }

        // Método auxiliar recursivo para DFS
        private void DFSRecursivo(int nodeIndex, List<string> visited, bool[] visitedArray)
        {
            // Marcar el nodo actual como visitado
            visitedArray[nodeIndex] = true;

            // Agregar el nodo visitado a la lista
            visited.Add(Nodes[nodeIndex].Name);

            // Explorar todos los nodos adyacentes (vecinos)
            for (int i = 0; i < Nodes.Count; i++)
            {
                // Si hay una conexión y el nodo no ha sido visitado
                if (Matrix[nodeIndex, i] != 0 && !visitedArray[i])
                {
                    DFSRecursivo(i, visited, visitedArray);  // Llamada recursiva al vecino no visitado
                }
            }
        }

        // Método DFS Iterativo (Usando Pila)
        public List<string> DFSIterativo(string startNodeName)
        {
            Nodo startNode = Nodes.Find(n => n.Name == startNodeName);
            if (startNode == null)
            {
                return new List<string>();
            }

            List<string> visited = new List<string>();
            bool[] visitedArray = new bool[Nodes.Count];

            Stack<Nodo> stack = new Stack<Nodo>();

            int startIndex = Nodes.IndexOf(startNode);
            visitedArray[startIndex] = true;
            stack.Push(startNode);

            while (stack.Count > 0)
            {
                Nodo currentNode = stack.Pop();
                int currentIndex = Nodes.IndexOf(currentNode);
                visited.Add(currentNode.Name);

                for (int i = 0; i < Nodes.Count; i++)
                {
                    if (Matrix[currentIndex, i] != 0 && !visitedArray[i])
                    {
                        visitedArray[i] = true;
                        stack.Push(Nodes[i]);
                    }
                }
            }

            return visited;
        }

        // Método para eliminar un nodo
        public void RemoveNode(string name)
        {
            // Buscar el nodo a eliminar
            Nodo nodeToRemove = Nodes.Find(n => n.Name == name);
            if (nodeToRemove == null)
            {
                Console.WriteLine("Nodo no encontrado.");
                return;
            }

            // Obtener el índice del nodo a eliminar
            int nodeIndex = Nodes.IndexOf(nodeToRemove);

            // Eliminar las aristas que están conectadas a este nodo
            Edges.RemoveAll(edge => edge.Origin == nodeToRemove || edge.Destination == nodeToRemove);

            // Eliminar el nodo de la lista de nodos
            Nodes.RemoveAt(nodeIndex);

            // Actualizar la matriz de adyacencia eliminando la fila y columna del nodo
            int newSize = Nodes.Count;
            int[,] newMatrix = new int[newSize, newSize];

            // Copiar los valores de la matriz antigua a la nueva, omitiendo la fila y columna del nodo eliminado
            for (int i = 0, newI = 0; i < Matrix.GetLength(0); i++)
            {
                if (i == nodeIndex) continue;  // Saltar la fila del nodo eliminado

                for (int j = 0, newJ = 0; j < Matrix.GetLength(1); j++)
                {
                    if (j == nodeIndex) continue;  // Saltar la columna del nodo eliminado

                    newMatrix[newI, newJ] = Matrix[i, j];
                    newJ++;
                }

                newI++;
            }

            // Asignar la nueva matriz
            Matrix = newMatrix;


        }

        // Método para eliminar una arista (edge)
        public void RemoveEdge(string origin, string destination)
        {
            // Buscar los nodos de origen y destino
            Nodo nodoOrigin = Nodes.Find(n => n.Name == origin);
            Nodo nodoDestination = Nodes.Find(n => n.Name == destination);

            if (nodoOrigin == null || nodoDestination == null)
            {
                Console.WriteLine("Nodo de origen o destino no encontrado.");
                return;
            }

            // Buscar la arista a eliminar
            Edge edgeToRemove = Edges.Find(e => e.Origin == nodoOrigin && e.Destination == nodoDestination);

            if (edgeToRemove == null)
            {
                Console.WriteLine("Arista no encontrada.");
                return;
            }

            // Eliminar la arista de la lista de aristas
            Edges.Remove(edgeToRemove);

            // Actualizar la matriz de adyacencia (poniendo un 0 para indicar que no hay conexión)
            int originIndex = Nodes.IndexOf(nodoOrigin);
            int destinationIndex = Nodes.IndexOf(nodoDestination);

            if (Matrix != null && originIndex >= 0 && destinationIndex >= 0)
            {
                Matrix[originIndex, destinationIndex] = 0;

                // Si es un grafo no dirigido, también eliminar la conexión inversa
                Matrix[destinationIndex, originIndex] = 0;
            }
        }
    }
}
