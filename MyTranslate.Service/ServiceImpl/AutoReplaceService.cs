using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyTranslate.Service;

using MyTranslate.Model;
using MyTranslate.DataAccess;


namespace MyTranslate.ServiceImpl
{
    public class AutoReplaceService : CommonServiceImpl, IAutoReplaceService
    {

        /// <summary>
        /// 取得 自动替换数据列表.
        /// </summary>
        /// <returns></returns>
        public List<AutoReplace> GetAutoReplaceList()
        {
            using (MyTranslateContext context = new MyTranslateContext())
            {
                var query =
                    from data in context.AutoReplaces
                    select
                        data;

                return query.ToList();
            }
        }



        /// <summary>
        /// 插入或更新 自动替换数据.
        /// </summary>
        /// <param name="autoReplaceData"></param>
        /// <returns></returns>
        public bool InsertOrUpdateAutoReplace(AutoReplace autoReplaceData)
        {
            try
            {
                if (String.IsNullOrEmpty(autoReplaceData.SourceText))
                {
                    ResultMessage = "原始文本不能为空！";
                    return false;
                }
                if (String.IsNullOrEmpty(autoReplaceData.MachineText))
                {
                    ResultMessage = "机翻文本不能为空！";
                    return false;
                }
                if (String.IsNullOrEmpty(autoReplaceData.TranslateText))
                {
                    ResultMessage = "结果文本不能为空！";
                    return false;
                }



                using (MyTranslateContext context = new MyTranslateContext())
                {
                    AutoReplace dbData = context.AutoReplaces.FirstOrDefault(p => p.SourceText == autoReplaceData.SourceText);

                    if (dbData == null)
                    {
                        // 数据库中不存在.
                        // 新增.
                        autoReplaceData.BeforeInsertOperation();

                        // 插入.
                        context.AutoReplaces.Add(autoReplaceData);
                    }
                    else
                    {
                        dbData.MachineText = autoReplaceData.MachineText;
                        dbData.TranslateText = autoReplaceData.TranslateText;
                        dbData.Status = autoReplaceData.Status;

                        dbData.BeforeUpdateOperation();
                    }
                    

                    // 物理保存.
                    context.SaveChanges();
                }


                return true;
            }
            catch (Exception ex)
            {
                ResultMessage = ex.Message;
                return false;
            }

        }

    }
}
