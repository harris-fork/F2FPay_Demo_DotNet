using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.pcredit.huabei.promo.query
    /// 入参大字段
    /// </summary>
    public class AlipayPcreditHuabeiPromoQueryRequest : BizAopRequest<AlipayPcreditHuabeiPromoQueryResponse>
    {
        

        #region BizAopRequest Members

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
