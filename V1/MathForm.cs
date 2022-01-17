using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace V1
{
    public partial class MathForm : Form
    {
        string path;
        public MathForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath;
        }
        public double[] MAI(List<double> a)
        {
            double multiply = 1;
            double[,] matrix = new double[a.Count, (a.Count + 2)];
            for(int i = 0; i < a.Count; i++)
            {
                for(int j = 0; j < a.Count; j++)
                {
                    matrix[i, j] = a[i] / a[j];
                    multiply *= matrix[i, j];
                }
                matrix[i, a.Count] = Math.Pow(multiply, 1d / a.Count);
            }
            double G = 0;
            double[] p = new double[a.Count];
            for(int i =0; i < a.Count; i++)
            {
                G += matrix[i, a.Count];
            }
            for(int i =0;i < a.Count; i++)
            {
                p[i] = matrix[i, a.Count] / G;
            }
            return p;
        }

        private void btn_loadComponets_Click(object sender, EventArgs e)
        {
            double[] weightForIndex;
            if (convert(tb_percents.Text) >= 100d)
            {
                MessageBox.Show("Кількість відсотків не може бути 100 і більше", "Помилка");
            }
            else {
                chart_index.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                componentsChart.Visible = true;
                pca_components.Visible = true;
                pca_components.BringToFront();
                pca_rr.Visible = true;
                btn_data.Visible = true;
                button2.Visible = true;
                pca_components.Series.Clear();
                pca_components.Titles.Clear();
                pca_rr.Series.Clear();
                pca_rr.Titles.Clear();
                //gr.Clear(Color.White);
                //system_koordinat(x1, x2, y1, y2);
                string s = File.ReadAllText(path + "\\pca\\pca_results.txt");
                List<string> ast = s.Split(new char[] { ' ', '[', ']', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                //clear(ast);
                List<string> rr = new List<string>();
                List<List<string>> components = new List<List<string>>();
                int k = 0;
                for (int i = 1; i < ast.Count; i++)
                {
                    if (convert(ast[i]) > 1)
                    {
                        k = i;
                        break;
                    }
                    //listBox1.Items.Add(ast[i]);
                    //listBox1.Items.Add(path);
                }
                for (int i = 0; i < (int)((double)(ast.Count) / (double)k); i++)
                {
                    rr.Add(ast[i * k]);
                    components.Add(new List<string>());
                    for (int j = 1; j < k; j++)
                    {
                        components[i].Add(ast[((i * k) + j)]);
                    }
                }

                //MessageBox.Show(k.ToString());
                //MessageBox.Show(((int)((double)(ast.Count)/(double)k)).ToString());
                /*int k = ast.IndexOf("\r\n");ochkas
                //MessageBox.Show(listBox1.Items[0].ToString());
                List<string> pc1 = new List<string>(k);
                List<string> pc2 = new List<string>(k);
                List<string> pc3 = new List<string>(k); 
                List<string> percents = new List<string>(k);
                string[] names = new string[] { "ГК1", "ГК2", "ГК3"};
                ast = clear(ast);
                pc1 = ast.GetRange(0, k);
                //MessageBox.Show(pc1[1]);
                pc2 = ast.GetRange(k, k);
                pc3 = ast.GetRange(2*k, k);
                percents = ast.GetRange(3*k, k-1);
               // string tmp = percents[0];
                //percents.RemoveAt(0);
                //percents.Add(tmp);*/
                pca_components.Titles.Add("Головні компоненти");
                pca_components.Titles[0].Font = new Font(SystemFonts.MenuFont, FontStyle.Regular);
                //pca_components.Series.Clear();
                //pca_rr.Series.Clear();
                pca_rr.Titles.Add("Правило кам'яної осипі");
                pca_rr.Series.Add("КО");
                pca_rr.Series[0].ChartType = SeriesChartType.FastLine;
                pca_rr.Series[0].BorderWidth = 4;
                double sum = 0;
                int f1 = 0;
                double[,] percents_ = toDouble(rr);
                while (sum <= convert(tb_percents.Text.ToString()))
                {
                    sum += percents_[f1, 0];
                    f1++;
                }
                string[] time = DataForm.getTime();
                List<List<float>> valuesOfComponents = new List<List<float>>();
                List<double> dispersions = new List<double>();
                for (int i1 = 0; i1 < f1; i1++)
                {
                    double[,] pc_ = toDouble(components[i1]);
                    pca_components.Series.Add("Складові компоненти " + (i1 + 1).ToString());
                    pca_components.Series[i1].ChartType = SeriesChartType.Column;
                    pca_components.Series[i1].BorderWidth = 4;
                    pca_components.Series[i1].YValueType = ChartValueType.Double;
                    for (int j1 = 0; j1 < components[i1].Count; j1++) {
                        pca_components.Series[i1].Points.AddXY(pc_[j1, 1], pc_[j1, 0]);
                    }
                    valuesOfComponents.Add(new List<float>());
                    for(int j =1; j < DataForm.arr.Count; j++)
                    {
                        float sumPC = 0;
                        for (int i = 0; i < f1;i++)
                        {
                            sumPC += (float)(pc_[i, 0] * convert(DataForm.ast[j][i]));
                        }
                        valuesOfComponents[i1].Add(sumPC);
                    }
                    dispersions.Add(dispersion(valuesOfComponents[i1]));
                }
                weightForIndex = MAI(dispersions);
                lbl_n_components.Text = "Для аналізу " + tb_percents.Text + "% інформації рекомендовано взяти " + (f1) + " компонент";
                for (int i = 0; i < rr.Count; i++)
                {
                    pca_rr.Series[0].Points.AddXY(percents_[i, 1], percents_[i, 0]);
                }
                componentsChart.Series.Clear();
                for(int i = 0; i < valuesOfComponents.Count; i++)
                {
                    componentsChart.Series.Add("Компонента " + (i + 1));
                    componentsChart.Series[i].BorderWidth = 4;
                    componentsChart.Series[i].ChartType = SeriesChartType.Spline;
                    componentsChart.Series[i].XValueType = ChartValueType.Double;
                    for (int j = 0; j < valuesOfComponents[i].Count; j++)
                    {
                        componentsChart.Series[i].Points.AddXY(convert(time[j]), valuesOfComponents[i][j]);
                    }
                }
                chart_index.Titles.Clear();
                chart_index.Series.Clear();
                chart_index.Titles.Add("Графік індексу");
                chart_index.Series.Add("Індекс");
                chart_index.Series[0].BorderWidth = 4;
                chart_index.Series[0].ChartType = SeriesChartType.Spline;
                StreamWriter sw = new StreamWriter(File.Create(path + "//results//" + StartDataForm.excelSheet + ".txt"));
                for (int j = 0; j < time.Length; j++)
                {
                    float d = 0;
                    for (int i = 0; i < weightForIndex.Length; i++)
                    {
                        d += (float)(valuesOfComponents[i][j] * weightForIndex[i]);
                    }
                    chart_index.Series[0].Points.AddXY(time[j], d);
                    sw.WriteLine(time[j] + "," + d);
                }
                sw.Close();
            }
        }
        
        public double[,] toDouble(List<string> a)
        {
            double[,] d = new double[a.Count, 2];
            for (int i = 0; i < a.Count; i++)
            {
                //a[i] = a[i].Replace(".", ",");
                if (a[i].Contains("\r\n"))
                {
                    a[i] = a[i].Substring(0, a[i].IndexOf("\r\n"));
                }
                else if(a[i].Last() == ',')
                {
                    a[i] = a[i].Substring(0, a[i].Length - 1);
                }
                d[i, 0] = convert(a[i]);
                d[i, 1] = (i + 1);
            }
            return d;
        }
        public static double convert(string s)
        {
            double a;
            try
            {
                a = Convert.ToDouble(s);
            }
            catch(Exception)
            {
                //string s = txtbx.Text;
                int index = s.IndexOf(',');
                if (index == -1)
                {
                    s = s.Replace('.', ',');
                    a = Convert.ToDouble(s);
                }
                else
                {
                    s = s.Replace(',', '.');
                    a = Convert.ToDouble(s);
                }
            }
            return a;
        }
        public double[] DecimalToDouble(decimal[] a)
        {
            double[] d = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                d[i] = Convert.ToDouble(a[i]);
            }
            return d;
        }
        public List<string> clear(List<string> a)
        {
            List<string> ast = a;
            for(int i = 0; i < ast.Count; i++)
            {
                if(ast[i] == "\r\n")
                {
                    ast.RemoveAt(i);
                }
            }
            return ast;
        }

        private void btn_data_Click(object sender, EventArgs e)
        {
            DataForm df = new DataForm();
            df.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartDataForm sdf = new StartDataForm();
            sdf.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseReason.UserClosing == e.CloseReason)
            {
                MenuForm.mf.Show();
                Hide();
            }
        }

        private void tb_percents_TextChanged(object sender, EventArgs e)
        {
            if(tb_percents.Text != "" || tb_percents.Text != "0")
            try
            {
                convert(tb_percents.Text);
                btn_loadComponets.Visible = true;
            }
            catch (Exception) { btn_loadComponets.Visible = false; }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            componentsChart.BringToFront();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pca_components.BringToFront();
        }
        public static double dispersion(List<float> a)
        {
            double dis = 0;
            for(int j = 0; j < a.Count; j++)
            {
                double temp;
                temp = Math.Pow(a[j] - a.Average(), 2);
                dis += temp;
            }
            dis /= Math.Sqrt(Math.Sqrt((a.Count) - 1));
            return Math.Sqrt(dis);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            chart_index.BringToFront();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MenuForm.mf.Show();
            Hide();
        }

        private void MathForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuForm.mf.Show();
        }
    }
}
