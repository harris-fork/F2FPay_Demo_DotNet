using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// koubei.marketing.data.trade.habbit.query
    /// 商户会员交易习惯查询接口
    /// </summary>
    public class KoubeiMarketingDataTradeHabbitQueryRequest : BizAopRequest<KoubeiMarketingDataTradeHabbitQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "koubei.marketing.data.trade.habbit.query";
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
