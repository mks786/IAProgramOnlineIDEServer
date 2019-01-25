using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;

namespace IAProgramOnlineIdeApi.Models
{
    [SuppressMessage("Resharper", "All")]
    public class LadderInstructionToolboxCategory
    {
        public LadderInstructionToolboxCategory()
        {
            instructions = new List<int>();
        }

        public string name { get; set; }

        public string displayName { get; set; }

        public bool isEnabled { get; set; }

        public List<int> instructions { get; set; }
    }
}