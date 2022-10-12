namespace Binance.Objects
{
    using System;
    using System.Security.Cryptography;
    using Newtonsoft.Json;
    using System.Text;
    using System.Collections.Generic;

    public static class MyFxn
    {
        /// <summary>
        /// returns either empty or desired list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="response"></param>
        /// <returns></returns>
        public static List<T> ErrorHandling<T>(string? response)
        {
            List<T> list = new List<T>();                           //An empty list
            if(response.Equals("") || response.Equals(null))       //if string is empty
            {                                                       //Most likely connection faliure
                Console.WriteLine("ErrorHandling(): null");
                return (list);
            }
            else
            {
                try
                {
                    var recdList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(response);
                    if (recdList.Count == 0)                        //response do NOT contain <T> type data string
                    {
                        Console.WriteLine("ErrorHandling: List has 0 Elements");
                        return (recdList);
                    }
                    else
                    {
                        return recdList;                            //desired List
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("ErrorHandling(): incompatable response");
                    return list;
                }
            }
        }

        /// <summary>
        /// change file extension
        /// </summary>
        /// <param name="orgFilePath"></param>
        /// <param name="extension"></param>
        /// <returns></returns>
        public static string editFileName(string? orgFilePath, string? extension)
        {
            var orgdir = System.IO.Path.GetDirectoryName(orgFilePath);
            var orgName = System.IO.Path.GetFileNameWithoutExtension(orgFilePath);
            return $"{orgdir}\\{orgName}.{extension}";
        }

        /// <summary>
        /// change file extension and add prefix to name
        /// </summary>
        /// <param name="orgFilePath"></param>
        /// <param name="extension"></param>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public static string editFileName(string? orgFilePath, string? extension, string? prefix)
        {
            var orgdir = System.IO.Path.GetDirectoryName(orgFilePath);
            var orgName = System.IO.Path.GetFileNameWithoutExtension(orgFilePath);
            return $"{orgdir}\\{prefix}{orgName}.{extension}";
        }

        /// <summary>
        /// change file extension, add prefix and add postfix to name
        /// </summary>
        /// <param name="orgFilePath"></param>
        /// <param name="extension"></param>
        /// <param name="prefix"></param>
        /// <param name="postfix"></param>
        /// <returns></returns>
        public static string editFileName(string? orgFilePath, string? extension, string? prefix, string? postfix)
        {
            var orgdir = System.IO.Path.GetDirectoryName(orgFilePath);
            var orgName = System.IO.Path.GetFileNameWithoutExtension(orgFilePath);
            return $"{orgdir}\\{prefix}{orgName}{postfix}.{extension}";
        }

        public static DateTime unixToLocalTime(long unixTime)
        {
            DateTimeOffset dateTimeOffSet = DateTimeOffset.FromUnixTimeMilliseconds(unixTime);
            DateTime dateTime = dateTimeOffSet.DateTime;    //UTC
            DateTime localTime = dateTime.ToLocalTime();    //IST
            return localTime;
        }
        /*public static DateTime UTC()
        {            
            DateTimeOffset dateTimeOffSet = DateTimeOffset.FromUnixTimeMilliseconds();
            DateTime dateTime = dateTimeOffSet.DateTime;    //UTC
        }*/
        /// <summary>
        /// enter filename not the path
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="extension"></param>
        /// <returns></returns>
        public static string createFile(string? fileName,string? extension)
        {
            var dirPath = @"C:\CSharp\repos\UserData\";
            var dateTime = DateTime.Now.ToString("dd_MMM_yy");
            var filePath = dirPath + fileName + "." + extension;
            Console.WriteLine(filePath);
            if (System.IO.Directory.Exists(dirPath)) { }
            else
            {
                System.IO.Directory.CreateDirectory(dirPath);
            }
            if (System.IO.File.Exists(filePath)) { }
            else
            {
                System.IO.File.Create(filePath);
            }
            return filePath;
        }


        /// <summary>
        /// This Method is not supported any longer
        /// </summary>
        /// <returns></returns>
        /*
        public static API.Keys LoadKeysFromFile()
        {
            var text = System.IO.File.ReadAllText(@"D:\CSharp\repos\WazirxKey.json");
            return JsonConvert.DeserializeObject<API.Keys>(text);
        }*/

        public static long UTC()
        {
            return (long)Math.Round(Convert.ToDecimal(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds), 0);
            
        }
        internal static string TimeStamp()
        {
            return "&timestamp=" +//
            Math.Round(Convert.ToDecimal(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds), 0).ToString();
        }

        internal static string RecvWindow(int windowTime)
        {
            return "recvWindow=" + windowTime.ToString();
        }

        /// <summary>
        /// for trading provide tradeKey as secret
        /// </summary>
        /// <param name="queryString"></param>
        /// <param name="secret"></param>
        /// <returns></returns>
        internal static string SignatureStamp(string? queryString, string? mysecret)
        {
            //var key = LoadKeysFromFile();
            return "&signature=" +//            
            BitConverter.ToString(new HMACSHA256(Encoding.ASCII.GetBytes(mysecret)).ComputeHash(Encoding.ASCII.GetBytes(queryString))).Replace("-", string.Empty).ToLower();            
        }

        /// <summary>
        /// changes unix to human time
        /// </summary>
        public static class Time
        {
            public enum dateTimeFormat
            {
                local, unix
            };
            static long humanTimeFormat(DateTime dateTime)
            {
                return 1;
            }
            static long unixTimeFormat()
            {
                return 1;
            }
        }

        /// <summary>
        /// Creates a new json file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static void ListToJsonFile<T>(List<T> list,string? filename)
        {
            System.IO.File.WriteAllText(filename, JsonConvert.SerializeObject(list));
            System.Console.WriteLine("done");
        }
    }
}
