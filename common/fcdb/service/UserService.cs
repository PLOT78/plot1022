using fc.common.fcdb.dao;
using fc.common.fcdb.domain.vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.service
{
    internal class UserService : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public void insertUserVo(UserVo UserVo)
        {
            using (UserDao userDao = new UserDao())
            {
                userDao.insertUserVo(UserVo);
            }
        }

        public UserVo selectUserVo(UserVo UserVo)
        {
            UserVo userVo = new UserVo();

            using (UserDao userDao = new UserDao())
            {
                userVo = userDao.selectUserVo(UserVo);
            }

            return userVo;
        }

        public void updateUserVo(UserVo UserVo)
        {
            using (UserDao userDao = new UserDao())
            {
                userDao.updateUserVo(UserVo);
            }
        }

        public void deleteUserVo(UserVo UserVo)
        {
            using (UserDao userDao = new UserDao())
            {
                userDao.deleteUserVo(UserVo);
            }
        }
    }
}
