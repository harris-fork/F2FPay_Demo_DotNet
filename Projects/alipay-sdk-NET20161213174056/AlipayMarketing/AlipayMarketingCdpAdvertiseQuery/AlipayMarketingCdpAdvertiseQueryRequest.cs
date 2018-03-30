using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.marketing.cdp.advertise.query
    /// 提供给ISV和开发者查询广告的接口
    /// </summary>
    public class AlipayMarketingCdpAdvertiseQueryRequest : BizAopRequest<AlipayMarketingCdpAdvertiseQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.marketing.cdp.advertise.query";
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
