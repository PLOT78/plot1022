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
    /// 사용자가족Service
    /// </summary>
    internal class UserFamilyService : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        /// <summary>
        /// 사용자가족Vo추가
        /// </summary>
        /// <param name="userFamilyVo">사용자가족Vo</param>
        public void insertUserFamilyVo(UserFamilyVo userFamilyVo)
        {
            using (UserFamilyDao userFamilyDao = new UserFamilyDao())
            {
                if ( (userFamilyVo.userFamily.userFamilyTypeNo == 1)    // 본인이면
                    || (userFamilyVo.userFamily.userFamilyTypeNo == 2)  // 배우자이면
                    )
                {
                    UserFamilyVo rtnUserFamilyVo = userFamilyDao.selectUserFamilyVo(userFamilyVo);

                    if (rtnUserFamilyVo.userFamily.userFamilyNo != -1)
                        throw new Exception("본인,배우자는 중복 입력할 수 없습니다. 확인 바랍니다.");
                }

                userFamilyDao.insertUserFamilyVo(userFamilyVo);
            }

        }

        /// <summary>
        /// 사용자가족Vo조회
        /// </summary>
        /// <param name="userFamilyVo">사용자가족Vo</param>
        /// <returns>사용자가족Vo</returns>
        public UserFamilyVo selectUserFamilyVo(UserFamilyVo userFamilyVo)
        {
            UserFamilyVo rtnUserFamilyVo = new UserFamilyVo();

            try
            {
                using (UserFamilyDao userFamilyDao = new UserFamilyDao())
                {
                    rtnUserFamilyVo = userFamilyDao.selectUserFamilyVo(userFamilyVo);
                }
            }
            catch (Exception e)
            {
                rtnUserFamilyVo.commonAttr.execSuccess = false;
                rtnUserFamilyVo.commonAttr.exceptionMessage = e.Message;
            }

            return rtnUserFamilyVo;
        }

        /// <summary>
        /// 사용자가족ListVo조회
        /// </summary>
        /// <param name="userFamilyVo">사용자가족Vo</param>
        public UserFamilyListVo selectListUserFamilyVo(UserFamilyVo userFamilyVo)
        {
            UserFamilyListVo userFamilyListVo = new UserFamilyListVo();

            using (UserFamilyDao userFamilyDao = new UserFamilyDao())
            {
                userFamilyListVo.userFamilyVoList = userFamilyDao.selectListUserFamilyVo(userFamilyVo);
            }

            return userFamilyListVo;
        }

        /// <summary>
        /// 사용자가족Vo수정
        /// </summary>
        /// <param name="userFamilyVo">사용자가족Vo</param>
        /// <returns>사용자가족Vo</returns>
        public UserFamilyVo updateUserFamilyVo(UserFamilyVo userFamilyVo)
        {
            UserFamilyVo rtnUserFamilyVo = new UserFamilyVo();

            try
            {
                using (UserFamilyDao userFamilyDao = new UserFamilyDao())
                {
                    userFamilyDao.updateUserFamilyVo(userFamilyVo);
                }
            }
            catch (Exception e)
            {
                rtnUserFamilyVo.commonAttr.execSuccess = false;
                rtnUserFamilyVo.commonAttr.exceptionMessage = e.Message;
            }

            return rtnUserFamilyVo;
        }

        /// <summary>
        /// 사용자가족Vo삭제
        /// </summary>
        /// <param name="userFamilyVo">사용자가족Vo</param>
        public void deleteUserFamilyVo(UserFamilyVo userFamilyVo)
        {
            using (UserFamilyDao userFamilyDao = new UserFamilyDao())
            {
                userFamilyDao.deleteUserFamilyVo(userFamilyVo);
            }
        }
    }
}
