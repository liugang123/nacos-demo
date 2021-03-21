using com.example.common.ConfigInfo;
using com.example.common.LocalConfig;
using Newtonsoft.Json;
using System;

namespace com.example.common
{
    public class ConfigManager
    {
        // public static readonly string rabbitConnectionStr = NacosConfig.rabbitConfig.ConnectionString;

        public static void LoadNacosConfigData()
        {
            // Console.WriteLine("从Nacos配置获取RabbitMq的连接串：" + rabbitConnectionStr);
        }

        public static void LoadLocalConfigData()
        {
            TencentConfig tencentConfig = LocalConfigLoader.GetSetting<TencentConfig>("tencent");
            Console.WriteLine("从Local配置获取Tencent数据：" + JsonConvert.SerializeObject(tencentConfig));
        }

    }
}
