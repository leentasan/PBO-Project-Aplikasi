namespace MedMinder
{
    public partial class MedMinder : Form
    {
        public MedMinder()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedList MedList = new MedList();  // Membuat instansi dari Form2
            MedList.Show();  // Menampilkan Form2
            this.Hide();
        }
    }
}