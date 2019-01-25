using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using IAProgramOnlineIdeApi.Models;
using IAProgramOnlineIdeApi.Resource;
using Newtonsoft.Json;

namespace IAProgramOnlineIdeApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("ladder")]
    public class LadderInstructionController : ApiController
    {
        [HttpGet]
        [Route("instruction/categories")]
        public IHttpActionResult GetInstructionCategories()
        {
            try
            {
                var data = JsonConvert.DeserializeObject<List<LadderInstructionToolboxCategory>>(LadderProgramResource.categories);
                return Json(data);
            }
            catch (Exception e)
            {
                return new ExceptionResult(e, this);
            }
        }

        [HttpGet]
        [Route("instruction/items")]
        public IHttpActionResult GetInstructionItems()
        {
            try
            {
                var data = JsonConvert.DeserializeObject<List<LadderInstructionToolboxItem>>(LadderProgramResource.instructions);
                return Json(data);
            }
            catch (Exception e)
            {
                return new ExceptionResult(e, this);
            }
        }
    }
}
