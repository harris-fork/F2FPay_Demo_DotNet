using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.offline.marketing.voucher.offline
    /// 券下架
    /// </summary>
    public class AlipayOfflineMarketingVoucherOfflineRequest : BizAopRequest<AlipayOfflineMarketingVoucherOfflineResponse>
    {
        

        #region BizAopRequest Members

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
