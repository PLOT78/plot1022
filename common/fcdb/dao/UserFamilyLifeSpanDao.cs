using fc.common.fcdb.domain.vo;
using FC.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.dao
{
    internal class UserFamilyLifeSpanDao : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public List<UserFamilyLifeSpanVo> selectlistUserFamilyLifeSpanVo(UserFamilyLifeSpanVo userFamilyLifeSpanVo)
        {
            List<UserFamilyLifeSpanVo> userFamilyLifeSpanVoList = new List<UserFamilyLifeSpanVo>();

            using (SqlCommon sqlCommon = new SqlCommon())
            {
                string procedureName = "UP_USER_FAMILY_LIFE_SPAN_LIST";

                DataSet ds = sqlCommon.ExecuteProcedure(procedureName, null);

                if ((ds != null)
                    && (ds.Tables != null) && (ds.Tables[0] != null)
                    && (ds.Tables[0].Rows.Count > 0) && (ds.Tables[0].Rows[0] != null))
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        UserFamilyLifeSpanVo userFamilyLifeSpanVoResult = new UserFamilyLifeSpanVo();

                        userFamilyLifeSpanVoResult.userFamilyLifeSpan.lifeSpan = int.Parse(dr["LIFE_SPAN"].ToString());

                        userFamilyLifeSpanVoList.Add(userFamilyLifeSpanVoResult);
                    }
                }
            }

            return userFamilyLifeSpanVoList;
        }
    }
}
