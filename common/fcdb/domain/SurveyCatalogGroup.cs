using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain
{
    public class SurveyCatalogGroup
    {
        public SurveyCatalogGroup()
        {
            this.surveyCatalogGroupNo = 0;
            this.surveyCatalogGroupName = string.Empty;
        }

        public int surveyCatalogGroupNo         { get; set; }
        public string surveyCatalogGroupName    { get; set; }
    }
}
