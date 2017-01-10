using fc.common.cmn.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain.vo
{
    public class UserVo
    {
        public UserVo()
        {
            this.commonAttr     = new CommonAttr();
            this.user           = new User();
            this.userGrade      = new UserGrade();
        }

        public CommonAttr       commonAttr  { get; set; }
        public User             user        { get; set; }
        public UserGrade        userGrade   { get; set; }
    }
}
