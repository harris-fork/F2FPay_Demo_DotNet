using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.pass.tpl.content.update
    /// </summary>
    public class AlipayPassTplContentUpdateRequest : IAopRequest<AlipayPassTplContentUpdateResponse>
    {
        /// <summary>
        /// 代理商代替商户发放卡券后，再代替商户更新卡券时，此值为商户的pid/appid
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// 支付宝pass唯一标识
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// 券状态,支持更新为USED,CLOSED两种状态
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 模版动态参数信息【支付宝pass模版参数键值对JSON字符串】
        /// </summary>
        public string TplParams { get; set; }

        /// <summary>
        /// 核销码串值【当状态变更为USED时，建议传入】
        /// </summary>
        public string VerifyCode { get; set; }

        /// <summary>
        /// 核销方式，目前支持：wave（声波方式）、qrcode（二维码方式）、barcode（条码方式）、input（文本方式，即手工输入方式）。pass和verify_type不能同时为空
        /// </summary>
        public string VerifyType { get; set; }

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
            return "alipay.pass.tpl.content.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("channel_id", this.ChannelId);
            parameters.Add("serial_number", this.SerialNumber);
            parameters.Add("status", this.Status);
            parameters.Add("tpl_params", this.TplParams);
            parameters.Add("verify_code", this.VerifyCode);
            parameters.Add("verify_type", this.VerifyType);
            return parameters;
        }

        #endregion
    }
}
