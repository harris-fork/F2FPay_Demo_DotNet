using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// zhima.merchant.test.practice
    /// asd
    /// </summary>
    public class ZhimaMerchantTestPracticeRequest : BizAopRequest<ZhimaMerchantTestPracticeResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "zhima.merchant.test.practice";
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
