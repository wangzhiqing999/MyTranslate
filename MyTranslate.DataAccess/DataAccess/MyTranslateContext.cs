using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Data.Entity;

// using MyTranslate.Config;
using MyTranslate.Model;



namespace MyTranslate.DataAccess
{

    // Enable-Migrations -ProjectName MyTranslate.DataAccess -EnableAutomaticMigrations
    public class MyTranslateContext : DbContext
    {

        public MyTranslateContext()
            : base("name=MyTranslateContext")
        {


        }



        /// <summary>
        /// 书.
        /// </summary>
        public DbSet<Book> Books { get; set; }


        /// <summary>
        /// 章节.
        /// </summary>
        public DbSet<Chapter> Chapters { get; set; }


        /// <summary>
        /// 行.
        /// </summary>
        public DbSet<Line> Lines { get; set; }





        /// <summary>
        /// 自动替换
        /// </summary>
        public DbSet<AutoReplace> AutoReplaces { get; set; }




        /// <summary>
        /// 指定如何创建 表的处理.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 配置信息.
            // modelBuilder.Configurations.Add(new TopicCategoryConfig());
        }


    }

}
