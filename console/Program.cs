using fc.common.fcdb.domain.vo;
using fc.common.fcdb.facade;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

using Microsoft.VisualBasic;

namespace FC.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            double rate = 0.05;             // 5% /12를 해야 월 이율
            double nPer = 30;               // 기간(년) *12를 해야 1년=12개월로 표현
            double pmt = 300000;            // 100000 // 월납입금액 은행에 내는 거라 마이너스

            double fv = 0;
            // fv = Math.Round(fv);

            System.Console.WriteLine(string.Format("{0}\t{1}\t\t{2}\t{3}\t{4:#,##0}", "연령", "납입액", "기간(년)", "이율", "적립액(연말기준)"));

            for (int i=0; i< nPer; i++)
            {
                fv = Financial.FV(rate / 12, (i+1) * 12, pmt * (-1));

                System.Console.WriteLine(string.Format("{0}\t{1:#,##0}\t\t{2}\t\t{3}\t{4:#,##0}", i+30, pmt, (i + 1), rate, fv));
            }

            

            //string s = "123";
            //bool bResult1, bResult2;
            //bResult1 = Information.IsNumeric(s);
            //// bResult1 now equals true
            //s = "Hello";
            //bResult2 = Information.IsNumeric(s);
            // bResult2 now equals false

            //Microsoft.VisualBasic.

            //double pmt = Financial..Pmt(rate, nper, pv, fv, due); // parameters are the same as in VB.NET

            //using (TransactionScope scope = new TransactionScope())
            //using (FCdbFacade fcCdbFacade = new FCdbFacade())
            //{
            //    UserVo userVo = new UserVo();
            //    userVo.user.userId = "USER002";
            //    userVo.user.userNm = "사용자002";

            //    fcCdbFacade.insertUserVo(userVo);
            //    userVo = fcCdbFacade.selectUserVo(userVo);
            //    System.Console.WriteLine(string.Format("INSERT 결과 : \t  USER_ID = {0} \t , USER_NM = {1}", userVo.user.userId, userVo.user.userNm));

            //    fcCdbFacade.updateUserVo(userVo);
            //    userVo = fcCdbFacade.selectUserVo(userVo);
            //    System.Console.WriteLine(string.Format("UPDATE 결과 : \t  USER_ID = {0} \t , USER_NM = {1}", userVo.user.userId, userVo.user.userNm));

            //    fcCdbFacade.deleteUserVo(userVo);
            //    userVo = fcCdbFacade.selectUserVo(userVo);
            //    System.Console.WriteLine(string.Format("DELETE 결과 : \t  USER_ID = {0} \t , USER_NM = {1}", userVo.user.userId, userVo.user.userNm));

            //    scope.Complete();
            //}


        }
    }
}
