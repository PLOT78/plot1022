using fc.common.cmn.domain.vo;
using fc.common.cmn.facade;
using fc.common.fcdb.domain.vo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;

/// <summary>
/// WebCommon의 요약 설명입니다.
/// </summary>
public class WebCommon : System.Web.UI.Page
{
    protected string home = string.Empty;

    protected UserVo userVo = null;

    public WebCommon()
    {
        this.home = getConfiguration("HOME");
    }

    private string getConfiguration(string configurationId)
    {
        ConfigurationVo rtnConfigurationVo = new ConfigurationVo();

        using (FCcmnFacade fccmnFacade = new FCcmnFacade())
        {
            ConfigurationVo configurationVo = new ConfigurationVo();
            configurationVo.configuration.configurationId = configurationId;

            rtnConfigurationVo = fccmnFacade.selectConfigurationVo(configurationVo);
        }

        if ( (rtnConfigurationVo == null) || (rtnConfigurationVo.configuration == null)
            || (rtnConfigurationVo.configuration.configurationUsed == false) )
        {
            return "";
        }

        return rtnConfigurationVo.configuration.configurationVal;
    }
}