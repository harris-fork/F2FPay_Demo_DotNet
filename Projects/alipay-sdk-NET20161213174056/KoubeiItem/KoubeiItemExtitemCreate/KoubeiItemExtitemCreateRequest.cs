using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// koubei.item.extitem.create
    /// 商品创建接口
    /// </summary>
    public class KoubeiItemExtitemCreateRequest : BizAopRequest<KoubeiItemExtitemCreateResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "koubei.item.extitem.create";
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
