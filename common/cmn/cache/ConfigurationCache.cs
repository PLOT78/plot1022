using fc.common.cmn.dao;
using fc.common.cmn.domain.vo;
using System;
using System.Runtime.Caching;

namespace fc.common.cmn.cache
{
    /// <summary>
    /// 구성Cache
    /// </summary>
    internal class ConfigurationCache : IDisposable
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
            ObjectCache cache = MemoryCache.Default;
            ConfigurationVo configurationVoHOME = cache["HOME"] as ConfigurationVo;

            if (configurationVoHOME != null)
            {
                rtnConfigurationVo = configurationVoHOME;
            }
            else
            {
                using (ConfigurationDao configurationDao = new ConfigurationDao())
                {
                    rtnConfigurationVo = configurationDao.selectConfigurationVo(configurationVo);

                    CacheItemPolicy policy = new CacheItemPolicy();
                    policy.AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(10);
                    cache.Set("HOME", rtnConfigurationVo, policy);
                }
            }

            return rtnConfigurationVo;
        }
    }
}
