using fc.common.cmn.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain.vo
{
    /// <summary>
    /// 사용자가족Vo
    /// </summary>
    public class UserFamilyVo
    {
        /// <summary>
        /// 사용자가족Vo 생성자
        /// </summary>
        public UserFamilyVo()
        {
            this.commonAttr         = new CommonAttr();

            this.userFamily         = new UserFamily();
            this.userFamilyType     = new UserFamilyType();
            this.userFamilySexType  = new UserFamilySexType();
            this.userFamilyJobType  = new UserFamilyJobType();
        }

        /// <summary>
        /// 공통속성 property
        /// </summary>
        public CommonAttr commonAttr { get; set; }
        /// <summary>
        /// 사용자가족 property
        /// </summary>
        public UserFamily userFamily { get; set; }
        /// <summary>
        /// 사용자가족구분 property
        /// </summary>
        public UserFamilyType userFamilyType { get; set; }
        /// <summary>
        /// 사용자가족성별구분 property
        /// </summary>
        public UserFamilySexType userFamilySexType { get; set; }
        /// <summary>
        /// 사용자가족직업구분 property
        /// </summary>
        public UserFamilyJobType userFamilyJobType { get; set; }
    }
}
