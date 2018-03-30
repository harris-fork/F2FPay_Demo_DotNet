using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.zdataassets.fcdatalab.zdatamergetask
    /// </summary>
    public class AlipayZdataassetsFcdatalabZdatamergetaskRequest : IAopRequest<AlipayZdataassetsFcdatalabZdatamergetaskResponse>
    {
        /// <summary>
        /// 业务参数
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.zdataassets.fcdatalab.zdatamergetask";
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
