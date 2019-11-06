namespace OLiOYouxi.OSystem.Singleton.Interfaces
{
    internal interface ISingletonMasterInternal<T>
        where T : class
    {
        T GetSingletonMaster { get; }
        T SetSingletonMaster { set; }
    }
}
