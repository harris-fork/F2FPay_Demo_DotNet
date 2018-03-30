using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.data.dataservice.bill.downloadurl.query
    /// 无授权模式的查询对账单下载地址
    /// </summary>
    public class AlipayDataDataserviceBillDownloadurlQueryRequest : BizAopRequest<AlipayDataDataserviceBillDownloadurlQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.data.dataservice.bill.downloadurl.query";
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
