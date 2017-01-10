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
    internal class UserFamilyTypeService : IDisposable
    {
        public void Dispose()
        {
            // throw new NotImplementedException();
        }

        public UserFamilyTypeListVo selectlistUserFamilyTypeVo(UserFamilyTypeVo userFamilyTypeVo)
        {
            UserFamilyTypeListVo userFamilyTypeListVo = new UserFamilyTypeListVo();

            using (UserFamilyTypeDao userFamilyTypeDao = new UserFamilyTypeDao())
            {
                userFamilyTypeListVo.userFamilyTypeVolist = userFamilyTypeDao.selectlistUserFamilyTypeVo(userFamilyTypeVo);
            }

            return userFamilyTypeListVo;
        }
    }
}
