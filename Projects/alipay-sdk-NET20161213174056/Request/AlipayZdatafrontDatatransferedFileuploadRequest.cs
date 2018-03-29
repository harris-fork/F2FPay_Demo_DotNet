using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.zdatafront.datatransfered.fileupload
    /// </summary>
    public class AlipayZdatafrontDatatransferedFileuploadRequest : IAopUploadRequest<AlipayZdatafrontDatatransferedFileuploadResponse>
    {
        /// <summary>
        /// 合作伙伴上传文件中的各字段,使用英文半角","分隔，file_type为json_data时必选
        /// </summary>
        public string Columns { get; set; }

        /// <summary>
        /// 二进制字节数组，由文件转出
        /// </summary>
        public FileItem File { get; set; }

        /// <summary>
        /// 文件描述信息，非解析数据类型必选
        /// </summary>
        public string FileDescription { get; set; }

        /// <summary>
        /// 文件摘要，算法SHA
        /// </summary>
        public string FileDigest { get; set; }

        /// <summary>
        /// 描述上传文件的类型
        /// </summary>
        public string FileType { get; set; }

        /// <summary>
        /// 上传数据文件的主键字段，注意该pk若出现重复则后入数据会覆盖前面的，file_type为json_data时必选
        /// </summary>
        public string PrimaryKey { get; set; }

        /// <summary>
        /// 上传数据文件包含的记录数，file_type为json_data时必选
        /// </summary>
        public Nullable<long> Records { get; set; }

        /// <summary>
        /// 外部公司的数据源标识信息，由联接网络分配
        /// </summary>
        public string TypeId { get; set; }

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
            return "alipay.zdatafront.datatransfered.fileupload";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("columns", this.Columns);
            parameters.Add("file_description", this.FileDescription);
            parameters.Add("file_digest", this.FileDigest);
            parameters.Add("file_type", this.FileType);
            parameters.Add("primary_key", this.PrimaryKey);
            parameters.Add("records", this.Records);
            parameters.Add("type_id", this.TypeId);
            return parameters;
        }

        

        #endregion

        #region IAopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("file", this.File);
            return parameters;
        }

        #endregion
    }
}
