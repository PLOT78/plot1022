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
    internal class UserFamilyJobTypeDao : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public List<UserFamilyJobTypeVo> selectlistUserFamilyJobTypeVo(UserFamilyJobTypeVo userFamilyJobTypeVo)
        {
            List<UserFamilyJobTypeVo> userFamilyJobTypeVoList = new List<UserFamilyJobTypeVo>();

            using (SqlCommon sqlCommon = new SqlCommon())
            {
                string procedureName = "UP_USER_FAMILY_JOB_TYPE_LIST";

                DataSet ds = sqlCommon.ExecuteProcedure(procedureName, null);

                if ((ds != null)
                    && (ds.Tables != null) && (ds.Tables[0] != null)
                    && (ds.Tables[0].Rows.Count > 0) && (ds.Tables[0].Rows[0] != null))
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        UserFamilyJobTypeVo userFamilyJobTypeVoResult = new UserFamilyJobTypeVo();

                        userFamilyJobTypeVoResult.userFamilyJobType.jobTypeNo = int.Parse(dr["JOB_TYPE_NO"].ToString());
                        userFamilyJobTypeVoResult.userFamilyJobType.jobTypeNm = dr["JOB_TYPE_NM"].ToString();

                        userFamilyJobTypeVoList.Add(userFamilyJobTypeVoResult);
                    }
                }
            }

            return userFamilyJobTypeVoList;
        }
    }
}
