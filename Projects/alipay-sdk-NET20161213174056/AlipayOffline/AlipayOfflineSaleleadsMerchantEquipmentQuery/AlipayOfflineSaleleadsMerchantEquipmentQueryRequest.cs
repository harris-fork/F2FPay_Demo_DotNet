using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.offline.saleleads.merchant.equipment.query
    /// 商户门店机具查询
    /// </summary>
    public class AlipayOfflineSaleleadsMerchantEquipmentQueryRequest : BizAopRequest<AlipayOfflineSaleleadsMerchantEquipmentQueryResponse>
    {
        

        #region BizAopRequest Members

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
