using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.msaas.promotion.cpainfo.create
    /// </summary>
    public class AlipayMsaasPromotionCpainfoCreateRequest : IAopRequest<AlipayMsaasPromotionCpainfoCreateResponse>
    {
        /// <summary>
        /// 此api为了让第三方渠道端调用 ，记录他们的调用数据，然后根据数据比对进行计费功能
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.msaas.promotion.cpainfo.create";
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
