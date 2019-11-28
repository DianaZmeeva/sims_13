using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sims_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        public int n, a, b, x=0, y=0, date=0;
        public double t = 0, ta=0, min, now=0.0, l;
        public List<double> ts = new List<double>();
        bool f = false;


        private void button_start_Click(object sender, EventArgs e)
        {
            button_start.Enabled = false;
            n = (int)numericUpDown_n.Value;
            a= (int)numericUpDown_a.Value;
            b = (int)numericUpDown_b.Value;
            l = (double)numericUpDown_l.Value;
            for (int i=0;i<n; i++)
            {
                ts.Add(Double.MaxValue);
            }
            f = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date++;
            now = (double)date / 10;
            label_time.Text="Time: "+now;
            if (f)
            {
                ta =Math.Round((now + PPPD(a, b, now)), 1);
                f = false;
                label_ta.Text = "Время прихода следующего клиента: " + ta;
            }
            
            ts.Sort();
            if (ta < ts[0])
                t = ta;
            else
                t = ts[0];
            if (now > ta)
            {
                if (x < n)
                {
                    ts[ts.Count - 1] = Math.Round((now + exp(l)), 1);
                    x++;
                }
                else
                    y++;
                f = true;
            }
            else if (now>ts[0])
            {
                if (y == 0)
                {
                    x--;
                    ts[0] = Double.MaxValue;
                }
                else
                {
                    y--;
                    ts[0] = Math.Round((now + exp(l)), 1);
                }
            }
            label_y.Text = "Количество клиентов в очереди: " + y;
            label_x.Text = "Количество занятых операторов: " + x;
        }

       
        private double exp(double l)
        {
            return -(Math.Log(rnd.NextDouble()) / l);
        }

        private double PPPD(int a, int b, double t)
        {
            double t_next = t;
            double l = a + b;
            double u;

            do
            {
                t_next += exp(l);
                u = rnd.NextDouble() * l;
            }
            while (Math.Abs(a * Math.Sin(t_next) + b) < u);

            return t_next- t;
        }

    }
}
