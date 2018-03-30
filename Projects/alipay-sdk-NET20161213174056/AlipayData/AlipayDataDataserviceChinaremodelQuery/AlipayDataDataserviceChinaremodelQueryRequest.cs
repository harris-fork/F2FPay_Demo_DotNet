using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.data.dataservice.chinaremodel.query
    /// 中再核保结果查询
    /// </summary>
    public class AlipayDataDataserviceChinaremodelQueryRequest : BizAopRequest<AlipayDataDataserviceChinaremodelQueryResponse>
    {
        

        #region BizAopRequest Members

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
