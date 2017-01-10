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
    internal class SurveyCatalogDao : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public List<SurveyCatalogVo> listSurveyCatalogVo(SurveyCatalogVo surveyCatalogVo)
        {
            List<SurveyCatalogVo> surveyCatalogVoList = new List<SurveyCatalogVo>();

            using (SqlCommon sqlCommon = new SqlCommon())
            {
                string procedureName = "UP_SURVEY_CATALOG_LIST";

                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@SURVEY_CATALOG_GROUP_NO", surveyCatalogVo.surveyCatalog.surveyCatalogGroupNo));

                DataSet ds = sqlCommon.ExecuteProcedure(procedureName, sqlParameters);

                if ((ds != null)
                    && (ds.Tables != null) && (ds.Tables[0] != null)
                    && (ds.Tables[0].Rows.Count > 0) && (ds.Tables[0].Rows[0] != null))
                {
                    foreach(DataRow dr in ds.Tables[0].Rows)
                    {
                        SurveyCatalogVo surveyCatalogVoResult = new SurveyCatalogVo();

                        surveyCatalogVoResult.surveyCatalog.surveyCatalogNo                         = int.Parse(dr["SURVEY_CATALOG_NO"].ToString());

                        surveyCatalogVoResult.surveyCatalog.surveyCatalogGroupNo                    = int.Parse(dr["SURVEY_CATALOG_GROUP_NO"].ToString());
                        surveyCatalogVoResult.surveyCatalogGroup.surveyCatalogGroupNo               = int.Parse(dr["SURVEY_CATALOG_GROUP_NO"].ToString());
                        surveyCatalogVoResult.surveyCatalogGroup.surveyCatalogGroupName             = dr["SURVEY_CATALOG_GROUP_NAME"].ToString();

                        surveyCatalogVoResult.surveyCatalog.surveyCatalogQuestionNo                 = int.Parse(dr["SURVEY_CATALOG_QUESTION_NO"].ToString());
                        surveyCatalogVoResult.surveyCatalogQuestion.surveyCatalogQuestionNo         = int.Parse(dr["SURVEY_CATALOG_QUESTION_NO"].ToString());
                        surveyCatalogVoResult.surveyCatalog.surveyCatalogQuestionAlias              = dr["SURVEY_CATALOG_QUESTION_ALIAS"].ToString();
                        surveyCatalogVoResult.surveyCatalogQuestion.surveyCatalogQuestionContents   = dr["SURVEY_CATALOG_QUESTION_CONTENTS"].ToString();

                        surveyCatalogVoResult.surveyCatalog.surveyCatalogAnswerNo                   = int.Parse(dr["SURVEY_CATALOG_ANSWER_NO"].ToString());
                        surveyCatalogVoResult.surveyCatalogAnswer.surveyCatalogAnswerNo             = int.Parse(dr["SURVEY_CATALOG_ANSWER_NO"].ToString());
                        surveyCatalogVoResult.surveyCatalog.surveyCatalogAnswerAlias                = dr["SURVEY_CATALOG_ANSWER_ALIAS"].ToString();
                        surveyCatalogVoResult.surveyCatalogAnswer.surveyCatalogAnswerContents       = dr["SURVEY_CATALOG_ANSWER_CONTENTS"].ToString();

                        surveyCatalogVoResult.surveyCatalog.score                                   = float.Parse(dr["SCORE"].ToString());

                        surveyCatalogVoList.Add(surveyCatalogVoResult);
                    }
                }
            }

            return surveyCatalogVoList;
        }
    }
}
