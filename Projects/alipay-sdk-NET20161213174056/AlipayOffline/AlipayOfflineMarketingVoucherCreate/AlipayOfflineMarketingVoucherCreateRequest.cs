using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.marketing.voucher.create
    /// </summary>
    public class AlipayOfflineMarketingVoucherCreateRequest : IAopRequest<AlipayOfflineMarketingVoucherCreateResponse>
    {
        /// <summary>
        /// 券模板创建
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.marketing.voucher.create";
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
