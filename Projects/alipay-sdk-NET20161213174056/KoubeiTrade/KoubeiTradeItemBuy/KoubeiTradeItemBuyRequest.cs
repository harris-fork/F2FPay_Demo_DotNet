using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// koubei.trade.item.buy
    /// 获取购特车scheme
    /// </summary>
    public class KoubeiTradeItemBuyRequest : BizAopRequest<KoubeiTradeItemBuyResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "koubei.trade.item.buy";
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
