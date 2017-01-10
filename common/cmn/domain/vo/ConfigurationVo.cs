namespace fc.common.cmn.domain.vo
{
    /// <summary>
    /// 구성Vo
    /// </summary>
    public class ConfigurationVo
    {
        /// <summary>
        /// 구성Vo 생성자
        /// </summary>
        public ConfigurationVo()
        {
            this.commonAttr = new CommonAttr();
            this.configuration = new Configuration();
        }

        /// <summary>
        /// 공통속성 property
        /// </summary>
        public CommonAttr commonAttr { get; set; }
        /// <summary>
        /// 구성 property
        /// </summary>
        public Configuration configuration { get; set; }
    }
}
