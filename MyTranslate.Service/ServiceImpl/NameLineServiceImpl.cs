using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyTranslate.Service;

using MyTranslate.Model;
using MyTranslate.DataAccess;


namespace MyTranslate.ServiceImpl
{


    public class NameLineServiceImpl : CommonServiceImpl, ILineService
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


                return query.ToList();

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


                return query.ToList();

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

                    // 名称需要先去除空格.
                    line.SourceText = line.SourceText.Trim();

                    // 对于名称， 需要先判断，  名称是否已存在
                    Line dbLine = context.Lines.FirstOrDefault(p => p.ChapterCode == line.ChapterCode && p.SourceText == line.SourceText);

                    if (dbLine != null)
                    {
                        ResultMessage = String.Format("名词 {0} 已存在！", line.SourceText);

                        return false;
                    }



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
