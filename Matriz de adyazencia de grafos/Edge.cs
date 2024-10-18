using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_de_adyazencia_de_grafos
{
    internal class Edge
    {
        public Nodo Origin {  get; set; }
        public Nodo Destination { get; set; }

        public int Weight {  get; set; }

        public Edge(Nodo origin,Nodo destination) 
        {
            this.Origin = origin;
            this.Destination = destination;
            this.Weight = 1;
     
        }

        public Edge(Nodo origin,Nodo destination,int weight) 
        {
            this.Origin = origin;
            this.Destination = destination;
            this.Weight = weight;
        }
    }
}
