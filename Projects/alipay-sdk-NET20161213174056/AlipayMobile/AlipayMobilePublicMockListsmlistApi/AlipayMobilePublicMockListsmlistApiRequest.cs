using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.mobile.public.mock.listsmlist.api
    /// JSON
    /// </summary>
    public class AlipayMobilePublicMockListsmlistApiRequest : BizAopRequest<AlipayMobilePublicMockListsmlistApiResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.public.mock.listsmlist.api";
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
