using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain
{
    public class UserGrade
    {
        public UserGrade()
        {
            this.userGradeNo = string.Empty;
            this.userGradeNm = string.Empty;
        }

        public string userGradeNo { get; set; }
        public string userGradeNm { get; set; }
    }
}
