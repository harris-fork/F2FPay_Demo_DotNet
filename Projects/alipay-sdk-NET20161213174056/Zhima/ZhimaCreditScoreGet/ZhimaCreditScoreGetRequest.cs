using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// zhima.credit.score.get
    /// 芝麻信用评分
    /// </summary>
    public class ZhimaCreditScoreGetRequest : BizAopRequest<ZhimaCreditScoreGetResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "zhima.credit.score.get";
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
