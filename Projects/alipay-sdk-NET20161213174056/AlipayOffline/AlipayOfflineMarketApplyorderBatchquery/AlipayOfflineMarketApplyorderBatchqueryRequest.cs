using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.market.applyorder.batchquery
    /// </summary>
    public class AlipayOfflineMarketApplyorderBatchqueryRequest : IAopRequest<AlipayOfflineMarketApplyorderBatchqueryResponse>
    {
        /// <summary>
        /// 分页查询Leads、门店、商品相关操作流水信息
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.market.applyorder.batchquery";
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
