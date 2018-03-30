using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.offline.market.item.state
    /// 通过此接口，商户可以出传入item_id与上下架标识，对商户创建的商品进行上架或下架处理
    /// </summary>
    public class AlipayOfflineMarketItemStateRequest : BizAopRequest<AlipayOfflineMarketItemStateResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.market.item.state";
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
