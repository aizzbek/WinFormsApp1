namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
        int qosiw = 0;
        int kobeytiw = 0;
        int aliw = 0;
        int boliw = 0;
      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Text = "restart";
            Random random = new Random();
            int ran=random.Next(1,4);
            Random r=new Random();
            int a = r.Next(1, 101);
            int b = r.Next(1,101);
            button1.Text = (qosiw + 10).ToString();
            button2.Text=(qosiw-10).ToString();
            button3.Text=(qosiw-1).ToString();
            button4.Text=(qosiw+1).ToString();
            Random rnd = new Random();
            int x4 = rnd.Next(1, 5);
            if(x4==1)
            {
                qosiw = a + b;
                label1.Text = a.ToString();
                label3.Text = b.ToString();
                label2.Text = "+";
                button1.Text = (qosiw + 10).ToString();
                button2.Text = (qosiw - 10).ToString();
                button3.Text = (qosiw - 1).ToString();
                button4.Text = (qosiw + 1).ToString();
                if (ran==1)
                {
                    button1.Text=qosiw.ToString();
                }
                else if (ran==2)
                {
                    button2.Text = qosiw.ToString();
                }
                else if (ran == 3)
                {
                    button3.Text = qosiw.ToString();
                }
                else if (ran == 4)
                {
                    button4.Text = qosiw.ToString();
                }
            }
            else if(x4==2)
            {
                label1.Text = a.ToString();
                label3.Text = b.ToString();
                button1.Text = (aliw + 10).ToString();
                button2.Text = (aliw - 10).ToString();
                button3.Text = (aliw - 1).ToString();
                button4.Text = (aliw + 1).ToString();
                label2.Text = "-";
                if (ran == 1)
                {
                    button1.Text = aliw.ToString();
                }
                else if (ran == 2)
                {
                    button2.Text = aliw.ToString();
                }
                else if (ran == 3)
                {
                    button3.Text = aliw.ToString();
                }
                else if (ran == 4)
                {
                    button4.Text = aliw.ToString();
                }
            }
            else if(x4==3)
            {
                label1.Text = a.ToString();
                label3.Text = b.ToString();
                label2.Text = "/";
                int san = a;
                string qatar = "";
                for(int i=1;i<=san;i++)
                {
                    if(san%i==0)
                    {
                        qatar+=i.ToString()+" ";
                    }
                }
                string[] t = qatar.Split();
                Random u = new Random();
                int q=u.Next(t.Length);
          
                button1.Text = (boliw + 10).ToString();
                button2.Text = (boliw - 10).ToString();
                button3.Text = (boliw - 1).ToString();
                button4.Text = (boliw + 1).ToString();
                if (ran == 1)
                {
                    button1.Text = boliw.ToString();
                }
                else if (ran == 2)
                {
                    button2.Text = boliw.ToString();
                }
                else if (ran == 3)
                {
                    button3.Text = boliw.ToString();
                }
                else if (ran == 4)
                {
                    button4.Text = boliw.ToString();
                }
            }
            else if(x4==4)
            {
                a = a % 10;
                b = b%10;
                kobeytiw = a * b;
                button1.Text = (kobeytiw + 10).ToString();
                button2.Text = (kobeytiw - 10).ToString();
                button3.Text = (kobeytiw - 1).ToString();
                button4.Text = (kobeytiw + 1).ToString();
                label1.Text = a.ToString();
                label3.Text = b.ToString();
                label2.Text = "*";
               ;
                if (ran == 1)
                {
                    button1.Text = kobeytiw.ToString();
                }
                else if (ran == 2)
                {
                    button2.Text = kobeytiw.ToString();
                }
                else if (ran == 3)
                {
                    button3.Text = kobeytiw.ToString();
                }
                else if (ran == 4)
                {
                    button4.Text = kobeytiw.ToString();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}