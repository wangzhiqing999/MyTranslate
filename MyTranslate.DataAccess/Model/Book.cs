using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using MyFramework.Model;



namespace MyTranslate.Model
{

    /// <summary>
    /// 书.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "")]
    [Table("mt_book")]
    public class Book : AbstractCommonData
    {

        /// <summary>
        /// 书代码.
        /// </summary>
        [DataMember]
        [Column("book_code")]
        [Display(Name = "书代码")]
        [Key]
        [StringLength(32)]
        public string BookCode { set; get; }



        /// <summary>
        /// 书名称
        /// </summary>
        [DataMember]
        [Column("book_name")]
        [Display(Name = "书名称")]
        [StringLength(128)]
        public string BookName { set; get; }




        /// <summary>
        /// 书地址.
        /// </summary>
        [DataMember]
        [Column("book_url")]
        [Display(Name = "书地址")]        
        [StringLength(128)]
        public string BookUrl { set; get; }




        #region 一对多的部分.  (与章节)

        /// <summary>
        /// 章节 
        /// </summary>
        public virtual List<Chapter> Chapters { set; get; }



        #endregion 一对多的部分.

    }


}
