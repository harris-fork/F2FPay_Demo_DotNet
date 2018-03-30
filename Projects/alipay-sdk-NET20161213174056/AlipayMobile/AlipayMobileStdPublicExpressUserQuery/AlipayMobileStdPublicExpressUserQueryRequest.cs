using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.std.public.express.user.query
    /// </summary>
    public class AlipayMobileStdPublicExpressUserQueryRequest : IAopRequest<AlipayMobileStdPublicExpressUserQueryResponse>
    {
        /// <summary>
        /// 查询请求，用户id
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.std.public.express.user.query";
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
