namespace _2022._12._04_kursach
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.openFileDialog_file = new System.Windows.Forms.OpenFileDialog();
            this.button_open = new System.Windows.Forms.Button();
            this.button_run_sred = new System.Windows.Forms.Button();
            this.textBox_r = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_all = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_save = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_r = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_run = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_all)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog_file
            // 
            this.openFileDialog_file.FileName = "openFileDialog1";
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(12, 12);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(96, 72);
            this.button_open.TabIndex = 0;
            this.button_open.Text = "открыть файл";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_run_sred
            // 
            this.button_run_sred.Enabled = false;
            this.button_run_sred.Location = new System.Drawing.Point(114, 102);
            this.button_run_sred.Name = "button_run_sred";
            this.button_run_sred.Size = new System.Drawing.Size(103, 78);
            this.button_run_sred.TabIndex = 5;
            this.button_run_sred.Text = "построить график локальной аномалии";
            this.button_run_sred.UseVisualStyleBackColor = true;
            this.button_run_sred.Click += new System.EventHandler(this.button_run_sred_Click);
            // 
            // textBox_r
            // 
            this.textBox_r.Location = new System.Drawing.Point(12, 136);
            this.textBox_r.Name = "textBox_r";
            this.textBox_r.Size = new System.Drawing.Size(96, 22);
            this.textBox_r.TabIndex = 6;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(0, 0);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // chart_all
            // 
            this.chart_all.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart_all.ChartAreas.Add(chartArea2);
            this.chart_all.Location = new System.Drawing.Point(223, 271);
            this.chart_all.Name = "chart_all";
            this.chart_all.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.LabelForeColor = System.Drawing.Color.Red;
            series2.LegendText = "Без обработки";
            series2.Name = "Series0";
            series3.ChartArea = "ChartArea1";
            series3.LegendText = "Метод скользящего среднего";
            series3.Name = "Series1";
            this.chart_all.Series.Add(series2);
            this.chart_all.Series.Add(series3);
            this.chart_all.Size = new System.Drawing.Size(1207, 306);
            this.chart_all.TabIndex = 8;
            this.chart_all.Text = "chart2";
            title1.Name = "Title1";
            this.chart_all.Titles.Add(title1);
            // 
            // button_save
            // 
            this.button_save.Enabled = false;
            this.button_save.Location = new System.Drawing.Point(12, 164);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(96, 78);
            this.button_save.TabIndex = 10;
            this.button_save.Text = "сохранить файл";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // chart
            // 
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            this.chart.Location = new System.Drawing.Point(223, 4);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Входные данные";
            this.chart.Series.Add(series4);
            this.chart.Size = new System.Drawing.Size(1207, 261);
            this.chart.TabIndex = 13;
            this.chart.Text = "chart2";
            title2.Name = "Title1";
            this.chart.Titles.Add(title2);
            // 
            // label_r
            // 
            this.label_r.AutoSize = true;
            this.label_r.Location = new System.Drawing.Point(21, 102);
            this.label_r.Name = "label_r";
            this.label_r.Size = new System.Drawing.Size(79, 16);
            this.label_r.TabIndex = 14;
            this.label_r.Text = " Введите R";
            this.label_r.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_r.Click += new System.EventHandler(this.label_r_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(12, 248);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(96, 56);
            this.button_exit.TabIndex = 15;
            this.button_exit.Text = "Очистить";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_run
            // 
            this.button_run.Enabled = false;
            this.button_run.Location = new System.Drawing.Point(114, 12);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(103, 72);
            this.button_run.TabIndex = 16;
            this.button_run.Text = "run";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 578);
            this.Controls.Add(this.button_run);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label_r);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.chart_all);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBox_r);
            this.Controls.Add(this.button_run_sred);
            this.Controls.Add(this.button_open);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_all)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_file;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_run_sred;
        private System.Windows.Forms.TextBox textBox_r;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_all;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label_r;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_run;
    }
}

