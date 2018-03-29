using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.pass.code.add
    /// </summary>
    public class AlipayPassCodeAddRequest : IAopRequest<AlipayPassCodeAddResponse>
    {
        /// <summary>
        /// alipass文件Base64编码后的内容。
        /// </summary>
        public string FileContent { get; set; }

        /// <summary>
        /// 识别信息  当 recognition_type=1时， recognition_info={“partner_id”:”2088102114633762”,“out_trade_no”:”1234567”}  当recognition_type=2时， recognition_info={“user_id”:”2088102114633761“ }
        /// </summary>
        public string RecognitionInfo { get; set; }

        /// <summary>
        /// 发放对象识别类型  1- 订单信息  2- 支付宝userId
        /// </summary>
        public string RecognitionType { get; set; }

        /// <summary>
        /// 该pass的核销方式,如果为空，则默认为["wave","qrcode"]
        /// </summary>
        public List<string> VerifyType { get; set; }

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
            return "alipay.pass.code.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("file_content", this.FileContent);
            parameters.Add("recognition_info", this.RecognitionInfo);
            parameters.Add("recognition_type", this.RecognitionType);
            parameters.Add("verify_type", this.VerifyType);
            return parameters;
        }

        #endregion
    }
}
