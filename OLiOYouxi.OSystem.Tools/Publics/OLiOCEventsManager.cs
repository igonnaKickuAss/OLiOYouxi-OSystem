using UnityEngine;
using System;

namespace OLiOYouxi.OSystem.Tools
{
    using OLiOYouxi.OSystem.Tools.CEvents;
    using OLiOYouxi.OSystem.Tools.CEventsBase;

    /// <summary>
    /// CustomEvents管理
    /// 1.PutIn(写入字典)
    /// 2.LookUp(查询字典并且执行该结果)
    /// </summary>
    public class OLiOCEventsManager : OLiOSingletonMaster<OLiOCEventsManager>
    {
        private OLiOCEventsManager(int fourBytes) : base(fourBytes)
        {
            defaultKey = "奥利奥";
        }

        #region -- Private Data --
        private string defaultKey = string.Empty;

        #endregion

        #region -- PutInVoid APIMethods --
        /// <summary>
        /// CEvent数据写入无返回值字典
        /// </summary>
        public void PutCEventInVoidDic()
        {
            PutCEventInVoidDic(defaultKey, () =>
            {
                Debug.Log(string.Format(
                    "<color=green>{0}</color>：已经调用(这是一个无参无返回值函数)。",
                    defaultKey
                    ));
            });
        }

        /// <summary>
        /// CEvent数据写入无返回值字典
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="ve0A">无参无返回值委托</param>
        public void PutCEventInVoidDic(string key, Action ve0A)
        {
            OLiOCEventsBase.VoidEvent0 @void = new OLiOCEventsBase.VoidEvent0(ve0A);
            OLiOCEventsStringTriggersInternal.Register(key, @void);
        }

        /// <summary>
        /// CEvent数据写入无返回值字典
        /// </summary>
        /// <typeparam name="T">无返回值委托的参数T</typeparam>
        /// <param name="key">键</param>
        /// <param name="ve1A">无返回值委托</param>
        public void PutCEventInVoidDic<T>(string key, Action<T> ve1A)
        {
            OLiOCEventsBase.VoidEvent1<T> @void = new OLiOCEventsBase.VoidEvent1<T>(ve1A);
            OLiOCEventsStringTriggersInternal.Register<T>(key, @void);
        }

        /// <summary>
        /// CEvent数据写入无返回值字典
        /// </summary>
        /// <typeparam name="T">无返回值委托的参数T</typeparam>
        /// <typeparam name="Y">无返回值委托的参数Y</typeparam>
        /// <param name="key">键</param>
        /// <param name="ve2A">无返回值委托</param>
        public void PutCEventInVoidDic<T, Y>(string key, Action<T, Y> ve2A)
        {
            OLiOCEventsBase.VoidEvent2<T, Y> @void = new OLiOCEventsBase.VoidEvent2<T, Y>(ve2A);
            OLiOCEventsStringTriggersInternal.Register<T, Y>(key, @void);
        }

        /// <summary>
        /// CEvent数据写入无返回值字典
        /// </summary>
        /// <typeparam name="T">无返回值委托的参数T</typeparam>
        /// <typeparam name="Y">无返回值委托的参数Y</typeparam>
        /// <typeparam name="U">无返回值委托的参数U</typeparam>
        /// <param name="key">键</param>
        /// <param name="ve3A">无返回值委托</param>
        public void PutCEventInVoidDic<T, Y, U>(string key, Action<T, Y, U> ve3A)
        {
            OLiOCEventsBase.VoidEvent3<T, Y, U> @void = new OLiOCEventsBase.VoidEvent3<T, Y, U>(ve3A);
            OLiOCEventsStringTriggersInternal.Register<T, Y, U>(key, @void);
        }
        
        #endregion

        #region -- LookUpVoid APIMethods --
        /// <summary>
        /// CEvent数据在无返回值字典中查询
        /// </summary>
        public void LookUpCEventToVoidDic()
        {
            LookUpCEventToVoidDic(defaultKey);
        }

        /// <summary>
        /// CEvent数据在无返回值字典中查询
        /// </summary>
        /// <param name="key">键</param>
        public void LookUpCEventToVoidDic(string key)
        {
            OLiOCEventsStringTriggersInternal.Invoke(key);
        }

        /// <summary>
        /// CEvent数据在无返回值字典中查询
        /// </summary>
        /// <typeparam name="T">无返回值委托的参数一类型</typeparam>
        /// <param name="key">键</param>
        /// <param name="obj0">无返回值委托的参数一</param>
        public void LookUpCEventToVoidDic<T>(string key, T obj0)
        {
            OLiOCEventsStringTriggersInternal.Invoke<T>(key, obj0);
        }

        /// <summary>
        /// CEvent数据在无返回值字典中查询
        /// </summary>
        /// <typeparam name="T">无返回值委托的参数一类型</typeparam>
        /// <typeparam name="Y">无返回值委托的参数二类型</typeparam>
        /// <param name="key">键</param>
        /// <param name="obj0">无返回值委托的参数一</param>
        /// <param name="obj1">无返回值委托的参数二</param>
        public void LookUpCEventToVoidDic<T, Y>(string key, T obj0, Y obj1)
        {
            OLiOCEventsStringTriggersInternal.Invoke<T, Y>(key, obj0, obj1);
        }

        /// <summary>
        /// CEvent数据在无返回值字典中查询
        /// </summary>
        /// <typeparam name="T">无返回值委托的参数一类型</typeparam>
        /// <typeparam name="Y">无返回值委托的参数二类型</typeparam>
        /// <typeparam name="U">无返回值委托的参数三类型</typeparam>
        /// <param name="key">键</param>
        /// <param name="obj0">无返回值委托的参数一</param>
        /// <param name="obj1">无返回值委托的参数二</param>
        /// <param name="obj2">无返回值委托的参数三</param>
        public void LookUpCEventToVoidDic<T, Y, U>(string key, T obj0, Y obj1, U obj2)
        {
            OLiOCEventsStringTriggersInternal.Invoke<T, Y, U>(key, obj0, obj1, obj2);
        }

        #endregion

        #region -- PutInObject APIMethods --
        /// <summary>
        /// CEvent数据写入有返回值字典
        /// </summary>
        public void PutCEventInObjectDic()
        {
            PutCEventInObjectDic(defaultKey, () =>
            {
                Debug.Log(string.Format(
                    "<color=green>{0}</color>：已经调用(这是一个无参有返回值函数)。",
                    defaultKey
                    ));
                return null;
            });
        }

        /// <summary>
        /// CEvent数据写入有返回值字典
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="oe0F">无参有返回值委托</param>
        public void PutCEventInObjectDic(string key, Func<object> oe0F)
        {
            OLiOCEventsBase.ObjectEvent0 @object = new OLiOCEventsBase.ObjectEvent0(oe0F);
            OLiOCEventsStringTriggersInternal.RegisterObject(key, @object);
        }

        /// <summary>
        /// CEvent数据写入有返回值字典
        /// </summary>
        /// <typeparam name="T">有返回值委托的参数T</typeparam>
        /// <param name="key">键</param>
        /// <param name="oe1F">有返回值委托</param>
        public void PutCEventInObjectDic<T>(string key, Func<T, object> oe1F)
        {
            OLiOCEventsBase.ObjectEvent1<T> @object = new OLiOCEventsBase.ObjectEvent1<T>(oe1F);
            OLiOCEventsStringTriggersInternal.RegisterObject<T>(key, @object);
        }

        /// <summary>
        /// CEvent数据写入有返回值字典
        /// </summary>
        /// <typeparam name="T">有返回值委托的参数T</typeparam>
        /// <typeparam name="Y">有返回值委托的参数Y</typeparam>
        /// <param name="key">键</param>
        /// <param name="oe2F">有返回值委托</param>
        public void PutCEventInObjectDic<T, Y>(string key, Func<T, Y, object> oe2F)
        {
            OLiOCEventsBase.ObjectEvent2<T, Y> @object = new OLiOCEventsBase.ObjectEvent2<T, Y>(oe2F);
            OLiOCEventsStringTriggersInternal.RegisterObject<T, Y>(key, @object);
        }

        /// <summary>
        /// CEvent数据写入有返回值字典
        /// </summary>
        /// <typeparam name="T">有返回值委托的参数T</typeparam>
        /// <typeparam name="Y">有返回值委托的参数Y</typeparam>
        /// <typeparam name="U">有返回值委托的参数U</typeparam>
        /// <param name="key">键</param>
        /// <param name="oe3F">有返回值委托</param>
        public void PutCEventInObjectDic<T, Y, U>(string key, Func<T, Y, U, object> oe3F)
        {
            OLiOCEventsBase.ObjectEvent3<T, Y, U> @object = new OLiOCEventsBase.ObjectEvent3<T, Y, U>(oe3F);
            OLiOCEventsStringTriggersInternal.RegisterObject<T, Y, U>(key, @object);
        }

        #endregion

        #region -- LookUpObject APIMethods --
        /// <summary>
        /// CEvent数据在有返回值字典中查询
        /// </summary>
        /// <returns>object</returns>
        public object LookUpCEventToObjectDic()
        {
            return LookUpCEventToObjectDic(defaultKey);
        }

        /// <summary>
        /// CEvent数据在有返回值字典中查询
        /// </summary>
        /// <param name="key">键</param>
        /// <returns>object</returns>
        public object LookUpCEventToObjectDic(string key)
        {
            return OLiOCEventsStringTriggersInternal.InvokeObject(key);
        }

        /// <summary>
        /// CEvent数据在有返回值字典中查询
        /// </summary>
        /// <typeparam name="T">有返回值委托的参数一类型</typeparam>
        /// <param name="key">键</param>
        /// <param name="obj0">有返回值委托的参数一</param>
        /// <returns>object</returns>
        public object LookUpCEventToObjectDic<T>(string key, T obj0)
        {
            return OLiOCEventsStringTriggersInternal.InvokeObject<T>(key, obj0);
        }

        /// <summary>
        /// CEvent数据在有返回值字典中查询
        /// </summary>
        /// <typeparam name="T">有返回值委托的参数一类型</typeparam>
        /// <typeparam name="Y">有返回值委托的参数二类型</typeparam>
        /// <param name="key">键</param>
        /// <param name="obj0">有返回值委托的参数一</param>
        /// <param name="obj1">有返回值委托的参数二</param>
        /// <returns>object</returns>
        public object LookUpCEventToObjectDic<T, Y>(string key, T obj0, Y obj1)
        {
            return OLiOCEventsStringTriggersInternal.InvokeObject<T, Y>(key, obj0, obj1);
        }

        /// <summary>
        /// CEvent数据在有返回值字典中查询
        /// </summary>
        /// <typeparam name="T">有返回值委托的参数一类型</typeparam>
        /// <typeparam name="Y">有返回值委托的参数二类型</typeparam>
        /// <typeparam name="U">有返回值委托的参数三类型</typeparam>
        /// <param name="key">键</param>
        /// <param name="obj0">有返回值委托的参数一</param>
        /// <param name="obj1">有返回值委托的参数二</param>
        /// <param name="obj2">有返回值委托的参数三</param>
        /// <returns>object</returns>
        public object LookUpCEventToObjectDic<T, Y, U>(string key, T obj0, Y obj1, U obj2)
        {
            return OLiOCEventsStringTriggersInternal.InvokeObject<T, Y, U>(key, obj0, obj1, obj2);
        }


        #endregion
    }
}
