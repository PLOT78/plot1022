using fc.common.cmn.domain.vo;
using fc.common.cmn.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.cmn.facade
{
    public class FCcmnFacade : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        #region ConfigurationService(구성Service) selectConfigurationVo(구성Vo조회)
        /// <summary>
        /// 구성Vo조회
        /// </summary>
        /// <param name="configurationVo">구성Vo</param>
        /// <returns>구성Vo</returns>
        public ConfigurationVo selectConfigurationVo(ConfigurationVo configurationVo)
        {
            ConfigurationVo rtnConfigurationVo = new ConfigurationVo();

            using (ConfigurationService configurationService = new ConfigurationService())
            {
                rtnConfigurationVo = configurationService.selectConfigurationVo(configurationVo);
            }

            return rtnConfigurationVo;
        }
        #endregion
    }
}
