using UnityEngine;

namespace OLiOYouxi.OSystem.Tools
{
    using OLiOYouxi.OSystem.Singleton;
    using OLiOYouxi.OSystem.Helpers;

    /// <summary>
    /// 奥利奥抵霸哥
    /// </summary>
    sealed public class OLiODebugger : OLiOSingletonMaster<OLiODebugger>
    {
        private OLiODebugger(int fourBytes) : base(fourBytes)
        {

        }

        #region -- Private Data --
        private string colorString = string.Empty;
        private string colorName = string.Empty;

        #endregion

        #region -- Public APIMethods --
        /// <summary>
        /// 记录讯息
        /// </summary>
        /// <param name="message">讯息</param>
        /// <param name="color">色</param>
        public void ToDebugLog(string message, OLiOEnumCentre.ColorName color)
        {
            colorName = string.Empty;
            OLiOHelperCentre.EnumToString(color, out colorName);
            if (colorName == string.Empty)
                return;
            Debug.LogFormat(colorString.Insert(7, colorName), message);
        }

        /// <summary>
        /// 记录讯息（警告）
        /// </summary>
        /// <param name="message">讯息</param>
        /// <param name="color">色</param>
        public void ToDebugLogWarn(string message, OLiOEnumCentre.ColorName color)
        {
            colorName = string.Empty;
            OLiOHelperCentre.EnumToString(color, out colorName);
            if (colorName == string.Empty)
                return;
            Debug.LogWarningFormat(colorString.Insert(7, colorName), message);
        }

        /// <summary>
        /// 记录讯息（错误）
        /// </summary>
        /// <param name="message">讯息</param>
        /// <param name="color">色</param>
        public void ToDebugLogErr(string message, OLiOEnumCentre.ColorName color)
        {
            colorName = string.Empty;
            OLiOHelperCentre.EnumToString(color, out colorName);
            if (colorName == string.Empty)
                return;
            Debug.LogErrorFormat(colorString.Insert(7, colorName), message);
        }

        #endregion
    }
}
