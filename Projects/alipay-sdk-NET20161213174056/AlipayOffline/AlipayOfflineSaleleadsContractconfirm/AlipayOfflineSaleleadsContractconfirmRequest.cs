using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.saleleads.contractconfirm
    /// </summary>
    public class AlipayOfflineSaleleadsContractconfirmRequest : IAopRequest<AlipayOfflineSaleleadsContractconfirmResponse>
    {
        /// <summary>
        /// crmhome提供私海leads确认签约功能
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.saleleads.contractconfirm";
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
