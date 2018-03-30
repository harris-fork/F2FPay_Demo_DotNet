using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.public.account.query
    /// </summary>
    public class AlipayMobilePublicAccountQueryRequest : IAopRequest<AlipayMobilePublicAccountQueryResponse>
    {
        /// <summary>
        /// 业务信息：userId，这是个json字段
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.public.account.query";
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
