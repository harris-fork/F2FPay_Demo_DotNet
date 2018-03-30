using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.eco.cplife.rooominfo.query
    /// </summary>
    public class AlipayEcoCplifeRooominfoQueryRequest : IAopRequest<AlipayEcoCplifeRooominfoQueryResponse>
    {
        /// <summary>
        /// 查询小区房屋信息列表
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.eco.cplife.rooominfo.query";
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
