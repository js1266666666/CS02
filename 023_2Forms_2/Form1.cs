using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _023_2Forms_2
{
    public partial class Form1 : Form


    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 f;
        private void button1_Click(object sender, EventArgs e)
        {
            if (f == null)
                f = new Form2(this);
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Label1.Text = " + f.textBox1.Text;
        }

        //Common 클래스에서 값을 가져오기
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Common.str + "\n" + Common.value);
        }
    }

    public static class Common//static class(정적 클래스)는 객체를 만들지 않고 클래스의 이름으로 사용=중요중요 / 일반적인 클래스는 객체를 만들어서 씀(EX))Random r = new Random)
        //Common이란 클래스가 있고 클래스 안에 메모리가 있음(ppt 참고)
    {
        //멤버 편수 = field(필드)
        public static string str = "";
        public static int value = 0;
    }
}
