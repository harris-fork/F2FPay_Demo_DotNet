using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: koubei.item.extitem.existed.query
    /// </summary>
    public class KoubeiItemExtitemExistedQueryRequest : IAopRequest<KoubeiItemExtitemExistedQueryResponse>
    {
        /// <summary>
        /// 查询商品编码对应的商品是否存在
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "koubei.item.extitem.existed.query";
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
