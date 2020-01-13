
#if NET20||NET30 


namespace System.Runtime.CompilerServices
{
    /// <summary>
    /// 在.NET Framework 2.0 3.0 version 使用扩展方法
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class
         | AttributeTargets.Method)]
    public sealed class ExtensionAttribute : Attribute { }
}


#endif