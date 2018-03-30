using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.zdataassets.easyservice
    /// biz_content
    /// </summary>
    public class AlipayZdataassetsEasyserviceRequest : BizAopRequest<AlipayZdataassetsEasyserviceResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.zdataassets.easyservice";
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
