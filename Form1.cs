using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlsInCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int top, left, height,width;
            top =  this.Height/10 ;
            left =  this.Width / 10;
            height = this.Height / 12;
            width= this.Width / 10;

            TextBox t = new TextBox();
            t.Name = "txtDisplay";
            t.Left = left;
            t.Top = top;    
            this.Controls.Add(t);

            

            for (int i=1;i<=4;i++)
            {
                Button b = new Button();
                b.Left = left;
                b.Top = (i+1)*top;
                b.Height = height;
                b.Width = width;
                b.Click += new EventHandler(Mojitaba);
                b.Text = i.ToString();
                this.Controls.Add(b);
            }


        }

        private void Mojitaba(object s, EventArgs e)
        {
            //MessageBox.Show("Hello");
            foreach(Control c in this.Controls)
                if(c.Name== "txtDisplay")
                    //c.Text=((Button)s).Text;
                    c.Text += ((Button)s).Text;
        }
    }

}
