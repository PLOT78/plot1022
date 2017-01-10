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
    internal class UserFamilyBirthYearDao : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public List<UserFamilyBirthYearVo> selectlistUserFamilyTypeVo(UserFamilyBirthYearVo userFamilyBirthYearVo)
        {
            List<UserFamilyBirthYearVo> userFamilyBirthYearVoList = new List<UserFamilyBirthYearVo>();

            using (SqlCommon sqlCommon = new SqlCommon())
            {
                string procedureName = "UP_USER_FAMILY_BIRTH_YEAR_LIST";

                DataSet ds = sqlCommon.ExecuteProcedure(procedureName, null);

                if ((ds != null)
                    && (ds.Tables != null) && (ds.Tables[0] != null)
                    && (ds.Tables[0].Rows.Count > 0) && (ds.Tables[0].Rows[0] != null))
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        UserFamilyBirthYearVo userFamilyBirthYearVoResult = new UserFamilyBirthYearVo();

                        userFamilyBirthYearVoResult.userFamilyBirthYear.birthYear       = int.Parse(dr["BIRTH_YEAR"].ToString());

                        if ((dr["DEFAULT_VAL"] != null) && (dr["DEFAULT_VAL"].ToString() == "Y"))
                            userFamilyBirthYearVoResult.userFamilyBirthYear.defaultVal  = true;

                        userFamilyBirthYearVoList.Add(userFamilyBirthYearVoResult);
                    }
                }
            }

            return userFamilyBirthYearVoList;
        }
    }
}
