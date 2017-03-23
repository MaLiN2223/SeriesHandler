using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using SeriesHandler.Database.Proxy.DTO.Read;
using SeriesHandler.Database.Proxy.DTO.Write;
using SeriesHandler.Database.Proxy.Functions;
using ServerLibrary.Exceptions;
using ServerLibrary.Utils;

namespace SeriesHandler.WebApi.Controllers
{

    [AllowAnonymous]
    [RoutePrefix("api/series")]
    public class SeriesController : ApiController
    {

        [HttpGet, ResponseType(typeof(ReadableSeries))]
        public IHttpActionResult GetSeries(int id)
        {
            var series = SeriesFunctions.GetSeries(id);
            if (series == null)
            {
                return NotFound();
            }
            return Ok(series);
        }
        [HttpGet, ResponseType(typeof(ReadableSeries))]
        public IHttpActionResult GetSeries()
        {
            var series = SeriesFunctions.GetSeries();
            if (series == null)
            {
                return NotFound();
            }
            return Ok(series);
        }

        [HttpPost]
        public IHttpActionResult PostSeries([FromBody] WritableSeries series)
        {
            try
            {
                SeriesFunctions.AddSeries(series);
                return Ok();
            }
            catch (Exception e)
            {
                throw new ResponseException(e, Utilities.ExceptionType.Database, series);
            }
        }
    }
}
