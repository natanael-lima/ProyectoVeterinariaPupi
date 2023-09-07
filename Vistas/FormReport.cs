using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Vistas
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();

            
        }
       

        private void FormReport_Load(object sender, EventArgs e)
        {
            // Llamar a una función para configurar los datos para cada gráfico
            ConfigureChart(chart1, "ChartArea1", "Series1");
            ConfigureChart(chart2, "ChartArea2", "Series2");
            ConfigureChart(chart3, "ChartArea3", "Series3");
        }
        private void ConfigureChart(Chart chart, string chartAreaName, string seriesName)
        {
            Series series2 = chart2.Series["Series1"];
            Series series3 = chart3.Series["Series1"];
            Series series1 = chart1.Series["Series1"];
            // Agregar nuevos puntos de datos
            series2.Points.AddXY("Dato1", 10);
            series2.Points.AddXY("Dato2", 20);
            series2.Points.AddXY("Dato3", 30);
            series2.Points.AddXY("Dato4", 40);
            // Agregar nuevos puntos de datos
            series3.Points.AddXY("Dato1", 10);
            series3.Points.AddXY("Dato2", 20);
            series3.Points.AddXY("Dato3", 30);
            series3.Points.AddXY("Dato4", 40);
            // Agregar nuevos puntos de datos
            series1.Points.AddXY("Dato1", 50);
            series1.Points.AddXY("Dato2", 60);
            series1.Points.AddXY("Dato3", 40);
            series1.Points.AddXY("Dato4", 30);
            series1.Points.AddXY("Dato5", 28);
        }
    }
}
