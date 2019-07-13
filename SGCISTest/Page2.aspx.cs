using DotNet.Highcharts;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Helpers;
using DotNet.Highcharts.Options;
using System;

namespace SGCISTest
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] dates = new[]
            {
                DateTime.UtcNow.AddDays(new Random().Next(10)).ToString("dd/MM/yyyy"),
                DateTime.UtcNow.AddDays(new Random().Next(20)).ToString("dd/MM/yyyy"),
                DateTime.UtcNow.AddDays(new Random().Next(30)).ToString("dd/MM/yyyy"),
                DateTime.UtcNow.AddDays(new Random().Next(40)).ToString("dd/MM/yyyy"),
                DateTime.UtcNow.AddDays(new Random().Next(50)).ToString("dd/MM/yyyy"),
                DateTime.UtcNow.AddDays(new Random().Next(60)).ToString("dd/MM/yyyy"),
                DateTime.UtcNow.AddDays(new Random().Next(70)).ToString("dd/MM/yyyy"),
                DateTime.UtcNow.AddDays(new Random().Next(80)).ToString("dd/MM/yyyy"),
                DateTime.UtcNow.AddDays(new Random().Next(90)).ToString("dd/MM/yyyy"),
                DateTime.UtcNow.AddDays(new Random().Next(100)).ToString("dd/MM/yyyy")
            };

            Random r = new Random();

            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart { Type = ChartTypes.Column })
                .SetTitle(new Title { Text = "SGCIS Test Page 2" })
                .SetSubtitle(new Subtitle { Text = Request.QueryString["Name"] + ", " + Request.QueryString["age"] + ", " + Request.QueryString["type"] })
                .SetXAxis(new XAxis { Categories = dates })
                .SetYAxis(new YAxis
                {
                    Min = 0
                })
                .SetSeries(new[]
                {
                    new Series { Data = new Data(new object[] { r.Next(0, 100), r.Next(0, 100), r.Next(0, 100), r.Next(0, 100), r.Next(0, 100), r.Next(0, 100), r.Next(0, 100), r.Next(0, 100), r.Next(0, 100), r.Next(0, 100) }) },
                });

            TeacherChart.Text = chart.ToHtmlString();
        }
    }
}