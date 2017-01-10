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
    internal class UserFamilyBirthYearService : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public UserFamilyBirthYearListVo selectlistUserFamilyBirthYearVo(UserFamilyBirthYearVo userFamilyBirthYearVo)
        {
            UserFamilyBirthYearListVo userFamilyBirthYearListVo = new UserFamilyBirthYearListVo();

            using (UserFamilyBirthYearDao userFamilyBirthYearDao = new UserFamilyBirthYearDao())
            {
                userFamilyBirthYearListVo.userFamilyBirthYearVoList = userFamilyBirthYearDao.selectlistUserFamilyTypeVo(userFamilyBirthYearVo);
            }

            return userFamilyBirthYearListVo;
        }
    }
}
