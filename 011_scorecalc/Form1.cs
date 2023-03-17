using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _011_scorecalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double sum = double.Parse(txtkor.Text) + double.Parse(txtmath.Text) + double.Parse(txteng.Text);
            // double.parse == convert.todobule(txtkor.text) => string을 숫자로 바꾸는 방법 2가지
            double avg = sum / 3;

            txtsum.Text = sum.ToString(); // .Tostring() => double을 string 형태로 바꿔줌
            txtavg.Text = avg.ToString("0.0"); // 소수점 한자리까지 표시
        }
    }
}
