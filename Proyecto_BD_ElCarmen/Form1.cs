namespace Proyecto_BD_ElCarmen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}