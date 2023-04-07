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

        private async void btninsert_Click(object sender, EventArgs e)
        {
            var data = new Data //==Data data = new data
            {
                Id = txtid.Text,
                SId = txtsid.Text,
                Name = txtname.Text,
                Phone = txtphone.Text
            };

            SetResponse response = await client.SetAsync("VP02_Phonebook/" + txtid.Text, data);// 추가
            Data result = response.ResultAs<Data>();
            MessageBox.Show("Data Inserted : " + result.Id);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtname.Text = "";
            txtphone.Text = "";
            txtsid.Text = "";
        }

        private async void btnsearch_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetAsync("VP02_Phonebook/" + txtid.Text);// 값 가져오기
            Data obj = response.ResultAs<Data>();

            txtid.Text = obj.Id;
            txtsid.Text = obj.SId;
            txtname.Text = obj.Name;
            txtphone.Text = obj.Phone;

            MessageBox.Show("Data retrieved successfully");
        }

        private async void btnupdate_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                Id = txtid.Text,
                SId = txtsid.Text,
                Name = txtname.Text,
                Phone = txtphone.Text
            };

            FirebaseResponse response = await client.UpdateAsync("VP02_Phonebook/" + txtid.Text, data);
            Data result = response.ResultAs<Data>();
            MessageBox.Show("Data updated at "+result.Id);
        }

        private async void btndelete_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.DeleteAsync("VP02_Phonebook/" + txtid.Text);
            MessageBox.Show("Deleted! : id = " + txtid.Text);
            txtid.Text = "";
            txtsid.Text = "";
            txtname.Text = "";
            txtphone.Text = "";        }

        private async void btndeleteall_Click(object sender, EventArgs e)
        {
            //메시지박스에서 확인 필요(모두삭제)
            DialogResult result = MessageBox.Show("저장된 데이터가 모두 삭제됩니다. 계속 할까요?", "Warring!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;

            FirebaseResponse response = await client.DeleteAsync("VP02_Phonebook");//VP02_Phonebook 전체 삭제

            MessageBox.Show("All data Deleted! /VP02_Phonebook");
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnviewall_Click(object sender, EventArgs e)
        {

        }
    }
}
