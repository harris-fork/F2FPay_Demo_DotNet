using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.pass.file.add
    /// </summary>
    public class AlipayPassFileAddRequest : IAopRequest<AlipayPassFileAddResponse>
    {
        /// <summary>
        /// 支付宝pass文件二进制Base64加密字符串
        /// </summary>
        public string FileContent { get; set; }

        /// <summary>
        /// 支付宝用户识别信息：  当 recognition_type=1时， recognition_info={“partner_id”:”2088102114633762”,“out_trade_no”:”1234567”}；  当recognition_type=2时， recognition_info={“user_id”:”2088102114633761“}  当recognition_type=3时，recognition_info={“mobile”:”136XXXXXXXX“}
        /// </summary>
        public string RecognitionInfo { get; set; }

        /// <summary>
        /// Alipass添加对象识别类型【1--订单信息；2--支付宝userId;3--支付宝绑定手机号】
        /// </summary>
        public string RecognitionType { get; set; }

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
            return "alipay.pass.file.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("file_content", this.FileContent);
            parameters.Add("recognition_info", this.RecognitionInfo);
            parameters.Add("recognition_type", this.RecognitionType);
            return parameters;
        }

        #endregion
    }
}
