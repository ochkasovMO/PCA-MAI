namespace V1
{
    partial class MathForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_loadComponets = new System.Windows.Forms.Button();
            this.pca_components = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pca_rr = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_data = new System.Windows.Forms.Button();
            this.lbl_n_components = new System.Windows.Forms.Label();
            this.tb_percents = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.componentsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_index = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pca_components)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pca_rr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_index)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1320, 982);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_loadComponets
            // 
            this.btn_loadComponets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_loadComponets.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_loadComponets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_loadComponets.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_loadComponets.Location = new System.Drawing.Point(405, 12);
            this.btn_loadComponets.Name = "btn_loadComponets";
            this.btn_loadComponets.Size = new System.Drawing.Size(226, 72);
            this.btn_loadComponets.TabIndex = 1;
            this.btn_loadComponets.Text = "Отримати графіки компонент";
            this.btn_loadComponets.UseVisualStyleBackColor = true;
            this.btn_loadComponets.Click += new System.EventHandler(this.btn_loadComponets_Click);
            // 
            // pca_components
            // 
            chartArea13.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea13.AxisX.Title = "Номер параметра";
            chartArea13.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea13.AxisY.Title = "Вага параметра";
            chartArea13.Name = "ChartArea1";
            this.pca_components.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.pca_components.Legends.Add(legend13);
            this.pca_components.Location = new System.Drawing.Point(30, 88);
            this.pca_components.Name = "pca_components";
            this.pca_components.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pca_components.Size = new System.Drawing.Size(820, 456);
            this.pca_components.TabIndex = 5;
            this.pca_components.Text = "chart1";
            this.pca_components.Visible = false;
            // 
            // pca_rr
            // 
            chartArea14.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea14.AxisX.Title = "Кількість компонент";
            chartArea14.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea14.AxisY.Title = "Інформативність компоненти, %";
            chartArea14.Name = "ChartArea1";
            this.pca_rr.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend2";
            this.pca_rr.Legends.Add(legend14);
            this.pca_rr.Location = new System.Drawing.Point(862, 88);
            this.pca_rr.Name = "pca_rr";
            this.pca_rr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pca_rr.Size = new System.Drawing.Size(416, 456);
            this.pca_rr.TabIndex = 7;
            this.pca_rr.Text = "chart1";
            this.pca_rr.Visible = false;
            // 
            // btn_data
            // 
            this.btn_data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_data.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_data.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_data.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_data.Location = new System.Drawing.Point(754, 611);
            this.btn_data.Name = "btn_data";
            this.btn_data.Size = new System.Drawing.Size(226, 72);
            this.btn_data.TabIndex = 8;
            this.btn_data.Text = "Передивитися данні";
            this.btn_data.UseVisualStyleBackColor = true;
            this.btn_data.Visible = false;
            this.btn_data.Click += new System.EventHandler(this.btn_data_Click);
            // 
            // lbl_n_components
            // 
            this.lbl_n_components.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_n_components.Location = new System.Drawing.Point(45, 632);
            this.lbl_n_components.Name = "lbl_n_components";
            this.lbl_n_components.Size = new System.Drawing.Size(539, 72);
            this.lbl_n_components.TabIndex = 10;
            // 
            // tb_percents
            // 
            this.tb_percents.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_percents.Location = new System.Drawing.Point(276, 22);
            this.tb_percents.Name = "tb_percents";
            this.tb_percents.Size = new System.Drawing.Size(100, 39);
            this.tb_percents.TabIndex = 11;
            this.tb_percents.Text = "80";
            this.tb_percents.TextChanged += new System.EventHandler(this.tb_percents_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 58);
            this.label1.TabIndex = 12;
            this.label1.Text = "Введіть необхідний відсоток інформації";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(51, 550);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(167, 58);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Координати компонент";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(305, 550);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(156, 58);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.Text = "Графіки компонент";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(583, 563);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(181, 31);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.Text = "Графік індексу";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // componentsChart
            // 
            chartArea15.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea15.AxisX.Title = "Час";
            chartArea15.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea15.AxisY.Title = "Значення компоненти";
            chartArea15.Name = "ChartArea1";
            this.componentsChart.ChartAreas.Add(chartArea15);
            legend15.Name = "Legend1";
            this.componentsChart.Legends.Add(legend15);
            this.componentsChart.Location = new System.Drawing.Point(25, 88);
            this.componentsChart.Name = "componentsChart";
            this.componentsChart.Size = new System.Drawing.Size(825, 456);
            this.componentsChart.TabIndex = 16;
            this.componentsChart.Text = "Графіки компонент";
            this.componentsChart.Visible = false;
            // 
            // chart_index
            // 
            chartArea16.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea16.AxisX.Title = "Час, с";
            chartArea16.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea16.AxisY.Title = "Значення індексу";
            chartArea16.Name = "ChartArea1";
            this.chart_index.ChartAreas.Add(chartArea16);
            legend16.Name = "Legend1";
            this.chart_index.Legends.Add(legend16);
            this.chart_index.Location = new System.Drawing.Point(25, 88);
            this.chart_index.Name = "chart_index";
            this.chart_index.Size = new System.Drawing.Size(822, 456);
            this.chart_index.TabIndex = 17;
            this.chart_index.Text = "chart1";
            this.chart_index.Visible = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1019, 611);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 72);
            this.button2.TabIndex = 18;
            this.button2.Text = "Завершити аналіз";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // MathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1284, 721);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.tb_percents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_n_components);
            this.Controls.Add(this.btn_data);
            this.Controls.Add(this.pca_rr);
            this.Controls.Add(this.btn_loadComponets);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pca_components);
            this.Controls.Add(this.componentsChart);
            this.Controls.Add(this.chart_index);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeBox = false;
            this.Name = "MathForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аналіз даних";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MathForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pca_components)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pca_rr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_index)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_loadComponets;
        public System.Windows.Forms.DataVisualization.Charting.Chart pca_components;
        public System.Windows.Forms.DataVisualization.Charting.Chart pca_rr;
        private System.Windows.Forms.Button btn_data;
        private System.Windows.Forms.Label lbl_n_components;
        private System.Windows.Forms.TextBox tb_percents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.DataVisualization.Charting.Chart componentsChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_index;
        private System.Windows.Forms.Button button2;
    }
}

