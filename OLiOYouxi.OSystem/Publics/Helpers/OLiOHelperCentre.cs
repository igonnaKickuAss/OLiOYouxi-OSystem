using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace OLiOYouxi.OSystem.Helpers
{
    /// <summary>
    /// 奥利奥帮你
    /// </summary>
    sealed public class OLiOHelperCentre
    {
        #region -- Enum APIMethods --
        /// <summary>
        /// 枚举转字符串
        /// </summary>
        /// <typeparam name="T">枚举型</typeparam>
        /// <param name="e">枚举</param>
        /// <param name="es">字符串</param>
        static public void EnumToString<T>(T e, out string es)
        {
            es = string.Empty;
            if (typeof(T).IsEnum)
                es = e.ToString();
        }

        /// <summary>
        /// 字符串转枚举
        /// </summary>
        /// <typeparam name="T">枚举型</typeparam>
        /// <param name="es">字符串</param>
        /// <param name="e">枚举</param>
        static public void StringToEnum<T>(string es, out T e)
        {
            e = default(T);
            if (typeof(T).IsEnum)
                e = (T)Enum.Parse(typeof(T), es);
        }

        #endregion

        #region -- Object Array APIMethods --
        /// <summary>
        /// （测试）添加一个默认元素到指定数组末尾
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        static public void AddOneElementToArray<T>() where T : new()
        {
            T[] arr = null;
            AddOneElementToArray<T>(ref arr);
        }

        /// <summary>
        /// 添加一个默认元素到指定数组末尾
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        static public void AddOneElementToArray<T>(ref T[] array) where T : new()
        {
            T[] arr = array;
            if (arr != null && arr.Length > 0)
            {
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = new T();
                array = arr;    //重新赋值
                return;
            }
            arr = new T[1];
            arr[0] = new T();
            array = arr;    //重新赋值
        }

        /// <summary>
        /// 添加一个指定元素到指定数组末尾
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        /// <param name="element">指定元素</param>
        static public void AddOneElementToArray<T>(ref T[] array, T element) where T : OLiOBaseObject, new()
        {
            int index = 0;
            if (array != null)
                index = array.Length;

            AddOneElementToArray<T>(ref array, element, index);
        }

        /// <summary>
        /// 添加一个默认元素到指定数组指定位置
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        /// <param name="element">指定元素</param>
        /// <param name="index">指定位置</param>
        static public void AddOneElementToArray<T>(ref T[] array, T element, int index) where T : new()
        {
            T[] arr = array;
            if (arr != null && element != null && arr.Length > 0)
            {
                if (index > array.Length)
                    return;

                Array.Resize(ref arr, arr.Length + 1);
                if (index < array.Length - 1)
                    Array.Copy(array, index, arr, index + 1, array.Length - index);
                arr[index] = element;        //赋值索引指定的元素
                array = arr;    //重新赋值
                return;
            }

            arr = new T[1];
            arr[0] = element;       //赋值最后一个元素
            array = arr;    //重新赋值
        }

        /// <summary>
        /// （测试）移除最后一个元素
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        static public void RemoveOneElementInArray<T>() where T : new()
        {
            T[] arr = new T[1];
            RemoveOneElementInArray<T>(ref arr);
        }

        /// <summary>
        /// 移除最后一个元素
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        static public void RemoveOneElementInArray<T>(ref T[] array) where T : new()
        {
            RemoveOneElementInArray<T>(ref array, array.Length - 1);
        }

        /// <summary>
        /// 移除指定元素
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        /// <param name="index">指定索引</param>
        static public void RemoveOneElementInArray<T>(ref T[] array, int index) where T : new()
        {
            RemoveOneElementInArray<T>(ref array, ref index);
        }

        /// <summary>
        /// 移除指定元素，改变当前索引位置
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        /// <param name="index">指定索引</param>
        static public void RemoveOneElementInArray<T>(ref T[] array, ref int index) where T : new()
        {
            if (array == null)
                return;

            T[] arr = array;
            ArrayList arrayOperation = new ArrayList();

            if (array.Length > 0 && index <= array.Length)
            {
                arrayOperation.AddRange(arr);
                arrayOperation.RemoveAt(index);
                T[] _arr = new T[arrayOperation.Count];
                arrayOperation.CopyTo(_arr);
                arrayOperation.Clear();
                array = _arr;        //重新赋值，之前的数组在该方法结束后不会再有任何这个方法里的变量去引用他了，出栈清空栈内存
                index -= 1;     //索引减一
            }
            //Debug.Log("没东西给你删除。。");
        }

        /// <summary>
        /// 移除当前指定元素，
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        /// <param name="element">指定元素</param>
        static public void RemoveOneElementInArray<T>(ref T[] array, ref T element) where T : new()
        {
            if (array == null)
                return;

            T[] arr = array;
            ArrayList arrayOperation = new ArrayList();

            if (array.Length > 0)
            {
                arrayOperation.AddRange(arr);
                arrayOperation.Remove(element);
                T[] _arr = new T[arrayOperation.Count];
                arrayOperation.CopyTo(_arr);
                arrayOperation.Clear();
                array = _arr;        //重新赋值，之前的数组在该方法结束后不会再有任何这个方法里的变量去引用他了，出栈清空栈内存
            }
            //Debug.Log("没东西给你删除。。");
        }

        /// <summary>
        /// 移除所有元素
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        static public void RemoveAllElementInArray<T>(ref T[] array) where T : new()
        {
            if (array == null)
                return;

            T[] arr = array;
            ArrayList arrayOperation = new ArrayList();

            //看上去可能很蠢，但是我喜欢啊
            if (arr.Length > 0)
            {
                arrayOperation.AddRange(arr);
                arrayOperation.RemoveRange(0, arr.Length);
                T[] _arr = new T[arrayOperation.Count];
                arrayOperation.CopyTo(_arr);
                array = _arr;   //重新赋值，之前的数组在该方法结束后不会再有任何这个方法里的变量去引用他了，出栈清空栈内存
            }
        }

        /// <summary>
        /// 清理数组元素
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        static public void ClearElementInArray<T>(ref T[] array) where T : new()
        {
            if (array == null)
                return;

            Array.Clear(array, 0, array.Length);
        }

        #endregion

        #region -- OLiOBaseObject Array APIMethods --
        /// <summary>
        /// （测试）奥利奥贝丝对象： 添加一个默认元素到指定数组末尾
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        static public void OArrayAddOne<T>() where T : OLiOBaseObject, new()
        {
            T[] arr = null;
            OArrayAddOne<T>(ref arr);
        }

        /// <summary>
        /// 奥利奥贝丝对象： 添加一个默认元素到指定数组末尾
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        static public void OArrayAddOne<T>(ref T[] array) where T : OLiOBaseObject, new()
        {
            string name = typeof(T).Name;
            OArrayAddOne<T>(ref array, name);
        }

        /// <summary>
        /// 奥利奥贝丝对象： 添加一个指定名称的到指定数组末尾
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        /// <param name="name">指定名字</param>
        static public void OArrayAddOne<T>(ref T[] array, string name) where T : OLiOBaseObject, new()
        {
            int index = 0;
            if (array != null)
                index = array.Length;

            OArrayAddOne<T>(ref array, name, index);
        }

        /// <summary>
        /// 奥利奥贝丝对象： 添加一个指定名称的到数组的指定位置
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        /// <param name="name">指定名字</param>
        /// <param name="index">指定位置</param>
        static public void OArrayAddOne<T>(ref T[] array, string name, int index) where T : OLiOBaseObject, new()
        {
            OArrayAddOne<T>(ref array, new T { baseName = $"{name} {index}" }, index);
        }

        /// <summary>
        /// 奥利奥贝丝对象： 添加一个指定元素的到数组的末尾
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        /// <param name="element">指定元素</param>
        static public void OArrayAddOne<T>(ref T[] array, T element) where T : OLiOBaseObject, new()
        {
            int index = 0;
            if (array != null)
                index = array.Length;

            OArrayAddOne<T>(ref array, element, index);
        }

        /// <summary>
        /// 奥利奥贝丝对象： 添加一个指定元素的到数组的指定位置
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        /// <param name="element">指定元素</param>
        /// <param name="index">指定位置</param>
        static public void OArrayAddOne<T>(ref T[] array, T element, int index) where T : OLiOBaseObject, new()
        {
            OLiOHelperCentre.AddOneElementToArray<T>(ref array, element, index);

            if (array.Length == 1)
                array[0].baseName = $"{typeof(T).Name} {index}";
        }

        /// <summary>
        /// （测试）奥利奥贝丝对象：移除指定数组末尾的一个元素
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        static public void OArrayRemoveOne<T>() where T : OLiOBaseObject, new()
        {
            T[] arr = new T[1];
            OArrayRemoveOne<T>(ref arr);
        }

        /// <summary>
        /// 奥利奥贝丝对象：移除指定数组末尾的一个元素
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        static public void OArrayRemoveOne<T>(ref T[] array) where T : OLiOBaseObject, new()
        {
            //移除最后一个元素
            OArrayRemoveOne<T>(ref array, array.Length - 1);
        }

        /// <summary>
        /// 奥利奥贝丝对象：移除指定数组的一个指定名字的元素
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        /// <param name="name">指定名字</param>
        static public void OArrayRemoveOne<T>(ref T[] array, string name) where T : OLiOBaseObject, new()
        {
            if (array == null)
                return;

            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                if (array[i] != null && (!array[i].baseName.Equals(name)))
                    continue;

                OArrayRemoveOne<T>(ref array, i);

                return;
            }

        }

        /// <summary>
        /// 奥利奥贝丝对象：移除指定位置的元素
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        /// <param name="index">指定位置</param>
        static public void OArrayRemoveOne<T>(ref T[] array, int index) where T : OLiOBaseObject, new()
        {
            OArrayRemoveOne<T>(ref array, ref index);
        }

        /// <summary>
        /// 奥利奥贝丝对象：移除指定位置的元素，改变当前索引位置
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        /// <param name="index">指定位置</param>
        static public void OArrayRemoveOne<T>(ref T[] array, ref int index) where T : OLiOBaseObject, new()
        {
            OLiOHelperCentre.RemoveOneElementInArray<T>(ref array, ref index);
        }

        /// <summary>
        /// 奥利奥贝丝对象：移除当前指定的元素
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        /// <param name="element">指定元素</param>
        static public void OArrayRemoveOne<T>(ref T[] array, T element) where T : OLiOBaseObject, new()
        {
            OLiOHelperCentre.RemoveOneElementInArray<T>(ref array, ref element);
        }

        /// <summary>
        /// 奥利奥贝丝对象：移除所有元素
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        static public void OArrayRemoveAll<T>(ref T[] array) where T : OLiOBaseObject, new()
        {
            OLiOHelperCentre.RemoveAllElementInArray<T>(ref array);
        }

        /// <summary>
        /// 奥利奥贝丝对象：清理数组元素
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        static public void OArrayClear<T>(ref T[] array) where T : OLiOBaseObject, new()
        {
            OLiOHelperCentre.ClearElementInArray<T>(ref array);
        }


        #endregion

        #region -- OLiOBaseStruct Array APIMethods --
        /// <summary>
        /// （测试）奥利奥贝丝值：添加一个默认元素（不初始化）到指定数组末尾
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        static public void SArrayAddOne<T>() where T : struct, OLiOBaseStruct
        {
            T[] arr = null;
            SArrayAddOne<T>(ref arr);
        }

        /// <summary>
        /// 奥利奥贝丝值：添加一个默认元素（不初始化）到指定数组末尾
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        static public void SArrayAddOne<T>(ref T[] array) where T : struct, OLiOBaseStruct
        {
            //string name = typeof(T).Name;
            SArrayAddOne<T>(ref array, false);
        }

        /// <summary>
        /// 奥利奥贝丝值：添加一个是否初始化的元素到指定数组末尾
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        /// <param name="useDefault">初始化吗</param>
        static public void SArrayAddOne<T>(ref T[] array, bool useDefault) where T : struct, OLiOBaseStruct
        {
            int index = 0;
            if (array != null)
                index = array.Length;

            SArrayAddOne<T>(ref array, useDefault, index);
        }

        /// <summary>
        /// 奥利奥贝丝值：添加一个是否初始化的元素到数组的指定位置
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        /// <param name="useDefault">初始化吗</param>
        /// <param name="index">指定位置</param>
        static public void SArrayAddOne<T>(ref T[] array, bool useDefault, int index) where T : struct, OLiOBaseStruct
        {
            T element = new T();
            if (useDefault)
                element.InitData();

            SArrayAddOne<T>(ref array, element, index);
        }

        /// <summary>
        /// 奥利奥贝丝值：添加一个指定元素到指定数组的末尾
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        /// <param name="element">指定元素</param>
        static public void SArrayAddOne<T>(ref T[] array, T element) where T : struct, OLiOBaseStruct
        {
            int index = 0;
            if (array != null)
                index = array.Length;

            SArrayAddOne<T>(ref array, element, index);
        }

        /// <summary>
        /// 奥利奥贝丝值：添加一个指定元素到数组的指定位置
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        /// <param name="element">指定元素</param>
        /// <param name="index">指定位置</param>
        static public void SArrayAddOne<T>(ref T[] array, T element, int index) where T : struct, OLiOBaseStruct
        {
            OLiOHelperCentre.AddOneElementToArray<T>(ref array, element, index);
        }

        /// <summary>
        /// （测试）奥利奥贝丝值：移除指定数组末尾的一个元素
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        static public void SArrayRemoveOne<T>() where T : struct, OLiOBaseStruct
        {
            T[] arr = new T[1];
            SArrayRemoveOne<T>(ref arr);
        }

        /// <summary>
        /// 奥利奥贝丝值：移除指定数组末尾的一个元素
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        static public void SArrayRemoveOne<T>(ref T[] array) where T : struct, OLiOBaseStruct
        {
            //移除最后一个元素
            SArrayRemoveOne<T>(ref array, array.Length - 1);
        }

        /// <summary>
        /// 奥利奥贝丝对象：移除指定位置的元素
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        /// <param name="index">指定位置</param>
        static public void SArrayRemoveOne<T>(ref T[] array, int index) where T : struct, OLiOBaseStruct
        {
            SArrayRemoveOne<T>(ref array, ref index);
        }

        /// <summary>
        /// 奥利奥贝丝对象：移除指定位置的元素，改变当前索引位置
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        /// <param name="index">指定位置</param>
        static public void SArrayRemoveOne<T>(ref T[] array, ref int index) where T : struct, OLiOBaseStruct
        {
            OLiOHelperCentre.RemoveOneElementInArray<T>(ref array, ref index);
        }

        /// <summary>
        /// 奥利奥贝丝对象：移除当前指定的元素
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        /// <param name="element">指定元素</param>
        static public void SArrayRemoveOne<T>(ref T[] array, T element) where T : struct, OLiOBaseStruct
        {
            OLiOHelperCentre.RemoveOneElementInArray<T>(ref array, ref element);
        }

        /// <summary>
        /// 奥利奥贝丝对象：移除所有元素
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        static public void SArrayRemoveAll<T>(ref T[] array) where T : struct, OLiOBaseStruct
        {
            OLiOHelperCentre.RemoveAllElementInArray<T>(ref array);
        }

        /// <summary>
        /// 奥利奥贝丝对象：清理数组元素
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="array">指定数组</param>
        static public void SArrayClear<T>(ref T[] array) where T : struct, OLiOBaseStruct
        {
            OLiOHelperCentre.ClearElementInArray<T>(ref array);
        }

        #endregion

        #region --- Public File APIMethods ---
        /// <summary>
        /// 读取
        /// </summary>
        /// <param name="_path">文件位置</param>
        /// <returns>字符串</returns>
        static public string Read(string _path)
        {
            try
            {
                StreamReader _sr = File.OpenText(_path);
                string _data = _sr.ReadToEnd();
                _sr.Close();
                return _data;
            }
            catch (Exception)
            {
                return "";
            }
        }

        /// <summary>
        /// 读取
        /// </summary>
        /// <param name="_paths">很多文件位置</param>
        /// <returns>字符串</returns>
        static public string Read(params string[] _paths)
        {
            return Read(CombinePaths(_paths));
        }

        /// <summary>
        /// 写入
        /// </summary>
        /// <param name="_data">数据</param>
        /// <param name="_path">文件位置</param>
        static public void Write(string _data, string _path)
        {
            try
            {
                CreateFolder(GetGlobalParentPath(_path));
                FileStream fs = new FileStream(_path, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
                sw.Write(_data);
                sw.Close();
                fs.Close();
            }
            catch (Exception)
            {
                return;
            }
        }

        /// <summary>
        /// 写入
        /// </summary>
        /// <param name="_data">数据</param>
        /// <param name="_paths">很多文件位置</param>
        static public void Write(string _data, params string[] _paths)
        {
            Write(_data, CombinePaths(_paths));
        }


        /// <summary>
        /// 文件转字节
        /// </summary>
        /// <param name="path">文件位置</param>
        /// <returns>字节数组</returns>
        static public byte[] FileToByte(string path)
        {
            if (File.Exists(path))
            {
                byte[] bytes = null;
                try
                {
                    bytes = File.ReadAllBytes(path);
                }
                catch
                {
                    return null;
                }
                return bytes;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 字节转文件
        /// </summary>
        /// <param name="bytes">很多字节</param>
        /// <param name="path">文件位置</param>
        /// <returns>布尔</returns>
        static public bool ByteToFile(byte[] bytes, string path)
        {
            try
            {
                string parentPath = new FileInfo(path).Directory.FullName;
                CreateFolder(parentPath);
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
                fs.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// 创建文件夹
        /// </summary>
        /// <param name="_path">文件夹位置</param>
        static public void CreateFolder(string _path)
        {
            _path = GetFullPath(_path);
            if (Directory.Exists(_path))
            {
                return;
            }
            string _parentPath = new FileInfo(_path).Directory.FullName;
            if (Directory.Exists(_parentPath))
            {
                Directory.CreateDirectory(_path);
            }
            else
            {
                CreateFolder(_parentPath);
                Directory.CreateDirectory(_path);
            }
        }

        /// <summary>
        /// 似否存在文件
        /// </summary>
        /// <param name="path">文件位置</param>
        /// <returns>布尔</returns>
        static public bool FileExist(string path)
        {
            return !string.IsNullOrEmpty(path) && File.Exists(path);
        }

        /// <summary>
        /// 似否存在目录
        /// </summary>
        /// <param name="path">文件夹位置</param>
        /// <returns>布尔</returns>
        static public bool DirectoryExist(string path)
        {
            return !string.IsNullOrEmpty(path) && Directory.Exists(path);
        }

        /// <summary>
        /// 似否存在文件或者目录
        /// </summary>
        /// <param name="path">位置</param>
        /// <returns>布尔</returns>
        static public bool FileOrDirectoryExist(string path)
        {
            return FileExist(path) || DirectoryExist(path);
        }

        /// <summary>
        /// 拷贝文件
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        static public void CopyFile(string from, string to)
        {
            CreateFolder(GetGlobalParentPath(to));
            File.Copy(from, to);
        }

        /// <summary>
        /// 移动文件
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        static public void MoveFile(string from, string to)
        {
            File.Move(from, to);
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="path">文件位置</param>
        static public void DeleteFile(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch { }
        }

        /// <summary>
        /// 删除目录
        /// </summary>
        /// <param name="path">文件位置</param>
        /// <param name="recursive">所有子目录</param>
        static public void DeleteDirectory(string path, bool recursive = true)
        {
            try
            {
                Directory.Delete(path, recursive);
            }
            catch { }
        }


        /// <summary>
        /// 删除指定位置的所有文件
        /// </summary>
        /// <param name="path">位置</param>
        /// <param name="exception"></param>
        static public void DeleteAllFilesIn(string path, string exception = "")
        {
            if (DirectoryExist(path))
            {
                string[] files = GetFilesIn(path);
                for (int i = 0; i < files.Length; i++)
                {
                    if (string.IsNullOrEmpty(exception) || GetName(files[i]) != GetName(exception))
                    {
                        DeleteFile(files[i]);
                    }
                }
            }
        }

        /// <summary>
        /// 字符串转字节
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        static public byte[] StringToByte(string data)
        {
            try
            {
                return System.Text.Encoding.UTF8.GetBytes(data);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 字节转字符串
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        static public string ByteToString(byte[] bytes)
        {
            try
            {
                return System.Text.Encoding.UTF8.GetString(bytes);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 分割字节数据以四字节为一块
        /// </summary>
        /// <param name="allBytes"></param>
        /// <returns></returns>
        static public byte[][] BreakData(byte[] allBytes)
        {
            try
            {
                List<byte[]> list = new List<byte[]>();
                int index = 0;
                while (index < allBytes.Length)
                {
                    int len = BitConverter.ToInt32(allBytes, index);
                    index += 4;
                    byte[] bytes = new byte[len];
                    Buffer.BlockCopy(allBytes, index, bytes, 0, len);
                    list.Add(bytes);
                    index += len;
                }
                return list.ToArray();
            }
            catch
            {
                return null;
            }
        }


        /// <summary>
        /// 合并数据
        /// </summary>
        /// <param name="bytess"></param>
        /// <returns></returns>
        static public byte[] MergeData(byte[][] bytess)
        {
            try
            {
                int allLen = 0;
                for (int i = 0; i < bytess.Length; i++)
                {
                    allLen += 4 + bytess[i].Length;
                }
                byte[] bytes = new byte[allLen];
                int index = 0;
                for (int i = 0; i < bytess.Length; i++)
                {
                    int len = bytess[i].Length;
                    Buffer.BlockCopy(BitConverter.GetBytes(len), 0, bytes, index, 4);
                    index += 4;
                    Buffer.BlockCopy(bytess[i], 0, bytes, index, len);
                    index += len;
                }
                return bytes;
            }
            catch
            {
                return null;
            }
        }




        #endregion

        #region --- Public Path APIMethods ---
        /// <summary>
        /// 完善路径讯息
        /// </summary>
        /// <param name="_path"></param>
        /// <returns></returns>
        static public string FixPath(string _path)
        {
            _path = _path.Replace('\\', '/');
            _path = _path.Replace("//", "/");
            while (_path.Length > 0 && _path[0] == '/')
            {
                _path = _path.Remove(0, 1);
            }
            return _path;
        }


        /// <summary>
        /// 拿到完整路径讯息
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static public string GetFullPath(string path)
        {
            return new FileInfo(path).FullName;
        }


        /// <summary>
        /// 组合所有路径
        /// </summary>
        /// <param name="paths"></param>
        /// <returns></returns>
        static public string CombinePaths(params string[] paths)
        {
            try
            {
                string path = "";
                for (int i = 0; i < paths.Length; i++)
                {
                    path = Path.Combine(path, FixPath(paths[i]));
                }
                return FixPath(path);
            }
            catch
            {
                return "";
            }
        }


        /// <summary>
        /// 拿到文件扩展名
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static public string GetExtension(string path)
        {
            return Path.GetExtension(path);// .xxx
        }


        /// <summary>
        /// 改变文件扩展名
        /// </summary>
        /// <param name="path"></param>
        /// <param name="newEx"></param>
        /// <returns></returns>
        static public string ChangeExtension(string path, string newEx)
        {
            return Path.ChangeExtension(path, newEx);
        }


        /// <summary>
        /// 拿到文件名
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static public string GetName(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        /// <summary>
        /// 拿到带扩展名的文件名
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static public string GetNameWithExtension(string path)
        {
            return Path.GetFileName(path);
        }


        /// <summary>
        /// 该路径似否为目录
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static public bool PathIsDirectory(string path)
        {
            FileAttributes attr = File.GetAttributes(path);
            return (attr & FileAttributes.Directory) == FileAttributes.Directory;
        }


        /// <summary>
        /// 拿到全局父类目录
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static public string GetGlobalParentPath(string path)
        {
            return new FileInfo(path).Directory.FullName;
        }

        /// <summary>
        /// 拿到统一资源定位器
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static public string GetUrl(string path)
        {
            return string.IsNullOrEmpty(path) ? "" : new Uri(path).AbsoluteUri;
        }

        /// <summary>
        /// 根据文件全名拿到文件路径
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        static public string GetFilePath(string fileName)
        {
            int i = 0;
            for (i = fileName.Length - 1; i >= 0; --i)
                if (fileName[i] == '/')
                    break;

            return fileName.Substring(0, i);
        }

        /// <summary>
        /// 拿到第一个文件的文件路径
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static public string GetFirstFilePath(string path)
        {
            try
            {
                if (DirectoryExist(path))
                {
                    FileInfo[] infos = new DirectoryInfo(path).GetFiles();
                    if (infos.Length > 0)
                    {
                        return infos[0].FullName;
                    }
                }
            }
            catch { }
            return "";
        }

        /// <summary>
        /// 拿到第一个文件的文件路径
        /// </summary>
        /// <param name="paths"></param>
        /// <returns></returns>
        static public string GetFirstFilePath(params string[] paths)
        {
            return GetFirstFilePath(CombinePaths(paths));
        }

        /// <summary>
        /// 拿到介个路径里的所有文件全名
        /// </summary>
        /// <param name="path"></param>
        /// <param name="searchs"></param>
        /// <returns></returns>
        static public string[] GetFilesIn(string path, params string[] searchs)
        {
            try
            {
                if (DirectoryExist(path))
                {
                    if (searchs == null || searchs.Length == 0)
                    {
                        return Directory.GetFiles(path);
                    }
                    else
                    {
                        List<string> paths = new List<string>();
                        for (int i = 0; i < searchs.Length; i++)
                        {
                            paths.AddRange(Directory.GetFiles(path, searchs[i], SearchOption.AllDirectories));
                        }
                        return paths.ToArray();
                    }
                }
            }
            catch { }
            return new string[0];
        }


        #endregion

        #region --- Public Other APIMethods ---
        /// <summary>
        /// 判断当前选择的
        /// </summary>
        static public bool IsTypeing
        {
            get
            {
                var g = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
                if (g)
                {
                    var input = g.GetComponent<UnityEngine.UI.InputField>();
                    return input && input.isFocused;
                }
                else
                {
                    return false;
                }
            }
        }


        #endregion

    }
}