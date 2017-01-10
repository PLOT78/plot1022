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
    internal class UserFamilyJobTypeService : IDisposable
    {
        public void Dispose()
        {
            // throw new NotImplementedException();
        }

        public UserFamilyJobTypeListVo selectlistUserFamilyJobTypeVo(UserFamilyJobTypeVo userFamilyJobTypeVo)
        {
            UserFamilyJobTypeListVo userFamilyJobTypeListVo = new UserFamilyJobTypeListVo();

            using (UserFamilyJobTypeDao userFamilyJobTypeDao = new UserFamilyJobTypeDao())
            {
                userFamilyJobTypeListVo.userFamilyJobTypeVoList = userFamilyJobTypeDao.selectlistUserFamilyJobTypeVo(userFamilyJobTypeVo);
            }

            return userFamilyJobTypeListVo;
        }
    }
}
