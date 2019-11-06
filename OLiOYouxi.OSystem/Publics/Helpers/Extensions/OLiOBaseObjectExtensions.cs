using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OLiOYouxi.OSystem.Helpers
{
    /// <summary>
    /// 关于OLiOBaseObject的扩展方法
    /// </summary>
    static public class OLiOBaseObjectExtensions
    {
        /// <summary>
        /// 添加至数组
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="element"></param>
        /// <param name="array"></param>
        static public void AddToArray<T>(this T element, ref T[] array) where T : OLiOBaseObject, new()
        {
            OLiOHelperCentre.OArrayAddOne<T>(ref array, element);
        }

        /// <summary>
        /// 添加至数组
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="element"></param>
        /// <param name="array"></param>
        /// <param name="index"></param>
        static public void AddToArray<T>(this T element, ref T[] array, int index) where T : OLiOBaseObject, new()
        {
            OLiOHelperCentre.OArrayAddOne<T>(ref array, element, index);
        }

        /// <summary>
        /// 从数组中移除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="element"></param>
        /// <param name="array"></param>
        static public void RemoveSelf<T>(this T element, ref T[] array) where T : OLiOBaseObject, new()
        {
            OLiOHelperCentre.OArrayRemoveOne<T>(ref array, element);
        }
        
    }

}
