namespace OLiOYouxi.OSystem.Tools.CEventsBase
{
    /// <summary>
    /// 给定委托事件
    /// </summary>
    public class OLiOCEventsBase
    {
        #region -- Void Events --
        internal delegate void VoidEvent0();
        internal delegate void VoidEvent1<T>(T a);
        internal delegate void VoidEvent2<T, Y>(T a, Y b);
        internal delegate void VoidEvent3<T, Y, U>(T a, Y b, U c);

        #endregion

        #region -- Object Events --
        internal delegate object ObjectEvent0();
        internal delegate object ObjectEvent1<T>(T a);
        internal delegate object ObjectEvent2<T, Y>(T a, Y b);
        internal delegate object ObjectEvent3<T, Y, U>(T a, Y b, U c);

        #endregion
    }


}
