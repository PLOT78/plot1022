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
    internal class UserFamilyRetirementAgeService : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public UserFamilyRetirementAgeListVo selectlistUserFamilyRetirementAgeVo(UserFamilyRetirementAgeVo userFamilyRetirementAgeVo)
        {
            UserFamilyRetirementAgeListVo userFamilyRetirementAgeListVo = new UserFamilyRetirementAgeListVo();

            using (UserFamilyRetirementAgeDao userFamilyRetirementAgeDao = new UserFamilyRetirementAgeDao())
            {
                userFamilyRetirementAgeListVo.userFamilyRetirementAgeVoList = userFamilyRetirementAgeDao.selectlistUserFamilyRetirementAgeVo(userFamilyRetirementAgeVo);
            }

            return userFamilyRetirementAgeListVo;
        }
    }
}
