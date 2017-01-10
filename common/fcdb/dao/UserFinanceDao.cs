using fc.common.fcdb.domain.vo;
using FC.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace fc.common.fcdb.dao
{
    /// <summary>
    /// 사용자재무Dao
    /// </summary>
    internal class UserFinanceDao : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        /// <summary>
        /// 사용자재무VoList조회
        /// </summary>
        /// <param name="userFinanceVo">사용자재무Vo</param>
        /// <returns>사용자재무Vo</returns>
        public List<UserFinanceVo> selectListUserFinanceVo(UserFinanceVo userFinanceVo)
        {
            List<UserFinanceVo> userFinanceVoList = new List<UserFinanceVo>();

            using (SqlCommon sqlCommon = new SqlCommon())
            {
                string procedureName = "UP_USER_FINANCE_LIST";

                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@USER_ID", userFinanceVo.userFinance.userId));

                DataSet ds = sqlCommon.ExecuteProcedure(procedureName, sqlParameters);

                if ((ds != null)
                    && (ds.Tables != null) && (ds.Tables[0] != null)
                    && (ds.Tables[0].Rows.Count > 0) && (ds.Tables[0].Rows[0] != null))
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        UserFinanceVo userFinanceVoResult = new UserFinanceVo();

                        userFinanceVoResult.userFinance.userId                              = dr["USER_ID"].ToString();
                        userFinanceVoResult.userFinance.userFinanceCatalogId                = dr["USER_FINANCE_CATALOG_ID"].ToString();

                        userFinanceVoResult.userFinanceCatalog.userFinanceCatalogId         = dr["USER_FINANCE_CATALOG_ID"].ToString();
                        userFinanceVoResult.userFinanceCatalog.userFinanceCatalogNm         = dr["USER_FINANCE_CATALOG_NM"].ToString();
                        userFinanceVoResult.userFinanceCatalog.userFinanceCatalogSubgroupNo = int.Parse(dr["USER_FINANCE_CATALOG_SUBGROUP_NO"].ToString());

                        userFinanceVoResult.userFinance.price                               = int.Parse(dr["PRICE"].ToString());

                        userFinanceVoList.Add(userFinanceVoResult);
                    }
                }
            }

            return userFinanceVoList;
        }

        /// <summary>
        /// 사용자재무Vo수정
        /// </summary>
        /// <param name="userFamilyVo">사용자재무Vo</param>
        public void updateUserFinanceVo(UserFinanceVo userFinanceVo)
        {
            using (SqlCommon sqlCommon = new SqlCommon())
            {
                string procedureName = "UP_USER_FINANCE_UPDATE";

                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@USER_ID",                  userFinanceVo.userFinance.userId));
                sqlParameters.Add(new SqlParameter("@USER_FINANCE_CATALOG_ID",  userFinanceVo.userFinance.userFinanceCatalogId));
                sqlParameters.Add(new SqlParameter("@PRICE",                    userFinanceVo.userFinance.price));

                sqlCommon.ExecuteProcedure(procedureName, sqlParameters);
            }
        }
    }
}
