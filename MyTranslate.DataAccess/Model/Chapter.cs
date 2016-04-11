using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

using System.Runtime.Serialization;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using MyFramework.Model;




namespace MyTranslate.Model
{

    /// <summary>
    /// 章节.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "")]
    [Table("mt_chapter")]
    public class Chapter : AbstractCommonData
    {

        /// <summary>
        /// 章节代码.
        /// </summary>
        [DataMember]
        [Column("chapter_code")]
        [Display(Name = "章节代码")]
        [Key]
        [StringLength(32)]
        public string ChapterCode { set; get; }




        [XmlIgnoreAttribute()]
        [NotMapped]
        public string ChapterSubCode
        {
            get
            {
                string[] tmp = this.ChapterCode.Split('/');
                return tmp.Last();
            }
        }



        /// <summary>
        /// 章节名称
        /// </summary>
        [DataMember]
        [Column("chapter_name")]
        [Display(Name = "章节名称")]
        [StringLength(128)]
        public string ChapterName { set; get; }




        [XmlIgnoreAttribute()]
        [NotMapped]
        public string DisplayChapterName
        {
            get
            {
                return String.Format("{0} {1}", this.ChapterCode, this.ChapterName);
            }
        }




        /// <summary>
        /// 章节地址.
        /// </summary>
        [DataMember]
        [Column("chapter_url")]
        [Display(Name = "章节地址")]
        [StringLength(128)]
        public string ChapterUrl { set; get; }



        public string GetChapterUrl()
        {
            string url = this.ChapterUrl;

            if (!url.Contains("http://"))
            {
                url = "http://ncode.syosetu.com" + url;
            }

            return url;
        }



        /// <summary>
        /// 格式化章节代码
        /// </summary>
        /// <param name="subLen"></param>
        public void FormatChapterCode(int subLen = 3)
        {
            if(String.IsNullOrEmpty( this.ChapterUrl)) {
                // 忽略没有 url 的.
                return;
            }

            string [] urlArray = this.ChapterUrl.TrimEnd('/').Split('/');

            if(urlArray.Length <2 ) {
                // 忽略格式错误的.
                return;
            }

            this.ChapterCode = String.Format(
                    "{0}/{1}", 
                    urlArray[urlArray.Length-2],
                    urlArray[urlArray.Length-1].PadLeft(subLen,'0') );

        }









        /// <summary>
        /// 章节名称(译名)
        /// </summary>
        [DataMember]
        [Column("chapter_translate_name")]
        [Display(Name = "章节名称(译名)")]
        [StringLength(128)]
        public string ChapterTranslateName { set; get; }





        #region 一对多的部分.  (与书)


        /// <summary>
        /// 书代码.
        /// </summary>
        [DataMember]
        [Column("book_code")]
        [Display(Name = "书代码")]
        [ForeignKey("Book")]
        [StringLength(32)]
        [Required]
        public string BookCode { set; get; }



        /// <summary>
        /// 书.
        /// </summary>
        [XmlIgnoreAttribute()]
        public virtual Book Book { set; get; }


        #endregion 一对多的部分.






        #region  一对多的部分.  (与行)


        /// <summary>
        /// 行. 
        /// </summary>
        public virtual List<Line> Lines { set; get; }



        #endregion 一对多的部分.


    }
}
