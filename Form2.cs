using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace mm
{
    public partial class Form2 : Form
    {

       

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(1, 20);
        }



        public Form2()
        {
            InitializeComponent();


        }

        public Form2(string ValorC)
        {
            InitializeComponent();
            txtClasse.Text = ValorC;


        }

        public abstract class Entity
        {



            protected string _name;
            protected int _forca, _resistencia, _vida, _sabedoria, _inteligencia, _agilidade;
            protected int _modificadorforca, _modificadorvida;

        }

        private void Form2_Load(object sender, EventArgs e)
        {


            btnGerarS.Focus();

            txtForca.Text = "Força";
            txtAgilidade.Text = "Agilidade";
            txtInteligencia.Text = "Inteligência";
            txtLabia.Text = "Lábia";
            txtSabedoria.Text = "Sabedoria";
            txtResistencia.Text = "Resistência";



        }

        private void BtnPronto_Click(object sender, EventArgs e)
        {
            if (txtSabedoria.Text == "Sabedoria" || txtResistencia.Text == "Resistencia" || txtNome.Text == "" || txtLabia.Text == "Lábia" || txtInteligencia.Text == "Inteligência" || txtForca.Text == "Força" || txtAgilidade.Text == "Agilidade")
            {
                MessageBox.Show("Preencha Tudo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Form0 destino = new Form0(txtSabedoria.Text, txtForca.Text, txtAgilidade.Text, txtInteligencia.Text, txtLabia.Text, txtResistencia.Text, txtClasse.Text);
                this.Hide();
                destino.Show();
            }

        }


        private void btnGerarF_Click(object sender, EventArgs e)
        {


        }

        private void cbxRaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)|| char.IsSymbol(e.KeyChar)|| char.IsPunctuation(e.KeyChar)|| char.IsWhiteSpace(e.KeyChar)|| char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbxRaca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGerarS_Click_1(object sender, EventArgs e)
        {

            btnGerarS.Enabled = false;

            int[] atributos = new int[6];
            Random random = new Random();
            for (int i = 0; i < atributos.Length;i++)
            {
                atributos[i] = random.Next(1, 21);
            }

            txtSabedoria.Text = atributos[0].ToString();
            txtForca.Text = atributos[1].ToString();
            txtAgilidade.Text = atributos[2].ToString();
            txtInteligencia.Text = atributos[3].ToString();
            txtLabia.Text = atributos[4].ToString();
            txtResistencia.Text = atributos[5].ToString();


            

            /* if (cbxRaca.Text == "Humano")
             {
                 Random random = new Random();
                 txtSabedoria.Text = random.Next(1, 20).ToString();
                 btnResistencia.Hide();

                 int humano = Convert.ToInt32(txtSabedoria.Text) + 2;

                 txtSabedoria.Text = Convert.ToString(humano);

                 cbxRaca.Enabled = false;


             }

             else if (cbxRaca.Text == "")
             {
                 MessageBox.Show("Escolha um Raça", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

             }

             else
             {
                 Random random = new Random();
                 txtSabedoria.Text = random.Next(1, 20).ToString();
                 btnGerarS.Hide();
                 cbxRaca.Enabled = false;
             }*/
        }
    }
    }

