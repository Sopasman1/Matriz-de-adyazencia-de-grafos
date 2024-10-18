namespace Matriz_de_adyazencia_de_grafos
{
    partial class Undirected
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtAddNode = new TextBox();
            AddNode = new Button();
            btnAddEdge = new Button();
            textv1 = new TextBox();
            textv2 = new TextBox();
            textweight = new TextBox();
            label2 = new Label();
            button3 = new Button();
            txtdeletenode = new TextBox();
            DeleteEdge = new Button();
            txtvd = new TextBox();
            txtvd2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            DTGmatrx = new DataGridView();
            seeMatrix = new Button();
            v1 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)DTGmatrx).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Node";
            // 
            // txtAddNode
            // 
            txtAddNode.Location = new Point(96, 43);
            txtAddNode.Name = "txtAddNode";
            txtAddNode.Size = new Size(100, 23);
            txtAddNode.TabIndex = 1;
            // 
            // AddNode
            // 
            AddNode.Location = new Point(5, 43);
            AddNode.Name = "AddNode";
            AddNode.Size = new Size(75, 23);
            AddNode.TabIndex = 2;
            AddNode.Text = "Add Node";
            AddNode.UseVisualStyleBackColor = true;
            AddNode.Click += button1_Click;
            // 
            // btnAddEdge
            // 
            btnAddEdge.Location = new Point(5, 123);
            btnAddEdge.Name = "btnAddEdge";
            btnAddEdge.Size = new Size(75, 23);
            btnAddEdge.TabIndex = 3;
            btnAddEdge.Text = "Add Edge";
            btnAddEdge.UseVisualStyleBackColor = true;
            btnAddEdge.Click += btnAddEdge_Click;
            // 
            // textv1
            // 
            textv1.Location = new Point(96, 124);
            textv1.Name = "textv1";
            textv1.Size = new Size(100, 23);
            textv1.TabIndex = 4;
            // 
            // textv2
            // 
            textv2.Location = new Point(202, 124);
            textv2.Name = "textv2";
            textv2.Size = new Size(100, 23);
            textv2.TabIndex = 5;
            // 
            // textweight
            // 
            textweight.Location = new Point(149, 171);
            textweight.Name = "textweight";
            textweight.Size = new Size(100, 23);
            textweight.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 96);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 8;
            label2.Text = "Edge";
            // 
            // button3
            // 
            button3.Location = new Point(5, 233);
            button3.Name = "button3";
            button3.Size = new Size(89, 23);
            button3.TabIndex = 9;
            button3.Text = "Delete Node";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtdeletenode
            // 
            txtdeletenode.Location = new Point(5, 272);
            txtdeletenode.Name = "txtdeletenode";
            txtdeletenode.Size = new Size(100, 23);
            txtdeletenode.TabIndex = 10;
            // 
            // DeleteEdge
            // 
            DeleteEdge.Location = new Point(5, 314);
            DeleteEdge.Name = "DeleteEdge";
            DeleteEdge.Size = new Size(89, 23);
            DeleteEdge.TabIndex = 11;
            DeleteEdge.Text = "Delete Edge";
            DeleteEdge.UseVisualStyleBackColor = true;
            DeleteEdge.Click += DeleteEdge_Click;
            // 
            // txtvd
            // 
            txtvd.Location = new Point(5, 363);
            txtvd.Name = "txtvd";
            txtvd.Size = new Size(100, 23);
            txtvd.TabIndex = 12;
            // 
            // txtvd2
            // 
            txtvd2.Location = new Point(126, 363);
            txtvd2.Name = "txtvd2";
            txtvd2.Size = new Size(100, 23);
            txtvd2.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 106);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 14;
            label3.Text = "V1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 106);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 15;
            label4.Text = "V2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(181, 197);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 16;
            label5.Text = "Weight";
            // 
            // DTGmatrx
            // 
            DTGmatrx.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGmatrx.Location = new Point(308, 9);
            DTGmatrx.Name = "DTGmatrx";
            DTGmatrx.Size = new Size(480, 429);
            DTGmatrx.TabIndex = 17;
            // 
            // seeMatrix
            // 
            seeMatrix.Location = new Point(12, 415);
            seeMatrix.Name = "seeMatrix";
            seeMatrix.Size = new Size(134, 23);
            seeMatrix.TabIndex = 18;
            seeMatrix.Text = "See Matrix";
            seeMatrix.UseVisualStyleBackColor = true;
            seeMatrix.Click += seeMatrix_Click;
            // 
            // v1
            // 
            v1.AutoSize = true;
            v1.Location = new Point(42, 389);
            v1.Name = "v1";
            v1.Size = new Size(19, 15);
            v1.TabIndex = 19;
            v1.Text = "v1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(158, 389);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 20;
            label6.Text = "v2";
            // 
            // Undirected
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(v1);
            Controls.Add(seeMatrix);
            Controls.Add(DTGmatrx);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtvd2);
            Controls.Add(txtvd);
            Controls.Add(DeleteEdge);
            Controls.Add(txtdeletenode);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(textweight);
            Controls.Add(textv2);
            Controls.Add(textv1);
            Controls.Add(btnAddEdge);
            Controls.Add(AddNode);
            Controls.Add(txtAddNode);
            Controls.Add(label1);
            Name = "Undirected";
            Text = "Undirected";
            ((System.ComponentModel.ISupportInitialize)DTGmatrx).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAddNode;
        private Button AddNode;
        private Button btnAddEdge;
        private TextBox textv1;
        private TextBox textv2;
        private TextBox textweight;
        private Label label2;
        private Button button3;
        private TextBox txtdeletenode;
        private Button DeleteEdge;
        private TextBox txtvd;
        private TextBox txtvd2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView DTGmatrx;
        private Button seeMatrix;
        private Label v1;
        private Label label6;
    }
}