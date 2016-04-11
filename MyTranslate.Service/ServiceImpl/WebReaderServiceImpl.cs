using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;

using System.Net;
using System.IO;


using MyTranslate.Model;
using MyTranslate.Service;



namespace MyTranslate.ServiceImpl
{


    public class WebReaderServiceImpl : IWebReaderService
    {


        /// <summary>
        /// 读取章节列表.
        /// </summary>
        /// <param name="bookUrl"></param>
        /// <returns></returns>
        public List<Chapter> ReadChapterList(string bookUrl)
        {
            List<Chapter> resultList = new List<Chapter>();



            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            Stream s = client.OpenRead(bookUrl);



            using (StreamReader sr = new StreamReader(s, Encoding.UTF8))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {

                    if (line.IndexOf("class=\"subtitle\"") >= 0)
                    {
                        int urlBeginIndex  = line.IndexOf("href=");
                        if (urlBeginIndex <= 0)
                        {
                            continue;
                        }


                        urlBeginIndex += 6;

                        int urlEndIndex = line.IndexOf("\"", urlBeginIndex);
                        if (urlEndIndex <= 0)
                        {
                            continue;
                        }




                        int nameBeginIndex  = line.IndexOf(">", urlEndIndex);
                        nameBeginIndex++;

                        int nameEndIndex  = line.IndexOf("<", nameBeginIndex);



                        Chapter chapter = new Chapter()
                        {
                            // Url.
                            ChapterUrl = line.Substring(urlBeginIndex, urlEndIndex - urlBeginIndex),

                            // 名称.
                            ChapterName = line.Substring(nameBeginIndex, nameEndIndex - nameBeginIndex),
                            
                        };

                        chapter.FormatChapterCode();


                        resultList.Add(chapter);
                    }
                }
            }



            return resultList;
        }








        /// <summary>
        /// 读取行列表.
        /// </summary>
        /// <param name="chapterUrl"></param>
        /// <returns></returns>
        public string ReadLineList(string chapterUrl)
        {
            List<Line> resultList = new List<Line>();

            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            Stream s = client.OpenRead(chapterUrl);


            StringBuilder buff = new StringBuilder();


            using (StreamReader sr = new StreamReader(s, Encoding.UTF8))
            {

                bool startFlag = false;

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.IndexOf("novel_honbun") >= 0)
                    {
                        // 开始处理标志.
                        startFlag = true;

                        // continue;
                    }


                    if (!startFlag)
                    {
                        continue;
                    }


                    if (line.IndexOf("novel_bn") >= 0)
                    {
                        // 结束.
                        break;
                    }

                    buff.AppendLine(line);



                }
            }


            string html = buff.ToString();



            return html;


            /*

            new Thread(() =>
            {
                // 加载页面.
                WebBrowser webBrowser1 = new WebBrowser();
                webBrowser1.DocumentCompleted +=
                    new WebBrowserDocumentCompletedEventHandler(WebDocumentCompleted);

                webBrowser1.DocumentText = html;

            }).Start();


            lock (locker)
            {
                // 等待通知.
                Monitor.Wait(locker);
            }


            


            int lineNo = 1;


            foreach (string oneLine in text.Split('\r'))
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
            */
        }




    }


}
