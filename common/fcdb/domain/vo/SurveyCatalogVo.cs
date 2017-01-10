using fc.common.cmn.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain.vo
{
    public class SurveyCatalogVo
    {
        public SurveyCatalogVo()
        {
            this.commonAttr             = new CommonAttr();
            this.surveyCatalog          = new SurveyCatalog();
            this.surveyCatalogGroup     = new SurveyCatalogGroup();
            this.surveyCatalogQuestion  = new SurveyCatalogQuestion();
            this.surveyCatalogAnswer    = new SurveyCatalogAnswer();
        }

        public CommonAttr               commonAttr              { get; set; }
        public SurveyCatalog            surveyCatalog           { get; set; }
        public SurveyCatalogGroup       surveyCatalogGroup      { get; set; }
        public SurveyCatalogQuestion    surveyCatalogQuestion   { get; set; }
        public SurveyCatalogAnswer      surveyCatalogAnswer     { get; set; }
    }
}
