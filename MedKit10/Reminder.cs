using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedKit10
{
    
    public partial class Reminder : Form
    {
        public string currenttime;
       public string messagetime;
        public Reminder()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            currenttime = DateTime.Now.ToString("hh:mm:ss tt");
            label3.Text = currenttime;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            messagetime = maskedTextBox1.Text + " " + comboBox1.Text;
            label5.Text = "Przypomnienie ustawione na : " + messagetime;

            if (currenttime == messagetime)
            {
                timer2.Stop();
                MessageBox.Show("Pamiętaj o zażyciu" + " " + textBox2.Text + " " + textBox1.Text + " " + maskedTextBox1.Text + " " + comboBox1.Text + " " + textBox4.Text);
                button1.Enabled = true;
                button2.Enabled = false;
                label5.Text = "";
                  
            }
              
        }

       // private void MessageBox(string text)
       // {
         //   throw new NotImplementedException();
      //  }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            button1.Enabled = true;
            button2.Enabled = false;
            label4.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            this.Hide();
            notifyIcon1.ShowBalloonTip(3000);
        }
    }
}
