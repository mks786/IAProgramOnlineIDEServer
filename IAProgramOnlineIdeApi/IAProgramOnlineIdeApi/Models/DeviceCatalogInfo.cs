using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;

namespace IAProgramOnlineIdeApi.Models
{
    [SuppressMessage("Resharper", "All")]
    public class DeviceCatalogInfo
    {
        public DeviceCatalogInfo()
        {
            revisions = new List<int>();
        }

        public string name { get; set; }

        public string family { get; set; }

        public List<int> revisions { get; set; }
    }
}