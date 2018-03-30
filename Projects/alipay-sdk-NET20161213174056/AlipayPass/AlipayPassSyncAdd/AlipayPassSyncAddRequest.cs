using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.pass.sync.add
    /// </summary>
    public class AlipayPassSyncAddRequest : IAopRequest<AlipayPassSyncAddResponse>
    {
        /// <summary>
        /// alipass文件Base64编码后的内容。
        /// </summary>
        public string FileContent { get; set; }

        /// <summary>
        /// 商户外部交易号，由商户生成并确保其唯一性
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 商户与支付宝签约时，分配的唯一ID。
        /// </summary>
        public string PartnerId { get; set; }

        /// <summary>
        /// 支付宝用户ID，即买家用户ID
        /// </summary>
        public string UserId { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.pass.sync.add";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("file_content", this.FileContent);
            parameters.Add("out_trade_no", this.OutTradeNo);
            parameters.Add("partner_id", this.PartnerId);
            parameters.Add("user_id", this.UserId);
            return parameters;
        }

        #endregion
    }
}
