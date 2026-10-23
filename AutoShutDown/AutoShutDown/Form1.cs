using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace AutoShutDown
{
    public partial class Form1 : Form
    {
        int seconds = 0;

        private string remainingTime(int second)
        {
            int hour = (second / 3600);
            second %= 3600;
            int minute = (second / 60);
            second %= 60;
            string result = "";

            result += hour >= 10 ? hour.ToString() : ("0" + hour.ToString());
            result += ":";
            result += minute >= 10 ? minute.ToString() : ("0" + minute.ToString());
            result += ":";
            result += second >= 10 ? second.ToString() : ("0" + second.ToString());

            return result;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_action.Items.Add("Shut Down");
            comboBox_action.Items.Add("Restart");
            comboBox_action.Items.Add("Log Out");
            comboBox_action.SelectedIndex = 0;

            comboBox_unit.Items.Add("Hour");
            comboBox_unit.Items.Add("Minute");
            comboBox_unit.Items.Add("Second");
            comboBox_unit.SelectedIndex = 2;

        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (button_Start.Text == "START")
            {
                if (textBox_Time.Text == "") return;
                button_Start.Text = "STOP";
                seconds = int.Parse(textBox_Time.Text.ToString());
                if (comboBox_unit.SelectedItem == "Hour")
                {
                    seconds *= 3600;
                }
                else if (comboBox_unit.SelectedItem == "Minute")
                {
                    seconds *= 60;
                }
            }
            else if (button_Start.Text == "STOP")
            {
                button_Start.Text = "CONTINUE";
                timer1.Stop();
                timer2.Stop();
                return;
            }
            else if (button_Start.Text == "CONTINUE")
            {
                button_Start.Text = "STOP";
            }
            label_Timer.Text = remainingTime(seconds);
            timer2.Start();
            timer1.Interval = seconds*1000;
            timer1.Start();

        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            seconds = 0;
            label_Timer.Text = remainingTime(seconds);
            button_Start.Text = "START";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string action = "/l";
            if (comboBox_action.SelectedIndex == 0) action = "/s /t 0";
            else if (comboBox_action.SelectedIndex == 1) action = "/r /t 0";

            if (seconds > 0)
            {
                return;
            }

            Process.Start("shutdown", action);
            timer1.Stop();
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            if (seconds <= 0)
            {
                timer2.Stop();
                return;
            }
            seconds--;
            label_Timer.Text = remainingTime(seconds);

        }

        private void textBox_Time_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
