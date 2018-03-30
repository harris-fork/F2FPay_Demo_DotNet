using System;
using System.Xml.Serialization;

namespace Aop.Api
{
    [Serializable]
    public abstract class AopResponse
    {
        /// <summary>
        /// 错误码
        /// 对应 ErrCode
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 错误信息
        /// 对应 ErrMsg
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 子错误码
        /// 对应 SubErrCode
        /// </summary>
        [XmlElement("sub_code")]
        public string SubCode { get; set; }

        /// <summary>
        /// 子错误信息
        /// 对应 SubErrMsg
        /// </summary>
        [XmlElement("sub_msg")]
        public string SubMsg { get; set; }

        /// <summary>
        /// 响应原始内容
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 响应结果是否错误
        /// </summary>
        public bool IsError
        {
            get
            {
                return !string.IsNullOrEmpty(this.SubCode);
            }
        }
    }
}
