using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELLOSQL
{
    public partial class Form1 : Form
    {
        public static string oracle_id { get; set; }
        public static string oracle_pw { get; set; }
        ArrayList list = new ArrayList();

        SQLConnect SQLConnect = new SQLConnect();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new Settings(this).ShowDialog();
            /*
             *  현재 생성된 테이블 이름을 가져옵니다. (owner를 확인)
             */
            try
            {
                if (SQLConnect.GetConnection() == true)
                {
                    OracleCommand comm = new OracleCommand();
                    comm.Connection = SQLConnect.Connection;
                    comm.CommandText = @"SELECT table_name FROM all_all_tables where OWNER='" + oracle_id.ToUpper() + "'";
                    comm.ExecuteReader();

                    using (var reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBox1.Items.Add(reader["TABLE_NAME"].ToString());
                            list.Add(reader["TABLE_NAME"].ToString());
                        }
                    }
                    comm.Cancel();
                    comm.Dispose();
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }

            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("데이터베이스 연결 실패 or 테이블 없음");
                this.Close();
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            // 인덱스를 저장할 변수
            int selectedIndex = -1;

            // 마우스 포인터의 위치
            Point point = e.Location;

            // 리스트 박스의 IndexFromPoint 메서드 호출
            selectedIndex = listBox1.IndexFromPoint(point);

            if (selectedIndex != -1) // 빈 공간이 아닌 곳을 더블클릭 했을 때.
            {
                // 선택된 항목 저장
                string selectedItem = listBox1.Items[selectedIndex] as string;
                // 선택한 항목으로 텍스트 대입
                listBox1.Text = selectedItem;

                /*
                 *  테이블의 속성들을 가져옵니다.
                 */

                if (SQLConnect.GetConnection() == true)
                {
                    OracleCommand comm = new OracleCommand();
                    comm.Connection = SQLConnect.Connection;
                    comm.CommandText = @"SELECT COLUMN_NAME, DATA_TYPE FROM COLS WHERE TABLE_NAME = '" + selectedItem + "'";
                    OracleDataAdapter da = new OracleDataAdapter(comm);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "TAB");
                    dataGridView1.DataSource = ds.Tables["TAB"];
                    comm.Cancel();
                    comm.Dispose();

                    foreach (DataGridViewRow Row in dataGridView1.Rows)
                    {
                        Row.Cells["result_use"].Value = true;
                    }
                }

                BusyIndicator(false);
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            result.Text = "";
            int Count = 0;
            int RowCount = 0;
            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                if (Row.Cells["result_use"].Value.ToString().Equals("True"))
                {
                    Count++;
                }
            }
            Console.WriteLine(Count + "만큼 체크를 했음니다");
            if (Count == 0) MessageBox.Show("아무것도 선택 안했는데여;;?");

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Select":
                    result.Text += "SELECT ";
                    foreach (DataGridViewRow Row in dataGridView1.Rows)
                    {
                        if (Row.Cells["result_use"].Value.ToString().Equals("True"))
                        {
                            RowCount++;

                            if (Count == RowCount)
                            {
                                result.Text += Row.Cells["COLUMN_NAME"].Value + " ";
                            }
                            else
                            {
                                result.Text += Row.Cells["COLUMN_NAME"].Value + ", ";
                            }
                        }
                    }
                    result.Text += "FROM " + listBox1.Text + ";";
                    break;

                case "Insert":
                    result.Text += "INSERT INTO " + listBox1.Text + "(";
                    foreach (DataGridViewRow Row in dataGridView1.Rows)
                    {
                        if (Row.Cells["result_use"].Value.ToString().Equals("True"))
                        {
                            RowCount++;

                            if (Count == RowCount)
                            {
                                result.Text += Row.Cells["COLUMN_NAME"].Value + ") VALUES (";
                                break;
                            }
                            else
                            {
                                result.Text += Row.Cells["COLUMN_NAME"].Value + ", ";
                            }
                        }
                    }
                    RowCount = 0;
                    foreach (DataGridViewRow Row in dataGridView1.Rows)
                    {
                        if (Row.Cells["result_use"].Value.ToString().Equals("True"))
                        {
                            RowCount++;

                            if (Count == RowCount)
                            {
                                result.Text += ":" + Row.Cells["COLUMN_NAME"].Value + ")";
                                break;
                            }
                            else
                            {
                                result.Text += ":" + Row.Cells["COLUMN_NAME"].Value + ", ";
                            }
                        }
                    }
                    result.Text += ";";
                    break;

                case "Update":
                    result.Text += "UPDATE " + listBox1.Text + " set ";
                    foreach (DataGridViewRow Row in dataGridView1.Rows)
                    {
                        if (Row.Cells["result_use"].Value.ToString().Equals("True"))
                        {
                            RowCount++;

                            if (Count == RowCount)
                            {
                                result.Text += Row.Cells["COLUMN_NAME"].Value + " = :" + Row.Cells["COLUMN_NAME"].Value + " ";
                                break;
                            }
                            else
                            {
                                result.Text += Row.Cells["COLUMN_NAME"].Value + " = :" + Row.Cells["COLUMN_NAME"].Value + " ,";
                            }
                        }
                    }
                    result.Text += "where " + dataGridView1.Rows[0].Cells["COLUMN_NAME"].Value + "=:" + dataGridView1.Rows[0].Cells["COLUMN_NAME"].Value + ";";
                    break;
                case "Delete":
                    result.Text += "DELETE from " + listBox1.Text;
                    result.Text += " where " + dataGridView1.Rows[0].Cells["COLUMN_NAME"].Value + "=:" + dataGridView1.Rows[0].Cells["COLUMN_NAME"].Value + ";";
                    break;
            }
        }

        #region  작업진행 중(Mouse Cursor = "WAIT")
        //************************************************************
        //**  작업진행 중(Mouse Cursor = "WAIT")
        //************************************************************
        static public void BusyIndicator(bool onoff)
        {
            if (onoff)
            {
                Cursor.Current = Cursors.WaitCursor;
            }
            else
            {
                Cursor.Current = Cursors.AppStarting;
            }
        }
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach(string a in list)
            {
                if (a.Contains(textBox1.Text.ToUpper()))
                {
                    listBox1.Items.Add(a);
                }
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}