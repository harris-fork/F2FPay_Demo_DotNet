using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.mobile.public.messagebatch.push
    /// 业务内容JSON
    /// </summary>
    public class AlipayMobilePublicMessagebatchPushRequest : BizAopRequest<AlipayMobilePublicMessagebatchPushResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.public.messagebatch.push";
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
