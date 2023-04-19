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
using System.Security.Cryptography;

namespace _021_Firebase
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();

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
        
            //DataGridView에서 사용하는 필드
            dt.Columns.Add("Id");
            dt.Columns.Add("학번");
            dt.Columns.Add("이름");
            dt.Columns.Add("전화번호");

            dataGridView1.DataSource = dt;

        }

        private async void btninsert_Click(object sender, EventArgs e)
        {
            //firebase에서 cnt값 가져오기
            FirebaseResponse resp = await client.GetAsync("VP02_Counter/nPhones"); //cnt가져온 값 resp에 넣고
            Counter c = resp.ResultAs<Counter>();//Counter타입으로 있음 , c에 counter타입으로 넣음


            var data = new Data
            {
                Id = (c.cnt + 1).ToString(), //string으로 바꿈
                SId = txtsid.Text,
                Name = txtname.Text,
                Phone = txtphone.Text
            };

            SetResponse response = await client.SetAsync("VP02_Phonebook/" + data.Id, data);// 추가
            Data result = response.ResultAs<Data>();
            MessageBox.Show("Data Inserted : " + result.Id);

            //Firebase에 있는 cnt 증가
            var obj = new Counter
            {
                cnt = c.cnt + 1
            };
            SetResponse resp1 = await client.SetAsync("VP02_Counter/nPhones",obj);
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
            export();
        }

        private async void btndelete_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.DeleteAsync("VP02_Phonebook/" + txtid.Text);
            MessageBox.Show("Deleted! : id = " + txtid.Text);
            txtid.Text = "";
            txtsid.Text = "";
            txtname.Text = "";
            txtphone.Text = "";
            export();
        }

        private async void btndeleteall_Click(object sender, EventArgs e)
        {
            //메시지박스에서 확인 필요(모두삭제)
            DialogResult result = MessageBox.Show("저장된 데이터가 모두 삭제됩니다. 계속 할까요?", "Warring!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;

            FirebaseResponse response = await client.DeleteAsync("VP02_Phonebook");//VP02_Phonebook 전체 삭제

            MessageBox.Show("All data Deleted! /VP02_Phonebook");
            export();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnviewall_Click(object sender, EventArgs e)
        {
            
            export();
        }

        //firebase에서 데이터를 읽고 DataGridView에 표시
        private async void export()
        {
            dt.Rows.Clear();
            int i = 0;
            FirebaseResponse response = await client.GetAsync("VP02_Counter/nPhones");
            Counter obj = response.ResultAs<Counter>();

            int cnt = obj.cnt;

            while (i != cnt)
            {
                i++;
                FirebaseResponse r = await client.GetAsync("VP02_Phonebook/" + i);
                Data d = r.ResultAs<Data>();


                if (d != null)
                {
                 DataRow row = dt.NewRow();
                 row["Id"] = d.Id;
                 row["학번"] = d.SId;
                 row["이름"] = d.Name;
                 row["전화번호"] = d.Phone;
             
                 dt.Rows.Add(row);
                }
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender; //sender를 사용할려면 이렇게 처리해야함
            txtid.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString(); //e는 DataGridViewCellEventArgs를 뜻함
            txtname.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtphone.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtsid.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();

        }
    }
}