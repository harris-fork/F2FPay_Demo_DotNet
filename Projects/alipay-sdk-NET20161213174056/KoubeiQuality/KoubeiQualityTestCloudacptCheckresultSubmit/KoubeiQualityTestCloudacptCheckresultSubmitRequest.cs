using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: koubei.quality.test.cloudacpt.checkresult.submit
    /// </summary>
    public class KoubeiQualityTestCloudacptCheckresultSubmitRequest : IAopRequest<KoubeiQualityTestCloudacptCheckresultSubmitResponse>
    {
        /// <summary>
        /// 云验收检测结果提交
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "koubei.quality.test.cloudacpt.checkresult.submit";
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
