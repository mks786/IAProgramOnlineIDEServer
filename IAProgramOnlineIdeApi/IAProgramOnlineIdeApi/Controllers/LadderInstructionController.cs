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
        private static List<LadderInstructionToolboxCategory> ladderCategories;
        private static List<LadderInstructionToolboxItem> ladderItems;

        public static List<LadderInstructionToolboxCategory> LadderCategories
        {
            get
            {
                if (ladderCategories == null || ladderCategories.Count <= 0)
                {
                    ladderCategories = JsonConvert.DeserializeObject<List<LadderInstructionToolboxCategory>>(LadderProgramResource.categories);
                }
                return ladderCategories;
            }
        }

        public static List<LadderInstructionToolboxItem> LadderItems
        {
            get
            {
                if (ladderItems == null || ladderItems.Count <= 0)
                {
                    ladderItems = JsonConvert.DeserializeObject<List<LadderInstructionToolboxItem>>(LadderProgramResource.instructions);
                }
                return ladderItems;
            }
        }

        static LadderInstructionController()
        {
            ladderCategories = new List<LadderInstructionToolboxCategory>();
            ladderItems = new List<LadderInstructionToolboxItem>();
        }


        [HttpGet]
        [Route("instruction/categories")]
        public IHttpActionResult GetInstructionCategories()
        {
            try
            {
                return Json(LadderCategories);
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
                return Json(LadderItems);
            }
            catch (Exception e)
            {
                return new ExceptionResult(e, this);
            }
        }
    }
}
