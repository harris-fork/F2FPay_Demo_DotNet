using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.marketing.cdp.advertise.create
    /// 提供给ISV、开发者创建广告的接口，创建广告后投放渠道包括钱包APP，聚牛APP等，投放支持的APP应用
    /// </summary>
    public class AlipayMarketingCdpAdvertiseCreateRequest : BizAopRequest<AlipayMarketingCdpAdvertiseCreateResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.marketing.cdp.advertise.create";
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
