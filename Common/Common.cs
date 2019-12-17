// <copyright file="Common.cs" company="">
// All rights reserved. Allware Technology source code is an unpublished work and the
// use of a copyright notice does not imply otherwise. This source code contains
// confidential, trade secret material of Allware. Any attempt or participation
// in deciphering, decoding, reverse engineering or in any way altering the source
// code is strictly prohibited, unless the prior written consent of Company Name
// is obtained.
// </copyright>
// <date>       Created : 2019/12/16   </date>
// <brief>      Description :  
// </brief>
// <author>     BoRen
// </author>

namespace AlCommon.Util
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Reflection;
    using Microsoft.Win32;
    using System.IO;

    /// <summary>
    /// 一般常用的函式放在這裏
    /// </summary>
    public class Common
    {
        #region Private Member
        /// <summary>
        /// 讓程式自動退出的機制
        /// </summary>
        private static Cleaner _cleaner = new Cleaner();

        /// <summary>
        /// 是否結束，此flag特別用在Wait()，若是無限等待的話，Wait()會進入後退不出來，特別用此flag通知
        /// </summary>
        private static bool _isExit { get; set; }
        #endregion

        #region Inner class
        /// <summary>
        /// 用來設定Common._isExit = true, 確保所有的wait(無限等待)的情況可以避免，否則AP程式會無法結束
        /// </summary>
        private class Cleaner
        {
            /// <summary>
            /// 建構子
            /// </summary>
            public Cleaner()
            {
            }

            /// <summary>
            /// 解構子
            /// </summary>
            ~Cleaner()
            {
                Common._isExit = true;
            }
        }
        #endregion

        #region Constant
        /// <summary>
        /// For Wait()
        /// </summary>
        private static TimeSpan InfiniteTimeout = TimeSpan.FromMilliseconds(-1);

        /// <summary>
        /// Wait() Function loop wait time
        /// </summary>
        private const Int32 MAX_WAIT = 100;
        #endregion

        /// <summary>
        /// 無條件捨去
        /// </summary>
        /// <param name="input">值</param>
        /// <param name="digit">位數</param>
        /// <returns>回傳無條件捨去的值</returns>
        public static double Floor(double input, int digit)
        {
            if (digit < 0)
                return Math.Floor(input);

            double pow = Math.Pow(10, digit);
            double sign = (input >= 0) ? 1 : -1;

            double cc = Math.Floor(sign * input * pow);

            return sign * Math.Floor(sign * input * pow) / pow;
        }

        /// <summary>
        /// 深層複製
        /// </summary>
        /// <typeparam name="T">複製型態</typeparam>
        /// <param name="obj">要複製的物件</param>
        /// <returns>回傳複製的物件</returns>
        public static T DeepClone<T>(T obj)
        {
            using(var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }
    }
}
