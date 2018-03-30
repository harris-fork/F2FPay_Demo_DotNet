using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.marketing.voucher.modify
    /// </summary>
    public class AlipayOfflineMarketingVoucherModifyRequest : IAopRequest<AlipayOfflineMarketingVoucherModifyResponse>
    {
        /// <summary>
        /// 券修改
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.marketing.voucher.modify";
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
