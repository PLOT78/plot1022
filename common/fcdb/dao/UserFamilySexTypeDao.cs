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
    internal class UserFamilySexTypeDao : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public List<UserFamilySexTypeVo> selectlistUserFamilySexTypeVo(UserFamilySexTypeVo userFamilySexTypeVo)
        {
            List<UserFamilySexTypeVo> userFamilySexTypeVoList = new List<UserFamilySexTypeVo>();

            using (SqlCommon sqlCommon = new SqlCommon())
            {
                string procedureName = "UP_USER_FAMILY_SEX_TYPE_LIST";

                DataSet ds = sqlCommon.ExecuteProcedure(procedureName, null);

                if ((ds != null)
                    && (ds.Tables != null) && (ds.Tables[0] != null)
                    && (ds.Tables[0].Rows.Count > 0) && (ds.Tables[0].Rows[0] != null))
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        UserFamilySexTypeVo userFamilySexTypeVoResult = new UserFamilySexTypeVo();

                        userFamilySexTypeVoResult.userFamilySexType.sexTypeNo = int.Parse(dr["SEX_TYPE_NO"].ToString());
                        userFamilySexTypeVoResult.userFamilySexType.sexTypeNm = dr["SEX_TYPE_NM"].ToString();

                        userFamilySexTypeVoList.Add(userFamilySexTypeVoResult);
                    }
                }
            }

            return userFamilySexTypeVoList;
        }
    }
}
