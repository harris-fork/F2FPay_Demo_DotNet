using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.pcredit.huabei.promo.query
    /// </summary>
    public class AlipayPcreditHuabeiPromoQueryRequest : IAopRequest<AlipayPcreditHuabeiPromoQueryResponse>
    {
        /// <summary>
        /// 入参大字段
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.pcredit.huabei.promo.query";
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
