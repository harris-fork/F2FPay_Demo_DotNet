using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.open.public.account.delete
    /// 解除绑定商户会员号
    /// </summary>
    public class AlipayOpenPublicAccountDeleteRequest : BizAopRequest<AlipayOpenPublicAccountDeleteResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.public.account.delete";
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
