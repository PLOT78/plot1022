using fc.common.fcdb.dao;
using fc.common.fcdb.domain.listVo;
using fc.common.fcdb.domain.vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.service
{
    /// <summary>
    /// 사용자재무Service
    /// </summary>
    internal class UserFinanceService : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        /// <summary>
        /// 사용자재무ListVo조회
        /// </summary>
        /// <param name="userFinanceVo">사용자재무Vo</param>
        /// <returns>사용자재무ListVo</returns>
        public UserFinanceListVo selectListUserFinanceVo(UserFinanceVo userFinanceVo)
        {
            UserFinanceListVo userFinanceListVo = new UserFinanceListVo();

            try
            {
                using (UserFinanceDao userFinanceDao = new UserFinanceDao())
                {
                    userFinanceListVo.userFinanceVoList = userFinanceDao.selectListUserFinanceVo(userFinanceVo);
                }
            }
            catch (Exception e)
            {
                userFinanceListVo.commonAttr.execSuccess = false;
                userFinanceListVo.commonAttr.exceptionMessage = e.Message;
            }

            return userFinanceListVo;
        }

        /// <summary>
        /// 사용자재무Vo수정
        /// </summary>
        /// <param name="userFinanceListVo">사용자재무ListVo</param>
        /// <returns>사용자재무ListVo</returns>
        public UserFinanceListVo updateUserFinanceVo(UserFinanceListVo userFinanceListVo)
        {
            UserFinanceListVo rtnUserFinanceListVo = new UserFinanceListVo();

            try
            {
                using (UserFinanceDao userFinanceDao = new UserFinanceDao())
                {
                    if ( (userFinanceListVo != null) 
                        && (userFinanceListVo.userFinanceVoList != null)
                        && (userFinanceListVo.userFinanceVoList.Count > 0) )
                    {
                        foreach (UserFinanceVo userFinanceVo in userFinanceListVo.userFinanceVoList)
                        {
                            userFinanceDao.updateUserFinanceVo(userFinanceVo);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                rtnUserFinanceListVo.commonAttr.execSuccess = false;
                rtnUserFinanceListVo.commonAttr.exceptionMessage = e.Message;
            }

            return rtnUserFinanceListVo;
        }
    }
}
