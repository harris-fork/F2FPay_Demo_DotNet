using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.ebpp.pdeduct.sign.validate
    /// 缴费直连代扣签约前置校验
    /// </summary>
    public class AlipayEbppPdeductSignValidateRequest : BizAopRequest<AlipayEbppPdeductSignValidateResponse>
    {
        

        #region BizAopRequest Members

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
