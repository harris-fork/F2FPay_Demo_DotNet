using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.offline.marketing.voucher.use
    /// 口碑外部券使用接口
    /// </summary>
    public class AlipayOfflineMarketingVoucherUseRequest : BizAopRequest<AlipayOfflineMarketingVoucherUseResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.marketing.voucher.use";
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
