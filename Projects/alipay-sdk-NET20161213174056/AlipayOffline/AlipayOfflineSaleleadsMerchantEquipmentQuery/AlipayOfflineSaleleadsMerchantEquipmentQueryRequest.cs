using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.saleleads.merchant.equipment.query
    /// </summary>
    public class AlipayOfflineSaleleadsMerchantEquipmentQueryRequest : IAopRequest<AlipayOfflineSaleleadsMerchantEquipmentQueryResponse>
    {
        /// <summary>
        /// 商户门店机具查询
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.saleleads.merchant.equipment.query";
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
