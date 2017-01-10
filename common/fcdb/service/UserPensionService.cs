using fc.common.fcdb.domain;
using fc.common.fcdb.domain.listVo;
using fc.common.fcdb.domain.vo;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.service
{
    /// <summary>
    /// 연금Service
    /// </summary>
    internal class UserPensionService : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        /// <summary>
        /// 연금ListVo조회
        /// </summary>
        /// <param name="userFinanceVo">연금Vo</param>
        /// <returns>연금ListVo</returns>
        public UserPensionListVo selectListUserPensionVo(UserPensionVo userPensionVo)
        {
            UserPensionListVo userPensionListVo = new UserPensionListVo();

            try
            {
                for (int i = 0; i < userPensionVo.userPension.per; i++)
                {
                    double fv = Financial.FV(userPensionVo.userPension.rate / 12, (i + 1) * 12, userPensionVo.userPension.payment * (-1));

                    UserPension userPensionResult   = new UserPension();
                    userPensionResult.age           = userPensionVo.userPension.age + i;    // 나이
                    userPensionResult.payment       = userPensionVo.userPension.payment;    // 납입액
                    userPensionResult.per           = i + 1;                                // 기간
                    userPensionResult.rate          = userPensionVo.userPension.rate;       // 이율
                    userPensionResult.accumulate    = Math.Round(fv, 0);                    // 적립액

                    UserPensionVo userPensionVoResult = new UserPensionVo();
                    userPensionVoResult.userPension = userPensionResult;

                    userPensionListVo.userPensionVoList.Add(userPensionVoResult);
                }
            }
            catch (Exception e)
            {
                userPensionListVo.commonAttr.execSuccess = false;
                userPensionListVo.commonAttr.exceptionMessage = e.Message;
            }

            return userPensionListVo;
        }
    }
}
