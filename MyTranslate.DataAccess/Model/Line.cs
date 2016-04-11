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
    /// 行.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "")]
    [Table("mt_line")]
    public class Line : AbstractCommonData
    {

        /// <summary>
        /// 行ID.
        /// </summary>
        [DataMember]
        [Column("line_id")]
        [Key]
        [Display(Name = "行ID")]
        [XmlIgnoreAttribute()]
        public long LineID { set; get; }


        /// <summary>
        /// 行号.
        /// </summary>
        [DataMember]
        [Column("line_number")]
        [Display(Name = "行号")]
        public int LineNumber { set; get; }



        /// <summary>
        /// 原始文本
        /// </summary>
        [DataMember]
        [Column("source_text")]
        [Display(Name = "原始文本")]
        [StringLength(1024)]
        public string SourceText { set; get; }



        /// <summary>
        /// 机翻文本
        /// </summary>
        [DataMember]
        [Column("machine_text")]
        [Display(Name = "机翻文本")]
        [StringLength(1024)]
        public string MachineText { set; get; }



        /// <summary>
        /// 翻译文本
        /// </summary>
        [DataMember]
        [Column("translate_text")]
        [Display(Name = "翻译文本")]
        [StringLength(1024)]
        public string TranslateText { set; get; }




        /// <summary>
        /// 是否是空行.
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMapped]
        public bool IsBlank
        {
            get
            {
                return String.IsNullOrEmpty(SourceText);
            }
        }





        #region 一对多的部分.  (与章节)


        /// <summary>
        /// 章节代码.
        /// </summary>
        [DataMember]
        [Column("chapter_code")]
        [Display(Name = "章节代码")]
        [ForeignKey("Chapter")]
        [StringLength(32)]
        [Required]
        public string ChapterCode { set; get; }




        /// <summary>
        /// 章节.
        /// </summary>
        [XmlIgnoreAttribute()]
        public virtual Chapter Chapter { set; get; }


        #endregion 一对多的部分.





        #region 状态常量.


        /// <summary>
        /// 状态是待处理.
        /// </summary>
        public const string STATUS_IS_WAIT = "WAIT";


        /// <summary>
        /// 状态是机翻.
        /// </summary>
        public const string STATUS_IS_MACHINE = "MACHINE";


        /// <summary>
        /// 状态是已完成.
        /// </summary>
        public const string STATUS_IS_DONE = "DONE";


        /// <summary>
        /// 状态是处理失败.
        /// </summary>
        public const string STATUS_IS_FAIL = "FAIL";



        /// <summary>
        /// 待处理.
        /// </summary>
        public void GotoWait()
        {
            this.Status = STATUS_IS_WAIT;
        }


        /// <summary>
        /// 机翻.
        /// </summary>
        public void GotoMachine()
        {
            this.Status = STATUS_IS_MACHINE;
        }


        /// <summary>
        /// 已完成.
        /// </summary>
        public void GotoDone()
        {
            this.Status = STATUS_IS_DONE;
        }

        /// <summary>
        /// 处理失败.
        /// </summary>
        public void GotoFail()
        {
            this.Status = STATUS_IS_FAIL;
        }

        #endregion 状态常量.


    }

}
