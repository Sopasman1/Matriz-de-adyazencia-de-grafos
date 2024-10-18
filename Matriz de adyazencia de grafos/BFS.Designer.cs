namespace Matriz_de_adyazencia_de_grafos
{
    partial class BFS
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
            seeMatrix3 = new Button();
            DTGmatrx3 = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            txtvd2_3 = new TextBox();
            txtvd_3 = new TextBox();
            deleteedge3 = new Button();
            txtdeletenode3 = new TextBox();
            DeleteNode3 = new Button();
            label2 = new Label();
            textv2_3 = new TextBox();
            textv1_3 = new TextBox();
            btnAddEdge3 = new Button();
            AddNode3 = new Button();
            txtAddNode3 = new TextBox();
            label1 = new Label();
            btnBFS = new Button();
            txtStartNode = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)DTGmatrx3).BeginInit();
            SuspendLayout();
            // 
            // seeMatrix3
            // 
            seeMatrix3.Location = new Point(16, 417);
            seeMatrix3.Name = "seeMatrix3";
            seeMatrix3.Size = new Size(134, 23);
            seeMatrix3.TabIndex = 54;
            seeMatrix3.Text = "See Matrix";
            seeMatrix3.UseVisualStyleBackColor = true;
            seeMatrix3.Click += seeMatrix3_Click;
            // 
            // DTGmatrx3
            // 
            DTGmatrx3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGmatrx3.Location = new Point(312, 11);
            DTGmatrx3.Name = "DTGmatrx3";
            DTGmatrx3.Size = new Size(480, 429);
            DTGmatrx3.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 108);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 51;
            label4.Text = "V2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 108);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 50;
            label3.Text = "V1";
            // 
            // txtvd2_3
            // 
            txtvd2_3.Location = new Point(130, 343);
            txtvd2_3.Name = "txtvd2_3";
            txtvd2_3.Size = new Size(100, 23);
            txtvd2_3.TabIndex = 49;
            // 
            // txtvd_3
            // 
            txtvd_3.Location = new Point(9, 343);
            txtvd_3.Name = "txtvd_3";
            txtvd_3.Size = new Size(100, 23);
            txtvd_3.TabIndex = 48;
            // 
            // deleteedge3
            // 
            deleteedge3.Location = new Point(9, 314);
            deleteedge3.Name = "deleteedge3";
            deleteedge3.Size = new Size(89, 23);
            deleteedge3.TabIndex = 47;
            deleteedge3.Text = "Delete Edge";
            deleteedge3.UseVisualStyleBackColor = true;
            deleteedge3.Click += deleteedge3_Click;
            // 
            // txtdeletenode3
            // 
            txtdeletenode3.Location = new Point(9, 285);
            txtdeletenode3.Name = "txtdeletenode3";
            txtdeletenode3.Size = new Size(100, 23);
            txtdeletenode3.TabIndex = 46;
            // 
            // DeleteNode3
            // 
            DeleteNode3.Location = new Point(12, 256);
            DeleteNode3.Name = "DeleteNode3";
            DeleteNode3.Size = new Size(89, 23);
            DeleteNode3.TabIndex = 45;
            DeleteNode3.Text = "Delete Node";
            DeleteNode3.UseVisualStyleBackColor = true;
            DeleteNode3.Click += DeleteNode3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 98);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 44;
            label2.Text = "Edge";
            // 
            // textv2_3
            // 
            textv2_3.Location = new Point(206, 126);
            textv2_3.Name = "textv2_3";
            textv2_3.Size = new Size(100, 23);
            textv2_3.TabIndex = 42;
            // 
            // textv1_3
            // 
            textv1_3.Location = new Point(100, 126);
            textv1_3.Name = "textv1_3";
            textv1_3.Size = new Size(100, 23);
            textv1_3.TabIndex = 41;
            // 
            // btnAddEdge3
            // 
            btnAddEdge3.Location = new Point(9, 126);
            btnAddEdge3.Name = "btnAddEdge3";
            btnAddEdge3.Size = new Size(75, 23);
            btnAddEdge3.TabIndex = 40;
            btnAddEdge3.Text = "Add Edge";
            btnAddEdge3.UseVisualStyleBackColor = true;
            btnAddEdge3.Click += btnAddEdge3_Click;
            // 
            // AddNode3
            // 
            AddNode3.Location = new Point(9, 45);
            AddNode3.Name = "AddNode3";
            AddNode3.Size = new Size(75, 23);
            AddNode3.TabIndex = 39;
            AddNode3.Text = "Add Node";
            AddNode3.UseVisualStyleBackColor = true;
            AddNode3.Click += AddNode3_Click;
            // 
            // txtAddNode3
            // 
            txtAddNode3.Location = new Point(100, 45);
            txtAddNode3.Name = "txtAddNode3";
            txtAddNode3.Size = new Size(100, 23);
            txtAddNode3.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 11);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 37;
            label1.Text = "Node";
            // 
            // btnBFS
            // 
            btnBFS.Location = new Point(9, 213);
            btnBFS.Name = "btnBFS";
            btnBFS.Size = new Size(75, 23);
            btnBFS.TabIndex = 55;
            btnBFS.Text = "BFS";
            btnBFS.UseVisualStyleBackColor = true;
            btnBFS.Click += btnBFS_Click;
            // 
            // txtStartNode
            // 
            txtStartNode.Location = new Point(100, 214);
            txtStartNode.Name = "txtStartNode";
            txtStartNode.Size = new Size(100, 23);
            txtStartNode.TabIndex = 56;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(162, 369);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 57;
            label6.Text = "v2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 369);
            label7.Name = "label7";
            label7.Size = new Size(19, 15);
            label7.TabIndex = 58;
            label7.Text = "v1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(139, 196);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 59;
            label8.Text = "Start";
            // 
            // BFS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtStartNode);
            Controls.Add(btnBFS);
            Controls.Add(seeMatrix3);
            Controls.Add(DTGmatrx3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtvd2_3);
            Controls.Add(txtvd_3);
            Controls.Add(deleteedge3);
            Controls.Add(txtdeletenode3);
            Controls.Add(DeleteNode3);
            Controls.Add(label2);
            Controls.Add(textv2_3);
            Controls.Add(textv1_3);
            Controls.Add(btnAddEdge3);
            Controls.Add(AddNode3);
            Controls.Add(txtAddNode3);
            Controls.Add(label1);
            Name = "BFS";
            Text = "BFS";
            ((System.ComponentModel.ISupportInitialize)DTGmatrx3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button seeMatrix3;
        private DataGridView DTGmatrx3;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtvd2_3;
        private TextBox txtvd_3;
        private Button deleteedge3;
        private TextBox txtdeletenode3;
        private Button DeleteNode3;
        private Label label2;
        private TextBox textweight2;
        private TextBox textv2_3;
        private TextBox textv1_3;
        private Button btnAddEdge3;
        private Button AddNode3;
        private TextBox txtAddNode3;
        private Label label1;
        private Button btnBFS;
        private TextBox txtStartNode;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}