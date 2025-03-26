namespace Guia1_24_marzo_9_JoshuaGonzalez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);

            for (int cont = 1; cont < 11; cont++)
            {
                int multi;
                multi = num1 * cont;
                // Agregar los datos en el Datagrivd
                dataGridView1.Rows.Add(num1, cont, multi);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();

        }
    }
}
