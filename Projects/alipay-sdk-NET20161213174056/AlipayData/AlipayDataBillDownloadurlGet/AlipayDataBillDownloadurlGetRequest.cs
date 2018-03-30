using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.data.bill.downloadurl.get
    /// </summary>
    public class AlipayDataBillDownloadurlGetRequest : IAopRequest<AlipayDataBillDownloadurlGetResponse>
    {
        /// <summary>
        /// 账单时间：日账单格式为yyyy-MM-dd,月账单格式为yyyy-MM
        /// </summary>
        public string BillDate { get; set; }

        /// <summary>
        /// 账单类型，目前支持的类型由：trade、air、air_b2b；trade指商户通过接口所获取的账单，或商户经开放平台授权后其所属服务商通过接口所获取的账单；air、air_b2b是航旅行业定制的账单，一般商户没有此账单；
        /// </summary>
        public string BillType { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.data.bill.downloadurl.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("bill_date", this.BillDate);
            parameters.Add("bill_type", this.BillType);
            return parameters;
        }

        #endregion
    }
}
