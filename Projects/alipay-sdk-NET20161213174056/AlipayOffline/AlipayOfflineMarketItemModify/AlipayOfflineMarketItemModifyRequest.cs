using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.offline.market.item.modify
    /// 商户可以通过此接口对商品进行库存等信息的修改（库存修改值只能大于当前值）
    /// </summary>
    public class AlipayOfflineMarketItemModifyRequest : BizAopRequest<AlipayOfflineMarketItemModifyResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.market.item.modify";
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
