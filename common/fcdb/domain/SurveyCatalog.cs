using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain
{
    public class SurveyCatalog
    {
        public SurveyCatalog()
        {
            this.surveyCatalogNo            = 0;
            this.surveyCatalogGroupNo       = 0;
            this.surveyCatalogQuestionNo    = 0;
            this.surveyCatalogQuestionAlias = string.Empty;
            this.surveyCatalogQuestionNo    = 0;
            this.surveyCatalogAnswerAlias   = string.Empty;
            this.score                      = 0;
        }

        public int      surveyCatalogNo             { get; set; }
        public int      surveyCatalogGroupNo        { get; set; }
        public int      surveyCatalogQuestionNo     { get; set; }
        public string   surveyCatalogQuestionAlias  { get; set; }
        public int      surveyCatalogAnswerNo       { get; set; }
        public string   surveyCatalogAnswerAlias    { get; set; }
        public float    score                       { get; set; }
    }
}
