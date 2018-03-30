using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// koubei.quality.test.cloudacpt.checkresult.submit
    /// 云验收检测结果提交
    /// </summary>
    public class KoubeiQualityTestCloudacptCheckresultSubmitRequest : BizAopRequest<KoubeiQualityTestCloudacptCheckresultSubmitResponse>
    {
        

        #region BizAopRequest Members

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
