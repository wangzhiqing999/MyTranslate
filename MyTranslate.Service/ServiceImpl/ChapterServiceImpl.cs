using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyTranslate.Service;

using MyTranslate.Model;
using MyTranslate.DataAccess;


namespace MyTranslate.ServiceImpl
{

    public class ChapterServiceImpl : CommonServiceImpl, IChapterService
    {

        /// <summary>
        /// 取得章节列表.
        /// </summary>
        /// <param name="bookCode"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public List<Chapter> GetChapterList(string bookCode, string status = null)
        {
            using (MyTranslateContext context = new MyTranslateContext())
            {

                var query =
                    from data in context.Chapters
                    where data.BookCode == bookCode
                    select data;


                if (!String.IsNullOrEmpty(status))
                {
                    query = query.Where(p => p.Status == status);
                }


                List<Chapter> resultList = query.ToList();

                return resultList;

            }


        }




        /// <summary>
        /// 创建  Line  列表.
        /// </summary>
        /// <param name="lineText"></param>
        /// <returns></returns>
        private List<Line> BuildSourceLineList(string[] lineTextArray)
        {

            List<Line> resultList = new List<Line>();

            int lineNo = 1;


            foreach (string oneLine in lineTextArray)
            {
                string lineTxt = oneLine.Trim();

                Line line = new Line()
                {
                    // 行号.
                    LineNumber = lineNo++,

                    // 文本.
                    SourceText = lineTxt,
                };


                resultList.Add(line);
            }

            return resultList;
        }





        /// <summary>
        /// 新章节.
        /// </summary>
        /// <param name="chapter"></param>
        /// <param name="lineTextArray"></param>
        /// <returns></returns>
        public bool NewChapter(Chapter chapter, string[] lineTextArray)
        {

            try
            {

                using (MyTranslateContext context = new MyTranslateContext())
                {

                    Chapter oldChapter = context.Chapters.Find(chapter.ChapterCode);
                    if (oldChapter != null)
                    {
                        ResultMessage = String.Format("章节代码 {0} 已存在！", chapter.ChapterCode);
                        return false;
                    }


                    chapter.IsActive = true;
                    chapter.BeforeInsertOperation();

                    context.Chapters.Add(chapter);




                    List<Line> lineList = BuildSourceLineList(lineTextArray);

                    foreach (Line line in lineList)
                    {
                        line.ChapterCode = chapter.ChapterCode;


                        if (line.IsBlank)
                        {
                            // 空行不需后续翻译操作.
                            line.MachineText = "";
                            line.TranslateText = "";
                            line.GotoDone();
                        }
                        else
                        {
                            line.GotoWait();
                        }


                        line.BeforeInsertOperation();

                        context.Lines.Add(line);
                    }




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
        /// 取得章节.
        /// </summary>
        /// <param name="chapterCode"></param>
        /// <returns></returns>
        public Chapter GetChapter(string chapterCode)
        {
            using (MyTranslateContext context = new MyTranslateContext())
            {
                var query =
                    from data in context.Chapters
                    where data.ChapterCode == chapterCode
                    select data;


                return query.FirstOrDefault();
            }
        }






        /// <summary>
        /// 取得章节的 源文本.
        /// </summary>
        /// <param name="chapterCode"></param>
        /// <returns></returns>
        public string[] GetChapterLineSourceText(string chapterCode)
        {
            using (MyTranslateContext context = new MyTranslateContext())
            {
                var query =
                    from data in context.Lines
                    where data.ChapterCode == chapterCode
                    orderby data.LineNumber
                    select data.SourceText;


                return query.ToArray();
            }
        }



        /// <summary>
        /// 取得章节的 机翻文本.
        /// </summary>
        /// <param name="chapterCode"></param>
        /// <returns></returns>
        public string[] GetChapterLineMachineText(string chapterCode)
        {
            using (MyTranslateContext context = new MyTranslateContext())
            {
                var query =
                    from data in context.Lines
                    where data.ChapterCode == chapterCode
                    orderby data.LineNumber
                    select data.MachineText;


                return query.ToArray();
            }
        }





        /// <summary>
        /// 取得章节的 翻译文本.
        /// </summary>
        /// <param name="chapterCode"></param>
        /// <returns></returns>
        public string[] GetChapterLineTranslateText(string chapterCode)
        {
            using (MyTranslateContext context = new MyTranslateContext())
            {
                var query =
                    from data in context.Lines
                    where data.ChapterCode == chapterCode
                    orderby data.LineNumber
                    select data.TranslateText;


                return query.ToArray();
            }
        }






        /// <summary>
        /// 取得机翻行列表.
        /// </summary>
        /// <param name="lineTextArray"></param>
        /// <returns></returns>
        private List<Line> BuildAutoTransLineList(string[] lineTextArray)
        {

            List<Line> resultList = new List<Line>();

            int lineNo = 0;


            while (lineNo < lineTextArray.Length)
            {

                string lineTxt = lineTextArray[lineNo].Trim();

                // 忽略空行.
                if (String.IsNullOrEmpty(lineTxt))
                {
                    lineNo++;
                    continue;
                }


                Line line = new Line()
                {
                    // 行号.
                    LineNumber = lineNo,

                    // 文本.
                    SourceText = lineTxt,

                    // 机翻文本.
                    MachineText = lineTextArray[lineNo + 1].Trim()
                };

                resultList.Add(line);


                lineNo += 2;
            }

            return resultList;
        }




        /// <summary>
        /// 机翻.
        /// </summary>
        /// <param name="chapterCode"></param>
        /// <param name="lineTextArray"></param>
        /// <returns></returns>
        public bool AutoTrans(string chapterCode, string[] lineTextArray)
        {
            try
            {

                using (MyTranslateContext context = new MyTranslateContext())
                {

                    Chapter oldChapter = context.Chapters.Find(chapterCode);
                    if (oldChapter == null)
                    {
                        ResultMessage = String.Format("章节代码 {0} 不存在！", chapterCode);
                        return false;
                    }


                    // 取得 行信息.
                    List<Line> lineList = oldChapter.Lines.OrderBy(p=>p.LineNumber).ToList();


                    // 取得机翻行.
                    List<Line> transLineList = BuildAutoTransLineList(lineTextArray);


                    // 取得自动替换信息.
                    List<AutoReplace> autoReplaceList = context.AutoReplaces.Where(p => p.Status == AutoReplace.STATUS_IS_ACTIVE).ToList();


                    foreach (Line line in lineList)
                    {
                        // 空行不需要翻译.
                        if (line.IsBlank)
                        {
                            continue;
                        }

                        // 检索机翻行.
                        Line transLine = transLineList.FirstOrDefault(p => p.SourceText == line.SourceText);

                        // 找到机翻行.
                        if (transLine != null)
                        {
                            // 更新.
                            line.MachineText = transLine.MachineText;


                            if (String.IsNullOrEmpty(line.TranslateText))
                            {
                                // 为非空的情况下， 提前设置.
                                line.TranslateText = line.MachineText;
                            }


                            // 检测是否存在 自动替换的标志.
                            foreach (var replaceData in autoReplaceList)
                            {
                                if (line.SourceText.Contains(replaceData.SourceText)
                                   && line.TranslateText.Contains(replaceData.MachineText))
                                {
                                    line.TranslateText = line.TranslateText.Replace(replaceData.MachineText, replaceData.TranslateText);
                                }
                            }

                            // 机翻标志.
                            line.GotoMachine();
                        }
                    }

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
        /// 新增或更新章节.
        /// </summary>
        /// <param name="chapter"></param>
        /// <returns></returns>
        public bool InsertOrUpdate(Chapter chapter)
        {
            try
            {
                using (MyTranslateContext context = new MyTranslateContext())
                {

                    // 先判断  书籍是否存在.
                    Book book = context.Books.Find(chapter.BookCode);
                    if (book == null)
                    {
                        ResultMessage = String.Format("未检索到代码为{0}的书籍！", chapter.BookCode);

                        return false;
                    }



                    // 先判断是 新增还是更新.

                    Chapter dbChapter = context.Chapters.Include("Lines").FirstOrDefault(p=>p.ChapterCode == chapter.ChapterCode);

                    if (dbChapter == null)
                    {
                        // 新增逻辑.


                        // 新增前处理.
                        chapter.BeforeInsertOperation();

                        foreach (Line line in chapter.Lines)
                        {
                            // 新增前处理.
                            line.BeforeInsertOperation();
                        }

                        
                        context.Chapters.Add(chapter);
                    }
                    else
                    {
                        // 更新逻辑.

                        // 名称.
                        dbChapter.ChapterName = chapter.ChapterName;
                        dbChapter.ChapterTranslateName = chapter.ChapterTranslateName;


                        List<Line> newLineList = new List<Line>();

                        // 行.
                        foreach (Line  line in chapter.Lines)
                        {

                            Line dbLine = null;


                            if (chapter.ChapterCode.Contains("NAMES"))
                            {
                                // 命名章节.
                                // 按照  原始文本进行匹配.
                                dbLine = dbChapter.Lines.FirstOrDefault(p => p.SourceText == line.SourceText);
                            }
                            else
                            {
                                // 普通章节.
                                // 按照 行号匹配.
                                dbLine = dbChapter.Lines.FirstOrDefault(p => p.LineNumber == line.LineNumber);
                            }



                            if (dbLine == null)
                            {
                                // 新增
                                newLineList.Add(line);
                            }
                            else
                            {
                                // 更新.
                                dbLine.SourceText = line.SourceText;
                                dbLine.MachineText = line.MachineText;
                                dbLine.TranslateText = line.TranslateText;
                                dbLine.Status = line.Status;
                                dbLine.BeforeUpdateOperation();
                            }
                        }

                        if (newLineList.Count > 0)
                        {
                            foreach (Line newLine in newLineList)
                            {
                                // 新增的，需要重置 流水ID.
                                newLine.LineID = 0;
                                newLine.Chapter = null;
                                newLine.CreateUser = null;
                                newLine.BeforeInsertOperation();

                                dbChapter.Lines.Add(newLine);
                            }
                        }


                    }




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
