using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using SeriesHandler.Database.Connector;
using SeriesHandler.Database.Proxy.DTO.Read;
using SeriesHandler.Database.Proxy.DTO.Write;
using SeriesHandler.Database.Proxy.Extensions;

namespace SeriesHandler.Database.Proxy.Functions
{
    public class SeriesFunctions
    {
        public static List<ReadableSeries> GetSeries()
        {
            using (var db = new Entities())
            {
                return db.Series.Select(x => x).ToAnotherType<Series, ReadableSeries>().ToList();
            }
        }

        public static ReadableSeries GetSeries(int i)
        {
            using (var db = new Entities())
            {
                var tmp = db.Series.FirstOrDefault(x => x.id == i);
                if (tmp == null)
                    return null;
                return new ReadableSeries(tmp);
            }
        }

        public static void AddSeries(WritableSeries series)
        {
            using (var db = new Entities())
            {
                db.Series.Add(series.ToSeries());
                db.SaveChanges();
            }
        }
    }
}
