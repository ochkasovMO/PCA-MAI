using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V1
{
    public partial class DataForm : Form
    {
        public static string path;
        public static string[] s;
        public static string[][] ast;
        public static List<List<string>> arr;

        public DataForm()
        {
            InitializeComponent();
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath;
            ReadCSV_();
        }
        public void ReadCSV_()
        {
            ReadCSV();
            dataGridView1.ColumnCount = ast[0].Length;
            dataGridView1.Columns[0].Visible = false;
            for(int i = 0; i < arr.Count; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < ast[i].Length; j++)
                    {
                        dataGridView1.Columns[j].HeaderText = ast[i][j];
                    }
                }
                else
                {
                    dataGridView1.Rows.Add();
                    for (int j = 0; j < ast[i].Length; j++)
                    {
                        if (ast[i][j].IndexOf(',') != -1)
                            dataGridView1.Rows[i - 1].Cells[j].Value = (ast[i][j].Substring(0, ast[i][j].IndexOf(',')+2));
                        else if (ast[i][j].IndexOf('.') != -1)
                        {
                            dataGridView1.Rows[i - 1].Cells[j].Value = (ast[i][j].Substring(0, ast[i][j].IndexOf('.')+2));
                        }
                        else dataGridView1.Rows[i - 1].Cells[j].Value = ast[i][j];
                    }
                }
            }
        }
        public static void ReadCSV()
        {
            path = Application.StartupPath;
            StreamReader sr = File.OpenText(path + "//pca//data(1).csv");
            s = File.ReadAllLines(path + "//pca//data(1).csv");
            arr = new List<List<string>>();
            int k = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if(sr.ReadLine() != "")
                {
                    arr.Add(new List<string>());
                    arr[k] = s[i].Split(new char[] { ',', '\n', '\r' }).ToList();
                    arr[k] = arr[k].Skip(0).ToList();
                    k++;
                }
            }
            ast = new string[arr.Count][];
            for (int i = 0; i < arr.Count; i++)
            {
                ast[i] = arr[i].ToArray();
            }
        }
        public static string[] getTime()
        {
            ReadCSV();
            string[] ff = new string[ast.Length-1];
            for(int i = 1; i < ast.Length; i++)
            {
                    ff[i-1] = ast[i][0];
            }
            return ff;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
