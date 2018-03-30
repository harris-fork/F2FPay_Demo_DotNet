using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: ant.merchant.expand.personal.apply
    /// </summary>
    public class AntMerchantExpandPersonalApplyRequest : IAopRequest<AntMerchantExpandPersonalApplyResponse>
    {
        /// <summary>
        /// 工商个体户入驻接口
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "ant.merchant.expand.personal.apply";
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
