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
    internal class UserFamilyTypeDao : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public List<UserFamilyTypeVo> selectlistUserFamilyTypeVo(UserFamilyTypeVo userFamilyTypeVo)
        {
            List<UserFamilyTypeVo> userFamilyTypeVoList = new List<UserFamilyTypeVo>();

            using (SqlCommon sqlCommon = new SqlCommon())
            {
                string procedureName = "UP_USER_FAMILY_TYPE_LIST";

                DataSet ds = sqlCommon.ExecuteProcedure(procedureName, null);

                if ((ds != null)
                    && (ds.Tables != null) && (ds.Tables[0] != null)
                    && (ds.Tables[0].Rows.Count > 0) && (ds.Tables[0].Rows[0] != null))
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        UserFamilyTypeVo userFamilyTypeVoResult = new UserFamilyTypeVo();

                        userFamilyTypeVoResult.userFamilyType.userFamilyTypeNo = int.Parse(dr["USER_FAMILY_TYPE_NO"].ToString());
                        userFamilyTypeVoResult.userFamilyType.userFamilyTypeNm = dr["USER_FAMILY_TYPE_NM"].ToString();

                        userFamilyTypeVoList.Add(userFamilyTypeVoResult);
                    }
                }
            }

            return userFamilyTypeVoList;
        }
    }
}
