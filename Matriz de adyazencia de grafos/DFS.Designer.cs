namespace Matriz_de_adyazencia_de_grafos
{
    partial class DFS
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
            txtStartNode2 = new TextBox();
            btnDFS = new Button();
            seeMatrix4 = new Button();
            DTGmatrx4 = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            txtvd2_4 = new TextBox();
            txtvd_4 = new TextBox();
            deleteedge4 = new Button();
            txtdeletenode4 = new TextBox();
            DeleteNode4 = new Button();
            label2 = new Label();
            textv2_4 = new TextBox();
            textv1_4 = new TextBox();
            btnAddEdge4 = new Button();
            AddNode4 = new Button();
            txtAddNode4 = new TextBox();
            label1 = new Label();
            btnDFS_I = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)DTGmatrx4).BeginInit();
            SuspendLayout();
            // 
            // txtStartNode2
            // 
            txtStartNode2.Location = new Point(74, 183);
            txtStartNode2.Name = "txtStartNode2";
            txtStartNode2.Size = new Size(100, 23);
            txtStartNode2.TabIndex = 74;
            // 
            // btnDFS
            // 
            btnDFS.Location = new Point(9, 212);
            btnDFS.Name = "btnDFS";
            btnDFS.Size = new Size(100, 23);
            btnDFS.TabIndex = 73;
            btnDFS.Text = "DFS Recurcivo";
            btnDFS.UseVisualStyleBackColor = true;
            btnDFS.Click += btnDFS_Click;
            // 
            // seeMatrix4
            // 
            seeMatrix4.Location = new Point(16, 417);
            seeMatrix4.Name = "seeMatrix4";
            seeMatrix4.Size = new Size(134, 23);
            seeMatrix4.TabIndex = 72;
            seeMatrix4.Text = "See Matrix";
            seeMatrix4.UseVisualStyleBackColor = true;
            seeMatrix4.Click += seeMatrix4_Click;
            // 
            // DTGmatrx4
            // 
            DTGmatrx4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGmatrx4.Location = new Point(312, 11);
            DTGmatrx4.Name = "DTGmatrx4";
            DTGmatrx4.Size = new Size(480, 429);
            DTGmatrx4.TabIndex = 71;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 108);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 70;
            label4.Text = "V2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 108);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 69;
            label3.Text = "V1";
            // 
            // txtvd2_4
            // 
            txtvd2_4.Location = new Point(130, 343);
            txtvd2_4.Name = "txtvd2_4";
            txtvd2_4.Size = new Size(100, 23);
            txtvd2_4.TabIndex = 68;
            // 
            // txtvd_4
            // 
            txtvd_4.Location = new Point(9, 343);
            txtvd_4.Name = "txtvd_4";
            txtvd_4.Size = new Size(100, 23);
            txtvd_4.TabIndex = 67;
            // 
            // deleteedge4
            // 
            deleteedge4.Location = new Point(9, 314);
            deleteedge4.Name = "deleteedge4";
            deleteedge4.Size = new Size(89, 23);
            deleteedge4.TabIndex = 66;
            deleteedge4.Text = "Delete Edge";
            deleteedge4.UseVisualStyleBackColor = true;
            deleteedge4.Click += deleteedge4_Click;
            // 
            // txtdeletenode4
            // 
            txtdeletenode4.Location = new Point(9, 285);
            txtdeletenode4.Name = "txtdeletenode4";
            txtdeletenode4.Size = new Size(100, 23);
            txtdeletenode4.TabIndex = 65;
            // 
            // DeleteNode4
            // 
            DeleteNode4.Location = new Point(12, 256);
            DeleteNode4.Name = "DeleteNode4";
            DeleteNode4.Size = new Size(89, 23);
            DeleteNode4.TabIndex = 64;
            DeleteNode4.Text = "Delete Node";
            DeleteNode4.UseVisualStyleBackColor = true;
            DeleteNode4.Click += DeleteNode4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 98);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 63;
            label2.Text = "Edge";
            // 
            // textv2_4
            // 
            textv2_4.Location = new Point(206, 126);
            textv2_4.Name = "textv2_4";
            textv2_4.Size = new Size(100, 23);
            textv2_4.TabIndex = 62;
            // 
            // textv1_4
            // 
            textv1_4.Location = new Point(100, 126);
            textv1_4.Name = "textv1_4";
            textv1_4.Size = new Size(100, 23);
            textv1_4.TabIndex = 61;
            // 
            // btnAddEdge4
            // 
            btnAddEdge4.Location = new Point(9, 126);
            btnAddEdge4.Name = "btnAddEdge4";
            btnAddEdge4.Size = new Size(75, 23);
            btnAddEdge4.TabIndex = 60;
            btnAddEdge4.Text = "Add Edge";
            btnAddEdge4.UseVisualStyleBackColor = true;
            btnAddEdge4.Click += btnAddEdge4_Click;
            // 
            // AddNode4
            // 
            AddNode4.Location = new Point(9, 45);
            AddNode4.Name = "AddNode4";
            AddNode4.Size = new Size(75, 23);
            AddNode4.TabIndex = 59;
            AddNode4.Text = "Add Node";
            AddNode4.UseVisualStyleBackColor = true;
            AddNode4.Click += AddNode4_Click;
            // 
            // txtAddNode4
            // 
            txtAddNode4.Location = new Point(100, 45);
            txtAddNode4.Name = "txtAddNode4";
            txtAddNode4.Size = new Size(100, 23);
            txtAddNode4.TabIndex = 58;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 11);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 57;
            label1.Text = "Node";
            // 
            // btnDFS_I
            // 
            btnDFS_I.Location = new Point(130, 212);
            btnDFS_I.Name = "btnDFS_I";
            btnDFS_I.Size = new Size(100, 23);
            btnDFS_I.TabIndex = 75;
            btnDFS_I.Text = "DFS Interativo";
            btnDFS_I.UseVisualStyleBackColor = true;
            btnDFS_I.Click += btnDFS_I_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 186);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 76;
            label5.Text = "Start Node";
            // 
            // DFS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(btnDFS_I);
            Controls.Add(txtStartNode2);
            Controls.Add(btnDFS);
            Controls.Add(seeMatrix4);
            Controls.Add(DTGmatrx4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtvd2_4);
            Controls.Add(txtvd_4);
            Controls.Add(deleteedge4);
            Controls.Add(txtdeletenode4);
            Controls.Add(DeleteNode4);
            Controls.Add(label2);
            Controls.Add(textv2_4);
            Controls.Add(textv1_4);
            Controls.Add(btnAddEdge4);
            Controls.Add(AddNode4);
            Controls.Add(txtAddNode4);
            Controls.Add(label1);
            Name = "DFS";
            Text = "DFS";
            ((System.ComponentModel.ISupportInitialize)DTGmatrx4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStartNode2;
        private Button btnDFS;
        private Button seeMatrix4;
        private DataGridView DTGmatrx4;
        private Label label4;
        private Label label3;
        private TextBox txtvd2_4;
        private TextBox txtvd_4;
        private Button deleteedge4;
        private TextBox txtdeletenode4;
        private Button DeleteNode4;
        private Label label2;
        private TextBox textv2_4;
        private TextBox textv1_4;
        private Button btnAddEdge4;
        private Button AddNode4;
        private TextBox txtAddNode4;
        private Label label1;
        private Button btnDFS_I;
        private Label label5;
    }
}