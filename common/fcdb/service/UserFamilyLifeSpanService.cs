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
    internal class UserFamilyLifeSpanService : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public UserFamilyLifeSpanListVo selectlistUserFamilyLifeSpanVo(UserFamilyLifeSpanVo userFamilyLifeSpanVo)
        {
            UserFamilyLifeSpanListVo userFamilyLifeSpanListVo = new UserFamilyLifeSpanListVo();

            using (UserFamilyLifeSpanDao userFamilyLifeSpanDao = new UserFamilyLifeSpanDao())
            {
                userFamilyLifeSpanListVo.userFamilyLifeSpanVoList = userFamilyLifeSpanDao.selectlistUserFamilyLifeSpanVo(userFamilyLifeSpanVo);
            }

            return userFamilyLifeSpanListVo;
        }
    }
}
