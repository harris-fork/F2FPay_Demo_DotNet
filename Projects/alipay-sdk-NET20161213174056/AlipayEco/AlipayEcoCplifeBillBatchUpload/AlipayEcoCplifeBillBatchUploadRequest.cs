using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.eco.cplife.bill.batch.upload
    /// 物业费账单数据批量上传
    /// </summary>
    public class AlipayEcoCplifeBillBatchUploadRequest : BizAopRequest<AlipayEcoCplifeBillBatchUploadResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.eco.cplife.bill.batch.upload";
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
