namespace fc.common.fcdb.domain
{
    /// <summary>
    /// 사용자가족성별구분domain
    /// </summary>
    public class UserFamilySexType
    {
        /// <summary>
        /// 사용자가족성별구분domain 생성자
        /// </summary>
        public UserFamilySexType()
        {
            this.sexTypeNo = -1;
            this.sexTypeNm = string.Empty;
        }

        /// <summary>
        /// 성별구분번호 property
        /// </summary>
        public int sexTypeNo { get; set; }
        /// <summary>
        /// 성별구분명 property
        /// </summary>
        public string sexTypeNm { get; set; }
    }
}
