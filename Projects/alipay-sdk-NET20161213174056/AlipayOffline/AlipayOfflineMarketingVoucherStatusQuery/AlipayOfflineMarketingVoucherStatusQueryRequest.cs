using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.offline.marketing.voucher.status.query
    /// 券状态查询
    /// </summary>
    public class AlipayOfflineMarketingVoucherStatusQueryRequest : BizAopRequest<AlipayOfflineMarketingVoucherStatusQueryResponse>
    {
        

        #region BizAopRequest Members

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
