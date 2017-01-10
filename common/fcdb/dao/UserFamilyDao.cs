using fc.common.fcdb.domain.vo;
using FC.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.dao
{
    /// <summary>
    /// 사용자가족Dao
    /// </summary>
    internal class UserFamilyDao : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        /// <summary>
        /// 사용자가족Vo추가
        /// </summary>
        /// <param name="userFamilyVo">사용자가족Vo</param>
        /// <returns>사용자가족Vo</returns>
        public void insertUserFamilyVo(UserFamilyVo userFamilyVo)
        {
            using (SqlCommon sqlCommon = new SqlCommon())
            {
                string procedureName = "UP_USER_FAMILY_INSERT";

                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@USER_ID",              userFamilyVo.userFamily.userId));
                sqlParameters.Add(new SqlParameter("@USER_FAMILY_TYPE_NO",  userFamilyVo.userFamily.userFamilyTypeNo));
                sqlParameters.Add(new SqlParameter("@USER_FAMILY_NM",       userFamilyVo.userFamily.userFamilyNm));
                sqlParameters.Add(new SqlParameter("@BIRTH_YEAR",           userFamilyVo.userFamily.birthYear));
                sqlParameters.Add(new SqlParameter("@SEX_TYPE_NO",          userFamilyVo.userFamily.sexTypeNo));
                sqlParameters.Add(new SqlParameter("@JOB_TYPE_NO",          userFamilyVo.userFamily.jobTypeNo));

                if(userFamilyVo.userFamily.retirementAge != null)
                    sqlParameters.Add(new SqlParameter("@RETIREMENT_AGE",   userFamilyVo.userFamily.retirementAge));

                if (userFamilyVo.userFamily.lifeSpan != null)
                    sqlParameters.Add(new SqlParameter("@LIFE_SPAN",        userFamilyVo.userFamily.lifeSpan));

                sqlCommon.ExecuteProcedure(procedureName, sqlParameters);
            }
        }

        /// <summary>
        /// 사용자가족Vo조회
        /// </summary>
        /// <param name="userFamilyVo">사용자가족Vo</param>
        /// <returns>사용자가족Vo</returns>
        public UserFamilyVo selectUserFamilyVo(UserFamilyVo userFamilyVo)
        {
            UserFamilyVo rtnUserFamilyVo = new UserFamilyVo();

            using (SqlCommon sqlCommon = new SqlCommon())
            {
                string procedureName = "UP_USER_FAMILY_SELECT";

                List<SqlParameter> sqlParameters = new List<SqlParameter>();

                if (userFamilyVo.userFamily.userFamilyNo != -1)
                    sqlParameters.Add(new SqlParameter("@USER_FAMILY_NO",       userFamilyVo.userFamily.userFamilyNo));
                if (userFamilyVo.userFamily.userId != null)
                    sqlParameters.Add(new SqlParameter("@USER_ID",              userFamilyVo.userFamily.userId));
                if (userFamilyVo.userFamily.userFamilyTypeNo != -1)
                    sqlParameters.Add(new SqlParameter("@USER_FAMILY_TYPE_NO",  userFamilyVo.userFamily.userFamilyTypeNo));

                DataSet ds = sqlCommon.ExecuteProcedure(procedureName, sqlParameters);

                if ((ds != null)
                    && (ds.Tables != null) && (ds.Tables[0] != null)
                    && (ds.Tables[0].Rows.Count > 0) && (ds.Tables[0].Rows[0] != null))
                {
                    rtnUserFamilyVo.userFamily.userFamilyNo = int.Parse(ds.Tables[0].Rows[0]["USER_FAMILY_NO"].ToString());
                    rtnUserFamilyVo.userFamily.userId = ds.Tables[0].Rows[0]["USER_ID"].ToString();
                    rtnUserFamilyVo.userFamily.userFamilyTypeNo = int.Parse(ds.Tables[0].Rows[0]["USER_FAMILY_TYPE_NO"].ToString());

                    rtnUserFamilyVo.userFamilyType.userFamilyTypeNo = int.Parse(ds.Tables[0].Rows[0]["USER_FAMILY_TYPE_NO"].ToString());
                    rtnUserFamilyVo.userFamilyType.userFamilyTypeNm = ds.Tables[0].Rows[0]["USER_FAMILY_TYPE_NM"].ToString();

                    rtnUserFamilyVo.userFamily.userFamilyNm = ds.Tables[0].Rows[0]["USER_FAMILY_NM"].ToString();
                    rtnUserFamilyVo.userFamily.birthYear = int.Parse(ds.Tables[0].Rows[0]["BIRTH_YEAR"].ToString());
                    rtnUserFamilyVo.userFamily.sexTypeNo = int.Parse(ds.Tables[0].Rows[0]["SEX_TYPE_NO"].ToString());

                    rtnUserFamilyVo.userFamilySexType.sexTypeNo = int.Parse(ds.Tables[0].Rows[0]["SEX_TYPE_NO"].ToString());
                    rtnUserFamilyVo.userFamilySexType.sexTypeNm = ds.Tables[0].Rows[0]["SEX_TYPE_NM"].ToString();

                    rtnUserFamilyVo.userFamily.jobTypeNo = int.Parse(ds.Tables[0].Rows[0]["JOB_TYPE_NO"].ToString());

                    rtnUserFamilyVo.userFamilyJobType.jobTypeNo = int.Parse(ds.Tables[0].Rows[0]["JOB_TYPE_NO"].ToString());
                    rtnUserFamilyVo.userFamilyJobType.jobTypeNm = ds.Tables[0].Rows[0]["JOB_TYPE_NM"].ToString();

                    if ((ds.Tables[0].Rows[0]["RETIREMENT_AGE"] != null) && (ds.Tables[0].Rows[0]["RETIREMENT_AGE"].ToString() != ""))
                        rtnUserFamilyVo.userFamily.retirementAge = int.Parse(ds.Tables[0].Rows[0]["RETIREMENT_AGE"].ToString());
                    else
                        rtnUserFamilyVo.userFamily.retirementAge = null;

                    if ((ds.Tables[0].Rows[0]["LIFE_SPAN"] != null) && (ds.Tables[0].Rows[0]["LIFE_SPAN"].ToString() != ""))
                        rtnUserFamilyVo.userFamily.lifeSpan = int.Parse(ds.Tables[0].Rows[0]["LIFE_SPAN"].ToString());
                    else
                        rtnUserFamilyVo.userFamily.lifeSpan = null;
                }
            }

            return rtnUserFamilyVo;
        }

        /// <summary>
        /// 사용자가족VoList조회
        /// </summary>
        /// <param name="userFamilyVo">사용자가족Vo</param>
        /// <returns>사용자가족VoList</returns>
        public List<UserFamilyVo> selectListUserFamilyVo(UserFamilyVo userFamilyVo)
        {
            List<UserFamilyVo> userFamilyVoList = new List<UserFamilyVo>();

            using (SqlCommon sqlCommon = new SqlCommon())
            {
                string procedureName = "UP_USER_FAMILY_LIST";

                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@USER_ID", userFamilyVo.userFamily.userId));

                DataSet ds = sqlCommon.ExecuteProcedure(procedureName, sqlParameters);

                if ((ds != null)
                    && (ds.Tables != null) && (ds.Tables[0] != null)
                    && (ds.Tables[0].Rows.Count > 0) && (ds.Tables[0].Rows[0] != null))
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        UserFamilyVo userFamilyVoResult = new UserFamilyVo();

                        userFamilyVoResult.userFamily.userFamilyNo = int.Parse(dr["USER_FAMILY_NO"].ToString());
                        userFamilyVoResult.userFamily.userId = dr["USER_ID"].ToString();
                        userFamilyVoResult.userFamily.userFamilyTypeNo = int.Parse(dr["USER_FAMILY_TYPE_NO"].ToString());

                        userFamilyVoResult.userFamilyType.userFamilyTypeNo = int.Parse(dr["USER_FAMILY_TYPE_NO"].ToString());
                        userFamilyVoResult.userFamilyType.userFamilyTypeNm = dr["USER_FAMILY_TYPE_NM"].ToString();

                        userFamilyVoResult.userFamily.userFamilyNm = dr["USER_FAMILY_NM"].ToString();
                        userFamilyVoResult.userFamily.birthYear = int.Parse(dr["BIRTH_YEAR"].ToString());
                        userFamilyVoResult.userFamily.sexTypeNo = int.Parse(dr["SEX_TYPE_NO"].ToString());

                        userFamilyVoResult.userFamilySexType.sexTypeNo = int.Parse(dr["SEX_TYPE_NO"].ToString());
                        userFamilyVoResult.userFamilySexType.sexTypeNm = dr["SEX_TYPE_NM"].ToString();

                        userFamilyVoResult.userFamily.jobTypeNo = int.Parse(dr["JOB_TYPE_NO"].ToString());

                        userFamilyVoResult.userFamilyJobType.jobTypeNo = int.Parse(dr["JOB_TYPE_NO"].ToString());
                        userFamilyVoResult.userFamilyJobType.jobTypeNm = dr["JOB_TYPE_NM"].ToString();

                        if ( (dr["RETIREMENT_AGE"] != null) && (dr["RETIREMENT_AGE"].ToString() != "") )
                            userFamilyVoResult.userFamily.retirementAge = int.Parse(dr["RETIREMENT_AGE"].ToString());
                        else
                            userFamilyVoResult.userFamily.retirementAge = null;

                        if ((dr["LIFE_SPAN"] != null) && (dr["LIFE_SPAN"].ToString() != ""))
                            userFamilyVoResult.userFamily.lifeSpan = int.Parse(dr["LIFE_SPAN"].ToString());
                        else
                            userFamilyVoResult.userFamily.lifeSpan = null;

                        userFamilyVoList.Add(userFamilyVoResult);
                    }
                }
            }           

            return userFamilyVoList;
        }

        /// <summary>
        /// 사용자가족Vo수정
        /// </summary>
        /// <param name="userFamilyVo">사용자가족Vo</param>
        public void updateUserFamilyVo(UserFamilyVo userFamilyVo)
        {
            using (SqlCommon sqlCommon = new SqlCommon())
            {
                string procedureName = "UP_USER_FAMILY_UPDATE";

                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@USER_FAMILY_NO", userFamilyVo.userFamily.userFamilyNo));
                sqlParameters.Add(new SqlParameter("@USER_ID", userFamilyVo.userFamily.userId));
                sqlParameters.Add(new SqlParameter("@USER_FAMILY_TYPE_NO", userFamilyVo.userFamily.userFamilyTypeNo));
                sqlParameters.Add(new SqlParameter("@USER_FAMILY_NM", userFamilyVo.userFamily.userFamilyNm));
                sqlParameters.Add(new SqlParameter("@BIRTH_YEAR", userFamilyVo.userFamily.birthYear));
                sqlParameters.Add(new SqlParameter("@SEX_TYPE_NO", userFamilyVo.userFamily.sexTypeNo));
                sqlParameters.Add(new SqlParameter("@JOB_TYPE_NO", userFamilyVo.userFamily.jobTypeNo));

                if (userFamilyVo.userFamily.retirementAge != null)
                    sqlParameters.Add(new SqlParameter("@RETIREMENT_AGE", userFamilyVo.userFamily.retirementAge));

                if (userFamilyVo.userFamily.lifeSpan != null)
                    sqlParameters.Add(new SqlParameter("@LIFE_SPAN", userFamilyVo.userFamily.lifeSpan));

                sqlCommon.ExecuteProcedure(procedureName, sqlParameters);
            }
        }

        /// <summary>
        /// 사용자가족Vo삭제
        /// </summary>
        /// <param name="userFamilyVo">사용자가족Vo</param>
        public void deleteUserFamilyVo(UserFamilyVo userFamilyVo)
        {
            using (SqlCommon sqlCommon = new SqlCommon())
            {
                string procedureName = "UP_USER_FAMILY_DELETE";

                List<SqlParameter> sqlParameters = new List<SqlParameter>();

                sqlParameters.Add(new SqlParameter("@USER_FAMILY_NO", userFamilyVo.userFamily.userFamilyNo));

                sqlCommon.ExecuteProcedure(procedureName, sqlParameters);
            }
        }
    }
}
