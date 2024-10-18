using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz_de_adyazencia_de_grafos
{
    public partial class DFS : Form
    {
        private Graph graph;
        public DFS()
        {
            InitializeComponent();
            graph = new Graph();
        }

        private void AddNode4_Click(object sender, EventArgs e)
        {

            string namenode = txtAddNode4.Text;
            graph.AddNode(namenode);
            txtAddNode4.Clear();
        }

        private void btnAddEdge4_Click(object sender, EventArgs e)
        {
            string nodeOrigin = textv1_4.Text;
            string nodeDest = textv2_4.Text;

            if (!string.IsNullOrEmpty(nodeOrigin) && !string.IsNullOrEmpty(nodeDest))
            {
                // Agregar la arista sin peso (peso por defecto será 1)
                graph.AddEdge2(nodeOrigin, nodeDest);
            }

            // Limpiar los campos de texto
            textv1_4.Clear();
            textv2_4.Clear();

        }

        private void MostrarMatrizAdyacencia()
        {
            // Limpiar el DataGridView para empezar desde cero
            DTGmatrx4.Columns.Clear();
            DTGmatrx4.Rows.Clear();

            // Agregar la primera columna vacía (encabezado de filas) para los nombres de los nodos
            DTGmatrx4.Columns.Add("", ""); // La primera columna está vacía para los nombres de las filas

            // Agregar columnas correspondientes a cada nodo (usando el nombre del nodo)
            foreach (var nodo in graph.Nodes)
            {
                DTGmatrx4.Columns.Add(nodo.Name, nodo.Name);  // Agregar cada nodo como encabezado de columna
            }

            // Agregar filas con los nombres de los nodos y los valores de la matriz de adyacencia
            for (int i = 0; i < graph.Nodes.Count; i++)
            {
                // Crear una nueva fila
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(DTGmatrx4);

                // La primera celda de cada fila es el nombre del nodo
                row.Cells[0].Value = graph.Nodes[i].Name;

                // Las siguientes celdas son los valores de la matriz de adyacencia (conexiones entre nodos)
                for (int j = 0; j < graph.Nodes.Count; j++)
                {
                    // Verificar si hay conexión entre los nodos i y j, y mostrar el peso o "0" si no hay conexión
                    row.Cells[j + 1].Value = graph.Matrix[i, j] != 0 ? graph.Matrix[i, j].ToString() : "0";
                }

                // Agregar la fila al DataGridView
                DTGmatrx4.Rows.Add(row);
            }
        }

        private void seeMatrix4_Click(object sender, EventArgs e)
        {
            MostrarMatrizAdyacencia();
        }

        private void btnDFS_Click(object sender, EventArgs e)
        {
            string startNode = txtStartNode2.Text;  // Nodo de inicio que se ingresa en el formulario

            List<string> dfsResult = graph.DFS(startNode);

            if (dfsResult.Count > 0)
            {
                MessageBox.Show("Recorrido DFS: " + string.Join(", ", dfsResult));
            }
            else
            {
                MessageBox.Show("El nodo no existe o no se pudo realizar el recorrido.");
            }
        }

        private void btnDFS_I_Click(object sender, EventArgs e)
        {
            // Obtener el nodo inicial ingresado por el usuario
            string startNode = txtStartNode2.Text;  // Nodo de inicio que se ingresa en el formulario

            // Verificar si el nodo inicial fue ingresado
            if (string.IsNullOrEmpty(startNode))
            {
                MessageBox.Show("Por favor, ingrese el nombre del nodo inicial.");
                return;
            }

            // Ejecutar DFS iterativo desde el nodo inicial
            List<string> dfsIterativeResult = graph.DFSIterativo(startNode);

            // Verificar si hubo un recorrido exitoso
            if (dfsIterativeResult.Count > 0)
            {
                // Mostrar el resultado en un MessageBox o en un control de la interfaz
                MessageBox.Show("Recorrido DFS Iterativo: " + string.Join(", ", dfsIterativeResult));
            }
            else
            {
                MessageBox.Show("El nodo no existe o no se pudo realizar el recorrido.");
            }
        }

        private void DeleteNode4_Click(object sender, EventArgs e)
        {
            // Obtener el nombre del nodo a eliminar
            string nodeName = txtdeletenode4.Text;

            if (string.IsNullOrEmpty(nodeName))
            {
                MessageBox.Show("Por favor, ingrese el nombre del nodo a eliminar.");
                return;
            }

            // Eliminar el nodo del grafo
            graph.RemoveNode(nodeName);

            // Actualizar el DataGridView para reflejar los cambios en la matriz de adyacencia
            MostrarMatrizAdyacencia();

            // Limpiar el campo de texto
            txtdeletenode4.Clear();
        }

        private void deleteedge4_Click(object sender, EventArgs e)
        {
            // Obtener el nodo de origen y destino
            string originNode = txtvd_4.Text;
            string destinationNode = txtvd2_4.Text;

            if (string.IsNullOrEmpty(originNode) || string.IsNullOrEmpty(destinationNode))
            {
                MessageBox.Show("Por favor, ingrese los nombres de los nodos de origen y destino.");
                return;
            }

            // Eliminar la arista del grafo
            graph.RemoveEdge(originNode, destinationNode);

            // Actualizar el DataGridView para reflejar los cambios en la matriz de adyacencia
            MostrarMatrizAdyacencia();

            // Limpiar los campos de texto
            txtvd_4.Clear();
            txtvd2_4.Clear();
        }
    }
}
