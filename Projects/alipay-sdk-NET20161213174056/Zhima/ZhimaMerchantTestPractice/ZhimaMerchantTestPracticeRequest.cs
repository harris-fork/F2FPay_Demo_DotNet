using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: zhima.merchant.test.practice
    /// </summary>
    public class ZhimaMerchantTestPracticeRequest : IAopRequest<ZhimaMerchantTestPracticeResponse>
    {
        /// <summary>
        /// asd
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

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
