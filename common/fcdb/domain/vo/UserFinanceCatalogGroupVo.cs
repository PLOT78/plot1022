using fc.common.cmn.domain;

namespace fc.common.fcdb.domain.vo
{
    /// <summary>
    /// 사용자재무카탈로그그룹Vo
    /// </summary>
    public class UserFinanceCatalogGroupVo
    {
        /// <summary>
        /// 사용자재무카탈로그그룹Vo 생성자
        /// </summary>
        public UserFinanceCatalogGroupVo()
        {
            this.commonAttr = new CommonAttr();
            this.userFinanceCatalogGroup = new UserFinanceCatalogGroup();
        }

        /// <summary>
        /// 공통속성 property
        /// </summary>
        public CommonAttr commonAttr { get; set; }
        /// <summary>
        /// 사용자재무카탈로그그룹 property
        /// </summary>
        public UserFinanceCatalogGroup userFinanceCatalogGroup { get; set; }
    }
}
