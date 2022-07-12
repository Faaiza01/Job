using Job.OutServices.IService;
using Job.OutServices.Models;
using Job.OutServices.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JobWebApi.Controllers
{
    public class RecordController : ApiController
    {
        IContract service;

        public RecordController()
        {
            service = new Service();
        }

        // GET api/values

        //1st Coding Strategy
        //public HttpResponseMessage Get()
        //{
        //    Record[] records = service.GetRecords();
        //    if (records == null)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.NotFound);
        //    }
        //    else
        //    {
        //        return Request.CreateResponse(HttpStatusCode.OK, records);
        //    }
            
        //}

        //2nd Coding Strategy
        //public IHttpActionResult Get()
        //{
        //    Record[] records = service.GetRecords();
        //    if (records == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        return Ok(records);
        //    }

        //}

        // GET api/values/5
        //public HttpResponseMessage Get(int id)
        //{
        //    Record record = service.GetRecord(id);
        //    if (record == null)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.NotFound);
        //    }
        //    else
        //    {
        //        return Request.CreateResponse(HttpStatusCode.OK, record);
        //    }
        //}

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
