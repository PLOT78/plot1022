namespace fc.common.cmn.domain
{
    /// <summary>
    /// 구성domain
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// 구성domain 생성자
        /// </summary>
        public Configuration()
        {
        }

        /// <summary>
        /// 구성아이디 property
        /// </summary>
        public string configurationId { get; set; }
        /// <summary>
        /// 구성명 property
        /// </summary>
        public string configurationNm { get; set; }
        /// <summary>
        /// 구성값 property
        /// </summary>
        public string configurationVal { get; set; }
        /// <summary>
        /// 구성사용여부 property
        /// </summary>
        public bool configurationUsed { get; set; }
        /// <summary>
        /// 구성서브그룹번호 property
        /// </summary>
        public int configurationSubgroupNo { get; set; }
    }
}
