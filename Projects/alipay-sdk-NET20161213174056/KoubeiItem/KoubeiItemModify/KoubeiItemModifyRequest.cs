using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// koubei.item.modify
    /// 商品修改
    /// </summary>
    public class KoubeiItemModifyRequest : BizAopRequest<KoubeiItemModifyResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "koubei.item.modify";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("biz_content", this.BizContent);
            return parameters;
        }

        #endregion
    }
}
