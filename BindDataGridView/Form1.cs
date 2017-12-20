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

namespace BindDataGridView
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\BindDataGridView\BindDataGridView\Database1.mdf;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 콤보박스 추가
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            // 체크박스 추가
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            // 버튼 추가
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();

            comboBoxColumn.HeaderText = "TestCombo";
            comboBoxColumn.Name = "combo";
            comboBoxColumn.Items.AddRange("Test1", "Test2", "Test3", "Test4", "Test5");

            checkBoxColumn.HeaderText = "Check";
            checkBoxColumn.Name = "check";

            buttonColumn.HeaderText = "Button";
            buttonColumn.Name = "button";

            dataGridView1.Columns.Add("column0", "Number");
            dataGridView1.Columns.Add("column1", "FileName");
            dataGridView1.Columns.Add("column2", "FileSize");
            dataGridView1.Columns.Add("column3", "FileExtension");
            dataGridView1.Columns.Add("column4", "LastWriteTime");
            dataGridView1.Columns.Add(comboBoxColumn);
            dataGridView1.Columns.Add(checkBoxColumn);
            dataGridView1.Columns.Add(buttonColumn);

            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[6].Width = 50;
            dataGridView1.Columns[7].Width = 50;

            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
