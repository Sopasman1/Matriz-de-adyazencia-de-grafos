namespace Matriz_de_adyazencia_de_grafos
{
    partial class Directed
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
            seeMatrix2 = new Button();
            DTGmatrx2 = new DataGridView();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtvd2_2 = new TextBox();
            txtvd_2 = new TextBox();
            button4 = new Button();
            txtdeletenode2 = new TextBox();
            DeleteNode2 = new Button();
            label2 = new Label();
            textweight2 = new TextBox();
            textv2_2 = new TextBox();
            textv1_2 = new TextBox();
            btnAddEdge2 = new Button();
            AddNode2 = new Button();
            txtAddNode2 = new TextBox();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)DTGmatrx2).BeginInit();
            SuspendLayout();
            // 
            // seeMatrix2
            // 
            seeMatrix2.Location = new Point(16, 417);
            seeMatrix2.Name = "seeMatrix2";
            seeMatrix2.Size = new Size(134, 23);
            seeMatrix2.TabIndex = 36;
            seeMatrix2.Text = "See Matrix";
            seeMatrix2.UseVisualStyleBackColor = true;
            seeMatrix2.Click += seeMatrix2_Click;
            // 
            // DTGmatrx2
            // 
            DTGmatrx2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGmatrx2.Location = new Point(312, 11);
            DTGmatrx2.Name = "DTGmatrx2";
            DTGmatrx2.Size = new Size(480, 429);
            DTGmatrx2.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(185, 199);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 34;
            label5.Text = "Weight";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 108);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 33;
            label4.Text = "V2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 108);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 32;
            label3.Text = "V1";
            // 
            // txtvd2_2
            // 
            txtvd2_2.Location = new Point(130, 365);
            txtvd2_2.Name = "txtvd2_2";
            txtvd2_2.Size = new Size(100, 23);
            txtvd2_2.TabIndex = 31;
            // 
            // txtvd_2
            // 
            txtvd_2.Location = new Point(9, 365);
            txtvd_2.Name = "txtvd_2";
            txtvd_2.Size = new Size(100, 23);
            txtvd_2.TabIndex = 30;
            // 
            // button4
            // 
            button4.Location = new Point(9, 316);
            button4.Name = "button4";
            button4.Size = new Size(89, 23);
            button4.TabIndex = 29;
            button4.Text = "Delete Edge";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtdeletenode2
            // 
            txtdeletenode2.Location = new Point(9, 274);
            txtdeletenode2.Name = "txtdeletenode2";
            txtdeletenode2.Size = new Size(100, 23);
            txtdeletenode2.TabIndex = 28;
            // 
            // DeleteNode2
            // 
            DeleteNode2.Location = new Point(9, 235);
            DeleteNode2.Name = "DeleteNode2";
            DeleteNode2.Size = new Size(89, 23);
            DeleteNode2.TabIndex = 27;
            DeleteNode2.Text = "Delete Node";
            DeleteNode2.UseVisualStyleBackColor = true;
            DeleteNode2.Click += DeleteNode2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 98);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 26;
            label2.Text = "Edge";
            // 
            // textweight2
            // 
            textweight2.Location = new Point(153, 173);
            textweight2.Name = "textweight2";
            textweight2.Size = new Size(100, 23);
            textweight2.TabIndex = 25;
            // 
            // textv2_2
            // 
            textv2_2.Location = new Point(206, 126);
            textv2_2.Name = "textv2_2";
            textv2_2.Size = new Size(100, 23);
            textv2_2.TabIndex = 24;
            // 
            // textv1_2
            // 
            textv1_2.Location = new Point(100, 126);
            textv1_2.Name = "textv1_2";
            textv1_2.Size = new Size(100, 23);
            textv1_2.TabIndex = 23;
            // 
            // btnAddEdge2
            // 
            btnAddEdge2.Location = new Point(9, 125);
            btnAddEdge2.Name = "btnAddEdge2";
            btnAddEdge2.Size = new Size(75, 23);
            btnAddEdge2.TabIndex = 22;
            btnAddEdge2.Text = "Add Edge";
            btnAddEdge2.UseVisualStyleBackColor = true;
            btnAddEdge2.Click += btnAddEdge2_Click;
            // 
            // AddNode2
            // 
            AddNode2.Location = new Point(9, 45);
            AddNode2.Name = "AddNode2";
            AddNode2.Size = new Size(75, 23);
            AddNode2.TabIndex = 21;
            AddNode2.Text = "Add Node";
            AddNode2.UseVisualStyleBackColor = true;
            AddNode2.Click += AddNode2_Click;
            // 
            // txtAddNode2
            // 
            txtAddNode2.Location = new Point(100, 45);
            txtAddNode2.Name = "txtAddNode2";
            txtAddNode2.Size = new Size(100, 23);
            txtAddNode2.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 11);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 19;
            label1.Text = "Node";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(162, 394);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 37;
            label6.Text = "v2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 394);
            label7.Name = "label7";
            label7.Size = new Size(19, 15);
            label7.TabIndex = 38;
            label7.Text = "v1";
            // 
            // Directed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(seeMatrix2);
            Controls.Add(DTGmatrx2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtvd2_2);
            Controls.Add(txtvd_2);
            Controls.Add(button4);
            Controls.Add(txtdeletenode2);
            Controls.Add(DeleteNode2);
            Controls.Add(label2);
            Controls.Add(textweight2);
            Controls.Add(textv2_2);
            Controls.Add(textv1_2);
            Controls.Add(btnAddEdge2);
            Controls.Add(AddNode2);
            Controls.Add(txtAddNode2);
            Controls.Add(label1);
            Name = "Directed";
            Text = "Directed";
            ((System.ComponentModel.ISupportInitialize)DTGmatrx2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button seeMatrix2;
        private DataGridView DTGmatrx2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtvd2_2;
        private TextBox txtvd_2;
        private Button button4;
        private TextBox txtdeletenode2;
        private Button DeleteNode2;
        private Label label2;
        private TextBox textweight2;
        private TextBox textv2_2;
        private TextBox textv1_2;
        private Button btnAddEdge2;
        private Button AddNode2;
        private TextBox txtAddNode2;
        private Label label1;
        private Label label6;
        private Label label7;
    }
}