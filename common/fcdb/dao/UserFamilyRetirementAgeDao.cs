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
    internal class UserFamilyRetirementAgeDao : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public List<UserFamilyRetirementAgeVo> selectlistUserFamilyRetirementAgeVo(UserFamilyRetirementAgeVo userFamilyRetirementAgeVo)
        {
            List<UserFamilyRetirementAgeVo> userFamilyRetirementAgeVoList = new List<UserFamilyRetirementAgeVo>();

            using (SqlCommon sqlCommon = new SqlCommon())
            {
                string procedureName = "UP_USER_FAMILY_RETIREMENT_AGE_LIST";

                DataSet ds = sqlCommon.ExecuteProcedure(procedureName, null);

                if ((ds != null)
                    && (ds.Tables != null) && (ds.Tables[0] != null)
                    && (ds.Tables[0].Rows.Count > 0) && (ds.Tables[0].Rows[0] != null))
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        UserFamilyRetirementAgeVo userFamilyRetirementAgeVoResult = new UserFamilyRetirementAgeVo();

                        userFamilyRetirementAgeVoResult.userFamilyRetirementAge.retirementAge = int.Parse(dr["RETIREMENT_AGE"].ToString());

                        userFamilyRetirementAgeVoList.Add(userFamilyRetirementAgeVoResult);
                    }
                }
            }

            return userFamilyRetirementAgeVoList;
        }
    }
}
