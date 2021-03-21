using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.example.common.ConfigInfo
{
    public class TencentConfig
    {
        public TencentCosConfig Cos { get; set; }
    }

    public class TencentCosConfig
    {
        public string SecretId { get; set; }
        public string SecretKey { get; set; }
        public string Region { get; set; }
        public string BucketName { get; set; }

        /// <summary>
        /// 每次请求签名有效时长
        /// </summary>
        public int DurationSecond { get; set; }

        /// <summary>
        /// 文件上传参数，文件分片上传阈值，默认4M
        /// </summary>
        public long DivisionForUpload { get; set; }

        /// <summary>
        /// 文件上传参数：每个分片上传文件大小，默认2M
        /// </summary>
        public long SliceSizeForUpload { get; set; }
    }
}
