using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.eco.mycar.violation.info.push
    /// </summary>
    public class AlipayEcoMycarViolationInfoPushRequest : IAopRequest<AlipayEcoMycarViolationInfoPushResponse>
    {
        /// <summary>
        /// ISV推送新违章信息
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.eco.mycar.violation.info.push";
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
