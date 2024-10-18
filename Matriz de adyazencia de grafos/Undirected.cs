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
    public partial class Undirected : Form
    {
        private Graph graph;
        public Undirected()
        {
            InitializeComponent();
            graph = new Graph();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string namenode = txtAddNode.Text;
            graph.AddNode(namenode);
            txtAddNode.Clear();


        }

        private void btnAddEdge_Click(object sender, EventArgs e)
        {
            string nodeorigin = textv1.Text;
            string nodedest = textv2.Text;

            if (string.IsNullOrEmpty(textweight.Text))
            {
                graph.AddEdge(nodeorigin, nodedest);
            }
            else
            {
                int weight = int.Parse(textweight.Text);
                graph.AddEdge(nodeorigin, nodedest, weight);
            }

            textv1.Clear();
            textv2.Clear();
            textweight.Clear();


        }

        private void MostrarMatrizAdyacencia()
        {
            // Limpiar el DataGridView para empezar desde cero
            DTGmatrx.Columns.Clear();
            DTGmatrx.Rows.Clear();

            // Agregar la primera columna vacía (encabezado de filas) para los nombres de los nodos
            DTGmatrx.Columns.Add("", ""); // La primera columna está vacía para los nombres de las filas

            // Agregar columnas correspondientes a cada nodo (usando el nombre del nodo)
            foreach (var nodo in graph.Nodes)
            {
                DTGmatrx.Columns.Add(nodo.Name, nodo.Name);  // Agregar cada nodo como encabezado de columna
            }

            // Agregar filas con los nombres de los nodos y los valores de la matriz de adyacencia
            for (int i = 0; i < graph.Nodes.Count; i++)
            {
                // Crear una nueva fila
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(DTGmatrx);

                // La primera celda de cada fila es el nombre del nodo
                row.Cells[0].Value = graph.Nodes[i].Name;

                // Las siguientes celdas son los valores de la matriz de adyacencia (conexiones entre nodos)
                for (int j = 0; j < graph.Nodes.Count; j++)
                {
                    // Verificar si hay conexión entre los nodos i y j, y mostrar el peso o "0" si no hay conexión
                    row.Cells[j + 1].Value = graph.Matrix[i, j] != 0 ? graph.Matrix[i, j].ToString() : "0";
                }

                // Agregar la fila al DataGridView
                DTGmatrx.Rows.Add(row);
            }
        }


        private void seeMatrix_Click(object sender, EventArgs e)
        {
            MostrarMatrizAdyacencia();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Obtener el nombre del nodo a eliminar
            string nodeName = txtdeletenode.Text;

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
            txtdeletenode.Clear();
        }

        private void DeleteEdge_Click(object sender, EventArgs e)
        {
            // Obtener el nodo de origen y destino
            string originNode = txtvd.Text;
            string destinationNode = txtvd2.Text;

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
            txtvd.Clear();
            txtvd2.Clear();
        }
    }
}
