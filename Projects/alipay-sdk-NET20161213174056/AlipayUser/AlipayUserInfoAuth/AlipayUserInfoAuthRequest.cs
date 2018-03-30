using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.user.info.auth
    /// 用户登陆授权
    /// </summary>
    public class AlipayUserInfoAuthRequest : BizAopRequest<AlipayUserInfoAuthResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.user.info.auth";
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
