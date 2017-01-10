using System;

public partial class UserMgmt_UserFamilyInsert : WebCommon
{
    public string uiId      = "User00101";
    public string uiTitle   = "가족정보상세";

    public string mode      = string.Empty;
    public int no           = -1;

    protected void Page_Load(object sender, EventArgs e)
    {
        base.userVo = Top1.GetUserVo();

        if (Request["MODE"] != null)
        {
            mode = Request["MODE"].ToString();

            if (Request["MODE"] == "I")
            {
                this.uiTitle = string.Format("{0} (입력)", uiTitle);
            }

            if (Request["MODE"] == "U")
            {
                this.uiTitle = string.Format("{0} (수정)", uiTitle);
            }
        }

        if (Request["NO"] != null) int.TryParse(Request["NO"].ToString(), out no);
    }

    //private void ininData()
    //{
    //    //this.ininDataUserFamilyType();
    //    //this.ininDataUserFamilyBirthYear();
    //    //this.ininDataUserFamilySexType();
    //    //this.ininDataUserFamilyJobType();
    //    //this.ininDataUserFamilyRetirementAge();
    //    //this.ininDataUserFamilyLifeSpan();
    //}

    //private void ininDataUserFamilyType()
    //{
    //    using (FCdbFacade fcdbFacade = new FCdbFacade())
    //    {
    //        UserFamilyTypeListVo userFamilyTypeListVo = fcdbFacade.selectlistUserFamilyTypeVo(new UserFamilyTypeVo());

    //        DataTable dataTable = new DataTable();
    //        dataTable.Columns.Add("userFamilyTypeNo");
    //        dataTable.Columns.Add("userFamilyTypeNm");

    //        foreach (UserFamilyTypeVo userFamilyTypeVo in userFamilyTypeListVo.userFamilyTypeVolist)
    //        {
    //            DataRow dataRow = dataTable.NewRow();
    //            dataRow[0] = userFamilyTypeVo.userFamilyType.userFamilyTypeNo;
    //            dataRow[1] = userFamilyTypeVo.userFamilyType.userFamilyTypeNm;

    //            dataTable.Rows.Add(dataRow);
    //        }

    //        ddlUserFamilyType.DataSource = dataTable;
    //        ddlUserFamilyType.DataValueField    = "userFamilyTypeNo";
    //        ddlUserFamilyType.DataTextField     = "userFamilyTypeNm";
    //        ddlUserFamilyType.DataBind();
    //    }
    //}

    //private void ininDataUserFamilyBirthYear()
    //{
    //    using (FCdbFacade fcdbFacade = new FCdbFacade())
    //    {
    //        UserFamilyBirthYearListVo userFamilyBirthYearListVo = fcdbFacade.selectlistUserFamilyBirthYearVo(new UserFamilyBirthYearVo());

    //        DataTable dataTable = new DataTable();
    //        dataTable.Columns.Add("birthYear");

    //        foreach (UserFamilyBirthYearVo userFamilyBirthYearVo in userFamilyBirthYearListVo.userFamilyBirthYearVoList)
    //        {
    //            DataRow dataRow = dataTable.NewRow();
    //            dataRow[0] = userFamilyBirthYearVo.userFamilyBirthYear.birthYear;

    //            dataTable.Rows.Add(dataRow);
    //        }

    //        ddlFamilyBirthYear.DataSource = dataTable;
    //        ddlFamilyBirthYear.DataValueField = "birthYear";
    //        ddlFamilyBirthYear.DataTextField = "birthYear";
    //        ddlFamilyBirthYear.DataBind();
    //    }
    //}

    //private void ininDataUserFamilySexType()
    //{
    //    using (FCdbFacade fcdbFacade = new FCdbFacade())
    //    {
    //        UserFamilySexTypeListVo userFamilySexTypeListVo = fcdbFacade.selectlistUserFamilySexTypeVo(new UserFamilySexTypeVo());

    //        DataTable dataTable = new DataTable();
    //        dataTable.Columns.Add("sexTypeNo");
    //        dataTable.Columns.Add("sexTypeNm");

    //        foreach (UserFamilySexTypeVo userFamilySexTypeVo in userFamilySexTypeListVo.userFamilySexTypeVoList)
    //        {
    //            DataRow dataRow = dataTable.NewRow();
    //            dataRow[0] = userFamilySexTypeVo.userFamilySexType.sexTypeNo;
    //            dataRow[1] = userFamilySexTypeVo.userFamilySexType.sexTypeNm;

    //            dataTable.Rows.Add(dataRow);
    //        }

    //        ddlUserFamilySexType.DataSource = dataTable;
    //        ddlUserFamilySexType.DataValueField = "sexTypeNo";
    //        ddlUserFamilySexType.DataTextField = "sexTypeNm";
    //        ddlUserFamilySexType.DataBind();
    //    }
    //}

    //private void ininDataUserFamilyJobType()
    //{
    //    using (FCdbFacade fcdbFacade = new FCdbFacade())
    //    {
    //        UserFamilyJobTypeListVo userFamilyJobTypeListVo = fcdbFacade.selectlistUserFamilyJobTypeVo(new UserFamilyJobTypeVo());

    //        DataTable dataTable = new DataTable();
    //        dataTable.Columns.Add("jobTypeNo");
    //        dataTable.Columns.Add("jobTypeNm");

    //        foreach (UserFamilyJobTypeVo userFamilyJobTypeVo in userFamilyJobTypeListVo.userFamilyJobTypeVoList)
    //        {
    //            DataRow dataRow = dataTable.NewRow();
    //            dataRow[0] = userFamilyJobTypeVo.userFamilyJobType.jobTypeNo;
    //            dataRow[1] = userFamilyJobTypeVo.userFamilyJobType.jobTypeNm;

    //            dataTable.Rows.Add(dataRow);
    //        }

    //        ddlUserFamilyJobType.DataSource = dataTable;
    //        ddlUserFamilyJobType.DataValueField = "jobTypeNo";
    //        ddlUserFamilyJobType.DataTextField  = "jobTypeNm";
    //        ddlUserFamilyJobType.DataBind();
    //    }
    //}

    //private void ininDataUserFamilyRetirementAge()
    //{
    //    using (FCdbFacade fcdbFacade = new FCdbFacade())
    //    {
    //        UserFamilyRetirementAgeListVo userFamilyRetirementAgeListVo = fcdbFacade.selectlistUserFamilyRetirementAgeVo(new UserFamilyRetirementAgeVo());

    //        DataTable dataTable = new DataTable();
    //        dataTable.Columns.Add("retirementAge");

    //        foreach (UserFamilyRetirementAgeVo userFamilyRetirementAgeVo in userFamilyRetirementAgeListVo.userFamilyRetirementAgeVoList)
    //        {
    //            DataRow dataRow = dataTable.NewRow();
    //            dataRow[0] = userFamilyRetirementAgeVo.userFamilyRetirementAge.retirementAge;

    //            dataTable.Rows.Add(dataRow);
    //        }

    //        ddlUserFamilyRetirementAge.DataSource = dataTable;
    //        ddlUserFamilyRetirementAge.DataValueField = "retirementAge";
    //        ddlUserFamilyRetirementAge.DataTextField = "retirementAge";
    //        ddlUserFamilyRetirementAge.DataBind();
    //    }
    //}

    //private void ininDataUserFamilyLifeSpan()
    //{
    //    using (FCdbFacade fcdbFacade = new FCdbFacade())
    //    {
    //        UserFamilyLifeSpanListVo userFamilyLifeSpanListVo = fcdbFacade.selectlistUserFamilyLifeSpanVo(new UserFamilyLifeSpanVo());

    //        DataTable dataTable = new DataTable();
    //        dataTable.Columns.Add("lifeSpan");

    //        foreach (UserFamilyLifeSpanVo userFamilyLifeSpanVo in userFamilyLifeSpanListVo.userFamilyLifeSpanVoList)
    //        {
    //            DataRow dataRow = dataTable.NewRow();
    //            dataRow[0] = userFamilyLifeSpanVo.userFamilyLifeSpan.lifeSpan;

    //            dataTable.Rows.Add(dataRow);
    //        }

    //        ddlUserFamilyLifeSpan.DataSource = dataTable;
    //        ddlUserFamilyLifeSpan.DataValueField = "lifeSpan";
    //        ddlUserFamilyLifeSpan.DataTextField = "lifeSpan";
    //        ddlUserFamilyLifeSpan.DataBind();
    //    }
    //}


   
}