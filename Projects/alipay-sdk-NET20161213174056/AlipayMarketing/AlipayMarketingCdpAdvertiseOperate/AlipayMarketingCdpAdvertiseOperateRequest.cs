using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.marketing.cdp.advertise.operate
    /// </summary>
    public class AlipayMarketingCdpAdvertiseOperateRequest : IAopRequest<AlipayMarketingCdpAdvertiseOperateResponse>
    {
        /// <summary>
        /// 提供给ISV、开发者操作广告的接口
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.marketing.cdp.advertise.operate";
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
