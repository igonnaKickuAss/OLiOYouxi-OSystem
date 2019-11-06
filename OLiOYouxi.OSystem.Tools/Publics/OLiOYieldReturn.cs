using UnityEngine;

namespace OLiOYouxi.OSystem.Tools
{
    using OLiOYouxi.OSystem;

    /// <summary>
    /// 奥利奥yield returns
    /// </summary>
    public class OLiOYieldReturn : OLiOSingletonMaster<OLiOYieldReturn>
    {
        private OLiOYieldReturn(int fourBytes) : base(fourBytes)
        {
            waitForEndOfFrame = new WaitForEndOfFrame();
            waitForFixedUpdate = new WaitForFixedUpdate();
            waitForOne = new WaitForSeconds(1.0f);
            waitForTwo = new WaitForSeconds(2.0f);
            waitForOneRealtime = new WaitForSecondsRealtime(1.0f);
            waitForTwoRealtime = new WaitForSecondsRealtime(2.0f);
        }

        #region -- Private Data --
        private WaitForEndOfFrame waitForEndOfFrame = null;
        private WaitForFixedUpdate waitForFixedUpdate = null;
        private WaitForSeconds waitForOne = null;
        private WaitForSeconds waitForTwo = null;
        private WaitForSecondsRealtime waitForOneRealtime = null;
        private WaitForSecondsRealtime waitForTwoRealtime = null;
        private WaitForSecondsRealtime waitForFullRealtime = null;

        #endregion

        #region -- Public ShotC --
        /// <summary>
        /// 设置等待时间（真实时间）
        /// </summary>
        public float SetWaitForFullSecondsRealtime
        {
            set {

                if (waitForFullRealtime == null)
                {
                    waitForFullRealtime = new WaitForSecondsRealtime(value);
                    return;
                }

                waitForFullRealtime.waitTime = value;
            }
        }

        #endregion

        #region -- Public APIMethods --
        /// <summary>
        /// 等待至所有物体渲染完成时（就在绘制画面到屏幕之前）
        /// </summary>
        /// <returns>WaitForEndOfFrame</returns>
        public WaitForEndOfFrame GetWaitForEndOfFrame()
        {
            return waitForEndOfFrame;
        }

        /// <summary>
        /// 等待到下次FixedUpdate
        /// </summary>
        /// <returns>WaitForFixedUpdate</returns>
        public WaitForFixedUpdate GetWaitForFixedUpdate()
        {
            return waitForFixedUpdate;
        }

        /// <summary>
        /// 等待一秒钟（内部时间）
        /// </summary>
        /// <returns>WaitForSeconds</returns>
        public WaitForSeconds GetWaitForOneSeccond()
        {
            return waitForOne;
        }

        /// <summary>
        /// 等待两秒钟（内部时间）
        /// </summary>
        /// <returns>WaitForSeconds</returns>
        public WaitForSeconds GetWaitForTwoSecconds()
        {
            return waitForTwo;
        }

        /// <summary>
        /// 等待一秒钟（真实时间）
        /// </summary>
        /// <returns>WaitForSecondsRealtime</returns>
        public WaitForSecondsRealtime GetWaitForOneSeccondRealtime()
        {
            return waitForOneRealtime;
        }

        /// <summary>
        /// 等待两秒种（真实时间）
        /// </summary>
        /// <returns>WaitForSecondsRealtime</returns>
        public WaitForSecondsRealtime GetWaitForTwoSeccondsRealtime()
        {
            return waitForTwoRealtime;
        }

        /// <summary>
        /// 等待你指定的时间（真实时间）
        /// </summary>
        /// <param name="waitTime">时间</param>
        /// <returns>WaitForSecondsRealtime</returns>
        public WaitForSecondsRealtime GetWaitForFullSecondsRealtime(float waitTime)
        {
            SetWaitForFullSecondsRealtime = waitTime;
            return waitForFullRealtime;
        }

        #endregion
    }
}
