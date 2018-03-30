using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.eco.mycar.carlib.info.push
    /// </summary>
    public class AlipayEcoMycarCarlibInfoPushRequest : IAopRequest<AlipayEcoMycarCarlibInfoPushResponse>
    {
        /// <summary>
        /// 同步车型库
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.eco.mycar.carlib.info.push";
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
