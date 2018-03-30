using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.app.codetesttest
    /// </summary>
    public class AlipayOpenAppCodetesttestRequest : IAopRequest<AlipayOpenAppCodetesttestResponse>
    {
        /// <summary>
        /// 统一对外错误码测试测试
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.app.codetesttest";
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
