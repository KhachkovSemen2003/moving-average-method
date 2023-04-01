using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _2022._12._04_kursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MagFile file;
        List<double> sredn = new List<double>();
        MagFile sre;
        MagFile la;
        private void button_open_Click(object sender, EventArgs e)//открыть файл и построить график начальных данных
        {
            try
            {
                if (openFileDialog_file.ShowDialog() == DialogResult.OK)
                {
                    file = new MagFile(openFileDialog_file.FileName);
                }
                chart.Titles[0].Text = "Исходные данные";
                MagFile.Drawgraphics(file.MagList, chart);
                button_run.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show("Ошибка в файле:" + ex.Message); }
        }

        private void button_run_sred_Click(object sender, EventArgs e)//построить локальные аномалии
        {
            try
            {
                int r = Int32.Parse(textBox_r.Text);
                la = MagFile.LocAnomal(file, sre, r);
                MagFile.Drawgraphics(la.MagList, chart);
                chart.Titles[0].Text = "Локальные аномалии";
            }
            catch (Exception ex) { MessageBox.Show("Неверно введен радиус:" + ex.Message); }

        }
        private void button_save_Click(object sender, EventArgs e)//сохранить файл
        {
            try
            {
                int r = Int32.Parse(textBox_r.Text);
                sredn = MagFile.Sred(file.MagList, r);
                sre = MagFile.createsred(sredn, file);
                MagFile.PrintMagFile(sre, r);
            }
            catch (Exception ex) { MessageBox.Show("выходной файл отсутствует:" + ex.Message); }
        }
        private void button_exit_Click(object sender, EventArgs e)//очистить
        {
            button_run.Enabled = false;
            button_run_sred.Enabled = false;
            button_save.Enabled = false;
            chart.Series[0].Points.Clear();
            chart_all.Series[0].Points.Clear();
            chart_all.Series[1].Points.Clear();
            textBox_r.Text = "";
            chart.Titles[0].Text = "";
            chart_all.Titles[0].Text = "";
        }
        private void button_run_Click(object sender, EventArgs e)//региональные аномалии
        {
            try
            {
                int r = Int32.Parse(textBox_r.Text);
                sredn = MagFile.Sred(file.MagList, r);
                sre = MagFile.createsred(sredn, file);
                button_run_sred.Enabled = true;
                button_save.Enabled = true;
                MagFile.Drawgraphics(sre.MagList, chart_all);
                chart_all.Titles[0].Text = "Метод скользящего среднего";
            }
            catch (Exception ex) { MessageBox.Show("Неверно введен радиус:" + ex.Message); }
        }

        private void label_r_Click(object sender, EventArgs e)
        {

        }
    }
}
