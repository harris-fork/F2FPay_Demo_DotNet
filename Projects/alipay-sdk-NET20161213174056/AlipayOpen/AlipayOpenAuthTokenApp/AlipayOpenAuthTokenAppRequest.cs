using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.open.auth.token.app
    /// 用应用授权码（app_auth_code）换取或者刷新应用授权令牌(app_auth_token)
    /// </summary>
    public class AlipayOpenAuthTokenAppRequest : BizAopRequest<AlipayOpenAuthTokenAppResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.auth.token.app";
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
