using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.user.test
    /// </summary>
    public class AlipayUserTestRequest : IAopRequest<AlipayUserTestResponse>
    {
        /// <summary>
        /// 顶顶顶
        /// </summary>
        public List<string> Userinfo { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.user.test";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("userinfo", this.Userinfo);
            return parameters;
        }

        #endregion
    }
}
