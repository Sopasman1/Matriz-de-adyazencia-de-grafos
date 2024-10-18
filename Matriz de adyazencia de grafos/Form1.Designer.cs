namespace Matriz_de_adyazencia_de_grafos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            Directed = new Button();
            UndirectedBtn = new Button();
            containerpanel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(Directed);
            panel1.Controls.Add(UndirectedBtn);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 552);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 8);
            label1.Name = "label1";
            label1.Size = new Size(132, 45);
            label1.TabIndex = 1;
            label1.Text = "GRAPH";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(11, 461);
            button4.Name = "button4";
            button4.Size = new Size(165, 23);
            button4.TabIndex = 4;
            button4.Text = "DFS";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(11, 332);
            button3.Name = "button3";
            button3.Size = new Size(165, 23);
            button3.TabIndex = 3;
            button3.Text = "BFS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Directed
            // 
            Directed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Directed.Location = new Point(11, 190);
            Directed.Name = "Directed";
            Directed.Size = new Size(165, 23);
            Directed.TabIndex = 2;
            Directed.Text = "Directed";
            Directed.UseVisualStyleBackColor = true;
            Directed.Click += button2_Click;
            // 
            // UndirectedBtn
            // 
            UndirectedBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UndirectedBtn.Location = new Point(11, 72);
            UndirectedBtn.Name = "UndirectedBtn";
            UndirectedBtn.Size = new Size(165, 23);
            UndirectedBtn.TabIndex = 1;
            UndirectedBtn.Text = "Undirected";
            UndirectedBtn.UseVisualStyleBackColor = true;
            UndirectedBtn.Click += button1_Click;
            // 
            // containerpanel
            // 
            containerpanel.Location = new Point(183, 1);
            containerpanel.Name = "containerpanel";
            containerpanel.Size = new Size(800, 552);
            containerpanel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 551);
            Controls.Add(containerpanel);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button4;
        private Button button3;
        private Button Directed;
        private Button UndirectedBtn;
        private Panel containerpanel;
    }
}
