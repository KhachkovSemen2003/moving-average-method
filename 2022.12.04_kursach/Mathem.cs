using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _2022._12._04_kursach
{
    class Mathem
    {
    }
    class MagRecord
    {
        private int piket;//координаты
        public int Piket { get { return piket; } set { piket = value; } }
        double _data;//отсчет в нТл
        public double Data { get { return _data; } set { _data = value; } }
        public MagRecord(int pK, double data)
        {
            Piket = pK;
            Data = data;
        }
    }
    class MagFile
    {
        public List<MagRecord> MagList;//массив данных
        public MagFile(string FileName)
        {
            StreamReader SR;
            try { SR = new StreamReader(FileName, System.Text.Encoding.UTF8); }
            catch { throw new Exception(); }
            MagList = new List<MagRecord>();
            while (!SR.EndOfStream)
            {
                string buf = SR.ReadLine();

                string[] bufarray = buf.Split(' ', '\t');
                try
                {
                    double bufdata = double.Parse(bufarray[1], System.Globalization.CultureInfo.GetCultureInfo("en-US"));
                    MagList.Add(new MagRecord(Int32.Parse(bufarray[0]), bufdata));                     
                }
                catch (Exception) { throw new Exception("файл имеет неверный формат:" + (MagList.Count().ToString())); }
            }
            SR.Close();
        }
        public MagFile()
        {
            MagList = new List<MagRecord>();
        }
        static public void Drawgraphics(List<MagRecord> mf, Chart CC)
        {
            CC.Series[0].Points.Clear();
            CC.Series[0].ChartType = SeriesChartType.Line;
            CC.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            CC.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            CC.ChartAreas[0].AxisY.IsStartedFromZero = false;
            CC.ChartAreas[0].AxisX.Title = "Номер пикета";
            CC.ChartAreas[0].AxisY.Title = "ΔT, нТесла";

            foreach (MagRecord el in mf)
            {
                CC.Series[0].Points.AddXY(el.Piket, el.Data);
            }
        }
        public static List<double> Sred(List<MagRecord> sr, int r)
        {
            List<double> res = new List<double>();
            for (int j = 0; j < (r + r % 2) / 2; j++)
            {
                res.Add(0);
            }
            for (int i = 0; i < sr.Count - r; i++)
            {
                double sum1 = 0;
                for (int k = 0; k < r; k++)
                {
                    sum1 += sr[i + k].Data;
                }
               res.Add(sum1 / r);
            }
            for(int j = 0; j < (r - r % 2) / 2; j++)
            {
                res.Add(0);
            }
            for (int i = 0; i < res.Count; i++) res[i] = Math.Round(res[i]);
            return res;
        }
        public static MagFile createsred(List<double> sr, MagFile fl)
        {
            MagFile res = new MagFile();
            for(int i = 0; i <fl.MagList.Count; i++)
            {
                res.MagList.Add(new MagRecord(fl.MagList[i].Piket, sr[i]));
            }
            return res;
        }

        public static MagFile LocAnomal(MagFile fl, MagFile sr, int r)
        {
            MagFile res = new MagFile();
            for (int i = 0; i < (r + r % 2) / 2; i++)
            {
                res.MagList.Add(new MagRecord(fl.MagList[i].Piket, 0));
            }
            for (int i = (r - r % 2) / 2; i < fl.MagList.Count - (r - r % 2) / 2; i++)
            {
                res.MagList.Add(new MagRecord(fl.MagList[i].Piket, fl.MagList[i].Data - sr.MagList[i].Data));
            }
            for (int i = fl.MagList.Count - (r - r % 2) / 2; i < fl.MagList.Count; i++)
            {
                res.MagList.Add(new MagRecord(fl.MagList[i].Piket, 0));
            }
            return res;
        }
        static public void PrintMagFile(MagFile print, int r)
        {
            String name = "save" + r + ".txt";
            StreamWriter SW = new StreamWriter(name);
            for (int i = 0; i < print.MagList.Count; i++)
            {
                SW.Write(print.MagList[i].Piket.ToString());
                SW.Write("\t");
                SW.Write(print.MagList[i].Data.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US")));
                SW.WriteLine(" ");
            }
            SW.Close();
        }
    }
}
