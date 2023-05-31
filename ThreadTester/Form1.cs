using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ThreadTester
{
    public partial class Form1 : Form
    {
        // New timer
        clsTimer mobjTimer;


        public Form1()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------
        // After button click timer starts
        //-----------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            // Start timeru
            mobjTimer = new clsTimer(100);


                // Using += because event cannot be equals to sth therefor it
                // will delete eveerything in que and any other thing won't be processed
            mobjTimer.Tick+=clsTimer_Tick;
            mobjTimer.mobjForm = this;
            mobjTimer.Start();
        }


        //-----------------------------------------------------------
        // Tick of timer
        //-----------------------------------------------------------
        void clsTimer_Tick()
        {
            textBox1.Text = "nn";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            mobjTimer.Stop();
        }
    }
}
