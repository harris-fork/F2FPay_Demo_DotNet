using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.commerce.medical.card.query
    /// 医疗机构根据用户userId查询该账户的医保卡相关信息
    /// </summary>
    public class AlipayCommerceMedicalCardQueryRequest : BizAopRequest<AlipayCommerceMedicalCardQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.commerce.medical.card.query";
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
