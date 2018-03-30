using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.ebpp.pdeduct.sign.query
    /// 直连代扣协议查询接口
    /// </summary>
    public class AlipayEbppPdeductSignQueryRequest : BizAopRequest<AlipayEbppPdeductSignQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.ebpp.pdeduct.sign.query";
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
