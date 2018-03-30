using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: ant.merchant.expand.mapplyorder.query
    /// </summary>
    public class AntMerchantExpandMapplyorderQueryRequest : IAopRequest<AntMerchantExpandMapplyorderQueryResponse>
    {
        /// <summary>
        /// 商户入驻单查询接口
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "ant.merchant.expand.mapplyorder.query";
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
