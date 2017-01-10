using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain
{
    public class SurveyCatalogQuestion
    {
        public SurveyCatalogQuestion()
        {
            this.surveyCatalogQuestionNo = 0;
            this.surveyCatalogQuestionContents = string.Empty;
        }

        public int surveyCatalogQuestionNo { get; set; }
        public string surveyCatalogQuestionContents { get; set; }
    }
}
