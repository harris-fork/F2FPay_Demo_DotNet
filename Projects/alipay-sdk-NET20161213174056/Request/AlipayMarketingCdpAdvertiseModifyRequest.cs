using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.marketing.cdp.advertise.modify
    /// </summary>
    public class AlipayMarketingCdpAdvertiseModifyRequest : IAopRequest<AlipayMarketingCdpAdvertiseModifyResponse>
    {
        /// <summary>
        /// 提供给ISV、开发者修改广告的接口，修改广告后投放渠道包括钱包APP，聚牛APP等，投放支持的APP应用
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members
        public bool NeedEncrypt { get; set; }
        public string ApiVersion { get; set; } = "1.0";
        public string TerminalType { get; set; }
        public string TerminalInfo { get; set; }
        public string ProdCode { get; set; }
        public string NotifyUrl { get; set; }
        public AopObject BizModel { get; set; }

        

        

        

        public string GetApiName()
        {
            return "alipay.marketing.cdp.advertise.modify";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("biz_content", this.BizContent);
            return parameters;
        }

        #endregion
    }
}
