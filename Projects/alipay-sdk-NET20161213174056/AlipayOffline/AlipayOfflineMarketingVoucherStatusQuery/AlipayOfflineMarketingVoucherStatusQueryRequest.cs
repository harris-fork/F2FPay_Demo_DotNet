using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.marketing.voucher.status.query
    /// </summary>
    public class AlipayOfflineMarketingVoucherStatusQueryRequest : IAopRequest<AlipayOfflineMarketingVoucherStatusQueryResponse>
    {
        /// <summary>
        /// 券状态查询
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.marketing.voucher.status.query";
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
