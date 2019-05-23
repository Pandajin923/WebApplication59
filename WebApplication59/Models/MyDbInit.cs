using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication59.Models
{
    public class MyDbInit
         : System.Data.Entity.CreateDatabaseIfNotExists<MyDb>
    {
        protected override void Seed(MyDb context)
        {
            base.Seed(context);


            context.Xueshengxinxis.Add(new Xueshengxinxi
            {
                Xueshengxuehao = "20180001",
                Xueshengxingming = "王五",
                Xueshengxingbie = "男"

            });
            context.Xueshengxinxis.Add(new Xueshengxinxi
            {
                Xueshengxuehao = "20180002",
                Xueshengxingming = "小六",
                Xueshengxingbie = "女"
            });


        }


    }
}