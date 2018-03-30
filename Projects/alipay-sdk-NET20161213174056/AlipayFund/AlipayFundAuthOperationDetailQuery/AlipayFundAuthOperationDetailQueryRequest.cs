using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.fund.auth.operation.detail.query
    /// 资金预授权单笔操作明细查询接口
    /// </summary>
    public class AlipayFundAuthOperationDetailQueryRequest : BizAopRequest<AlipayFundAuthOperationDetailQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.fund.auth.operation.detail.query";
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
