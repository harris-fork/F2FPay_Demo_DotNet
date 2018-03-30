using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.data.dataservice.chinaremodel.query
    /// </summary>
    public class AlipayDataDataserviceChinaremodelQueryRequest : IAopRequest<AlipayDataDataserviceChinaremodelQueryResponse>
    {
        /// <summary>
        /// 中再核保结果查询
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.data.dataservice.chinaremodel.query";
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
