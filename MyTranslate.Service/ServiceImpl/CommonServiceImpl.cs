using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using MyTranslate.Service;

namespace MyTranslate.ServiceImpl
{
    public class CommonServiceImpl : ICommonService
    {

        /// <summary>
        /// 结果消息.
        /// </summary>
        public string ResultMessage
        {
            set;
            get;
        }

    }
}
