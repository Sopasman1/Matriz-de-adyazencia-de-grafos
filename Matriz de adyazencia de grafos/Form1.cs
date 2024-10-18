namespace Matriz_de_adyazencia_de_grafos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AbrirFrom(object from)
        {
            if (this.containerpanel.Controls.Count > 0)
                this.containerpanel.Controls.RemoveAt(0);
            Form fh = from as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.containerpanel.Controls.Add(fh);
            this.containerpanel.Tag = fh;
            fh.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFrom(new Undirected());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFrom(new Directed());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFrom(new BFS());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFrom(new DFS());
        }
    }
}
