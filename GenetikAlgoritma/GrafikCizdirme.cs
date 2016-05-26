using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace GenetikAlgoritma
{
    class GrafikCizdirme
    {
        
        public GrafikCizdirme()
        {

        }

        public void cizGrafik1(List<double> liste, Chart chart, string cizgi, Color renk)
        {
            chart.Series.Clear();
            chart.Series.Add(cizgi);
            for (int i = 1; i < liste.Count; i++)
            chart.Series[cizgi].Points.Add(new DataPoint(i, liste[i]));
            chart.Series[cizgi].ChartType = SeriesChartType.Line;
            chart.Series[cizgi].Color = renk;
            chart.Series[cizgi].BorderWidth = 2;
            chart.Series[cizgi].YValueType = ChartValueType.Double;
            
        }

    }
}
