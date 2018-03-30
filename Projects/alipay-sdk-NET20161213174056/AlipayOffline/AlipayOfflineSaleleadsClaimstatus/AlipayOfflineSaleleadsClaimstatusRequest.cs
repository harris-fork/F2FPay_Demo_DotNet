using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.saleleads.claimstatus
    /// </summary>
    public class AlipayOfflineSaleleadsClaimstatusRequest : IAopRequest<AlipayOfflineSaleleadsClaimstatusResponse>
    {
        /// <summary>
        /// crmhome中leads认领\分配\释放
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.saleleads.claimstatus";
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
