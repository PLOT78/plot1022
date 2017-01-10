using fc.common.fcdb.domain.listVo;
using fc.common.fcdb.domain.vo;
using fc.common.fcdb.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.facade
{
    public class FCdbFacade : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public SurveyCatalogListVo listSurveyCatalogVo(SurveyCatalogVo surveyCatalogVo)
        {
            SurveyCatalogListVo surveyCatalogListVo = new SurveyCatalogListVo();

            using (SurveyCatalogService surveyCatalogService = new SurveyCatalogService())
            {
                surveyCatalogListVo = surveyCatalogService.listSurveyCatalogVo(surveyCatalogVo);
            }

            return surveyCatalogListVo;
        }

        public UserFamilyBirthYearListVo selectlistUserFamilyBirthYearVo(UserFamilyBirthYearVo userFamilyBirthYearVo)
        {
            UserFamilyBirthYearListVo userFamilyBirthYearListVo = new UserFamilyBirthYearListVo();

            using (UserFamilyBirthYearService userFamilyBirthYearService = new UserFamilyBirthYearService())
            {
                userFamilyBirthYearListVo = userFamilyBirthYearService.selectlistUserFamilyBirthYearVo(userFamilyBirthYearVo);
            }

            return userFamilyBirthYearListVo;
        }

        public UserFamilyJobTypeListVo selectlistUserFamilyJobTypeVo(UserFamilyJobTypeVo userFamilyJobTypeVo)
        {
            UserFamilyJobTypeListVo userFamilyJobTypeListVo = new UserFamilyJobTypeListVo();

            using (UserFamilyJobTypeService userFamilyJobTypeService = new UserFamilyJobTypeService())
            {
                userFamilyJobTypeListVo = userFamilyJobTypeService.selectlistUserFamilyJobTypeVo(userFamilyJobTypeVo);
            }

            return userFamilyJobTypeListVo;
        }

        public UserFamilyLifeSpanListVo selectlistUserFamilyLifeSpanVo(UserFamilyLifeSpanVo userFamilyLifeSpanVo)
        {
            UserFamilyLifeSpanListVo userFamilyLifeSpanListVo = new UserFamilyLifeSpanListVo();

            using (UserFamilyLifeSpanService userFamilyLifeSpanService = new UserFamilyLifeSpanService())
            {
                userFamilyLifeSpanListVo = userFamilyLifeSpanService.selectlistUserFamilyLifeSpanVo(userFamilyLifeSpanVo);
            }

            return userFamilyLifeSpanListVo;
        }

        public UserFamilyRetirementAgeListVo selectlistUserFamilyRetirementAgeVo(UserFamilyRetirementAgeVo userFamilyRetirementAgeVo)
        {
            UserFamilyRetirementAgeListVo userFamilyRetirementAgeListVo = new UserFamilyRetirementAgeListVo();

            using (UserFamilyRetirementAgeService userFamilyRetirementAgeService = new UserFamilyRetirementAgeService())
            {
                userFamilyRetirementAgeListVo = userFamilyRetirementAgeService.selectlistUserFamilyRetirementAgeVo(userFamilyRetirementAgeVo);
            }

            return userFamilyRetirementAgeListVo;
        }

        /// <summary>
        /// 사용자가족Vo추가
        /// </summary>
        /// <param name="userFamilyVo">사용자가족Vo</param>
        public void insertUserFamilyVo(UserFamilyVo userFamilyVo)
        {
            using (UserFamilyService userFamilyService = new UserFamilyService())
            {
                userFamilyService.insertUserFamilyVo(userFamilyVo);
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

            using (UserFamilyService userFamilyService = new UserFamilyService())
            {
                rtnUserFamilyVo = userFamilyService.selectUserFamilyVo(userFamilyVo);
            }

            return rtnUserFamilyVo;
        }

        /// <summary>
        /// 사용자가족ListVo조회
        /// </summary>
        /// <param name="userFamilyVo">사용자가족Vo</param>
        /// <returns>사용자가족ListVo</returns>
        public UserFamilyListVo selectListUserFamilyVo(UserFamilyVo userFamilyVo)
        {
            UserFamilyListVo userFamilyListVo = new UserFamilyListVo();

            using (UserFamilyService userFamilyService = new UserFamilyService())
            {
                userFamilyListVo = userFamilyService.selectListUserFamilyVo(userFamilyVo);
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

            using (UserFamilyService userFamilyService = new UserFamilyService())
            {
                rtnUserFamilyVo = userFamilyService.updateUserFamilyVo(userFamilyVo);
            }

            return rtnUserFamilyVo;
        }

        /// <summary>
        /// 사용자가족Vo삭제
        /// </summary>
        /// <param name="userFamilyVo">사용자가족Vo</param>
        public void deleteUserFamilyVo(UserFamilyVo userFamilyVo)
        {
            using (UserFamilyService userFamilyService = new UserFamilyService())
            {
                userFamilyService.deleteUserFamilyVo(userFamilyVo);
            }
        }

        public UserFamilySexTypeListVo selectlistUserFamilySexTypeVo(UserFamilySexTypeVo userFamilySexTypeVo)
        {
            UserFamilySexTypeListVo userFamilySexTypeListVo = new UserFamilySexTypeListVo();

            using (UserFamilySexTypeService userFamilySexTypeService = new UserFamilySexTypeService())
            {
                userFamilySexTypeListVo = userFamilySexTypeService.selectlistUserFamilySexTypeVo(userFamilySexTypeVo);
            }

            return userFamilySexTypeListVo;
        }

        public UserFamilyTypeListVo selectlistUserFamilyTypeVo(UserFamilyTypeVo userFamilyTypeVo)
        {
            UserFamilyTypeListVo userFamilyTypeListVo = new UserFamilyTypeListVo();

            using (UserFamilyTypeService userFamilyTypeService = new UserFamilyTypeService())
            {
                userFamilyTypeListVo = userFamilyTypeService.selectlistUserFamilyTypeVo(userFamilyTypeVo);
            }

            return userFamilyTypeListVo;
        }

        /// <summary>
        /// 사용자재무ListVo조회
        /// </summary>
        /// <param name="userFinanceVo">사용자재무Vo</param>
        /// <returns>사용자재무ListVo</returns>
        public UserFinanceListVo selectListUserFinanceVo(UserFinanceVo userFinanceVo)
        {
            UserFinanceListVo userFinanceListVo = new UserFinanceListVo();

            using (UserFinanceService userFinanceService = new UserFinanceService())
            {
                userFinanceListVo = userFinanceService.selectListUserFinanceVo(userFinanceVo);
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

            using (UserFinanceService userFinanceService = new UserFinanceService())
            {
                rtnUserFinanceListVo = userFinanceService.updateUserFinanceVo(userFinanceListVo);
            }

            return rtnUserFinanceListVo;
        }




        public void insertUserVo(UserVo UserVo)
        {
            using (UserService userService = new UserService())
            {
                userService.insertUserVo(UserVo);
            }
        }

        public UserVo selectUserVo(UserVo UserVo)
        {
            UserVo userVo = new UserVo();

            using (UserService userService = new UserService())
            {
                userVo = userService.selectUserVo(UserVo);
            }

            return userVo;
        }

        public void updateUserVo(UserVo UserVo)
        {
            using (UserService userService = new UserService())
            {
                userService.updateUserVo(UserVo);
            }
        }

        public void deleteUserVo(UserVo UserVo)
        {
            using (UserService userService = new UserService())
            {
                userService.deleteUserVo(UserVo);
            }
        }

        /// <summary>
        /// 연금ListVo조회
        /// </summary>
        /// <param name="userFinanceVo">연금Vo</param>
        /// <returns>연금ListVo</returns>
        public UserPensionListVo selectListUserPensionVo(UserPensionVo userPensionVo)
        {
            UserPensionListVo userPensionListVo = new UserPensionListVo();

            using (UserPensionService userPensionService = new UserPensionService())
            {
                userPensionListVo = userPensionService.selectListUserPensionVo(userPensionVo);
            }

            return userPensionListVo;
        }
    }
}
