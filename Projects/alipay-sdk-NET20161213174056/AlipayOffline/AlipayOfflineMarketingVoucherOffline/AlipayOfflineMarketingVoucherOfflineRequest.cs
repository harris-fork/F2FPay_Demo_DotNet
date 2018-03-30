using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.marketing.voucher.offline
    /// </summary>
    public class AlipayOfflineMarketingVoucherOfflineRequest : IAopRequest<AlipayOfflineMarketingVoucherOfflineResponse>
    {
        /// <summary>
        /// 券下架
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.marketing.voucher.offline";
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
