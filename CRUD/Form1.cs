using static System.Net.Mime.MediaTypeNames;

namespace CRUD
{
    public partial class Form1 : Form
    {
        string NOME, SOBRENOME, CURSO, RM;
        int ano, idade;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            NOME = TextBoxNOME.Text;
            SOBRENOME = TEXTBOXSOBRENOME.Text;
            RM = TEXTBOXRM.Text;
            CURSO = textboxCURSO.Text

                IDADE = int.Parse(TextBoxIDADE.Text);
            ANO = int.Parse(textBoxANO.Text);

        }
    }
}
