using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyTranslate.Service;

using MyTranslate.Model;
using MyTranslate.DataAccess;


namespace MyTranslate.ServiceImpl
{


    public class LineServiceImpl : CommonServiceImpl, ILineService
    {


        /// <summary>
        /// 取得章节的行列表.
        /// </summary>
        /// <param name="chapterCode"></param>
        /// <returns></returns>
        public List<Line> GetChapterLineList(string chapterCode)
        {
            using (MyTranslateContext context = new MyTranslateContext())
            {

                var query =
                    from data in context.Lines.Include("Chapter")
                    where
                        data.ChapterCode == chapterCode
                    orderby
                        data.LineNumber
                    select
                        data;



                List<Line> resultList = query.ToList();

                // 为 Null 的数据， 变更为字符.
                foreach (var oneResult in resultList)
                {

                    if (oneResult.MachineText == null)
                    {
                        oneResult.MachineText = String.Empty;
                    }
                    if (oneResult.TranslateText == null)
                    {
                        oneResult.TranslateText = String.Empty;
                    }

                }


                return resultList;

            }
        }




        /// <summary>
        /// 取得指定书的，  包含指定名词的 行列表
        /// </summary>
        /// <param name="bookCode"></param>
        /// <param name="sourceName"></param>
        /// <returns></returns>
        public List<Line> GetLineListByName(string bookCode, string sourceName)
        {
            // 结果列表.
            List<Line> resultList = new List<Line>();


            using (MyTranslateContext context = new MyTranslateContext())
            {

                var query =
                    from data in context.Lines.Include("Chapter")
                    where
                        data.Chapter.BookCode == bookCode
                        && data.SourceText.Contains(sourceName)
                    orderby
                        data.ChapterCode,
                        data.LineNumber
                    select
                        data;


                // 2016-3-11 修改开始.
                // 好像日文字符，上面的查询， 在 SQL Server 下面， 没有问题， 但是在 SQLite 数据库里面，存在问题。
                // 只能在这里， 作后续的 手工筛选。

                // return query.ToList();

                foreach (Line line in query)
                {


                    if (line.SourceText.Contains(sourceName))
                    {
                        resultList.Add(line);
                    }

                    // 区分大小写方式， 尝试 区分 平假/片假.
                    //int idx = line.SourceText.IndexOf(sourceName,  StringComparison.CurrentCulture);
                    //if (idx >= 0)
                    //{
                    //    resultList.Add(line);
                    //}
                   
                }

                // 2016-3-11 修改结束.



                // 把行号=0 的，放到最前.
                resultList = resultList.OrderBy(p => p.LineNumber == 0 ? 0 : 1).ToList();



                // 返回.
                return resultList;
            }
        }




        /// <summary>
        /// 新增一行.
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public bool NewOneLine(Line line)
        {
            try
            {
                using (MyTranslateContext context = new MyTranslateContext())
                {
                    line.BeforeInsertOperation();


                    context.Lines.Add(line);


                    // 物理保存.
                    context.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                ResultMessage = ex.Message;

                return false;
            }
        }



        /// <summary>
        /// 更新一行.
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public bool UpdateOneLine(Line line)
        {
            try
            {
                using (MyTranslateContext context = new MyTranslateContext())
                {

                    Line oldLine = context.Lines.Find(line.LineID);

                    if (oldLine == null)
                    {
                        ResultMessage = "数据不存在！！！";

                        return false;
                    }


                    // 只更新 译文 与 状态.
                    oldLine.TranslateText = line.TranslateText;
                    oldLine.Status = line.Status;


                    // 如果是名称行。 额外更新.
                    if (line.ChapterCode.Contains("NAMES") && !String.IsNullOrEmpty(line.MachineText))
                    {
                        oldLine.MachineText = line.MachineText;
                    }


                    oldLine.BeforeUpdateOperation();


                    // 物理保存.
                    context.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                ResultMessage = ex.Message;

                return false;
            }

        }



    }
}
