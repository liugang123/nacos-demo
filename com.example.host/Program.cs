using com.example.common;
using com.example.common.LocalConfig;
using System;

namespace com.example.host
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.初始化Nacos配置
            // NacosConfig.Init();

            // 2.读取Nacos配置信息
            // ConfigManager.LoadNacosConfigData();

            // 3.初始化Local配置
            LocalConfigLoader.Init();

            // 4.读取Local配置信息
            ConfigManager.LoadLocalConfigData();

            Console.ReadLine();
        }
    }
}
