using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: koubei.item.extitem.brand.query
    /// </summary>
    public class KoubeiItemExtitemBrandQueryRequest : IAopRequest<KoubeiItemExtitemBrandQueryResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "koubei.item.extitem.brand.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
