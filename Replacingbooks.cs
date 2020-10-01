using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18001996_Task1
{
    public partial class ReplacingBooks : Form
    {


        String A;
        String B;
        String C;
        String part1, part2;
      
        RandomClass rc = new RandomClass();
        List<string> answer = new List<string>();
        List<String> callnum = new List<String>();

        private int originalWidth;
        private int originalHeight;
        int attempt = 0;
    
        int t = 0;

        public ReplacingBooks()
        {
            InitializeComponent();
            originalWidth = this.Width;
            originalHeight = this.Height;

        }

        public void Form1_Load(object sender, EventArgs e)
        {

            this.Width = 741;
            this.Height = 530;
            MessageBox.Show("Achievement Unlocked! Your first Game :)");
            
            addtolist();
            groupBox1.Enabled = false;
            groupBox1.Visible = false;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
    
        }
        public void addtolist()
        {
            
            for (int i = 10 - 1; i >= 0; i--)
            {
               
                A = rc.RandomNumber(3);
                B =  rc.RandomString(3);
                C = rc.Randomdoublenumber(2);
                part1 = String.Concat(A, ".");
                part2 = String.Concat(part1, C);

                callnum.Add(String.Concat(part2," ", B));  
            }

            call1.Text = callnum[1];
            call2.Text = callnum[2];
            call3.Text = callnum[3];
            call4.Text = callnum[4];
            call5.Text = callnum[5];
            call6.Text = callnum[6];
            call7.Text = callnum[7];
            call8.Text = callnum[8];
            call9.Text = callnum[9];
            call10.Text = callnum[0];




        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Width = 1090;
            //New Height
            this.Height = 530;
        }
            private void button1_Click(object sender, EventArgs e)
            {
            callnum.Sort();
            if (answer.Count<10)
            {
                MessageBox.Show("Please compelete all before checking your answer");

            }
            else
            { 
            timer1.Enabled = false;
            string timelapsed = label1.Text;
               
           
            if (callnum.SequenceEqual(answer))
            {
                MessageBox.Show("Well done! You have got it right");
                    if (attempt == 0)
                    {
                        MessageBox.Show("Achievement Unlocked! You have sorted it on your first attempt o_0");
                        label3.Visible = true;

                    }
                    if (attempt < 3)
                    {
                        MessageBox.Show("Achievement Unlocked! You have completed your first puzzle");
                        label3.Visible = true;

                    }

                }
            else
            {
                MessageBox.Show("Oops! That's not correct Please try again");
                    groupBox1.Enabled = true;
                    answer.Clear();
                    UserAnswer.Items.Clear();
                    attempt++;
                    timer1.Enabled=true;
                    call1.Enabled = true;
                    call2.Enabled = true;
                    call3.Enabled = true;
                    call4.Enabled = true;
                    call5.Enabled = true;
                    call6.Enabled = true;
                    call7.Enabled = true;
                    call8.Enabled = true;
                    call9.Enabled = true;
                    call10.Enabled = true;
                   if (attempt == 3)
                    {
                        MessageBox.Show("Achievement Unlocked! Failed attempts = 5");
                        label4.Visible = true;


                    }
                    if (attempt == 5)
                    {
                        MessageBox.Show("Achievement Unlocked! Failed attempts = 10");
                        label5.Visible = true;


                    }
                }
                if (attempt>5)
                {
                    MessageBox.Show("Game Over");
                    SelelectionScreen sc = new SelelectionScreen();
                    this.Hide();
                    sc.Show();

                }
            }

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

      

        private void call6_Click(object sender, EventArgs e)
        {
            answer.Add(this.call6.Text);
            UserAnswer.Items.Add(this.call6.Text);
            this.call6.Visible = false;
        }

        private void call1_Click(object sender, EventArgs e)
        {
            answer.Add(this.call1.Text);
            UserAnswer.Items.Add(this.call1.Text);
            this.call1.Visible = false;
        }

        private void call2_Click(object sender, EventArgs e)
        {
            answer.Add(this.call2.Text);
            UserAnswer.Items.Add(this.call2.Text);
            this.call2.Visible = false;
        }

        private void call3_Click(object sender, EventArgs e)
        {
            answer.Add(this.call3.Text);
            UserAnswer.Items.Add(this.call3.Text);
            this.call3.Visible = false;
        }

        private void call4_Click(object sender, EventArgs e)
        {
            answer.Add(this.call4.Text);
            UserAnswer.Items.Add(this.call4.Text);
            this.call4.Visible = false;
        }

        private void call5_Click(object sender, EventArgs e)
        {
            answer.Add(this.call5.Text);
            UserAnswer.Items.Add(this.call5.Text);
            this.call5.Visible = false;
        }

        private void call7_Click(object sender, EventArgs e)
        {
            answer.Add(this.call7.Text);
            UserAnswer.Items.Add(this.call7.Text);
            this.call7.Visible = false;
        }

        private void call8_Click(object sender, EventArgs e)
        {
            answer.Add(this.call8.Text);
            UserAnswer.Items.Add(this.call8.Text);
            this.call8.Visible = false;
        }

        private void call9_Click(object sender, EventArgs e)
        {
            answer.Add(this.call9.Text);
            UserAnswer.Items.Add(this.call9.Text);
            this.call9.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.btnPlay.Enabled = false;
            this.Width = 741;
            this.Height = 530;
            groupBox1.Enabled = true;
            groupBox1.Visible = true;
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
 
            t ++;
            label1.Text = t.ToString() + " Seconds";
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Width = 741;
            this.Height = 530;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            SelelectionScreen sp = new SelelectionScreen();
            ReplacingBooks rp = new ReplacingBooks();

            this.Close();
            this.Hide();
            sp.Show();
            
            
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            Instructions ins = new Instructions();
            this.Hide();
            ins.Show();
        }

        private void call10_Click(object sender, EventArgs e)
        {
            answer.Add(this.call10.Text);
            UserAnswer.Items.Add(this.call10.Text);
            this.call10.Visible = false;
        }

      

     
    }
}
