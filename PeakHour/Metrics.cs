using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using PeakHour.Data;

namespace PeakHour
{
    public partial class Metrics : MaterialForm
    {
        PeakHourEntities entities = new PeakHourEntities();
        private double okayCount;
        private double stressedCount;
        private double energeticCount;
        private double neutralCount;
        public Metrics()
        {

            InitializeComponent();

            okayCount = 0;
            stressedCount = 0;
            energeticCount = 0;
            neutralCount = 0;

            MaterialSkinManager matSkinManager = MaterialSkinManager.Instance;
            matSkinManager.AddFormToManage(this);
            matSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            matSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Metrics_Load(object sender, EventArgs e)
        {
            GetDailyData();

            GetWeeklyData();
        }


        public void GetDailyData()
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
                 string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);


            stressedCount = entities.tblPeakHours.Where(s => s.Mood.Equals("Stressed", StringComparison.OrdinalIgnoreCase) && s.DateToday == DateTime.Today).Count();
            okayCount = entities.tblPeakHours.Where(s => s.Mood.Equals("Okay", StringComparison.OrdinalIgnoreCase) && s.DateToday == DateTime.Today).Count();
            neutralCount = entities.tblPeakHours.Where(s => s.Mood.Equals("Neutral", StringComparison.OrdinalIgnoreCase) && s.DateToday == DateTime.Today).Count();
            energeticCount = entities.tblPeakHours.Where(s => s.Mood.Equals("Energetic", StringComparison.OrdinalIgnoreCase) && s.DateToday == DateTime.Today).Count();

            dailyPiChart.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Stressed",
                    Values = new ChartValues<double> {stressedCount},
                    //PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Okay",
                    Values = new ChartValues<double> {okayCount},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Neutral",
                    Values = new ChartValues<double> {neutralCount},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Energetic",
                    Values = new ChartValues<double> {energeticCount},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };
            dailyPiChart.LegendLocation = LegendLocation.Bottom;
        }


        public void GetWeeklyData()
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
                 string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            double totalStressed = 0;
            double totalOkay = 0;
            double totalNeutral = 0;
            double totalEnergetic = 0;

            var startWeek = DateTime.Today.AddDays(-7);
            var weekBetween = DateTime.Today - startWeek;
            List<DateTime> daysBetween = new List<DateTime>();

            var sevendaysAgo = DateTime.Today.AddDays(-7);
            var model = entities.tblPeakHours;
            var results = Enumerable.Range(0, 8).Select(d => sevendaysAgo.AddDays(d)).ToList();

            foreach (var item in results)
            {
                stressedCount = model.Where(s => s.Mood.Equals("Stressed", StringComparison.OrdinalIgnoreCase) && s.DateToday == item).Count();
                totalStressed += stressedCount;
                okayCount = entities.tblPeakHours.Where(s => s.Mood.Equals("Okay", StringComparison.OrdinalIgnoreCase) && s.DateToday == item).Count();
                totalOkay += okayCount;
                neutralCount = entities.tblPeakHours.Where(s => s.Mood.Equals("Neutral", StringComparison.OrdinalIgnoreCase) && s.DateToday == item).Count();
                totalNeutral += neutralCount;
                energeticCount = entities.tblPeakHours.Where(s => s.Mood.Equals("Energetic", StringComparison.OrdinalIgnoreCase) && s.DateToday == item).Count();
                totalEnergetic += energeticCount;
            }

            weeklyPiChart.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Stressed",
                    Values = new ChartValues<double> {totalStressed},
                    //PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Okay",
                    Values = new ChartValues<double> {totalOkay},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Neutral",
                    Values = new ChartValues<double> {totalNeutral},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Energetic",
                    Values = new ChartValues<double> {totalEnergetic},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };
            weeklyPiChart.LegendLocation = LegendLocation.Bottom;
        }
    }
}
