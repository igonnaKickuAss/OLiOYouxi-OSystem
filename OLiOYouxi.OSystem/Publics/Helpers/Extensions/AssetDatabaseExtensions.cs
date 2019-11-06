using UnityEngine;
using UnityEditor;

namespace OLiOYouxi.OSystem.Helpers.Extensions
{
    /// <summary>
    /// 关于AssetDatabase的扩展方法
    /// </summary>
    static public class AssetDatabaseExtensions
    {
        private const string extension = ".asset";
        private const string assetStorePath = "Assets/AssetsStorage";

        /// <summary>
        /// 在当前选中的文件夹中写入文件
        /// </summary>
        /// <typeparam name="T">可编辑对象</typeparam>
        /// <param name="file">文件名称</param>
        /// <param name="asset">文件</param>
        static public void WriteAssetInCurrentFolder<T>(string file, T asset) where T : ScriptableObject
        {
            WriteAssetInCurrentFolder<T>(file, ref asset);
        }

        /// <summary>
        /// 在当前选中的文件夹中写入文件
        /// </summary>
        /// <typeparam name="T">可编辑对象</typeparam>
        /// <param name="file">文件名称</param>
        /// <param name="asset">文件</param>
        static public void WriteAssetInCurrentFolder<T>(string file, ref T asset) where T : ScriptableObject
        {
            //拿到正确的文件名字
            OutCorrectedFilePath(out string filePath);

            //拿到正确的文件名字
            OutCorrectedFileName(ref filePath, ref file, out string fileName);

            //创建保存刷新文件
            CreateSaveRefreshAsset(ref fileName, ref asset);
        }

        /// <summary>
        /// 在当前选中的文件夹中写入你指定类型名字的文件
        /// </summary>
        /// <typeparam name="T">可编辑对象</typeparam>
        /// <param name="file">文件名称</param>
        static public void WriteAssetInCurrentFolderByName<T>(string file) where T : ScriptableObject
        {
            //拿到正确的文件名字
            OutCorrectedFilePath(out string filePath);

            //拿到正确的文件名字
            OutCorrectedFileName(ref filePath, ref file, out string fileName);

            //创建保存刷新文件
            CreateSaveRefreshAssetByName<T>(ref fileName);
        }

        /// <summary>
        /// 尝试在这个文件路径写入文件
        /// </summary>
        /// <typeparam name="T">可编辑对象</typeparam>
        /// <param name="filePath">文件路径</param>
        /// <param name="file">文件名称</param>
        /// <param name="asset">文件</param>
        static public void TryWriteAssetInThisFilePath<T>(this string filePath, string file, T asset) where T : ScriptableObject
        {
            filePath.TryWriteAssetInThisFilePath<T>(file, ref asset);
        }

        /// <summary>
        /// 尝试在这个文件路径写入文件
        /// </summary>
        /// <typeparam name="T">可编辑对象</typeparam>
        /// <param name="filePath">文件路径</param>
        /// <param name="file">文件名称</param>
        /// <param name="asset">文件</param>
        static public void TryWriteAssetInThisFilePath<T>(this string filePath, string file, ref T asset) where T : ScriptableObject
        {
            //拿到正确的文件名字
            OutCorrectedFileName(ref filePath, ref file, out string fileName);

            //创建保存刷新文件
            CreateSaveRefreshAsset(ref fileName, ref asset);
        }

        /// <summary>
        /// 尝试在这个文件路径写入你指定类型名字的文件
        /// </summary>
        /// <typeparam name="T">可编辑对象</typeparam>
        /// <param name="filePath">文件路径</param>
        /// <param name="file">文件名称</param>
        static public void TryWriteAssetInThisFilePathByName<T>(this string filePath, string file) where T : ScriptableObject
        {
            //拿到正确的文件名字
            OutCorrectedFileName(ref filePath, ref file, out string fileName);

            //创建保存刷新文件
            CreateSaveRefreshAssetByName<T>(ref fileName);
        }

        #region -- Private APIMethods --
        static private void OutCorrectedFilePath(out string filePath)
        {
            Object[] assets = Selection.GetFiltered<Object>(SelectionMode.TopLevel | SelectionMode.Assets);

            if (assets == null || assets.Length == 0)
            {
                filePath = assetStorePath;
                return;
            }

            filePath = AssetDatabase.GetAssetPath(assets[0]);

            if (OLiOHelperCentre.PathIsDirectory(filePath))
                return;

            filePath = OLiOHelperCentre.GetFilePath(filePath);
        }

        static private void OutCorrectedFileName(ref string filePath, ref string file, out string fileName)
        {
            int id = 1;

            //在这个位置新建文件夹
            OLiOHelperCentre.CreateFolder(filePath);

            //拿到文件名称
            fileName = OLiOHelperCentre.CombinePaths(filePath, $"{file}{extension}");

            //这个位置似否有重名
            while (OLiOHelperCentre.FileExist(fileName))
            {
                fileName = OLiOHelperCentre.CombinePaths(filePath, $"{file}{id}{extension}");

                id++;
            }
        }

        static private void CreateSaveRefreshAssetByName<T>(ref string fileName) where T : ScriptableObject
        {
            T asset = ScriptableObject.CreateInstance<T>();

            CreateSaveRefreshAsset<T>(ref fileName, ref asset);
        }

        static private void CreateSaveRefreshAsset<T>(ref string fileName, ref T asset) where T : ScriptableObject
        {
            //创建文件
            AssetDatabase.CreateAsset(asset, fileName);

            AssetDatabase.SaveAssets();

            AssetDatabase.Refresh();
        }

        #endregion
    }
}

