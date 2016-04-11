using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

using System.Runtime.Serialization;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using MyFramework.Model;




namespace MyTranslate.Model
{

    /// <summary>
    /// 自动替换.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "")]
    [Table("mt_auto_replace")]
    public class AutoReplace : AbstractCommonData
    {

        /// <summary>
        /// ID.
        /// </summary>
        [DataMember]
        [Column("id")]
        [Key]
        [Display(Name = "ID")]
        [XmlIgnoreAttribute()]
        public long ID { set; get; }



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

    }

}
