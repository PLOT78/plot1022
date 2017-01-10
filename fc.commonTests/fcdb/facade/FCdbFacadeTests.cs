using Microsoft.VisualStudio.TestTools.UnitTesting;
using fc.common.fcdb.facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using fc.common.fcdb.domain.vo;

namespace fc.common.fcdb.facade.Tests
{
    [TestClass()]
    public class FCdbFacadeTests
    {
        UserVo userVo = null;

        public FCdbFacadeTests()
        {
            userVo = new UserVo();
            userVo.user.userId = "USER002";
            userVo.user.userNm = "사용자002";
        }

        [TestMethod()]
        public void insertUserVoTest()
        {
            using (TransactionScope scope = new TransactionScope())
            using (FCdbFacade fcCdbFacade = new FCdbFacade())
            {
                fcCdbFacade.insertUserVo(userVo);
                scope.Complete();
            }
        }

        [TestMethod()]
        public void selectUserVoTest()
        {
            using (TransactionScope scope = new TransactionScope())
            using (FCdbFacade fcCdbFacade = new FCdbFacade())
            {
                fcCdbFacade.selectUserVo(userVo);
                scope.Complete();
            }
        }

        [TestMethod()]
        public void updateUserVoTest()
        {
            using (TransactionScope scope = new TransactionScope())
            using (FCdbFacade fcCdbFacade = new FCdbFacade())
            {
                fcCdbFacade.updateUserVo(userVo);
                scope.Complete();
            }
        }

        [TestMethod()]
        public void deleteUserVoTest()
        {
            using (TransactionScope scope = new TransactionScope())
            using (FCdbFacade fcCdbFacade = new FCdbFacade())
            {
                fcCdbFacade.deleteUserVo(userVo);
                scope.Complete();
            }
        }
    }
}