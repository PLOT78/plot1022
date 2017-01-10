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
    internal class UserDao : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public void insertUserVo(UserVo userVo)
        {
            using (SqlCommon sqlCommon = new SqlCommon())
            {
                string procedureName = "UP_USER_INSERT";

                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@USER_ID",          userVo.user.userId));
                sqlParameters.Add(new SqlParameter("@USER_NM",          userVo.user.userNm));
                sqlParameters.Add(new SqlParameter("@USER_GRADE_NO",    userVo.user.userGradeNo));

                DataSet ds = sqlCommon.ExecuteProcedure(procedureName, sqlParameters);
            }
        }

        public UserVo selectUserVo(UserVo UserVo)
        {
            UserVo userVo = new UserVo();

            using (SqlCommon sqlCommon = new SqlCommon())
            {
                string procedureName = "UP_USER_SELECT";

                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@USER_ID",  UserVo.user.userId));
                sqlParameters.Add(new SqlParameter("@PWD",      UserVo.user.pwd));

                DataSet ds = sqlCommon.ExecuteProcedure(procedureName, sqlParameters);

                if ( (ds != null) 
                    && (ds.Tables != null)  && (ds.Tables[0] != null) 
                    && (ds.Tables[0].Rows.Count > 0) && (ds.Tables[0].Rows[0] != null) )
                {
                    userVo.user.userId              = ds.Tables[0].Rows[0]["USER_ID"].ToString();
                    userVo.user.userNm              = ds.Tables[0].Rows[0]["USER_NM"].ToString();
                    userVo.user.userGradeNo         = ds.Tables[0].Rows[0]["USER_GRADE_NO"].ToString();

                    userVo.userGrade.userGradeNo    = ds.Tables[0].Rows[0]["USER_GRADE_NO"].ToString();
                    userVo.userGrade.userGradeNm    = ds.Tables[0].Rows[0]["USER_GRADE_NM"].ToString();
                }
            }

            return userVo;
        }

        public void updateUserVo(UserVo userVo)
        {
            using (SqlCommon sqlCommon = new SqlCommon())
            {
                string procedureName = "UP_USER_UPDATE";

                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@USER_ID",          userVo.user.userId));
                sqlParameters.Add(new SqlParameter("@USER_NM",          userVo.user.userNm));
                sqlParameters.Add(new SqlParameter("@USER_GRADE_NO",    userVo.user.userGradeNo));

                DataSet ds = sqlCommon.ExecuteProcedure(procedureName, sqlParameters);
            }
        }

        public void deleteUserVo(UserVo userVo)
        {
            using (SqlCommon sqlCommon = new SqlCommon())
            {
                string procedureName = "UP_USER_DELETE";

                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@USER_ID",          userVo.user.userId));

                DataSet ds = sqlCommon.ExecuteProcedure(procedureName, sqlParameters);
            }
        }
    }
}
