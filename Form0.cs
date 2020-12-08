using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;
using System.Windows.Forms;

namespace mm
{
    public partial class Form0 : Form
    {





        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(20, 25);
        }

        [System.ComponentModel.Bindable(true)]
        [System.ComponentModel.Browsable(false)]
        public object SelectedItem { get; set; }





        Timer Timer3 = new Timer();

        Timer Timer4 = new Timer();

        Timer TimerPV = new Timer();

        public Form0()
        {
            InitializeComponent();



        }



        public string DamageC2()
        {


            int b = pbrVidaD.Value;

            int dano = -Convert.ToInt32(txtAgilidade2.Text) - Convert.ToInt32(txtForca2.Text);




            return Convert.ToString(dano);


        }



        public string DamageM()
        {

            // int vidaIn = Convert.ToInt32(pbrVidaD.Value);

            int b = pbrVidaD.Value;

            int dano = -Convert.ToInt32(txtSabedoria2.Text) - Convert.ToInt32(txtInteligencia2.Text);




            return Convert.ToString(dano);


        }

        public string DamageA()
        {

            int b = pbrVidaD.Value;

            int dano = -Convert.ToInt32(txtAgilidade2.Text) - Convert.ToInt32(txtInteligencia2.Text);




            return Convert.ToString(dano);


        }

        public string DamageD()
        {

            int dano = -23 + (Convert.ToInt32(txtResistencia2.Text) / 2);
            int a = pbrVidaM.Value;

            return Convert.ToString(dano);

        }

        public string DamageD2()
        {

            int dano = -28 + (Convert.ToInt32(txtResistencia2.Text) / 2);
            int a = pbrVidaM.Value;

            return Convert.ToString(dano);

        }



        public Form0(string ValorS, string ValorF, string ValorA, string ValorI, string ValorL, string ValorR, string ValorC)
        {
            InitializeComponent();
            txtSabedoria2.Text = ValorS;
            txtForca2.Text = ValorF;
            txtAgilidade2.Text = ValorA;
            txtInteligencia2.Text = ValorI;
            txtLabia2.Text = ValorL;
            txtResistencia2.Text = ValorR;
            txtClasse2.Text = ValorC;

            if (txtClasse2.Text == "Mago!!")
            {
                int a = Convert.ToInt32(txtSabedoria2.Text);
                int b = 2;
                int c = a + b;

                txtSabedoria2.Text = Convert.ToString(c);
            }

            else if (txtClasse2.Text == "Assassino!!")
            {

                int a = Convert.ToInt32(txtAgilidade2.Text);
                int b = 2;
                int c = a + b;

                txtAgilidade2.Text = Convert.ToString(c);
            }

            else if (txtClasse2.Text == "Cavaleiro!!")
            {
                int a = Convert.ToInt32(txtResistencia2.Text);
                int b = 2;
                int c = a + b;

                txtResistencia2.Text = Convert.ToString(c);


            }
            else
            {

            }

        }

        private void BtnCaminhar_Click(object sender, EventArgs e)
        {
            btnAcampar.Enabled = false;
            btnCaminhar.Enabled = false;
            btnConversar.Enabled = false;
            btnVasculhar.Enabled = false;
            btnPet.Enabled = false;
            btnAtaque.Visible = false;


            Random random = new Random();

            if (random.Next(1, 6) == 1)
            {
                MessageBox.Show("Você escuta um barulho um tanto estranho...", "BLOP", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                btnAtaque.Enabled = true;
                pbrVidaD.Value = 50;

                pbDagao.Visible = true;
                pbrVidaD.Visible = true;


                btnAcampar.Enabled = false;
                btnVasculhar.Enabled = false;
                btnCaminhar.Enabled = false;
                btnAtaque.Visible = true;
                btnAtaque2.Visible = false;

            }

            else if (random.Next(1, 6) == 2)
            {

                MessageBox.Show("Você percebe que pisou em algo marrom...", "ಠ_ಠ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }


            else if (random.Next(1, 6) == 3)
            {


                MessageBox.Show("Encontrou uma pedra mágica que desaparece ao tocar.", "ಠ_ಠ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                pbrXp.Increment(25);
                btnVasculhar.Enabled = true;
                btnAcampar.Enabled = true;
                btnPet.Enabled = true;
                btnConversar.Enabled = true;
                btnCaminhar.Enabled = true;
                if (pbrXp.Value == 100)
                {
                    MessageBox.Show("Isso! LvL Up!.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    lblNivel.Text = " Nível 2";
                 
                    pbrXp.Maximum = 500;
                }

                if (pbrXp.Value == 500)
                {
                    MessageBox.Show("Isso! LvL Up!.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    lblNivel.Text = " Nível 3";
                    pbrXp.Maximum = 1500;

                }

                if (pbrXp.Value == 1500)
                {
                    MessageBox.Show("Isso! LvL Up!.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    lblNivel.Text = " Nível 4";
                    pbrXp.Maximum = 5000;

                }


            }

            else if (random.Next(1, 6) == 4)
            {





            }

            else if (random.Next(1, 6) == 5)
            {

                btnPet.Enabled = true;
                btnConversar.Enabled = true;

                MessageBox.Show("Um vendedor!", "◕ ‿‿ ◕", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                pbMago.Visible = true;
                btnArma.Visible = true;
                btnVender.Visible = true;
                btnSair.Visible = true;
                btnPocao.Visible = true;


                btnAtaque.Visible = false;
                btnCaminhar.Visible = false;
                btnAcampar.Visible = false;
                btnVasculhar.Visible = false;




            }

            else
            {
                btnAtaque.Enabled = true;
                pbrDagao2.Value = 60;

                pbDagao2.Visible = true;
                pbrDagao2.Visible = true;


                btnAcampar.Enabled = false;
                btnVasculhar.Enabled = false;
                btnCaminhar.Visible = false;
                btnAtaque2.Enabled = true;
                btnAtaque2.Visible = true;
                btnAtaque.Visible = false;
            }





            if (txtClasse2.Text == "Cavaleiro!!")
            {
                pbPrimeiro.Visible = true;




                timer.Tick += new EventHandler(MyTimer_Tick);

                timer.Enabled = true;


            }

            if (txtClasse2.Text == "Assassino!!")
            {
                pbAssassino1.Visible = true;




                timer.Tick += new EventHandler(MyTimera_Tick);

                timer.Enabled = true;


            }

            if (txtClasse2.Text == "Mago!!")
            {
                pbPrimeiroM.Visible = true;




                timer.Tick += new EventHandler(MyTimerm_Tick);

                timer.Enabled = true;


            }


        }

        private void MyTimera_Tick(object sender, EventArgs e)
        {
            pbAssassino2.Visible = true;
            pbAssassino1.Visible = false;

            timer.Enabled = false;

            if (timer.Enabled == false)
            {

                Timer2.Enabled = true;


                Timer2.Tick += new EventHandler(MyTimera2_Tick);

            }
        }

        private void MyTimera2_Tick(object sender, EventArgs e)
        {
            pbAssassino1.Visible = true;
            pbAssassino2.Visible = false;


            Timer2.Enabled = false;

            if (Timer2.Enabled == false)
            {
                Timer3.Start();

                Timer3.Enabled = true;

                Timer3.Interval = (400);


                pbAssassino1.Visible = false;
                pbAssassino2.Visible = false;
                pbAssassino1.Visible = false;


                btnAcampar.Enabled = true;
                btnCaminhar.Enabled = true;
                btnConversar.Enabled = true;
                btnVasculhar.Enabled = true;
                btnPet.Enabled = true;
                btnCura.Enabled = true;



                if (pbDagao.Visible == true)
                {

                    btnAcampar.Enabled = false;
                    btnCaminhar.Enabled = false;
                    btnConversar.Enabled = true;
                    btnVasculhar.Enabled = false;
                    btnPet.Enabled = false;
                    btnCura.Visible = true;
                    btnAtaque.Visible = true;

                }


                else if (pbDagao.Visible == false)
                {
                    btnAcampar.Enabled = true;
                    btnCaminhar.Enabled = true;
                    btnConversar.Enabled = true;
                    btnVasculhar.Enabled = true;
                    btnPet.Enabled = true;
                    btnCura.Visible = true;
                    btnAtaque.Visible = false;
                }

                else
                {


                }

            }
        }



        private void MyTimerm_Tick(object sender, EventArgs e)
        {
            pbSegundoM.Visible = true;
            pbPrimeiroM.Visible = false;

            timer.Enabled = false;

            if (timer.Enabled == false)
            {
                Timer2.Start();

                Timer2.Enabled = true;

                Timer2.Interval = (400);

                Timer2.Tick += new EventHandler(MyTimerm2_Tick);

            }
        }

        private void MyTimerm2_Tick(object sender, EventArgs e)
        {
            pbPrimeiroM.Visible = true;
            pbSegundoM.Visible = false;


            Timer2.Enabled = false;

            if (Timer2.Enabled == false)
            {
                Timer3.Start();

                Timer3.Enabled = true;

                Timer3.Interval = (400);

                Timer3.Tick += new EventHandler(MyTimerm3_Tick);

            }
        }

        private void MyTimerm3_Tick(object sender, EventArgs e)
        {
            pbSegundoM.Visible = true;
            pbPrimeiroM.Visible = false;



            Timer3.Enabled = false;

            pbPrimeiroM.Visible = false;
            pbSegundoM.Visible = false;
            pbPrimeiroM.Visible = false;


            btnAcampar.Enabled = true;
            btnCaminhar.Enabled = true;
            btnConversar.Enabled = true;
            btnVasculhar.Enabled = true;
            btnPet.Enabled = true;
            btnCura.Enabled = true;



            if (pbDagao.Visible == true)
            {

                btnAcampar.Enabled = false;
                btnCaminhar.Enabled = false;
                btnConversar.Enabled = true;
                btnVasculhar.Enabled = false;
                btnPet.Enabled = false;
                btnCura.Visible = true;
                btnAtaque.Visible = true;

            }




            else if (pbDagao2.Visible == true)
            {

                btnAcampar.Enabled = false;
                btnCaminhar.Enabled = false;
                btnConversar.Enabled = true;
                btnVasculhar.Enabled = false;
                btnPet.Enabled = false;
                btnCura.Visible = true;
                btnAtaque.Visible = true;

            }

            else
            {

            }


        }


        private void MyTimer_Tick(object sender, EventArgs e)
        {
            pbSegundo.Visible = true;
            pbPrimeiro.Visible = false;

            timer.Enabled = false;

            if (timer.Enabled == false)
            {
                Timer2.Start();

                Timer2.Enabled = true;

                Timer2.Interval = (400);

                Timer2.Tick += new EventHandler(MyTimer2_Tick);

            }
        }

        private void MyTimer2_Tick(object sender, EventArgs e)
        {
            pbPrimeiro.Visible = true;
            pbSegundo.Visible = false;


            Timer2.Enabled = false;

            if (Timer2.Enabled == false)
            {
                Timer3.Start();

                Timer3.Enabled = true;

                Timer3.Interval = (400);

                Timer3.Tick += new EventHandler(MyTimer3_Tick);

            }
        }

        private void MyTimer3_Tick(object sender, EventArgs e)
        {
            pbSegundo.Visible = true;
            pbPrimeiro.Visible = false;



            Timer3.Enabled = false;


            pbPrimeiro.Visible = false;
            pbSegundo.Visible = false;
            pbPrimeiroM.Visible = false;


            btnAcampar.Enabled = true;
            btnCaminhar.Enabled = true;
            btnConversar.Enabled = true;
            btnVasculhar.Enabled = true;
            btnPet.Enabled = true;
            btnCura.Enabled = true;

            if (pbDagao.Visible == true)
            {

                btnAcampar.Enabled = false;
                btnCaminhar.Enabled = false;
                btnConversar.Enabled = true;
                btnVasculhar.Enabled = false;
                btnPet.Enabled = false;
                btnCura.Visible = true;
                btnAtaque.Visible = true;


            }



            else
            {


            }


        }





        private void btnAtaque_Click(object sender, EventArgs e)
        {

            if (txtClasse2.Text == "Cavaleiro!!")
            {

                pbrVidaD.Increment(Convert.ToInt32(DamageC2()));

                if (Convert.ToInt32(pbrVidaD.Value) < 0 || Convert.ToInt32(pbrVidaD.Value) == 0)
                {
                    if (pbrVidaD.Value == 0 || pbrVidaD.Value < 0)
                    {

                        Random random = new Random();

                        if (random.Next(1, 5) == 1)
                        {
                            cbxItens.Items.Add("Poção de Vida (+25V) ");
                        }

                        else if (random.Next(1, 5) == 2)
                        {
                            cbxItens.Items.Add("Lixo ");
                        }

                        else if (random.Next(1, 5) == 3)
                        {
                            MessageBox.Show("Dropou nada...", ":O", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }

                        else if (random.Next(1, 5) == 4)
                        {
                            MessageBox.Show("Dropou nada...", ":O", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }

                        else if (random.Next(1, 5) == 5)
                        {
                            MessageBox.Show("Dropou nada...", ":O", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }

                        int recebe;


                        recebe = Convert.ToInt32(txtMoedas.Text) + 10;
                        txtMoedas.Text = Convert.ToString(recebe);

                        btnAcampar.Enabled = true;

                        lblQuero.Visible = false;
                        pbrVidaD.Visible = false;
                        btnAtaque2.Visible = true;

                        pbDagao.Visible = false;
                        btnCaminhar.Enabled = true;

                        btnAcampar.Enabled = true;
                        btnVasculhar.Enabled = true;
                        btnAtaque.Enabled = false;
                        btnAtaque2.Enabled = false;
                        pbrXp.Increment(50);
                        btnPet.Enabled = true;

                        pbrVidaD.Value = 50;


                        if (lblNausea.Visible == true)
                        {
                            int a = Convert.ToInt32(txtAgilidade2.Text) + 5;

                            txtAgilidade2.Text = Convert.ToString(a);
                            lblNausea.Visible = false;
                        }



                    }







                    if (pbrXp.Value == 100)
                    {
                        MessageBox.Show("Isso! LvL Up!.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        lblNivel.Text = " Nível 2";
                        pbrXp.Maximum = 500;
                    }

                    if (pbrXp.Value == 500)
                    {
                        MessageBox.Show("Isso! LvL Up!.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        lblNivel.Text = "Nível 3";
                        pbrXp.Maximum = 1500;

                    }

                    if (pbrXp.Value == 1500)
                    {
                        MessageBox.Show("Isso! LvL Up!.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        lblNivel.Text = "Nível 4";
                        pbrXp.Maximum = 5000;

                    }




                }





                pbrVidaM.Increment(Convert.ToInt32(DamageD()));




                if (Convert.ToInt32(pbrVidaM.Value) < 0 || Convert.ToInt32(pbrVidaM.Value) == 0)
                {
                    MessageBox.Show("Sua alma está sendo levada para algum lugar, mas você sente que qualquer lugar é melhor que essa vida.", "╭∩╮（︶︿︶）╭∩╮", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Application.Exit();

                }




                else if (Convert.ToInt32(pbrVidaM.Value) < 0 || Convert.ToInt32(pbrVidaM.Value) == 0)
                {
                    MessageBox.Show("Isso! Você morreu!.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }

            else if (txtClasse2.Text == "Mago!!")
            {

                pbrVidaD.Increment(Convert.ToInt32(DamageM()));

                if (Convert.ToInt32(pbrVidaD.Value) < 0 || Convert.ToInt32(pbrVidaD.Value) == 0)
                {
                    if (pbrVidaD.Value == 0 || pbrVidaD.Value < 0)
                    {

                        Random random = new Random();

                        if (random.Next(1, 5) == 1)
                        {
                            cbxItens.Items.Add("Poção de Vida (+25V) ");
                        }

                        else if (random.Next(1, 5) == 2)
                        {
                            cbxItens.Items.Add("Lixo ");
                        }

                        else if (random.Next(1, 5) == 3)
                        {
                            MessageBox.Show("Dropou nada...", ":O", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }

                        else if (random.Next(1, 5) == 4)
                        {
                            MessageBox.Show("Dropou nada...", ":O", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }

                        else if (random.Next(1, 5) == 5)
                        {
                            MessageBox.Show("Dropou nada...", ":O", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }

                        if (pbrVidaD.Value == 0 || pbrVidaD.Value < 0)
                        {
                            btnAcampar.Enabled = true;


                            int recebe;


                            recebe = Convert.ToInt32(txtMoedas.Text) + 10;
                            txtMoedas.Text = Convert.ToString(recebe);

                            lblQuero.Visible = false;
                            pbrVidaD.Visible = false;
                            btnAtaque2.Visible = true;

                            pbDagao.Visible = false;
                            btnCaminhar.Enabled = true;

                            btnAcampar.Enabled = true;
                            btnVasculhar.Enabled = true;
                            btnAtaque.Enabled = false;
                            btnAtaque2.Enabled = false;
                            pbrXp.Increment(50);
                            btnPet.Enabled = true;
                            pbrVidaD.Value = 50;

                            if (lblNausea.Visible == true)
                            {
                                int a = Convert.ToInt32(txtAgilidade2.Text) + 5;

                                txtAgilidade2.Text = Convert.ToString(a);
                                lblNausea.Visible = false;
                            }

                        }
                    }







                    if (pbrXp.Value == 100)
                    {
                        MessageBox.Show(" isso te enche de determinação.! ", "LvL Up!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        lblNivel.Text = " Nível 2";
                        pbrXp.Maximum = 500;
                    }

                    if (pbrXp.Value == 500)
                    {
                        MessageBox.Show(" isso te enche de determinação.! ", "LvL Up!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        lblNivel.Text = "Nível 3";
                        pbrXp.Maximum = 1500;

                    }

                    if (pbrXp.Value == 1500)
                    {
                        MessageBox.Show(" isso te enche de determinação.! ", "LvL Up!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        lblNivel.Text = "Nível 4";
                        pbrXp.Maximum = 5000;

                    }




                }





                pbrVidaM.Increment(Convert.ToInt32(DamageD()));




                if (Convert.ToInt32(pbrVidaM.Value) < 0 || Convert.ToInt32(pbrVidaM.Value) == 0)
                {
                    MessageBox.Show("Sua alma está sendo levada para algum lugar, mas você sente que qualquer lugar é melhor que essa vida.", "╭∩╮（︶︿︶）╭∩╮", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Application.Exit();

                }




                else if (Convert.ToInt32(pbrVidaM.Value) < 0 || Convert.ToInt32(pbrVidaM.Value) == 0)
                {
                    MessageBox.Show("Isso! Você morreu!.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }

            }

            else if (txtClasse2.Text == "Assassino!!")
            {
                pbrVidaD.Increment(Convert.ToInt32(DamageA()));

                if (Convert.ToInt32(pbrVidaD.Value) < 0 || Convert.ToInt32(pbrVidaD.Value) == 0)
                {
                    if (pbrVidaD.Value == 0 || pbrVidaD.Value < 0)
                    {

                        Random random = new Random();

                        if (random.Next(1, 5) == 1)
                        {
                            cbxItens.Items.Add("Poção de Vida (+25V) ");
                        }

                        else if (random.Next(1, 5) == 2)
                        {
                            cbxItens.Items.Add("Lixo ");
                        }

                        else if (random.Next(1, 5) == 3)
                        {
                            MessageBox.Show("Dropou nada...", ":O", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }

                        else if (random.Next(1, 5) == 4)
                        {
                            MessageBox.Show("Dropou nada...", ":O", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }

                        else if (random.Next(1, 5) == 5)
                        {
                            MessageBox.Show("Dropou nada...", ":O", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }

                        if (pbrVidaD.Value == 0 || pbrVidaD.Value < 0)
                        {

                            btnAcampar.Enabled = true;


                            int recebe;


                            recebe = Convert.ToInt32(txtMoedas.Text) + 10;
                            txtMoedas.Text = Convert.ToString(recebe);

                            lblQuero.Visible = false;
                            pbrVidaD.Visible = false;
                            btnAtaque2.Visible = true;

                            pbDagao.Visible = false;
                            btnCaminhar.Enabled = true;

                            btnAcampar.Enabled = true;
                            btnVasculhar.Enabled = true;
                            btnAtaque.Enabled = false;
                            btnAtaque2.Enabled = false;
                            btnPet.Enabled = true;

                            pbrXp.Increment(50);
                            pbrVidaD.Value = 50;

                            if (lblNausea.Visible == true)
                            {
                                int a = Convert.ToInt32(txtAgilidade2.Text) + 5;

                                txtAgilidade2.Text = Convert.ToString(a);
                                lblNausea.Visible = false;
                            }
                        }

                    }






                    if (pbrXp.Value == 100)
                    {
                        MessageBox.Show("Isso! LvL Up!.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        lblNivel.Text = " Nível 2";
                        pbrXp.Maximum = 500;
                    }

                    if (pbrXp.Value == 500)
                    {
                        MessageBox.Show("Isso! LvL Up!.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        lblNivel.Text = "Nível 3";
                        pbrXp.Maximum = 1500;

                    }

                    if (pbrXp.Value == 1500)
                    {
                        MessageBox.Show("Isso! LvL Up!.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        lblNivel.Text = "Nível 4";
                        pbrXp.Maximum = 5000;

                    }




                }





                pbrVidaM.Increment(Convert.ToInt32(DamageD()));




                if (Convert.ToInt32(pbrVidaM.Value) < 0 || Convert.ToInt32(pbrVidaM.Value) == 0)
                {
                    MessageBox.Show("Sua alma está sendo levada para algum lugar, mas você sente que qualquer lugar é melhor que essa vida.", "╭∩╮（︶︿︶）╭∩╮", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Application.Exit();

                }




                else if (Convert.ToInt32(pbrVidaM.Value) < 0 || Convert.ToInt32(pbrVidaM.Value) == 0)
                {
                    MessageBox.Show("Isso! Você morreu!.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }


        }









        private void btnCura_Click(object sender, EventArgs e)
        {
            if (cbxItens.Text == "Poção de Vida (+25V)")
            {
                int potion = 25;
                int vid = Convert.ToInt32(pbrVidaM.Value);

                cbxItens.Items.Remove("Poção de Vida (+25V)");

                int all = vid + potion;

                pbrVidaM.Increment(all);

                cbxItens.Items.Remove("Poção de Vida(+25V)");
            }


            else if (cbxItens.Text != "Poção de Vida (+25V)")
            {
                System.Windows.Forms.MessageBox.Show("erro", "Selecione a PoçãoV em seus itens", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

            }
        }

        private void btnConversar_Click(object sender, EventArgs e)
        {
            if (pbrVidaD.Visible == true)
            {
                MessageBox.Show("Eae meu consagrado.", ":)", MessageBoxButtons.OK, MessageBoxIcon.None);
                MessageBox.Show("BLOP", ":O", MessageBoxButtons.OK, MessageBoxIcon.None);
                MessageBox.Show("Você percebe que diálogo é inútil....", "ah", MessageBoxButtons.OK, MessageBoxIcon.None);

            }

            else if (pbrVidaD.Visible == false && pbMago.Visible == false && pbDagao.Visible == false && pbDagao2.Visible == false)
            {
                MessageBox.Show("Não estou vendo muito com o que conversar...", ":V", MessageBoxButtons.OK, MessageBoxIcon.None);

            }

            else if (pbMago.Visible == true && Convert.ToInt32(txtLabia2.Text) > 17)
            {
                MessageBox.Show("Eae velho, como andas?", ":V", MessageBoxButtons.OK, MessageBoxIcon.None);
                MessageBox.Show("Gostei de você, tudo metade do preço", ":|", MessageBoxButtons.OK, MessageBoxIcon.None);
                MessageBox.Show("...", " Σ(꒪ȏ꒪)", MessageBoxButtons.OK, MessageBoxIcon.None);

            }

            else if (pbMago.Visible == true && Convert.ToInt32(txtLabia2.Text) < 18)
            {
                MessageBox.Show("Eae velho, como andas?", ":V", MessageBoxButtons.OK, MessageBoxIcon.None);
                MessageBox.Show("Se você veio para comprar nada se prepara pro meu expectro patronum", ":|", MessageBoxButtons.OK, MessageBoxIcon.None);
                MessageBox.Show("...", "ಠ_ಠ", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

            else if (pbDagao2.Visible == true )
            {
                MessageBox.Show("Olá", ":V", MessageBoxButtons.OK, MessageBoxIcon.None);
                MessageBox.Show("Beep-bop", ":|", MessageBoxButtons.OK, MessageBoxIcon.None);
                MessageBox.Show("Não vamos chegar a lugar nenhum", "ಠ_ಠ", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

            else
            {

            }

        }



        private void btnAcampar_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt16(txtMoedas.Text) > 19 )
            {
                int a = Convert.ToInt16(txtMoedas.Text);
                int b = -20;
                int c = a + b;

                txtMoedas.Text = Convert.ToString(c);

                MessageBox.Show(":|", "Você usa um feitiço simples para desviar a chuva por um tempo.", MessageBoxButtons.OK, MessageBoxIcon.None);


                timer1.Enabled = true;
                btnAcampar.Enabled = false;
                btnCaminhar.Enabled = false;
                btnConversar.Enabled = false;
                btnCura.Enabled = false;
                btnPet.Enabled = false;
                btnVasculhar.Enabled = false;
                // MessageBox.Show(":|", "Adoro fogo mágico, Nem na chuva o bixo decepciona.", MessageBoxButtons.OK, MessageBoxIcon.None);
                pbBonf.Visible = true;
            }

            else
            {
                MessageBox.Show("Preciso de 15 Moedas...", ":|", MessageBoxButtons.OK, MessageBoxIcon.None);

            }





        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
            pbBonf.Visible = false;
            btnAcampar.Enabled = true;
            btnCaminhar.Enabled = true;
            btnConversar.Enabled = true;
            btnCura.Enabled = true;
            btnPet.Enabled = true;
            btnVasculhar.Enabled = true;
            pbrVidaM.Value = pbrVidaM.Maximum;
            MessageBox.Show("Dormindo", "（￣Ω￣）.", MessageBoxButtons.OK, MessageBoxIcon.None);

        }
        /*
        private void MyTimer10_Tick(object senders, EventArgs e)
        {

            MessageBox.Show(":|", "Adoro fogo mágico, Nem na chuva o bixo decepciona.", MessageBoxButtons.OK, MessageBoxIcon.None);
            timer.Stop();
            timer.Enabled = false;
            pbBonf.Visible = false;
        }

        */

        private void btnPet_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            if (random.Next(1, 6) == 1)
            {

                MessageBox.Show("O dragão te olha irritado.", "ಠ_ಠ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else if (random.Next(1, 6) == 2)
            {

                MessageBox.Show("O dragão te olha indiferente e depois vira.", " ◕ ‿‿ ◕ ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else if (random.Next(1, 6) == 3)
            {

                MessageBox.Show("O dragão te olha Com a cara de quem entendeu tudo.", " (っಠ‿ಠ)っ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else if (random.Next(1, 6) == 4)
            {

                MessageBox.Show("O dragão não te olha.", " (っ⇀⑃↼)っ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else if (random.Next(1, 6) == 5)
            {

                MessageBox.Show("O dragão comenta sobre o ódio das massas repreendidas.", "ლ(´ ❥ `ლ)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else
            {

                MessageBox.Show("O dragão Faz uma saudação que te lembra alguém não muito legal...", "∠(^ー^)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            /*
            txtVidaD.Clear();
            MessageBox.Show(" {{{(>_<)}}} ", "O dragão vai atacar.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            int a = 42;
           int p = a - ((Convert.ToInt32(txtSabedoria2.Text) + Convert.ToInt32(txtAgilidade2.Text)));

            txtVidaD.Text = Convert.ToString( p );
            */

            //Aqui tamb 

        }

        private void btnVasculhar_Click(object sender, EventArgs e)
        {


            pbrVasculhando.Visible = true;
            pbrVasculhando.Value = 0;
            lblVacu.Visible = true;

            Random random = new Random();

            if (random.Next(1, 10) == 1)
            {
                MessageBox.Show("O dragão te olha irritado por perder tanto tempo para achar LIXO", "ಠ_ಠ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cbxItens.Items.Add("Lixo");

            }

            else if (random.Next(1, 10) == 2)
            {
                MessageBox.Show("╭∩╮（︶︿︶）╭∩╮", "╭∩╮（︶︿︶）╭∩╮", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cbxItens.Items.Add("Lixo diferenciado");

            }

            else if (random.Next(1, 10) == 3)
            {
                MessageBox.Show("Um sanduíche perfeito. Você acha incrível, mas se lembra que não pode comer no jogo...", "~旦_(^O^ )", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cbxItens.Items.Add("O SANDUÍCHE!");
                //╭∩╮（︶︿︶）╭∩╮
            }

            else if (random.Next(1, 10) == 4)
            {
                lblNausea.Visible = true;
                MessageBox.Show("Você nota que o mundo está estranho... ", "ಠ_ಠ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show("Náusea", "Você Foi picado por um inseto. ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                if (lblNausea.Visible == true)
                {
                    int a = -5;
                    int b = Convert.ToInt32(txtAgilidade2.Text) + a;
                    txtAgilidade2.Text = Convert.ToString(b);
                }


            }

            else if (random.Next(1, 10) == 5)
            {
                timer.Enabled = false;
                MessageBox.Show("O dragão te olha como se você fosse retardado.", "ಠ_ಠ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cbxItens.Items.Add("Boboneco de madeira!");
            }

            else if (random.Next(1, 10) == 6)
            {
                MessageBox.Show("Um Chapéu de cowboy, aparentemente não  para você que começa a tentar imitar um bruxo", "(∩｀-´)⊃━☆ﾟ.*･｡ﾟ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cbxItens.Items.Add("Chapéu");
            }

            else if (random.Next(1, 10) == 7)
            {
                MessageBox.Show("Você e seu dragão se encaram surpresos.", "⑉ႣỏႣ⑉   ༼⁰o⁰；༽", MessageBoxButtons.OK, MessageBoxIcon.None);
                MessageBox.Show("Oi", "⑉ႣỏႣ⑉   ༼⁰o⁰；༽", MessageBoxButtons.OK, MessageBoxIcon.None);
                MessageBox.Show("Oi", "Mãe", MessageBoxButtons.OK, MessageBoxIcon.None);
                MessageBox.Show("é...", "⑉ႣỏႣ⑉   ༼⁰o⁰；༽", MessageBoxButtons.OK, MessageBoxIcon.None);
                MessageBox.Show("Se não tem nada pra falar, só me leva daqui", "Mãe", MessageBoxButtons.OK, MessageBoxIcon.None);
                MessageBox.Show("Adquiriu sua mãe", "(⺣ ◡ ⺣)♡*", MessageBoxButtons.OK, MessageBoxIcon.None);



                cbxItens.Items.Add("(⺣ ◡ ⺣)♡*");

            }

            else if (random.Next(1, 10) == 8)
            {
                MessageBox.Show("Você encontra o Mochila de Criança.", "ಠ_ಠ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show("Yo.", "ಠ_ಠ", MessageBoxButtons.OK, MessageBoxIcon.None);
                MessageBox.Show("Yo.", "↜(╰ •ω•)╯ψ", MessageBoxButtons.OK, MessageBoxIcon.None);
                MessageBox.Show("Preciso fazer algum pacto?", "ಠ_ಠ", MessageBoxButtons.OK, MessageBoxIcon.None);
                MessageBox.Show("", "↜(╰ •ω•)╯ψ", MessageBoxButtons.OK, MessageBoxIcon.None);
                MessageBox.Show("No", "↜(╰ •ω•)╯ψ", MessageBoxButtons.OK, MessageBoxIcon.None);
                MessageBox.Show("Adquiriu o Mochila de Criança", "↜(╰ •ω•)╯ψ", MessageBoxButtons.OK, MessageBoxIcon.None);



                cbxItens.Items.Add("↜(╰ •ω•)╯ψ");

            }

            else if (random.Next(1, 10) == 9)
            {
                MessageBox.Show("Você escuta um barulho um tanto familiar...", "BLOP", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                pbDagao.Visible = true;
                pbrVidaD.Value = 50;
                pbrVidaD.Visible = true;


                btnAcampar.Enabled = false;
                btnVasculhar.Enabled = false;
                btnCaminhar.Enabled = false;
                btnAtaque.Visible = true;
                btnAtaque.Enabled = true;



            }

            else
            {
                MessageBox.Show("Nada", "...", MessageBoxButtons.OK, MessageBoxIcon.None);

            }



            timer.Enabled = true;

            timer.Interval = (1000);

            pbrVasculhando.Increment(100);





            timer.Tick += new EventHandler(MyTimer11_Tick);
        }

        private void MyTimer11_Tick(object senders, EventArgs e)
        {
            pbrVasculhando.Visible = false;
            lblVacu.Visible = false;

            timer.Enabled = false;




        }

        private void pbFundo_Click(object sender, EventArgs e)
        {

        }

        private void btnPocao_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtLabia2.Text) > 17)
            {
                if (Convert.ToInt32(txtMoedas.Text) > 16)
                {
                    lblMetade2.Visible = false;


                    int z = Convert.ToInt32(txtMoedas.Text) - 16;
                    cbxItens.Items.Add("Poção de Vida (+25V)");
                    txtMoedas.Text = Convert.ToString(z);

                }

                else if (Convert.ToInt32(txtMoedas.Text) < 17)
                {
                    lblMetade2.Visible = true;
                }

            }

            else if (Convert.ToInt32(txtMoedas.Text) > 34)
            {
                lblPocao.Visible = false;


                int z = Convert.ToInt32(txtMoedas.Text) - 35;
                cbxItens.Items.Add("Poção de Vida (+25V)");
                txtMoedas.Text = Convert.ToString(z);

            }

            else if (Convert.ToInt32(txtMoedas.Text) < 35)
            {
                lblPocao.Visible = true;
            }

            else
            {

            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (cbxItens.Text == "Poção de Vida (+25V)")
            {
                lblVenda.Visible = false;

                int recebe;

                cbxItens.Items.Remove("Poção de Vida (+25V)");
                recebe = Convert.ToInt32(txtMoedas.Text) + 35;
                txtMoedas.Text = Convert.ToString(recebe);
                lblQuero.Visible = false;

            }

            else if (cbxItens.Text == "↜(╰ •ω•)╯ψ")
            {
                lblVenda.Visible = false;


                int recebe;


                cbxItens.Items.Remove("↜(╰ •ω•)╯ψ");
                recebe = Convert.ToInt32(txtMoedas.Text) + 50;
                txtMoedas.Text = Convert.ToString(recebe);
                lblQuero.Visible = false;


            }

            else if (cbxItens.Text == "Boboneco de madeira!")
            {
                lblVenda.Visible = false;


                int recebe;


                cbxItens.Items.Remove("Boboneco de madeira!");
                recebe = Convert.ToInt32(txtMoedas.Text) + 5;
                txtMoedas.Text = Convert.ToString(recebe);
                lblQuero.Visible = false;


            }

            else if (cbxItens.Text == "Pó de sangue")
            {
                lblVenda.Visible = false;


                int recebe;


                cbxItens.Items.Remove("Pó de sangue");
                recebe = Convert.ToInt32(txtMoedas.Text) + 100;
                txtMoedas.Text = Convert.ToString(recebe);
                lblQuero.Visible = false;


            }

            else if (cbxItens.Text == "Pó de sono")
            {
                lblVenda.Visible = false;


                int recebe;


                cbxItens.Items.Remove("Pó de sono");
                recebe = Convert.ToInt32(txtMoedas.Text) + 40;
                txtMoedas.Text = Convert.ToString(recebe);
                lblQuero.Visible = false;


            }

            else if (cbxItens.Text == "Cachorro")
            {
                lblVenda.Visible = false;


                int recebe;


                cbxItens.Items.Remove("Cachorro");
                recebe = Convert.ToInt32(txtMoedas.Text) + 15;
                txtMoedas.Text = Convert.ToString(recebe);
                lblQuero.Visible = false;


            }

            else if (cbxItens.Text == "Veneno")
            {
                lblVenda.Visible = false;


                int recebe;


                cbxItens.Items.Remove("Veneno");
                recebe = Convert.ToInt32(txtMoedas.Text) + 40;
                txtMoedas.Text = Convert.ToString(recebe);
                lblQuero.Visible = false;


            }

            else if (cbxItens.Text == "Gato")
            {
                lblVenda.Visible = false;


                int recebe;


                cbxItens.Items.Remove("Gato");
                recebe = Convert.ToInt32(txtMoedas.Text) + 15;
                txtMoedas.Text = Convert.ToString(recebe);
                lblQuero.Visible = false;


            }

            else if (cbxItens.Text == "Chapéu")
            {
                lblVenda.Visible = false;


                int recebe;


                cbxItens.Items.Remove("Chapéu");
                recebe = Convert.ToInt32(txtMoedas.Text) + 3;
                txtMoedas.Text = Convert.ToString(recebe);
                lblQuero.Visible = false;



            }

            else if (cbxItens.Text == "Lixo diferenciado")
            {
                lblVenda.Visible = false;


                int recebe;


                cbxItens.Items.Remove("Lixo diferenciado");
                recebe = Convert.ToInt32(txtMoedas.Text) + 2;
                txtMoedas.Text = Convert.ToString(recebe);
                lblQuero.Visible = false;



            }

            else if (cbxItens.Text == "O SANDUÍCHE!")
            {
                lblVenda.Visible = false;


                int recebe;

                cbxItens.Items.Remove("O SANDUÍCHE!");
                recebe = Convert.ToInt32(txtMoedas.Text) + 15;
                txtMoedas.Text = Convert.ToString(recebe);
                lblQuero.Visible = false;



            }

            else if (cbxItens.Text == "Lixo")
            {
                lblVenda.Visible = false;
                lblQuero.Visible = false;

                int recebe;

                cbxItens.Items.Remove("Lixo");
                recebe = Convert.ToInt32(txtMoedas.Text) + 1;
                txtMoedas.Text = Convert.ToString(recebe);


            }

            else if (cbxItens.Text == "")
            {
                lblVenda.Visible = true;
            }

            else
            {
                lblQuero.Visible = true;

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            lblPocao.Visible = false;
            btnConversar.Enabled = true;
            btnPet.Enabled = true;
            btnCaminhar.Visible = true;
            btnAcampar.Visible = true;
            btnVasculhar.Visible = true;

            pbMago.Visible = false;
            btnPocao.Visible = false;
            btnVender.Visible = false;
            btnArma.Visible = false;
            btnSair.Visible = false;
            lblArma.Visible = false;
            lblVenda.Visible = false;
            lblQuero.Visible = false;
            lblPocao.Visible = false;

        }

        private void cbxItens_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void btnArma_Click(object sender, EventArgs e)
        {
            string h = txtClasse2.Text;



            if (Convert.ToInt32(txtLabia2.Text) > 17)
            {
                if (h == "Mago!!" && Convert.ToInt32(txtMoedas.Text) < 50)
                {
                    lblMetade1.Visible = true;

                }

                else if (h == "Mago!!" && Convert.ToInt32(txtMoedas.Text) > 49)
                {


                    Random random = new Random();


                    if (random.Next(1, 5) == 1)
                    {
                        int t;

                        t = Convert.ToInt32(txtMoedas.Text);
                        t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(50);
                        txtMoedas.Text = Convert.ToString(t);

                        lblMetade1.Visible = false;

                        cbxItens.Items.Add("Pó do sono");
                    }

                    else if (random.Next(1, 5) == 2)
                    {
                        int t;

                        t = Convert.ToInt32(txtMoedas.Text);
                        t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(50);
                        txtMoedas.Text = Convert.ToString(t);

                        lblMetade1.Visible = false;

                        cbxItens.Items.Add("Pó de sangue");
                    }

                    else if (random.Next(1, 5) == 3)
                    {
                        int t;

                        t = Convert.ToInt32(txtMoedas.Text);
                        t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(50);
                        txtMoedas.Text = Convert.ToString(t);

                        lblMetade1.Visible = false;

                        cbxItens.Items.Add("Terra");
                    }

                    else if (random.Next(1, 5) == 4)
                    {
                        int t;

                        t = Convert.ToInt32(txtMoedas.Text);
                        t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(50);
                        txtMoedas.Text = Convert.ToString(t);

                        lblMetade1.Visible = false;

                        cbxItens.Items.Add("Remédio contra náusea");
                    }

                    else if (random.Next(1, 5) == 5)
                    {
                        int t;

                        t = Convert.ToInt32(txtMoedas.Text);
                        t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(50);
                        txtMoedas.Text = Convert.ToString(t);

                        lblMetade1.Visible = false;

                        cbxItens.Items.Add("saco de lixo");
                    }


                }



                else if (h == "Cavaleiro!!" && Convert.ToInt32(txtMoedas.Text) > 49)
                {
                    Random random = new Random();


                    if (random.Next(1, 5) == 1)
                    {
                        int t;

                        t = Convert.ToInt32(txtMoedas.Text);
                        t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(50);
                        txtMoedas.Text = Convert.ToString(t);

                        lblMetade1.Visible = false;

                        cbxItens.Items.Add("Estilingue");
                    }

                    else if (random.Next(1, 5) == 2)
                    {
                        int t;

                        t = Convert.ToInt32(txtMoedas.Text);
                        t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(50);
                        txtMoedas.Text = Convert.ToString(t);

                        lblMetade1.Visible = false;

                        cbxItens.Items.Add("Cachorro");
                    }

                    else if (random.Next(1, 5) == 3)
                    {
                        int t;

                        t = Convert.ToInt32(txtMoedas.Text);
                        t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(50);
                        txtMoedas.Text = Convert.ToString(t);

                        lblMetade1.Visible = false;

                        cbxItens.Items.Add("Terra");
                    }

                    else if (random.Next(1, 5) == 4)
                    {
                        int t;

                        t = Convert.ToInt32(txtMoedas.Text);
                        t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(50);
                        txtMoedas.Text = Convert.ToString(t);

                        lblMetade1.Visible = false;

                        cbxItens.Items.Add("Remédio contra náusea");
                    }

                    else if (random.Next(1, 5) == 5)
                    {
                        int t;

                        t = Convert.ToInt32(txtMoedas.Text);
                        t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(50);
                        txtMoedas.Text = Convert.ToString(t);

                        lblMetade1.Visible = false;

                        cbxItens.Items.Add("Botas");
                    }
                }


                else if (h == "Assassino!!" && Convert.ToInt32(txtMoedas.Text) > 49)
                {
                    Random random = new Random();

                    if (random.Next(1, 5) == 1)
                    {
                        int t;

                        t = Convert.ToInt32(txtMoedas.Text);
                        t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(50);
                        txtMoedas.Text = Convert.ToString(t);

                        lblMetade1.Visible = false;

                        cbxItens.Items.Add("Veneno");
                    }

                    else if (random.Next(1, 5) == 2)
                    {
                        int t;

                        t = Convert.ToInt32(txtMoedas.Text);
                        t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(50);
                        txtMoedas.Text = Convert.ToString(t);

                        lblMetade1.Visible = false;

                        cbxItens.Items.Add("Gato");
                    }

                    else if (random.Next(1, 5) == 3)
                    {
                        int t;

                        t = Convert.ToInt32(txtMoedas.Text);
                        t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(50);
                        txtMoedas.Text = Convert.ToString(t);

                        lblMetade1.Visible = false;

                        cbxItens.Items.Add("Terra");
                    }

                    else if (random.Next(1, 5) == 4)
                    {
                        int t;

                        t = Convert.ToInt32(txtMoedas.Text);
                        t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(50);
                        txtMoedas.Text = Convert.ToString(t);

                        lblMetade1.Visible = false;

                        cbxItens.Items.Add("Remédio contra náusea");
                    }

                    else if (random.Next(1, 5) == 5)
                    {
                        int t;

                        t = Convert.ToInt32(txtMoedas.Text);
                        t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(50);
                        txtMoedas.Text = Convert.ToString(t);

                        lblMetade1.Visible = false;

                        cbxItens.Items.Add("Capuz 2.0");
                    }
                }

                else if (h == "Assassino!!" && Convert.ToInt32(txtMoedas.Text) < 50)
                {
                    lblMetade1.Visible = true;
                }

                else if (h == "Cavaleiro!!" && Convert.ToInt32(txtMoedas.Text) < 50)
                {
                    lblMetade1.Visible = true;
                }

                else if (txtClasse2.Text == "Cavaleiro!!" && Convert.ToInt32(txtMoedas.Text) < 50)
                {
                    lblMetade1.Visible = true;
                }

                else if (txtClasse2.Text == "Cavaleiro!!" && txtMoedas.Text == null)
                {
                    lblMetade1.Visible = true;
                }

                else if (txtClasse2.Text == "Assassino!!" && txtMoedas.Text == null)
                {
                    lblMetade1.Visible = true;
                }

                else if (txtClasse2.Text == "Mago!!" && txtMoedas.Text == null)
                {

                    lblMetade1.Visible = true;
                }
                else
                {

                }
            }

            else if (h == "Mago!!" && Convert.ToInt32(txtMoedas.Text) < 100)
            {
                lblArma.Visible = true;


            }

            else if (h == "Mago!!" && Convert.ToInt32(txtMoedas.Text) > 99)
            {
                Random random = new Random();


                if (random.Next(1, 5) == 1)
                {
                    int t;

                    t = Convert.ToInt32(txtMoedas.Text);
                    t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(100);
                    txtMoedas.Text = Convert.ToString(t);

                    lblArma.Visible = false;

                    cbxItens.Items.Add("Pó do sono");
                }

                else if (random.Next(1, 5) == 2)
                {
                    int t;

                    t = Convert.ToInt32(txtMoedas.Text);
                    t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(100);
                    txtMoedas.Text = Convert.ToString(t);

                    lblArma.Visible = false;

                    cbxItens.Items.Add("Pó de sangue");
                }

                else if (random.Next(1, 5) == 3)
                {
                    int t;

                    t = Convert.ToInt32(txtMoedas.Text);
                    t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(100);
                    txtMoedas.Text = Convert.ToString(t);

                    lblArma.Visible = false;

                    cbxItens.Items.Add("Terra");
                }

                else if (random.Next(1, 5) == 4)
                {
                    int t;

                    t = Convert.ToInt32(txtMoedas.Text);
                    t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(100);
                    txtMoedas.Text = Convert.ToString(t);

                    lblArma.Visible = false;

                    cbxItens.Items.Add("Remédio contra náusea");
                }

                else if (random.Next(1, 5) == 5)
                {
                    int t;

                    t = Convert.ToInt32(txtMoedas.Text);
                    t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(100);
                    txtMoedas.Text = Convert.ToString(t);

                    lblArma.Visible = false;

                    cbxItens.Items.Add("saco de lixo");
                }

            }



            else if (h == "Cavaleiro!!" && Convert.ToInt32(txtMoedas.Text) > 99)
            {
                Random random = new Random();


                if (random.Next(1, 5) == 1)
                {
                    int t;

                    t = Convert.ToInt32(txtMoedas.Text);
                    t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(100);
                    txtMoedas.Text = Convert.ToString(t);

                    lblArma.Visible = false;

                    cbxItens.Items.Add("Estilingue");
                }

                else if (random.Next(1, 5) == 2)
                {
                    int t;

                    t = Convert.ToInt32(txtMoedas.Text);
                    t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(100);
                    txtMoedas.Text = Convert.ToString(t);

                    lblArma.Visible = false;

                    cbxItens.Items.Add("Cachorro");
                }

                else if (random.Next(1, 5) == 3)
                {
                    int t;

                    t = Convert.ToInt32(txtMoedas.Text);
                    t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(100);
                    txtMoedas.Text = Convert.ToString(t);

                    lblArma.Visible = false;

                    cbxItens.Items.Add("Terra");
                }

                else if (random.Next(1, 5) == 4)
                {
                    int t;

                    t = Convert.ToInt32(txtMoedas.Text);
                    t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(100);
                    txtMoedas.Text = Convert.ToString(t);

                    lblArma.Visible = false;

                    cbxItens.Items.Add("Remédio contra náusea");
                }

                else if (random.Next(1, 5) == 5)
                {
                    int t;

                    t = Convert.ToInt32(txtMoedas.Text);
                    t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(100);
                    txtMoedas.Text = Convert.ToString(t);

                    lblArma.Visible = false;

                    cbxItens.Items.Add("Botas");
                }
            }


            else if (h == "Assassino!!" && Convert.ToInt32(txtMoedas.Text) > 99)
            {
                Random random = new Random();

                if (random.Next(1, 5) == 1)
                {
                    int t;

                    t = Convert.ToInt32(txtMoedas.Text);
                    t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(100);
                    txtMoedas.Text = Convert.ToString(t);

                    lblArma.Visible = false;

                    cbxItens.Items.Add("Veneno");
                }

                else if (random.Next(1, 5) == 2)
                {
                    int t;

                    t = Convert.ToInt32(txtMoedas.Text);
                    t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(100);
                    txtMoedas.Text = Convert.ToString(t);

                    lblArma.Visible = false;

                    cbxItens.Items.Add("Gato");
                }

                else if (random.Next(1, 5) == 3)
                {
                    int t;

                    t = Convert.ToInt32(txtMoedas.Text);
                    t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(100);
                    txtMoedas.Text = Convert.ToString(t);

                    lblArma.Visible = false;
                    lblArma.Visible = false;

                    cbxItens.Items.Add("Terra");
                }

                else if (random.Next(1, 5) == 4)
                {
                    int t;

                    t = Convert.ToInt32(txtMoedas.Text);
                    t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(100);
                    txtMoedas.Text = Convert.ToString(t);

                    lblArma.Visible = false;

                    cbxItens.Items.Add("Remédio contra náusea");
                }

                else if (random.Next(1, 5) == 5)
                {
                    int t;

                    t = Convert.ToInt32(txtMoedas.Text);
                    t = Convert.ToInt32(txtMoedas.Text) - Convert.ToInt32(100);
                    txtMoedas.Text = Convert.ToString(t);

                    lblArma.Visible = false;

                    cbxItens.Items.Add("Capuz 2.0");
                }
            }

            else if (h == "Assassino!!" && Convert.ToInt32(txtMoedas.Text) < 100)
            {
                lblArma.Visible = true;
            }

            else if (h == "Cavaleiro!!" && Convert.ToInt32(txtMoedas.Text) < 100)
            {
                lblArma.Visible = true;

            }

            else if (txtClasse2.Text == "Cavaleiro!!" && Convert.ToInt32(txtMoedas.Text) < 100)
            {
                lblArma.Visible = true;

            }

            else if (txtClasse2.Text == "Cavaleiro!!" && txtMoedas.Text == null)
            {
                lblArma.Visible = true;

            }

            else if (txtClasse2.Text == "Assassino!!" && txtMoedas.Text == null)
            {
                lblArma.Visible = true;

            }

            else if (txtClasse2.Text == "Mago!!" && txtMoedas.Text == null)
            {

                lblArma.Visible = true;

            }
            else
            {

            }



        }

        private void btnataque2_Click(object sender, EventArgs e)
        {
            if (txtClasse2.Text == "Cavaleiro!!")
            {


                pbrDagao2.Increment(Convert.ToInt32(DamageC2()));

                if (Convert.ToInt32(pbrDagao2.Value) < 0 || Convert.ToInt32(pbrDagao2.Value) == 0)
                {
                    if (pbrDagao2.Value == 0 || pbrDagao2.Value < 0)
                    {
                        Random random = new Random();

                        if (random.Next(1, 5) == 1)
                        {
                            cbxItens.Items.Add("Poção de Vida (+25V) ");
                        }

                        else if (random.Next(1, 5) == 2)
                        {
                            cbxItens.Items.Add("Lixo ");
                        }

                        else if (random.Next(1, 5) == 3)
                        {
                            MessageBox.Show("Dropou nada...", ":O", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }

                        else if (random.Next(1, 5) == 4)
                        {
                            MessageBox.Show("Dropou nada...", ":O", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }

                        else if (random.Next(1, 5) == 5)
                        {
                            MessageBox.Show("Dropou nada...", ":O", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }

                       
                            btnPet.Enabled = true;
                            btnAcampar.Enabled = true;


                            int recebe;


                            recebe = Convert.ToInt32(txtMoedas.Text) + 12;
                            txtMoedas.Text = Convert.ToString(recebe);

                            pbrXp.Increment(80);

                            btnCaminhar.Visible = true;
                            btnAtaque.Visible = true;
                            lblQuero.Visible = false;
                            pbDagao.Visible = false;
                            pbDagao2.Visible = false;
                            pbrDagao2.Visible = false;
                            btnCaminhar.Enabled = true;


                            btnAcampar.Enabled = true;
                            btnVasculhar.Enabled = true;
                            pbrDagao2.Value = 60;
                            btnAtaque.Enabled = false;
                            btnAtaque2.Enabled = false;
                            if (lblNausea.Visible == true)
                            {
                                int a = Convert.ToInt32(txtAgilidade2.Text) + 5;

                                txtAgilidade2.Text = Convert.ToString(a);
                                lblNausea.Visible = false;
                            }
                        

                    }



                    if (pbrXp.Value == 100)
                    {
                        MessageBox.Show("Isso! LvL Up!.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        lblNivel.Text = " Nível 2";
                        pbrXp.Maximum = 500;
                    }

                    if (pbrXp.Value == 500)
                    {
                        MessageBox.Show("Isso! LvL Up!.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        lblNivel.Text = "Nível 3";
                        pbrXp.Maximum = 1500;

                    }

                    if (pbrXp.Value == 1500)
                    {
                        MessageBox.Show("Isso! LvL Up!.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        lblNivel.Text = "Nível 4";
                        pbrXp.Maximum = 5000;

                    }




                }


                pbrVidaM.Increment(Convert.ToInt32(DamageD2()));




                if (Convert.ToInt32(pbrVidaM.Value) < 0 || Convert.ToInt32(pbrVidaM.Value) == 0)
                {
                    MessageBox.Show("Sua alma está sendo levada para algum lugar, mas você sente que qualquer lugar é melhor que essa vida.", "╭∩╮（︶︿︶）╭∩╮", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Application.Exit();

                }


                else if (Convert.ToInt32(pbrVidaM.Value) < 0 || Convert.ToInt32(pbrVidaM.Value) == 0)
                {
                    MessageBox.Show("Isso! Você morreu!.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }

            else if (txtClasse2.Text == "Mago!!")
            {
                pbrDagao2.Increment(Convert.ToInt32(DamageM()));

                if (Convert.ToInt32(pbrDagao2.Value) < 0 || Convert.ToInt32(pbrDagao2.Value) == 0)
                {
                    if (pbrDagao2.Value == 0 || pbrDagao2.Value < 0)
                    {
                        Random random = new Random();

                        if (random.Next(1, 5) == 1)
                        {
                            cbxItens.Items.Add("Poção de Vida (+25V) ");
                        }

                        else if (random.Next(1, 5) == 2)
                        {
                            cbxItens.Items.Add("Lixo ");
                        }

                        else if (random.Next(1, 5) == 3)
                        {
                            MessageBox.Show("Dropou nada...", ":O", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }

                        else if (random.Next(1, 5) == 4)
                        {
                            MessageBox.Show("Dropou nada...", ":O", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }

                        else if (random.Next(1, 5) == 5)
                        {
                            MessageBox.Show("Dropou nada...", ":O", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }

                     
                            btnPet.Enabled = true;
                            btnAcampar.Enabled = true;

                            int recebe;


                        recebe = Convert.ToInt32(txtMoedas.Text) + 12;
                        txtMoedas.Text = Convert.ToString(recebe);

                            pbrXp.Increment(80);
                            btnAtaque.Visible = true;

                            lblQuero.Visible = false;
                            pbDagao.Visible = false;
                            pbDagao2.Visible = false;
                            pbrDagao2.Visible = false;
                            btnCaminhar.Enabled = true;
                            btnCaminhar.Visible = true;




                            btnAcampar.Enabled = true;
                            btnVasculhar.Enabled = true;
                            pbrDagao2.Value = 60;
                            btnAtaque.Enabled = false;
                            btnAtaque2.Enabled = false;
                            if (lblNausea.Visible == true)
                            {
                                int a = Convert.ToInt32(txtAgilidade2.Text) + 5;

                                txtAgilidade2.Text = Convert.ToString(a);
                                lblNausea.Visible = false;
                            }
                        
                    }



                    if (pbrXp.Value == 100)
                    {
                        MessageBox.Show("Isso! LvL Up!.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        lblNivel.Text = " Nível 2";
                        pbrXp.Maximum = 500;
                    }

                    if (pbrXp.Value == 500)
                    {
                        MessageBox.Show("Isso! LvL Up!.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        lblNivel.Text = "Nível 3";
                        pbrXp.Maximum = 1500;

                    }

                    if (pbrXp.Value == 1500)
                    {
                        MessageBox.Show("Isso! LvL Up!.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        lblNivel.Text = "Nível 4";
                        pbrXp.Maximum = 5000;

                    }




                }


                pbrVidaM.Increment(Convert.ToInt32(DamageD2()));





                if (Convert.ToInt32(pbrVidaM.Value) < 0 || Convert.ToInt32(pbrVidaM.Value) == 0)
                {
                    MessageBox.Show("Sua alma está sendo levada para algum lugar, mas você sente que qualquer lugar é melhor que essa vida.", "╭∩╮（︶︿︶）╭∩╮", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Application.Exit();

                }


                else if (Convert.ToInt32(pbrVidaM.Value) < 0 || Convert.ToInt32(pbrVidaM.Value) == 0)
                {
                    MessageBox.Show("Isso! Você morreu!.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }

            else if (txtClasse2.Text == "Assassino!!")
            {
                pbrDagao2.Increment(Convert.ToInt32(DamageA()));

                if (Convert.ToInt32(pbrDagao2.Value) < 0 || Convert.ToInt32(pbrDagao2.Value) == 0)
                {
                    if (pbrDagao2.Value == 0 || pbrDagao2.Value < 0)
                    {
                        Random random = new Random();

                        if (random.Next(1, 5) == 1)
                        {
                            cbxItens.Items.Add("Poção de Vida (+25V) ");
                        }

                        else if (random.Next(1, 5) == 2)
                        {
                            cbxItens.Items.Add("Lixo ");
                        }

                        else if (random.Next(1, 5) == 3)
                        {
                            MessageBox.Show("Dropou nada...", ":O", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }

                        else if (random.Next(1, 5) == 4)
                        {
                            MessageBox.Show("Dropou nada...", ":O", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }

                        else if (random.Next(1, 5) == 5)
                        {
                            MessageBox.Show("Dropou nada...", ":O", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }

                       
                            btnPet.Enabled = true;
                            btnAcampar.Enabled = true;

                            int recebe;


                        recebe = Convert.ToInt32(txtMoedas.Text) + 12;
                        txtMoedas.Text = Convert.ToString(recebe);

                            pbrXp.Increment(80);
                            btnAtaque.Visible = true;

                            lblQuero.Visible = false;
                            pbDagao.Visible = false;
                            pbDagao2.Visible = false;
                            pbrDagao2.Visible = false;
                            btnCaminhar.Enabled = true;
                            btnCaminhar.Visible = true;




                            btnAcampar.Enabled = true;
                            btnVasculhar.Enabled = true;
                            pbrDagao2.Value = 60;
                            btnAtaque.Enabled = false;
                            btnAtaque2.Enabled = false;
                            if (lblNausea.Visible == true)
                            {
                                int a = Convert.ToInt32(txtAgilidade2.Text) + 5;

                                txtAgilidade2.Text = Convert.ToString(a);
                                lblNausea.Visible = false;
                            }
                        
                    }



                    if (pbrXp.Value == 100)
                    {
                        MessageBox.Show("Isso! LvL Up!.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        lblNivel.Text = " Nível 2";
                        pbrXp.Maximum = 500;
                    }

                    if (pbrXp.Value == 500)
                    {
                        MessageBox.Show("Isso! LvL Up!.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        lblNivel.Text = "Nível 3";
                        pbrXp.Maximum = 1500;

                    }

                    if (pbrXp.Value == 1500)
                    {
                        MessageBox.Show("Isso! LvL Up!.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        lblNivel.Text = "Nível 4";
                        pbrXp.Maximum = 5000;

                    }




                }


                pbrVidaM.Increment(Convert.ToInt32(DamageD2()));





                if (Convert.ToInt32(pbrVidaM.Value) < 0 || Convert.ToInt32(pbrVidaM.Value) == 0)
                {
                    MessageBox.Show("Sua alma está sendo levada para algum lugar, mas você sente que qualquer lugar é melhor que essa vida.", "╭∩╮（︶︿︶）╭∩╮", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Application.Exit();

                }


                else if (Convert.ToInt32(pbrVidaM.Value) < 0 || Convert.ToInt32(pbrVidaM.Value) == 0)
                {
                    MessageBox.Show("Isso! Você morreu!.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }
        }

        private void cbxItens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(cbxItens.Text) == "Capuz 2.0")

            {
                MessageBox.Show("Um capuz faz o homem.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }

            else if (Convert.ToString(cbxItens.Text) == "Remédio contra náusea")
            {
                MessageBox.Show("Um problema a menos.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }

            else if (Convert.ToString(cbxItens.Text) == "Veneno" && pbDagao.Visible == true || Convert.ToString(cbxItens.Text) == "Veneno" && pbDagao2.Visible == true)
            {
                MessageBox.Show("Segura ai", ":Z", MessageBoxButtons.OK, MessageBoxIcon.None);

                pbrXp.Increment(80);
                pbrVidaD.Visible = false;
                pbrDagao2.Visible = false;
                pbDagao2.Visible = false;
                pbDagao.Visible = false;
                btnAtaque.Enabled = false;
                btnAtaque2.Enabled = false;
                btnVasculhar.Enabled = true;
                btnAcampar.Enabled = true;
                btnCaminhar.Enabled = true;

                MessageBox.Show("Morre em agonia...", ":(", MessageBoxButtons.OK, MessageBoxIcon.None);


            }

            else if (Convert.ToString(cbxItens.Text) == "Veneno")
            {
                MessageBox.Show("Preciso de um alvo...", ":Z", MessageBoxButtons.OK, MessageBoxIcon.None);

            }

            else if (Convert.ToString(cbxItens.Text) == "Gato" && pbDagao.Visible == true || Convert.ToString(cbxItens.Text) == "Gato" && pbDagao2.Visible == true)
            {
                MessageBox.Show("Já viu um desse?", ":O", MessageBoxButtons.OK, MessageBoxIcon.None);
                pbrVidaD.Visible = false;
                pbrDagao2.Visible = false;
                pbDagao2.Visible = false;
                pbDagao.Visible = false;
                btnAtaque.Enabled = false;
                btnAtaque2.Enabled = false;
                btnVasculhar.Enabled = true;
                btnAcampar.Enabled = true;
                btnCaminhar.Enabled = true;
                pbrXp.Increment(65);




                MessageBox.Show("O inimigo foge com medo!", ":(", MessageBoxButtons.OK, MessageBoxIcon.None);


            }

            else if (Convert.ToString(cbxItens.Text) == "Gato")
            {
                MessageBox.Show("Eu deveria esperar, para mostrá-lo a alguém...", ":O", MessageBoxButtons.OK, MessageBoxIcon.None);

            }

            else if (Convert.ToString(cbxItens.Text) == "Estilingue")
            {
                MessageBox.Show("Forte, aparentemente...", ":V", MessageBoxButtons.OK, MessageBoxIcon.None);

                cbxItens.Items.Remove("Estilingue");

                int a = 1;
                int b = Convert.ToInt32(txtForca2.Text) + a;
                txtForca2.Text = Convert.ToString(b);
                ;
            }

            else if (Convert.ToString(cbxItens.Text) == "Cachorro")
            {
                MessageBox.Show("que fofinho ", ":O", MessageBoxButtons.OK, MessageBoxIcon.None);

                cbxItens.Items.Remove("Cachorro");

                MessageBox.Show("Ele te lambe e corre em direção ao amanhã, isso te enche de determinação. E de vida também. ", ":O", MessageBoxButtons.OK, MessageBoxIcon.None);
                pbrVidaM.Value = pbrVidaM.Maximum;


            }

            else if (Convert.ToString(cbxItens.Text) == "Pó do sono" && pbDagao.Visible == true || Convert.ToString(cbxItens.Text) == "Pó do sono" && pbDagao2.Visible == true)
            {
                MessageBox.Show("pega o pó", ":)", MessageBoxButtons.OK, MessageBoxIcon.None);
                cbxItens.Items.Remove("Pó do sono");

                pbrVidaD.Visible = false;
                pbrDagao2.Visible = false;
                pbDagao2.Visible = false;
                pbDagao.Visible = false;
                btnAtaque.Enabled = false;
                btnAtaque2.Enabled = false;
                btnVasculhar.Enabled = true;
                btnAcampar.Enabled = true;
                btnCaminhar.Enabled = true;
                pbrXp.Increment(65);


                MessageBox.Show("O inimigo dorme. ", ":)", MessageBoxButtons.OK, MessageBoxIcon.None);

                pbrVidaM.Value = pbrVidaM.Maximum;


            }

            else if (Convert.ToString(cbxItens.Text) == "(⺣ ◡ ⺣)♡*" && pbDagao.Visible == true || Convert.ToString(cbxItens.Text) == "(⺣ ◡ ⺣)♡*" && pbDagao2.Visible == true)
            {
                MessageBox.Show("Num ato desesperado você lança sua mãe na direção do inimigo", ":(", MessageBoxButtons.OK, MessageBoxIcon.None);
                cbxItens.Items.Remove("(⺣ ◡ ⺣)♡*");

                pbrVidaD.Visible = false;
                pbrDagao2.Visible = false;
                pbDagao2.Visible = false;
                pbDagao.Visible = false;
                btnAtaque.Enabled = false;
                btnAtaque2.Enabled = false;
                btnVasculhar.Enabled = true;
                btnAcampar.Enabled = true;
                btnCaminhar.Enabled = true;
                pbrXp.Increment(65);


                MessageBox.Show("O inimigo Explode. ", ":)", MessageBoxButtons.OK, MessageBoxIcon.None);

                pbrVidaM.Value = pbrVidaM.Maximum;


            }

            else if (Convert.ToString(cbxItens.Text) == "(⺣ ◡ ⺣)♡*" )
            {
                MessageBox.Show("Não fale comigo", ":(", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
               
            }


            else if (Convert.ToString(cbxItens.Text) == "Pó do sono")
            {


                MessageBox.Show("Sem alvo. ", ":|", MessageBoxButtons.OK, MessageBoxIcon.None);



            }

            else if (Convert.ToString(cbxItens.Text) == "Boboneco de madeira!" && pbDagao.Visible == true || Convert.ToString(cbxItens.Text) == "Boboneco de madeira!" && pbDagao2.Visible == true)
            {
                pbBoboneco.Visible = true;
                cbxItens.Items.Remove("Boboneco de madeira!");

               


                pbrDagao2.Increment(-20);
                pbrVidaD.Increment(-20);

                timer5.Enabled = true;

            }

            else if (Convert.ToString(cbxItens.Text) == "Boboneco de madeira!")
            {

                MessageBox.Show("Boboneco não faz nada ", ":|", MessageBoxButtons.OK, MessageBoxIcon.None);

            }

            else if (Convert.ToString(cbxItens.Text) == "↜(╰ •ω•)╯ψ")
            {

                MessageBox.Show("O inferno continua quente", ":)", MessageBoxButtons.OK, MessageBoxIcon.None);

            }

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pbBoboneco.Visible = false;

            timer5.Enabled = false;
        }
    }
}

