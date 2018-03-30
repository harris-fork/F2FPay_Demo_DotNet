using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.marketing.cdp.advertise.operate
    /// 提供给ISV、开发者操作广告的接口
    /// </summary>
    public class AlipayMarketingCdpAdvertiseOperateRequest : BizAopRequest<AlipayMarketingCdpAdvertiseOperateResponse>
    {
        

        #region BizAopRequest Members

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
