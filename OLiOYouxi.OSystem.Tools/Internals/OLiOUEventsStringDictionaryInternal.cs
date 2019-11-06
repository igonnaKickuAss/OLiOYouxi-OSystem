using System.Collections.Generic;

namespace OLiOYouxi.OSystem.Tools.UEvents
{
    using OLiOYouxi.OSystem.Tools.UEventsBase;
    
    /// <summary>
    /// 给定无参字典
    /// </summary>
    internal class OLiOUEventsStringDictionaryInternal
    {
        #region -- String Dictionary --
        internal Dictionary<string, OLiOEvent> dic_StringOLiOEvent = null;

        #endregion

        #region -- 单例 --
        static private OLiOUEventsStringDictionaryInternal _UEventsStringDictionary = null;

        /// <summary>
        /// 这是单例
        /// </summary>
        static internal OLiOUEventsStringDictionaryInternal Instance
        {
            get
            {
                if (_UEventsStringDictionary == null)
                {
                    _UEventsStringDictionary = new OLiOUEventsStringDictionaryInternal();
                    return _UEventsStringDictionary;
                }
                return _UEventsStringDictionary;
            }
        }

        #endregion

        #region -- 初始化 --
        private OLiOUEventsStringDictionaryInternal()
        {
            InitData();
        }

        private void InitData()
        {
            dic_StringOLiOEvent = new Dictionary<string, OLiOEvent>();
            
        }
        
        #endregion
    }

    /// <summary>
    /// 给定泛型单参字典
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class OLiOUEventsStringDictionaryInternal<T>
    {
        #region -- String Dictionary --
        internal Dictionary<string, OLiOEvent<T>> dic_StringOLiOEventT = null;

        #endregion

        #region -- 单例 --
        static private OLiOUEventsStringDictionaryInternal<T> _UEventsStringDictionary = null;

        /// <summary>
        /// 这是单例
        /// </summary>
        static internal OLiOUEventsStringDictionaryInternal<T> Instance
        {
            get
            {
                if (_UEventsStringDictionary == null)
                {
                    _UEventsStringDictionary = new OLiOUEventsStringDictionaryInternal<T>();
                    return _UEventsStringDictionary;
                }
                return _UEventsStringDictionary;
            }
        }

        #endregion

        #region -- 初始化 --
        private OLiOUEventsStringDictionaryInternal()
        {
            InitData();
        }

        private void InitData()
        {
            dic_StringOLiOEventT = new Dictionary<string, OLiOEvent<T>>();

        }

        #endregion
    }

    /// <summary>
    /// 给定泛型双参字典
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="Y"></typeparam>
    internal class OLiOUEventsStringDictionaryInternal<T, Y>
    {
        #region -- String Dictionary --
        internal Dictionary<string, OLiOEvent<T, Y>> dic_StringOLiOEventTY = null;

        #endregion

        #region -- 单例 --
        static private OLiOUEventsStringDictionaryInternal<T, Y> _UEventsStringDictionary = null;

        /// <summary>
        /// 这是单例
        /// </summary>
        static internal OLiOUEventsStringDictionaryInternal<T, Y> Instance
        {
            get
            {
                if (_UEventsStringDictionary == null)
                {
                    _UEventsStringDictionary = new OLiOUEventsStringDictionaryInternal<T, Y>();
                    return _UEventsStringDictionary;
                }
                return _UEventsStringDictionary;
            }
        }

        #endregion

        #region -- 初始化 --
        private OLiOUEventsStringDictionaryInternal()
        {
            InitData();
        }

        private void InitData()
        {
            dic_StringOLiOEventTY = new Dictionary<string, OLiOEvent<T, Y>>();

        }

        #endregion
    }

    /// <summary>
    /// 给定泛型三参字典
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="Y"></typeparam>
    /// <typeparam name="U"></typeparam>
    internal class OLiOUEventsStringDictionaryInternal<T, Y, U>
    {
        #region -- String Dictionary --
        internal Dictionary<string, OLiOEvent<T, Y, U>> dic_StringOLiOEventTYU = null;

        #endregion

        #region -- 单例 --
        static private OLiOUEventsStringDictionaryInternal<T, Y, U> _UEventsStringDictionary = null;

        /// <summary>
        /// 这是单例
        /// </summary>
        static internal OLiOUEventsStringDictionaryInternal<T, Y, U> Instance
        {
            get
            {
                if (_UEventsStringDictionary == null)
                {
                    _UEventsStringDictionary = new OLiOUEventsStringDictionaryInternal<T, Y, U>();
                    return _UEventsStringDictionary;
                }
                return _UEventsStringDictionary;
            }
        }

        #endregion

        #region -- 初始化 --
        private OLiOUEventsStringDictionaryInternal()
        {
            InitData();
        }

        private void InitData()
        {
            dic_StringOLiOEventTYU = new Dictionary<string, OLiOEvent<T, Y, U>>();

        }

        #endregion
    }

    /// <summary>
    /// 给定泛型四参字典
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="Y"></typeparam>
    /// <typeparam name="U"></typeparam>
    /// <typeparam name="I"></typeparam>
    internal class OLiOUEventsStringDictionaryInternal<T, Y, U, I>
    {
        #region -- String Dictionary --
        internal Dictionary<string, OLiOEvent<T, Y, U, I>> dic_StringOLiOEventTYUI = null;

        #endregion

        #region -- 单例 --
        static private OLiOUEventsStringDictionaryInternal<T, Y, U, I> _UEventsStringDictionary = null;

        /// <summary>
        /// 这是单例
        /// </summary>
        static internal OLiOUEventsStringDictionaryInternal<T, Y, U, I> Instance
        {
            get
            {
                if (_UEventsStringDictionary == null)
                {
                    _UEventsStringDictionary = new OLiOUEventsStringDictionaryInternal<T, Y, U, I>();
                    return _UEventsStringDictionary;
                }
                return _UEventsStringDictionary;
            }
        }

        #endregion

        #region -- 初始化 --
        private OLiOUEventsStringDictionaryInternal()
        {
            InitData();
        }

        private void InitData()
        {
            dic_StringOLiOEventTYUI = new Dictionary<string, OLiOEvent<T, Y, U, I>>();

        }

        #endregion
    }
    
}
