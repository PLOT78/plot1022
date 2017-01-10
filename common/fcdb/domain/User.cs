using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain
{
    public class User
    {
        public User()
        {
            this.userId         = string.Empty;
            this.userNm         = string.Empty;
            this.pwd            = string.Empty;
            this.userGradeNo    = string.Empty;
        }

        public string userId        { get; set; }
        public string userNm        { get; set; }
        public string pwd           { get; set; }
        public string userGradeNo   { get; set; }
        
    }
}
