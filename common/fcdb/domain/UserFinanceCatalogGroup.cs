namespace fc.common.fcdb.domain
{
    /// <summary>
    /// 사용자재무카탈로그그룹domain
    /// </summary>
    public class UserFinanceCatalogGroup
    {
        /// <summary>
        /// 사용자재무카탈로그그룹domain 생성자
        /// </summary>
        public UserFinanceCatalogGroup()
        {
            this.userFinanceCatalogGroupNo = -1;
            this.userFinanceCatalogGroupNm = string.Empty;
        }

        /// <summary>
        /// 사용자재무카탈로그그룹번호 property
        /// </summary>
        public int userFinanceCatalogGroupNo { get; set; }
        /// <summary>
        /// 사용자재무카탈로그그룹명 property
        /// </summary>
        public string userFinanceCatalogGroupNm { get; set; }
    }
}
