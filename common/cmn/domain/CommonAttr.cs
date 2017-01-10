using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.cmn.domain
{
    /// <summary>
    /// 공통속성
    /// </summary>
    public class CommonAttr
    {
        /// <summary>
        /// 사용자가족domain 생성자
        /// </summary>
        public CommonAttr()
        {
            this.execSuccess = true;
            this.exceptionMessage = string.Empty;
        }

        /// <summary>
        /// 실행성공여부
        /// </summary>
        public bool execSuccess { get; set; }
        /// <summary>
        /// 예외메시지
        /// </summary>
        public string exceptionMessage { get; set; }
    }
}
