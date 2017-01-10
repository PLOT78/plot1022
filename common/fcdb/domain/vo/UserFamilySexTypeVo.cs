using fc.common.cmn.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain.vo
{
    /// <summary>
    /// 사용자가족성별구분Vo
    /// </summary>
    public class UserFamilySexTypeVo
    {
        /// <summary>
        /// 사용자가족성별구분Vo 생성자
        /// </summary>
        public UserFamilySexTypeVo()
        {
            this.commonAttr = new CommonAttr();
            this.userFamilySexType = new UserFamilySexType();
        }

        /// <summary>
        /// 공통속성 property
        /// </summary>
        public CommonAttr commonAttr { get; set; }
        /// <summary>
        /// 사용자가족성별구분 property
        /// </summary>
        public UserFamilySexType userFamilySexType { get; set; }
    }
}
