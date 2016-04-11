using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyTranslate.Model;



namespace MyTranslate.Service
{


    public interface IAutoReplaceService : ICommonService
    {

        /// <summary>
        /// 取得 自动替换数据列表.
        /// </summary>
        /// <returns></returns>
        List<AutoReplace> GetAutoReplaceList();



        /// <summary>
        /// 插入或更新 自动替换数据.
        /// </summary>
        /// <param name="autoReplaceData"></param>
        /// <returns></returns>
        bool InsertOrUpdateAutoReplace(AutoReplace autoReplaceData);

    }

}
