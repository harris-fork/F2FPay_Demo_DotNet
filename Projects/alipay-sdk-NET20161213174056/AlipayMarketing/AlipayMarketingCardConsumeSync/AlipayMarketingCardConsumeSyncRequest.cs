using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.marketing.card.consume.sync
    /// </summary>
    public class AlipayMarketingCardConsumeSyncRequest : IAopRequest<AlipayMarketingCardConsumeSyncResponse>
    {
        /// <summary>
        /// 会员卡消费记录同步
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.marketing.card.consume.sync";
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
