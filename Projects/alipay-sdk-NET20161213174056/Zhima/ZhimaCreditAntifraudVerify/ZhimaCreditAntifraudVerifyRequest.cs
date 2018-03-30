using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// zhima.credit.antifraud.verify
    /// 欺诈信息验证
    /// </summary>
    public class ZhimaCreditAntifraudVerifyRequest : BizAopRequest<ZhimaCreditAntifraudVerifyResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "zhima.credit.antifraud.verify";
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
