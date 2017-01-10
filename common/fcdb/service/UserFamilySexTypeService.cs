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
    internal class UserFamilySexTypeService : IDisposable
    {
        public void Dispose()
        {
           // throw new NotImplementedException();
        }

        public UserFamilySexTypeListVo selectlistUserFamilySexTypeVo(UserFamilySexTypeVo userFamilySexTypeVo)
        {
            UserFamilySexTypeListVo userFamilySexTypeListVo = new UserFamilySexTypeListVo();

            using (UserFamilySexTypeDao userFamilySexTypeDao = new UserFamilySexTypeDao())
            {
                userFamilySexTypeListVo.userFamilySexTypeVoList = userFamilySexTypeDao.selectlistUserFamilySexTypeVo(userFamilySexTypeVo);
            }

            return userFamilySexTypeListVo;
        }
    }
}
