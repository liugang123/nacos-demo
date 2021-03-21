using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace com.example.common.LocalConfig
{
    /// <summary>
    /// 本地配置文件加载
    /// </summary>
    public class LocalConfigLoader
    {
        // 环境变量名称
        private static readonly string envConfig = "CONFIG_ENV";
        // 配置文件根路径
        private static readonly string configRootPath = "Config/Env";
        // 配置json数据
        private static string configContent;

        public static void Init()
        {
            string appConfigName = "application.json";
            string envConfigValue = Environment.GetEnvironmentVariable(envConfig, EnvironmentVariableTarget.Machine);
            if (!string.IsNullOrEmpty(envConfigValue))
            {
                appConfigName = string.Format("application-{0}.json", envConfigValue.ToLower());
            }
            // 读取配置文件数据
            configContent = ReadLocalConfigFile(appConfigName);
        }

        /// <summary>
        ///  获取配置文件信息
        /// </summary>
        /// <param name="appConfigName"></param>
        /// <returns></returns>
        private static string ReadLocalConfigFile(string appConfigName)
        {
            string configFullPath = configRootPath + "/" + appConfigName;
            return File.ReadAllText(@configFullPath);
        }

        /// <summary>
        /// 获取配置信息
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T GetSetting<T>(string key)
        {
            try
            {
                var jsonObject = JObject.Parse(configContent);
                var token = jsonObject.SelectToken(key);
                var result = default(T);
                if (token != null)
                {
                    result = jsonObject.SelectToken(key).ToObject<T>();
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
