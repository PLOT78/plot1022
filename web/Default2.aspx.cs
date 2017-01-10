using fc.common.fcdb.facade;
using fc.common.fcdb.domain;
using fc.common.fcdb.domain.vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    List<int> showQuestionList;

    protected void Page_Load(object sender, EventArgs e)
    {
        showQuestionList = new List<int>();

        using (FCdbFacade fcdbFacade = new FCdbFacade())
        {
            SurveyCatalogVo surveyCatalogVo = new SurveyCatalogVo();
            surveyCatalogVo.surveyCatalog.surveyCatalogGroupNo = 1;

            SurveyCatalogListVo surveyCatalogListVo = fcdbFacade.listSurveyCatalogVo(surveyCatalogVo);

            listResult.DataSource = surveyCatalogListVo.surveyCatalogVolist;
            listResult.DataBind();
        }
    }


    public bool isShowQuestion(int surveyCatalogQuestionNo)
    {
        bool bShowQuestion = false;

        foreach(int showQuestion in showQuestionList)
        {
            if (showQuestion == surveyCatalogQuestionNo)
            {
                bShowQuestion = true;
                return bShowQuestion;
            }
        }

        showQuestionList.Add(surveyCatalogQuestionNo);

        return bShowQuestion;
    }
}