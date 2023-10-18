using System;
using System.Windows.Forms;

namespace WinFormsApp5

{
    public partial class Form1 : Form
    {
        private System.Timers.Timer timer;
        public Form1()
        {
            InitializeComponent();
        }


        


        private void Form1_Load(object sender, EventArgs e)
        {

           
                    timer = new System.Timers.Timer();
            timer.Interval = 1000; 
            timer.Elapsed += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime utcNow = DateTime.UtcNow;

            
            TimeZoneInfo europeTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");


      TimeZoneInfo asiaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Asia/Tokyo");

                             TimeZoneInfo usaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

            DateTime europeTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, europeTimeZone);


      DateTime asiaTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, asiaTimeZone);


            DateTime usaTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, usaTimeZone);

            
       textBox1.Invoke((Action)(() => textBox1.Text = europeTime.ToString("HH:mm:ss")));



    textBox2.Invoke((Action)(() => textBox2.Text = asiaTime.ToString("HH:mm:ss")));


            textBox3.Invoke((Action)(() => textBox3.Text = usaTime.ToString("HH:mm:ss")));
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text =textBox3.Text = "Remove Mouse!";
            textBox1.BackColor = Color.LightSkyBlue;
            textBox2.BackColor = Color.LightSkyBlue;
            textBox3.BackColor = Color.LightSkyBlue;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}