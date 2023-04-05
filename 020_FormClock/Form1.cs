using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _020_FormClock
{
    public partial class Form1 : Form
    {
        //이 클래스의 변수(필드)
        private Graphics g;
        private bool aClockFlag =  true;
        private Point center;
        private double radius;
        private int hourHands;
        private int minHands; 
        private int secHands; 

        const int clientSize = 300; //상수로 클라이언트 크기 지정
        const int clockSize = 200; //시계의 크기
        public Form1()
        {
            InitializeComponent();
            this.Text = "Form Clock";

            panel1.BackColor = Color.WhiteSmoke;
            this.ClientSize = new Size(clientSize, clientSize+menuStrip1.Height);


            //그래픽스 객체를 만든다
            g = panel1.CreateGraphics();

            aclockSetting();
            dclockSetting();
            Timersetting();
            
            
        }

        private void dclockSetting()
        {
            label1.Font = new Font("맑은 고딕", 16, FontStyle.Bold | FontStyle.Italic);
        }

        private void aclockSetting()
        {
            center = new Point(clientSize / 2, clientSize / 2);
            radius = clockSize / 2;
            hourHands = (int)(radius * 0.45);
            minHands = (int)(radius * 0.55);
            secHands = (int)(radius * 0.65);
        }

        private void Timersetting()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;//1초에 한번
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime c = DateTime.Now;

            panel1.Refresh(); // 패널 지우기
            if(aClockFlag == true)
            {
                DrawClockFace();

                //각도계산
                double radHr = (c.Hour % 12 + c.Minute / 60) * 30 * Math.PI / 180; //시간 당 30도
                double radMi = (c.Minute + c.Second / 60) * 6 * Math.PI / 180; //분 당 6도
                double radSe = c.Second * 6 * Math.PI / 180;//초 당 6도


                DrawHands(radHr,radMi,radSe);

                for(int d=0; d<360; d += 30)
                {
                    int x = (int)(center.X + radius * Math.Sin(d * Math.PI / 180));
                    int y = (int)(center.Y - radius * Math.Cos(d * Math.PI / 180));

                    int dotSize = 16;
                    g.FillEllipse(Brushes.AliceBlue, new Rectangle(x - dotSize / 2, y - dotSize / 2,dotSize,dotSize));
                }
            }
            else
            {
                label1.Text = DateTime.Now.ToString();
                label1.Location = new Point(ClientSize.Width / 2 - label1.Width / 2, ClientSize.Height / 2 - label1.Height / 2);
            }
        }

        private void DrawHands(double radHr, double radMi, double radSe)
        {
            DrawLine(0, 0, (int)(hourHands * Math.Sin(radHr)), (int)(-hourHands *Math.Cos(radHr)),Brushes.RoyalBlue,8);
            DrawLine(0, 0, (int)(minHands * Math.Sin(radMi)), (int)(-minHands * Math.Cos(radMi)), Brushes.SkyBlue, 6);
            DrawLine(0,0,(int)(secHands*Math.Sin(radSe)), (int)(-secHands *Math.Cos(radSe)),Brushes.OrangeRed,4);

            int coreSize = 16;
            Rectangle r = new Rectangle(center.X - coreSize / 2, center.Y - coreSize / 2, coreSize, coreSize);
            g.FillEllipse(Brushes.Gold, r);
            g.DrawEllipse(new Pen(Brushes.Green, 3), r);
        }

        private void DrawLine(int x1, int y1, int x2, int y2, Brush brush, int thick)
        {
            Pen p = new Pen(brush, thick);
            p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            g.DrawLine(p, center.X + x1, center.Y + y1, center.X + x2, center.Y + y2);
        }

        private void DrawClockFace()
        {
            Pen p = new Pen(Color.LightSteelBlue, 30);
            g.DrawEllipse(p, center.X - clockSize / 2, center.Y - clockSize / 2, clockSize, clockSize);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void 아날로그ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aClockFlag = true;
            label1.Text = "";
        }

        private void 디지털ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aClockFlag = false;
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}