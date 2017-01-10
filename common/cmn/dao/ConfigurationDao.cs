using fc.common.cmn.domain.vo;
using FC.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace fc.common.cmn.dao
{
    /// <summary>
    /// 구성Dao
    /// </summary>
    internal class ConfigurationDao : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        /// <summary>
        /// 구성Vo조회
        /// </summary>
        /// <param name="configurationVo">구성Vo</param>
        /// <returns>구성Vo</returns>
        public ConfigurationVo selectConfigurationVo(ConfigurationVo configurationVo)
        {
            ConfigurationVo rtnConfigurationVo = new ConfigurationVo();

            using (SqlCommon sqlCommon = new SqlCommon())
            {
                string procedureName = "UP_CONFIGURATION_SELECT";

                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@CONFIGURATION_ID", configurationVo.configuration.configurationId));

                DataSet ds = sqlCommon.ExecuteProcedure(procedureName, sqlParameters);

                if ((ds != null)
                    && (ds.Tables != null) && (ds.Tables[0] != null)
                    && (ds.Tables[0].Rows.Count > 0) && (ds.Tables[0].Rows[0] != null))
                {
                    rtnConfigurationVo.configuration.configurationId            = ds.Tables[0].Rows[0]["CONFIGURATION_ID"].ToString();
                    rtnConfigurationVo.configuration.configurationNm            = ds.Tables[0].Rows[0]["CONFIGURATION_NM"].ToString();
                    rtnConfigurationVo.configuration.configurationVal           = ds.Tables[0].Rows[0]["CONFIGURATION_VAL"].ToString();

                    rtnConfigurationVo.configuration.configurationUsed          = bool.Parse(ds.Tables[0].Rows[0]["CONFIGURATION_USED"].ToString());
                    rtnConfigurationVo.configuration.configurationSubgroupNo    = int.Parse(ds.Tables[0].Rows[0]["CONFIGURATION_SUBGROUP_NO"].ToString());
                }
            }

            return rtnConfigurationVo;
        }
    }
}
