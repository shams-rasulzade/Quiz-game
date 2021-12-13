using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sql
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            right.Visible = false;

        }

        SqlConnection sql = new SqlConnection("Data Source=DESKTOP-PE9P8LD;Initial Catalog=quizgame;Integrated Security=True");

        int count = 0, s = 0, time = 10;
        int n = 2; //The number of questions


        public void buttondisable()
        {
            List<Button> bd = new List<Button>()
            {
             b1,
             b2,
             b3,
             b4,
            };

            foreach (var button in bd)
            {
                button.Enabled = false;
            }
        }

        public void buttonenable()
        {
            List<Button> bd = new List<Button>()
            {
             b1,
             b2,
             b3,
             b4,
            };

            foreach (var button in bd)
            {
                button.Enabled = true;
            }
        }

        public void buttonbackcolor()
        {
            List<Button> bd = new List<Button>()
            {
             b1,
             b2,
             b3,
             b4,
            };

            foreach (var button in bd)
            {
                button.BackColor = Color.White;
            }
        }
        public void buttonclear()
        {
            List<Button> bd = new List<Button>()
            {
             b1,
             b2,
             b3,
             b4,
            };

            foreach (var button in bd)
            {
                button.Text = String.Empty;
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            buttondisable();
            if (b1.Text == right.Text)
            {
                s += 1;
                score2.Text = s.ToString();
                b1.BackColor = Color.Green;
            }
            else b1.BackColor = Color.Red;

            start.Enabled = true;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            buttondisable();
            if (b2.Text == right.Text)
            {
                s += 1;
                score2.Text = s.ToString();
                b2.BackColor = Color.Green;
            }
            else b2.BackColor = Color.Red;

            start.Enabled = true;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            buttondisable();
            if (b3.Text == right.Text)
            {
                s += 1;
                score2.Text = s.ToString();
                b3.BackColor = Color.Green;
            }
            else b3.BackColor = Color.Red;

            start.Enabled = true;
        }


        private void b4_Click(object sender, EventArgs e)
        {
            buttondisable();
            if (b4.Text == right.Text)
            {
                s += 1;
                score2.Text = s.ToString();
                b4.BackColor = Color.Green;
            }
            else b4.BackColor = Color.Red;

            start.Enabled = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = time.ToString();
            time -= 1;

            if (time == 0)
            {
                timer1.Enabled = false;
                buttondisable();
                start.Enabled = true;
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            time = 10;
            buttonbackcolor();
            buttonenable();
            start.Enabled = false;
            start.Text = "Next";
            count++;
            int a = count;
            counter.Text = count.ToString();

            if (a <= n)
            {
                sql.Open();
                SqlCommand command = new SqlCommand("Select *From Question" + a + " order by NEWID()", sql);
                SqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {
                    b1.Text = (read["a"].ToString());
                    b2.Text = (read["b"].ToString());
                    b3.Text = (read["c"].ToString());
                    b4.Text = (read["d"].ToString());
                    question.Text = (read["question"].ToString());
                    right.Text = (read["true"].ToString());
                }
                if (a == n)
                {
                    start.Text = "End";
                }
                sql.Close();
            }

            else
            {
                timer1.Enabled = false;
                counter.Visible = false;
                start.Enabled = false;
                buttondisable();
                question.Clear();
                buttonclear();
                MessageBox.Show("The End\nYour score is: " + s);
                System.Windows.Forms.Application.Exit();

            }
            
        }

    }    
}
