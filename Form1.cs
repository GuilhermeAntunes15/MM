using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mm
{
    public partial class Form1 : Form
    {

        Timer timer = new Timer();

        Timer Timer2 = new Timer();

        Timer Timer3 = new Timer();

        Timer Timer4 = new Timer();


        public Form1()
        {
            InitializeComponent();
        }

     
     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //passa a string de conexão
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3307;User Id=root;database=m; pasbd_msword=usbw");
                //abre o banco de dados
                objcon.Open();
                MessageBox.Show("Conectado");
                //fecha a conexão
                objcon.Close();

            }

            catch
            {
                MessageBox.Show("Não conectou");
            }
        }

       

 

        private void btnKnight_MouseHover(object sender, EventArgs e)
        {
            txtKnight.Visible = true;
        }

        private void btnKnight_MouseLeave(object sender, EventArgs e)
        {
            txtKnight.Visible = false;
        }

        public void btnMage_Click(object sender, EventArgs e)
        {


            timer.Start();

            timer.Interval = (500); // 45 mins


            timer.Tick += new EventHandler(MyTimerMage_Tick);

            timer.Enabled = true;
            /*  Form2 form2 = new Form2();
              this.Hide();
              form2.Show(); */
        }

        private void MyTimerMage_Tick(object sender, EventArgs e)
        {
            pbMage2.Visible = true;
            pbMage.Visible = false;
           

            timer.Enabled = false;

            if (timer.Enabled == false)
            {
                Timer2.Start();

                Timer2.Enabled = true;

                Timer2.Interval = (310);

                Timer2.Tick += new EventHandler(MyTimerMage2_Tick);

            }
        }

        private void MyTimerMage2_Tick(object sender, EventArgs e)
        {
            pbMage3.Visible = true;
            pbMage2.Visible = false;
           

            Timer2.Enabled = false;

            if (Timer2.Enabled == false)
            {
                Timer3.Start();

                Timer3.Enabled = true;

                Timer3.Interval = (310);

                Timer3.Tick += new EventHandler(MyTimerMage3_Tick);

            }

        }


        private void MyTimerMage3_Tick(object sender, EventArgs e)
        {
            pbMage4.Visible = true;
            pbMage3.Visible = false;
          

            Timer3.Enabled = false;

            if (Timer3.Enabled == false)
            {

                Timer4.Start();

                Timer4.Enabled = true;

                Timer4.Interval = (310);

                Timer4.Tick += new EventHandler(MyTimerMage4_Tick);

            }

        }

        private void MyTimerMage4_Tick(object sender, EventArgs e)
        {
            Form2 destino = new Form2(txtMage.Text);
            this.Hide();
            destino.Show();

            Timer4.Enabled = false;
        }

            private void btnMage_MouseHover(object sender, EventArgs e)
        {
            txtMage.Visible = true;
        }

        private void btnMage_MouseLeave(object sender, EventArgs e)
        {
            txtMage.Visible = false;
        }

        public void btnKnight_Click(object sender, EventArgs e)
        {
            timer.Start();
            
            timer.Interval = (500); // 45 mins


            timer.Tick += new EventHandler(MyTimer_Tick);

            timer.Enabled = true;


        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {

            pbKnight2.Visible = true;
            pbKnight.Visible = false;
            

            timer.Enabled = false;

            if (timer.Enabled == false)
            {
               

                Timer2.Start();

                Timer2.Enabled = true;

                Timer2.Interval = (310);

                Timer2.Tick += new EventHandler(MyTimer2_Tick);

               
            }




        }

        private void MyTimer2_Tick(object sender, EventArgs e)
        {
            pbKnight3.Visible = true;
            pbKnight2.Visible = false;
            

            Timer2.Enabled = false;

            if (Timer2.Enabled == false)
            {
                Timer3.Start();

                Timer3.Enabled = true;

                Timer3.Interval = (310);

                Timer3.Tick += new EventHandler(MyTimer3_Tick);

            }


        }

        private void MyTimer3_Tick(object sender, EventArgs e)
        {
            
            pbKnight4.Visible = true;
            pbKnight3.Visible = false;

            Timer3.Enabled = false;

            if (Timer3.Enabled == false)
            {
                Timer4.Start();

                Timer4.Enabled = true;

                Timer4.Interval = (500);

                Timer4.Tick += new EventHandler(MyTimer4_Tick);
            }
        }

        private void MyTimer4_Tick(object sender, EventArgs e)
        {
            Form2 destino = new Form2(txtKnight.Text);
            this.Hide();
            destino.Show();

            Timer4.Enabled = false;

        }

            private void btnAssassin_MouseHover(object sender, EventArgs e)
        {
           txtAssassin.Visible = true;
        }

        private void btnAssassin_MouseLeave(object sender, EventArgs e)
        {
            txtAssassin.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void btnAssassin_Click(object sender, EventArgs e)
        {
            timer.Start();

            timer.Interval = (500); // 45 mins


            timer.Tick += new EventHandler(MyTimerAssassin_Tick);

        }

    

        private void MyTimerAssassin_Tick(object sender, EventArgs e)
        {
            pbAssassin2.Visible = true;
            pbAssassin.Visible = false;
            

            timer.Enabled = false;

            if (timer.Enabled == false)
            {
                Timer2.Start();

                Timer2.Enabled = true;

                Timer2.Interval = (310);

                Timer2.Tick += new EventHandler(MyTimerAssassin_Tick2);

            }
        }

        private void MyTimerAssassin_Tick2(object sender, EventArgs e)
        {
            pbAssassin3.Visible = true;
            pbAssassin2.Visible = false;
          

            Timer2.Enabled = false;

            if (Timer2.Enabled == false)
            {
                Timer3.Start();

                Timer3.Enabled = true;

                Timer3.Interval = (310);

                Timer3.Tick += new EventHandler(MyTimerAssassin_Tick3);

            }

        }


        private void MyTimerAssassin_Tick3(object sender, EventArgs e)
        {
            pbAssassin4.Visible = true;
            pbAssassin3.Visible = false;
     

            Timer3.Enabled = false;

            if (Timer3.Enabled == false)
            {

                Timer4.Start();

                Timer4.Enabled = true;

                Timer4.Interval = (310);

                Timer4.Tick += new EventHandler(MyTimerAssassin_Tick4);

            }

        }

        private void MyTimerAssassin_Tick4(object sender, EventArgs e)
        {
            Form2 destino = new Form2(txtAssassin.Text);
            this.Hide();
            destino.Show();

            Timer4.Enabled = false;
        }

        private void txtMage_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pbKnight_Click(object sender, EventArgs e)
        {

        }

        private void txtAssassin_TextChanged(object sender, EventArgs e)
        {

        }

        private void PbDemon1_MouseHover(object sender, EventArgs e)
        {
            txtDemonio.Visible = true;
        }

        private void PbDemon1_MouseLeave(object sender, EventArgs e)
        {
            txtDemonio.Visible = false;
        }

        private void PbHounddog_MouseHover(object sender, EventArgs e)
        {
            txtCachorro.Visible = true;
        }

        private void PbHounddog_MouseLeave(object sender, EventArgs e)
        {
            txtCachorro.Visible = false;
        }

        private void PbDemon_MouseHover(object sender, EventArgs e)
        {
            txtDemonio2.Visible = true;
        }

        private void PbDemon_MouseLeave(object sender, EventArgs e)
        {
            txtDemonio2.Visible = false;
        }

        private void pbKnight3_Click(object sender, EventArgs e)
        {

        }

        private void pbDemon_Click(object sender, EventArgs e)
        {

        }
    }
}
