namespace fc.common.fcdb.domain
{
    /// <summary>
    /// 사용자가족구분domain
    /// </summary>
    public class UserFamilyType
    {
        /// <summary>
        /// 사용자가족구분domain 생성자
        /// </summary>
        public UserFamilyType()
        {
            this.userFamilyTypeNo = -1;
            this.userFamilyTypeNm = string.Empty;
        }

        /// <summary>
        /// 사용자가족구분번호 property
        /// </summary>
        public int userFamilyTypeNo { get; set; }
        /// <summary>
        /// 사용자가족구분명 property
        /// </summary>
        public string userFamilyTypeNm { get; set; }
    }
}
