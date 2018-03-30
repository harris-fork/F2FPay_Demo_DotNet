using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ebpp.pdeduct.sign.validate
    /// </summary>
    public class AlipayEbppPdeductSignValidateRequest : IAopRequest<AlipayEbppPdeductSignValidateResponse>
    {
        /// <summary>
        /// 缴费直连代扣签约前置校验
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.ebpp.pdeduct.sign.validate";
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
