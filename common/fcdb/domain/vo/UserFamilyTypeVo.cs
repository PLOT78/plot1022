using fc.common.cmn.domain;

namespace fc.common.fcdb.domain.vo
{
    /// <summary>
    /// 사용자가족구분Vo
    /// </summary>
    public class UserFamilyTypeVo
    {
        /// <summary>
        /// 사용자가족구분Vo 생성자
        /// </summary>
        public UserFamilyTypeVo()
        {
            this.commonAttr = new CommonAttr();
            this.userFamilyType = new UserFamilyType();
        }

        /// <summary>
        /// 공통속성 property
        /// </summary>
        public CommonAttr commonAttr { get; set; }
        /// <summary>
        /// 사용자가족구분 property
        /// </summary>
        public UserFamilyType userFamilyType { get; set; }
    }
}
