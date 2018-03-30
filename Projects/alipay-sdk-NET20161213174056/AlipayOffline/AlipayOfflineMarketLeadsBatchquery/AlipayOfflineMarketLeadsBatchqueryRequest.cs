using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.market.leads.batchquery
    /// </summary>
    public class AlipayOfflineMarketLeadsBatchqueryRequest : IAopRequest<AlipayOfflineMarketLeadsBatchqueryResponse>
    {
        /// <summary>
        /// 通过该接口多组合条件查询口碑线下Leads信息
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.market.leads.batchquery";
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
