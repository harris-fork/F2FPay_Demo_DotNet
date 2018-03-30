using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: zhima.data.feedbackurl.query
    /// </summary>
    public class ZhimaDataFeedbackurlQueryRequest : IAopRequest<ZhimaDataFeedbackurlQueryResponse>
    {
        /// <summary>
        /// 获取数据反馈模板
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "zhima.data.feedbackurl.query";
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
