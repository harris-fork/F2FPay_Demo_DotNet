using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.flashsales.stock.sync.update
    /// </summary>
    public class AlipayFlashsalesStockSyncUpdateRequest : IAopRequest<AlipayFlashsalesStockSyncUpdateResponse>
    {
        /// <summary>
        /// 商户的商品id
        /// </summary>
        public string OutProductId { get; set; }

        /// <summary>
        /// 服务窗id
        /// </summary>
        public string PublicId { get; set; }

        /// <summary>
        /// 库存数量
        /// </summary>
        public Nullable<long> Stock { get; set; }

        #region IAopRequest Members
        public bool NeedEncrypt { get; set; }
        public string ApiVersion { get; set; } = "1.0";
        public string TerminalType { get; set; }
        public string TerminalInfo { get; set; }
        public string ProdCode { get; set; }
        public string NotifyUrl { get; set; }
        public AopObject BizModel { get; set; }

        

        

        

        public string GetApiName()
        {
            return "alipay.flashsales.stock.sync.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("out_product_id", this.OutProductId);
            parameters.Add("public_id", this.PublicId);
            parameters.Add("stock", this.Stock);
            return parameters;
        }

        #endregion
    }
}
