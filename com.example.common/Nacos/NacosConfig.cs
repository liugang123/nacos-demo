using com.example.common.ConfigInfo;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace com.example.common.Nacos
{
    public class NacosConfig
    {
        public static RabbitConfig rabbitConfig = null;

        public static TencentConfig tencentConfig = null;

        public static void Init()
        {
            // 1.加载配置
            string config = Com.Alibaba.Nacos.Core.Nacos.init().runOnce();
            if (string.IsNullOrEmpty(config))
            {
                throw new Exception("nacos config load error!");
            }
            // 2.解析配置
            JObject jsonObject = (JObject)JsonConvert.DeserializeObject(config);
            rabbitConfig = jsonObject["rabbit"].ToObject<RabbitConfig>();
            tencentConfig = jsonObject["tencent"].ToObject<TencentConfig>();
        }

    }
}

