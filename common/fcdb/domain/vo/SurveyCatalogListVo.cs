using fc.common.cmn.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain.vo
{
    public class SurveyCatalogListVo
    {
        public SurveyCatalogListVo()
        {
            this.commonAttr = new CommonAttr();
            this.surveyCatalogVolist = new List<SurveyCatalogVo>();
        }

        public CommonAttr commonAttr { get; set; }
        public List<SurveyCatalogVo> surveyCatalogVolist { get; set; }
    }
}
