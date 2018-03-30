using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.public.messagespecify.push
    /// </summary>
    public class AlipayMobilePublicMessagespecifyPushRequest : IAopRequest<AlipayMobilePublicMessagespecifyPushResponse>
    {
        /// <summary>
        /// 业务内容JSON
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.public.messagespecify.push";
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
