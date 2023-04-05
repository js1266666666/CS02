using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;

namespace _021_Firebase
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "u8NJbVCBHRgvOnUJxWCQoUrOOI4MsfHwTRSmvp7e", // 설정 - 프로젝트 설정 - 서비스 계정 - 비밀번호
            BasePath = "https://fir-js-b77f6-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
                MessageBox.Show("Connection 성공");
        }
    }
}
