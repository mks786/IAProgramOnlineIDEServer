using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IAProgramOnlineIdeApi.Models
{
    public class DeviceCatalogDetail
    {
        public string family { get; set; }

        public int embeddedInput { get; set; }

        public int embeddedOutput { get; set; }

        public string memory { get; set; }

        public string communication { get; set; }

        public string hsc { get; set; }

        public string ptoMotion { get; set; }

        public string pluginModule { get; set; }

        public string epxansionIo { get; set; }
    }
}