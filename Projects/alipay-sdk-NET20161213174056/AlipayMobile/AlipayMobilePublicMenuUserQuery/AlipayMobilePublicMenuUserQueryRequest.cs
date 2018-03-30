using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.public.menu.user.query
    /// </summary>
    public class AlipayMobilePublicMenuUserQueryRequest : IAopRequest<AlipayMobilePublicMenuUserQueryResponse>
    {
        /// <summary>
        /// 用户openId
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.public.menu.user.query";
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
