using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.zdataassets.metadata
    /// </summary>
    public class AlipayZdataassetsMetadataRequest : IAopRequest<AlipayZdataassetsMetadataResponse>
    {
        /// <summary>
        /// 业务参数
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.zdataassets.metadata";
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
