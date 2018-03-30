using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.public.std.mock.listsmlist.api
    /// </summary>
    public class AlipayMobilePublicStdMockListsmlistApiRequest : IAopRequest<AlipayMobilePublicStdMockListsmlistApiResponse>
    {
        /// <summary>
        /// JSON
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.public.std.mock.listsmlist.api";
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