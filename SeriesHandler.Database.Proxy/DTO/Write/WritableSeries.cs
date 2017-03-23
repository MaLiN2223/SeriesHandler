using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeriesHandler.Database.Connector;
using SeriesHandler.Database.Proxy.DTO.Read;

namespace SeriesHandler.Database.Proxy.DTO.Write
{
    public class WritableSeries
    {
        public WritableSeries() { }

        public Series ToSeries()
        {
            var series = new Series();
            series.startDate = StartDate;
            series.endDate = EndDate;
            series.title = Title;
            series.description = Description;
            return series;
        }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
