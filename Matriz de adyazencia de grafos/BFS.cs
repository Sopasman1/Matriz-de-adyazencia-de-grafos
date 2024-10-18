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
    public partial class BFS : Form
    {
        private Graph graph;
        public BFS()
        {
            InitializeComponent();
            graph = new Graph();
        }

        private void AddNode3_Click(object sender, EventArgs e)
        {
            string namenode = txtAddNode3.Text;
            graph.AddNode(namenode);
            txtAddNode3.Clear();
        }

        private void btnAddEdge3_Click(object sender, EventArgs e)
        {
            string nodeOrigin = textv1_3.Text;
            string nodeDest = textv2_3.Text;

            if (!string.IsNullOrEmpty(nodeOrigin) && !string.IsNullOrEmpty(nodeDest))
            {
                // Agregar la arista sin peso (peso por defecto será 1)
                graph.AddEdge2(nodeOrigin, nodeDest);
            }

            // Limpiar los campos de texto
            textv1_3.Clear();
            textv2_3.Clear();

        }

        private void MostrarMatrizAdyacencia()
        {
            // Limpiar el DataGridView para empezar desde cero
            DTGmatrx3.Columns.Clear();
            DTGmatrx3.Rows.Clear();

            // Agregar la primera columna vacía (encabezado de filas) para los nombres de los nodos
            DTGmatrx3.Columns.Add("", ""); // La primera columna está vacía para los nombres de las filas

            // Agregar columnas correspondientes a cada nodo (usando el nombre del nodo)
            foreach (var nodo in graph.Nodes)
            {
                DTGmatrx3.Columns.Add(nodo.Name, nodo.Name);  // Agregar cada nodo como encabezado de columna
            }

            // Agregar filas con los nombres de los nodos y los valores de la matriz de adyacencia
            for (int i = 0; i < graph.Nodes.Count; i++)
            {
                // Crear una nueva fila
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(DTGmatrx3);

                // La primera celda de cada fila es el nombre del nodo
                row.Cells[0].Value = graph.Nodes[i].Name;

                // Las siguientes celdas son los valores de la matriz de adyacencia (conexiones entre nodos)
                for (int j = 0; j < graph.Nodes.Count; j++)
                {
                    // Verificar si hay conexión entre los nodos i y j, y mostrar el peso o "0" si no hay conexión
                    row.Cells[j + 1].Value = graph.Matrix[i, j] != 0 ? graph.Matrix[i, j].ToString() : "0";
                }

                // Agregar la fila al DataGridView
                DTGmatrx3.Rows.Add(row);
            }
        }

        private void seeMatrix3_Click(object sender, EventArgs e)
        {
            MostrarMatrizAdyacencia();
        }

        private void btnBFS_Click(object sender, EventArgs e)
        {
            string startNode = txtStartNode.Text;  // Nodo de inicio que se ingresa en el formulario

            List<string> bfsResult = graph.BFS(startNode);

            if (bfsResult.Count > 0)
            {
                MessageBox.Show("Recorrido BFS: " + string.Join(", ", bfsResult));
            }
            else
            {
                MessageBox.Show("El nodo no existe o no se pudo realizar el recorrido.");
            }
        }

        private void DeleteNode3_Click(object sender, EventArgs e)
        {
            // Obtener el nombre del nodo a eliminar
            string nodeName = txtdeletenode3.Text;

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
            txtdeletenode3.Clear();
        }

        private void deleteedge3_Click(object sender, EventArgs e)
        {
            // Obtener el nodo de origen y destino
            string originNode = txtvd_3.Text;
            string destinationNode = txtvd2_3.Text;

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
            txtvd_3.Clear();
            txtvd2_3.Clear();
        }
    }
}
