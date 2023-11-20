namespace Practica_3__unidad_3
{
    public partial class Form1 : Form
    {
        float f_num, total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Boton SumarNumeros
            textBox2.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Boton Añadir
            listBox1.Items.Add(textBox1.Text);
            //Aqui es donde pasamos al perimetro
            f_num = float.Parse(textBox1.Text);
            total += f_num;
            textBox1.Text = "";
            textBox2.Focus();
        }
    }
}