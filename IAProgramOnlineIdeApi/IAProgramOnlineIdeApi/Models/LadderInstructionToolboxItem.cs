using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;

namespace IAProgramOnlineIdeApi.Models
{
    [SuppressMessage("Resharper","All")]
    public class LadderInstructionToolboxItem
    {
        public LadderInstructionToolboxItem()
        {
            searchKeywords = new List<string>();
        }

        public int id { get; set; }

        public string name { get; set; }

        public string displayName { get; set; }

        public List<string> searchKeywords { get; set; }

        public string tooltip { get; set; }

        public bool isEnabled { get; set; }

        public bool isShowImage { get; set; }

        public bool isDefaultFavorite { get; set; }
    }
}