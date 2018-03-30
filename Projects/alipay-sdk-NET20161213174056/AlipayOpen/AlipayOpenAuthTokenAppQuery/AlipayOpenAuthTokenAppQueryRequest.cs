using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.auth.token.app.query
    /// </summary>
    public class AlipayOpenAuthTokenAppQueryRequest : IAopRequest<AlipayOpenAuthTokenAppQueryResponse>
    {
        /// <summary>
        /// 查询某个ISV下的指定app_auth_token的授权信息：授权者、授权接口列表、状态、过期时间等
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.auth.token.app.query";
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
