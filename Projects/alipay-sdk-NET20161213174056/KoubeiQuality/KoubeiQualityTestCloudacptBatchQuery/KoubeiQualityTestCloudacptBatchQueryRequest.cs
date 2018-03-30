using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// koubei.quality.test.cloudacpt.batch.query
    /// 云验收单品列表查询
    /// </summary>
    public class KoubeiQualityTestCloudacptBatchQueryRequest : BizAopRequest<KoubeiQualityTestCloudacptBatchQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "koubei.quality.test.cloudacpt.batch.query";
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
