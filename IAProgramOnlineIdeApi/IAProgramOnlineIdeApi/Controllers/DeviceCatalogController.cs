using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using IAProgramOnlineIdeApi.Models;
using IAProgramOnlineIdeApi.Resource;
using Newtonsoft.Json;

namespace IAProgramOnlineIdeApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("catalog")]
    public class DeviceCatalogController : ApiController
    {
        private static List<DeviceCatalogInfo> catalogCache;
        private static List<DeviceCatalogDetail> catalogDetailCache;

        public static List<DeviceCatalogInfo> Catalogs
        {
            get
            {
                if (catalogCache == null || catalogCache.Count <= 0)
                {
                    catalogCache = JsonConvert.DeserializeObject<List<DeviceCatalogInfo>>(LadderProgramResource.deviceCatalog);
                }
                return catalogCache;
            }
        }

        public static List<DeviceCatalogDetail> CatalogDetails
        {
            get
            {
                if (catalogDetailCache == null || catalogDetailCache.Count <= 0)
                {
                    catalogDetailCache = JsonConvert.DeserializeObject<List<DeviceCatalogDetail>>(LadderProgramResource.deviceCatalog);
                }
                return catalogDetailCache;
            }
        }

        static DeviceCatalogController()
        {
            catalogCache = new List<DeviceCatalogInfo>();
            catalogDetailCache = new List<DeviceCatalogDetail>();
        }

        [HttpGet]
        [Route("info/all")]
        public IHttpActionResult GetDeviceCatalogs()
        {
            try
            {
                return Json(Catalogs);
            }
            catch (Exception e)
            {
                return new ExceptionResult(e, this);
            }
        }

        [HttpGet]
        [Route("detail/{catalog}")]
        public IHttpActionResult GetDeviceCatalogDetail()
        {
            try
            {
                var routeMap = Request.GetRouteData().Values;
                if (routeMap == null || !routeMap.ContainsKey("catalog"))
                    return BadRequest("not correct url");

                if (routeMap.TryGetValue("catalog", out var catalog))
                {
                    var strCatalog = catalog.ToString();
                    var splits = strCatalog.Split('-');

                    // TODO:
                }
                return BadRequest("not correct url");
            }
            catch (Exception e)
            {
                return new ExceptionResult(e, this);
            }
        }
    }
}
