using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// ant.merchant.expand.enterprise.apply
    /// 商户入驻接口
    /// </summary>
    public class AntMerchantExpandEnterpriseApplyRequest : BizAopRequest<AntMerchantExpandEnterpriseApplyResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "ant.merchant.expand.enterprise.apply";
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
