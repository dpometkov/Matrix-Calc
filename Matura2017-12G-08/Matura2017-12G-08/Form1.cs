using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Vuprosi> questions = new List<Vuprosi>();
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader r = new StreamReader("vuprosi.txt");
            for (int i = 0; ; i++)
            {
                Vuprosi v = new Vuprosi();
                v.num = r.ReadLine();
                v.vupros = r.ReadLine();
                v.otg1 = r.ReadLine();
                v.otg2 = r.ReadLine();
                v.otg3 = r.ReadLine();
                v.otg4 = r.ReadLine();
                v.ver = r.ReadLine();
                questions.Add(v);
                if (r.EndOfStream) break;
            }
            r.Close();
        }
        public List<int> RAND()
        {//razlichni
            List<int> a = new List<int>();
            Random x = new Random();
            for (int i = 0; ; i++)
            {
                int v = x.Next(1,40);
                if (!a.Contains(v)) a.Add(v);
                if (a.Count() == 10) break;
            }
            return a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true; radioButton1.Visible = true; radioButton2.Visible = true; radioButton3.Visible = true; radioButton4.Visible = true;
            groupBox1.Visible=true;
            label2.Visible = true; radioButton8.Visible = true; radioButton7.Visible = true; radioButton5.Visible = true; radioButton6.Visible = true;
            groupBox2.Visible = true;
            label3.Visible = true; radioButton12.Visible = true; radioButton11.Visible = true; radioButton9.Visible = true; radioButton10.Visible = true;
            groupBox3.Visible = true;
            label4.Visible = true; radioButton16.Visible = true; radioButton15.Visible = true; radioButton13.Visible = true; radioButton14.Visible = true;
            groupBox4.Visible = true;
            label5.Visible = true; radioButton20.Visible = true; radioButton19.Visible = true; radioButton17.Visible = true; radioButton18.Visible = true;
            groupBox5.Visible = true;
            label6.Visible = true; radioButton24.Visible = true; radioButton23.Visible = true; radioButton21.Visible = true; radioButton22.Visible = true;
            groupBox6.Visible = true;
            label7.Visible = true; radioButton28.Visible = true; radioButton27.Visible = true; radioButton25.Visible = true; radioButton26.Visible = true;
            groupBox7.Visible = true;
            label8.Visible = true; radioButton32.Visible = true; radioButton31.Visible = true; radioButton29.Visible = true; radioButton30.Visible = true;
            groupBox8.Visible = true;
            label9.Visible = true; radioButton36.Visible = true; radioButton35.Visible = true; radioButton33.Visible = true; radioButton34.Visible = true;
            groupBox9.Visible = true;
            label10.Visible = true; radioButton40.Visible = true; radioButton39.Visible = true; radioButton37.Visible = true; radioButton38.Visible = true;
            groupBox10.Visible = true;
            button2.Visible = true;

            List<int> a = RAND();
            label1.Text = "1. " + questions[a[0] - 1].vupros;
            radioButton1.Text = questions[a[0] - 1].otg1;
            radioButton2.Text = questions[a[0] - 1].otg2;
            radioButton3.Text = questions[a[0] - 1].otg3;
            radioButton4.Text = questions[a[0] - 1].otg4;

            label2.Text = "2. " + questions[a[1] - 1].vupros;
            radioButton8.Text = questions[a[1] - 1].otg1;
            radioButton7.Text = questions[a[1] - 1].otg2;
            radioButton5.Text = questions[a[1] - 1].otg3;
            radioButton6.Text = questions[a[1] - 1].otg4;

            label3.Text = "3. " + questions[a[2] - 1].vupros;
            radioButton12.Text = questions[a[2] - 1].otg1;
            radioButton11.Text = questions[a[2] - 1].otg2;
            radioButton9.Text = questions[a[2] - 1].otg3;
            radioButton10.Text = questions[a[2] - 1].otg4;

            label4.Text = "4. " + questions[a[3] - 1].vupros;
            radioButton16.Text = questions[a[3] - 1].otg1;
            radioButton15.Text = questions[a[3] - 1].otg2;
            radioButton13.Text = questions[a[3] - 1].otg3;
            radioButton14.Text = questions[a[3] - 1].otg4;

            label5.Text = "5. " + questions[a[4] - 1].vupros;
            radioButton20.Text = questions[a[4] - 1].otg1;
            radioButton19.Text = questions[a[4] - 1].otg2;
            radioButton17.Text = questions[a[4] - 1].otg3;
            radioButton18.Text = questions[a[4] - 1].otg4;

            label6.Text = "6. " + questions[a[5] - 1].vupros;
            radioButton24.Text = questions[a[5] - 1].otg1;
            radioButton23.Text = questions[a[5] - 1].otg2;
            radioButton21.Text = questions[a[5] - 1].otg3;
            radioButton22.Text = questions[a[5] - 1].otg4;

            label7.Text = "7. " + questions[a[6] - 1].vupros;
            radioButton28.Text = questions[a[6] - 1].otg1;
            radioButton27.Text = questions[a[6] - 1].otg2;
            radioButton25.Text = questions[a[6] - 1].otg3;
            radioButton26.Text = questions[a[6] - 1].otg4;

            label8.Text = "8. " + questions[a[7] - 1].vupros;
            radioButton32.Text = questions[a[7] - 1].otg1;
            radioButton31.Text = questions[a[7] - 1].otg2;
            radioButton29.Text = questions[a[7] - 1].otg3;
            radioButton30.Text = questions[a[7] - 1].otg4;

            label9.Text = "9. " + questions[a[8] - 1].vupros;
            radioButton36.Text = questions[a[8] - 1].otg1;
            radioButton35.Text = questions[a[8] - 1].otg2;
            radioButton33.Text = questions[a[8] - 1].otg3;
            radioButton34.Text = questions[a[8] - 1].otg4;

            label10.Text = "10. " + questions[a[9] - 1].vupros;
            radioButton40.Text = questions[a[9] - 1].otg1;
            radioButton39.Text = questions[a[9] - 1].otg2;
            radioButton37.Text = questions[a[9] - 1].otg3;
            radioButton38.Text = questions[a[9] - 1].otg4;

        }// 3 8 9 8 24 40 8 24 20

        private void button2_Click(object sender, EventArgs e)
        {
            int br = 0;
        }
    }
}
