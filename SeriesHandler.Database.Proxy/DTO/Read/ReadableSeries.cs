using System;

namespace SeriesHandler.Database.Proxy.DTO.Read
{
    public class ReadableSeries
    {
        public ReadableSeries() { }

        public ReadableSeries(Connector.Series series)
        {
            StartDate = series.startDate;
            EndDate = series.endDate;
            Title = series.title;
            Description = series.description;
        }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
