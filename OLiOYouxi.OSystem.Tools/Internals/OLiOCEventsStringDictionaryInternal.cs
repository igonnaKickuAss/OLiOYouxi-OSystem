using System.Collections.Generic;

namespace OLiOYouxi.OSystem.Tools.CEvents
{
    using OLiOYouxi.OSystem.Tools.CEventsBase;

    /// <summary>
    /// 给定无参字典
    /// </summary>
    internal class OLiOCEventsStringDictionaryInternal
    {
        #region -- String Dictionary --
        internal Dictionary<string, OLiOCEventsBase.VoidEvent0> dic_StringVoidEvent0 = null;
        internal Dictionary<string, OLiOCEventsBase.ObjectEvent0> dic_StringObjectEvent0 = null;

        #endregion

        #region -- 单例 --
        static private OLiOCEventsStringDictionaryInternal _CEventsStringDictionary = null;

        /// <summary>
        /// 这是单例
        /// </summary>
        static internal OLiOCEventsStringDictionaryInternal Instance
        {
            get
            {
                if (_CEventsStringDictionary == null)
                {
                    _CEventsStringDictionary = new OLiOCEventsStringDictionaryInternal();
                    return _CEventsStringDictionary;
                }
                return _CEventsStringDictionary;
            }
        }

        #endregion

        #region -- 初始化 --
        private OLiOCEventsStringDictionaryInternal()
        {
            InitData();
        }

        private void InitData()
        {
            dic_StringVoidEvent0 = new Dictionary<string, OLiOCEventsBase.VoidEvent0>();

            dic_StringObjectEvent0 = new Dictionary<string, OLiOCEventsBase.ObjectEvent0>();
        }


        #endregion
    }

    /// <summary>
    /// 给定单参字典
    /// </summary>
    internal class OLiOCEventsStringDictionaryInternal<T>
    {
        #region -- String Dictionary --
        internal Dictionary<string, OLiOCEventsBase.VoidEvent1<T>> dic_StringVoidEvent1 = null;
        internal Dictionary<string, OLiOCEventsBase.ObjectEvent1<T>> dic_StringObjectEvent1 = null;

        #endregion

        #region -- ShotC --
        static private OLiOCEventsStringDictionaryInternal<T> _CEventsStringDictionary = null;

        /// <summary>
        /// 这是单例
        /// </summary>
        static internal OLiOCEventsStringDictionaryInternal<T> Instance
        {
            get
            {
                if (_CEventsStringDictionary == null)
                {
                    _CEventsStringDictionary = new OLiOCEventsStringDictionaryInternal<T>();
                    return _CEventsStringDictionary;
                }
                return _CEventsStringDictionary;
            }
        }

        #endregion

        #region -- 初始化 --
        private OLiOCEventsStringDictionaryInternal()
        {
            InitData();
        }

        private void InitData()
        {
            dic_StringVoidEvent1 = new Dictionary<string, OLiOCEventsBase.VoidEvent1<T>>();

            dic_StringObjectEvent1 = new Dictionary<string, OLiOCEventsBase.ObjectEvent1<T>>();
        }


        #endregion
    }

    /// <summary>
    /// 给定双参字典
    /// </summary>
    internal class OLiOCEventsStringDictionaryInternal<T, Y>
    {
        #region -- String Dictionary --
        internal Dictionary<string, OLiOCEventsBase.VoidEvent2<T, Y>> dic_StringVoidEvent2 = null;
        internal Dictionary<string, OLiOCEventsBase.ObjectEvent2<T, Y>> dic_StringObjectEvent2 = null;

        #endregion

        #region -- ShotC --
        static private OLiOCEventsStringDictionaryInternal<T, Y> _CEventsStringDictionary = null;

        /// <summary>
        /// 这是单例
        /// </summary>
        static internal OLiOCEventsStringDictionaryInternal<T, Y> Instance
        {
            get
            {
                if (_CEventsStringDictionary == null)
                {
                    _CEventsStringDictionary = new OLiOCEventsStringDictionaryInternal<T, Y>();
                    return _CEventsStringDictionary;
                }
                return _CEventsStringDictionary;
            }
        }

        #endregion

        #region -- 初始化 --
        private OLiOCEventsStringDictionaryInternal()
        {
            InitData();
        }

        private void InitData()
        {
            dic_StringVoidEvent2 = new Dictionary<string, OLiOCEventsBase.VoidEvent2<T, Y>>();

            dic_StringObjectEvent2 = new Dictionary<string, OLiOCEventsBase.ObjectEvent2<T, Y>>();
        }


        #endregion
    }

    /// <summary>
    /// 给定三参字典
    /// </summary>
    internal class OLiOCEventsStringDictionaryInternal<T, Y, U>
    {
        #region -- String Dictionary --
        internal Dictionary<string, OLiOCEventsBase.VoidEvent3<T, Y, U>> dic_StringVoidEvent3 = null;
        internal Dictionary<string, OLiOCEventsBase.ObjectEvent3<T, Y, U>> dic_StringObjectEvent3 = null;

        #endregion

        #region -- ShotC --
        static private OLiOCEventsStringDictionaryInternal<T, Y, U> _CEventsStringDictionary = null;

        /// <summary>
        /// 这是单例
        /// </summary>
        static internal OLiOCEventsStringDictionaryInternal<T, Y, U> Instance
        {
            get
            {
                if (_CEventsStringDictionary == null)
                {
                    _CEventsStringDictionary = new OLiOCEventsStringDictionaryInternal<T, Y, U>();
                    return _CEventsStringDictionary;
                }
                return _CEventsStringDictionary;
            }
        }

        #endregion

        #region -- 初始化 --
        private OLiOCEventsStringDictionaryInternal()
        {
            InitData();
        }

        private void InitData()
        {
            dic_StringVoidEvent3 = new Dictionary<string, OLiOCEventsBase.VoidEvent3<T, Y, U>>();

            dic_StringObjectEvent3 = new Dictionary<string, OLiOCEventsBase.ObjectEvent3<T, Y, U>>();
        }


        #endregion
    }
}
