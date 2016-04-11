using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyTranslate.Model;


namespace MyTranslate.Service
{


    public interface IWebReaderService
    {


        /// <summary>
        /// 读取章节列表.
        /// </summary>
        /// <param name="bookUrl"></param>
        /// <returns></returns>
        List<Chapter> ReadChapterList(string bookUrl);




        /// <summary>
        /// 读取行列表.
        /// </summary>
        /// <param name="chapterUrl"></param>
        /// <returns></returns>
        string ReadLineList(string chapterUrl);



    }


}
