using fc.common.fcdb.dao;
using fc.common.fcdb.domain.vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.service
{
    internal class SurveyCatalogService : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public SurveyCatalogListVo listSurveyCatalogVo(SurveyCatalogVo surveyCatalogVo)
        {
            SurveyCatalogListVo surveyCatalogListVo = new SurveyCatalogListVo();
            List<SurveyCatalogVo> surveyCatalogVolist = new List<SurveyCatalogVo>();

            using (SurveyCatalogDao surveyCatalogDao = new SurveyCatalogDao())
            {
                surveyCatalogVolist = surveyCatalogDao.listSurveyCatalogVo(surveyCatalogVo);
            }

            surveyCatalogListVo.surveyCatalogVolist = surveyCatalogVolist;

            return surveyCatalogListVo;
        }
    }
}
