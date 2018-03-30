using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.public.appinfo.update
    /// </summary>
    public class AlipayMobilePublicAppinfoUpdateRequest : IAopRequest<AlipayMobilePublicAppinfoUpdateResponse>
    {
        /// <summary>
        /// 业务json
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.public.appinfo.update";
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
