namespace OLiOYouxi.OSystem.Tools.CEvents
{
    using OLiOYouxi.OSystem.Tools.CEventsBase;

    /// <summary>
    /// CustomEvents触发器。
    /// 1.可以注册(Register, RegisterObject)
    /// 2.可以调用(Invoke, InvokeObject)
    /// </summary>
    static internal class OLiOCEventsStringTriggersInternal
    {
        #region -- Void Register --
        static internal void Register(string key, OLiOCEventsBase.VoidEvent0 e)
        {
            if (OLiOCEventsStringDictionaryInternal.Instance.dic_StringVoidEvent0.ContainsKey(key))
                OLiOCEventsStringDictionaryInternal.Instance.dic_StringVoidEvent0[key] += e;
            else
                OLiOCEventsStringDictionaryInternal.Instance.dic_StringVoidEvent0.Add(key, e);
        }
        
        static internal void Register<T>(string key, OLiOCEventsBase.VoidEvent1<T> e)
        {
            if (OLiOCEventsStringDictionaryInternal<T>.Instance.dic_StringVoidEvent1.ContainsKey(key))
                OLiOCEventsStringDictionaryInternal<T>.Instance.dic_StringVoidEvent1[key] += e;
            else
                OLiOCEventsStringDictionaryInternal<T>.Instance.dic_StringVoidEvent1.Add(key, e);
        }
        
        static internal void Register<T, Y>(string key, OLiOCEventsBase.VoidEvent2<T, Y> e)
        {
            if (OLiOCEventsStringDictionaryInternal<T, Y>.Instance.dic_StringVoidEvent2.ContainsKey(key))
                OLiOCEventsStringDictionaryInternal<T, Y>.Instance.dic_StringVoidEvent2[key] += e;
            else
                OLiOCEventsStringDictionaryInternal<T, Y>.Instance.dic_StringVoidEvent2.Add(key, e);
        }
        
        static internal void Register<T, Y, U>(string key, OLiOCEventsBase.VoidEvent3<T, Y, U> e)
        {
            if (OLiOCEventsStringDictionaryInternal<T, Y, U>.Instance.dic_StringVoidEvent3.ContainsKey(key))
                OLiOCEventsStringDictionaryInternal<T, Y, U>.Instance.dic_StringVoidEvent3[key] += e;
            else
                OLiOCEventsStringDictionaryInternal<T, Y, U>.Instance.dic_StringVoidEvent3.Add(key, e);
        }

        #endregion

        #region -- Void Invoke --
        static internal void Invoke(string key)
        {
            if (OLiOCEventsStringDictionaryInternal.Instance.dic_StringVoidEvent0.ContainsKey(key))
                OLiOCEventsStringDictionaryInternal.Instance.dic_StringVoidEvent0[key].Invoke();
        }
        
        static internal void Invoke<T>(string key, T dataa)
        {
            if (OLiOCEventsStringDictionaryInternal<T>.Instance.dic_StringVoidEvent1.ContainsKey(key))
                OLiOCEventsStringDictionaryInternal<T>.Instance.dic_StringVoidEvent1[key].Invoke(dataa);
        }
        
        static internal void Invoke<T, Y>(string key, T dataa, Y datab)
        {
            if (OLiOCEventsStringDictionaryInternal<T, Y>.Instance.dic_StringVoidEvent2.ContainsKey(key))
                OLiOCEventsStringDictionaryInternal<T, Y>.Instance.dic_StringVoidEvent2[key].Invoke(dataa, datab);
        }
        
        static internal void Invoke<T, Y, U>(string key, T dataa, Y datab, U datac)
        {
            if (OLiOCEventsStringDictionaryInternal<T, Y, U>.Instance.dic_StringVoidEvent3.ContainsKey(key))
                OLiOCEventsStringDictionaryInternal<T, Y, U>.Instance.dic_StringVoidEvent3[key].Invoke(dataa, datab, datac);
        }

        #endregion

        #region -- Object Register --
        static internal void RegisterObject(string key, OLiOCEventsBase.ObjectEvent0 e)
        {
            if (OLiOCEventsStringDictionaryInternal.Instance.dic_StringObjectEvent0.ContainsKey(key))
                OLiOCEventsStringDictionaryInternal.Instance.dic_StringObjectEvent0[key] += e;
            else
                OLiOCEventsStringDictionaryInternal.Instance.dic_StringObjectEvent0.Add(key, e);
        }

        static internal void RegisterObject<T>(string key, OLiOCEventsBase.ObjectEvent1<T> e)
        {
            if (OLiOCEventsStringDictionaryInternal<T>.Instance.dic_StringObjectEvent1.ContainsKey(key))
                OLiOCEventsStringDictionaryInternal<T>.Instance.dic_StringObjectEvent1[key] += e;
            else
                OLiOCEventsStringDictionaryInternal<T>.Instance.dic_StringObjectEvent1.Add(key, e);
        }

        static internal void RegisterObject<T, Y>(string key, OLiOCEventsBase.ObjectEvent2<T, Y> e)
        {
            if (OLiOCEventsStringDictionaryInternal<T, Y>.Instance.dic_StringObjectEvent2.ContainsKey(key))
                OLiOCEventsStringDictionaryInternal<T, Y>.Instance.dic_StringObjectEvent2[key] += e;
            else
                OLiOCEventsStringDictionaryInternal<T, Y>.Instance.dic_StringObjectEvent2.Add(key, e);
        }

        static internal void RegisterObject<T, Y, U>(string key, OLiOCEventsBase.ObjectEvent3<T, Y, U> e)
        {
            if (OLiOCEventsStringDictionaryInternal<T, Y, U>.Instance.dic_StringObjectEvent3.ContainsKey(key))
                OLiOCEventsStringDictionaryInternal<T, Y, U>.Instance.dic_StringObjectEvent3[key] += e;
            else
                OLiOCEventsStringDictionaryInternal<T, Y, U>.Instance.dic_StringObjectEvent3.Add(key, e);
        }

        #endregion

        #region -- Object Invoke --
        static internal object InvokeObject(string key)
        {
            return OLiOCEventsStringDictionaryInternal.Instance.dic_StringObjectEvent0.ContainsKey(key) ? OLiOCEventsStringDictionaryInternal.Instance.dic_StringObjectEvent0[key].Invoke() : null;
        }

        static internal object InvokeObject<T>(string key, T dataa)
        {
            return OLiOCEventsStringDictionaryInternal<T>.Instance.dic_StringObjectEvent1.ContainsKey(key) ? OLiOCEventsStringDictionaryInternal<T>.Instance.dic_StringObjectEvent1[key].Invoke(dataa) : null;
        }

        static internal object InvokeObject<T, Y>(string key, T dataa, Y datab)
        {
            return OLiOCEventsStringDictionaryInternal<T, Y>.Instance.dic_StringObjectEvent2.ContainsKey(key) ? OLiOCEventsStringDictionaryInternal<T, Y>.Instance.dic_StringObjectEvent2[key].Invoke(dataa, datab) : null;
        }

        static internal object InvokeObject<T, Y, U>(string key, T dataa, Y datab, U datac)
        {
            return OLiOCEventsStringDictionaryInternal<T, Y, U>.Instance.dic_StringObjectEvent3.ContainsKey(key) ? OLiOCEventsStringDictionaryInternal<T, Y, U>.Instance.dic_StringObjectEvent3[key].Invoke(dataa, datab, datac) : null;
        }

        #endregion
    }
}
