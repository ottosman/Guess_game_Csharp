using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_guess_last
{
    
    public partial class Form1 : Form
    {
        
        int num_of_game = 0;
        Random randint = new Random();
        int num_of_guesses = 0;
        int num_of_time = 0;
        
       

        public Form1()
        {
            InitializeComponent();
            method_of_very_firt_start();
            method_of_random_num_finder();
            method_of_labels();
       

        }

        private void button_universe_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button_universe.Visible = false;
            button_check_iF.Visible = true;
        }

        private void button_check_if_Click(object sender, EventArgs e)
        {
            
            method_of_game_logic();
            textBox_input.Text = ("");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            num_of_time++;
            label_time_counter.Text = num_of_time.ToString();
            label_time_counter.Text = ("Time: " + num_of_time + " seconds");
            

        }

        public void method_of_random_num_finder()
        {
            num_of_game = randint.Next(1, 100);


        }

        private void method_of_very_firt_start()
        {
            button_check_iF.Visible = false;
        }    
        
         public void method_of_game_logic()
        {
            if  (textBox_input.Text == "" )
            {
                MessageBox.Show("PLAY WITH RULES");
                textBox_input.Text = ("1");
            }
            
            //TRY CATCH
            int x = Convert.ToInt32(textBox_input.Text);         
            label_guess_counter.Text = Convert.ToString(num_of_guesses);

            num_of_guesses++;
            label_guess_counter.Text = ("GUESSES: " + num_of_guesses);
            if (x == num_of_game)
            {
                timer1.Stop();
                MessageBox.Show("WELL DONE, time(seconds)="+num_of_time+"  tries= "+num_of_guesses);
                num_of_time = 0;
                num_of_guesses = 0;
                //System.Windows.Forms.Application.Exit();
                method_of_random_num_finder();
                method_of_game_logic();
                timer1.Start();

            }

            else if (x < num_of_game)
            {
                MessageBox.Show("GO UP");
            }



           
    
            else
            {
                MessageBox.Show("GO DOWN");
            }
        }
        
        public void method_of_labels()
        {
         
            label_guess_counter.Text = ("GUESSES: ");
            label_header.Text = ("GAME OF GUESSING");
            label_time_counter.Text = ("TIME: ");
            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                method_of_game_logic();
                textBox_input.Text = ("");   
            }

       
        }

        private void textBox_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }
        //private void reject_string()
        //{
        //    int.Parse(textBox_input.Text);

        //}


    }
}
