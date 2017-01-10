using fc.common.cmn.cache;
using fc.common.cmn.domain.vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.cmn.service
{
    /// <summary>
    /// 구성Service
    /// </summary>
    internal class ConfigurationService : IDisposable
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

            using (ConfigurationCache configurationCache = new ConfigurationCache())
            {
                rtnConfigurationVo = configurationCache.selectConfigurationVo(configurationVo);

                if ((rtnConfigurationVo == null) || (rtnConfigurationVo.configuration == null)
                     || (rtnConfigurationVo.configuration.configurationUsed == false))
                {
                    rtnConfigurationVo = null;
                }
            }

            return rtnConfigurationVo;
        }
    }
}
