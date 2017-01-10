using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain
{
    public class SurveyCatalogAnswer
    {
        public SurveyCatalogAnswer()
        {
            this.surveyCatalogAnswerNo          = 0;
            this.surveyCatalogAnswerContents    = string.Empty;
        }

        public int      surveyCatalogAnswerNo         { get; set; }
        public string   surveyCatalogAnswerContents   { get; set; }
    }
}
