using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.zdataassets.easyservice
    /// </summary>
    public class AlipayZdataassetsEasyserviceRequest : IAopRequest<AlipayZdataassetsEasyserviceResponse>
    {
        /// <summary>
        /// biz_content
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

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
