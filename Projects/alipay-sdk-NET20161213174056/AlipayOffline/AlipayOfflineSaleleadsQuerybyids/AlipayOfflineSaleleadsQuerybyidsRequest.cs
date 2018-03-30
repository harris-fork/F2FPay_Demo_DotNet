using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.offline.saleleads.querybyids
    /// crmhome提供leads分页查询功能
    /// </summary>
    public class AlipayOfflineSaleleadsQuerybyidsRequest : BizAopRequest<AlipayOfflineSaleleadsQuerybyidsResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.saleleads.querybyids";
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
