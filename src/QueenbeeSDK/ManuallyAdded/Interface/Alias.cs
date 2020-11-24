using System.Collections.Generic;

namespace QueenbeeSDK.Interface.Io
{
    public partial interface IAlias 
    {
        List<string> Platform { get; set; }
        List<IOAliasHandler> Handler { get; set; }
        string Name { get; set; }
        Dictionary<string, string> Annotations { get; set; }
        string Description { get; set; }
        bool Required { get; set; }
        object Spec { get; set; }

    }
    

}

namespace QueenbeeSDK
{
    public partial class DAGLinkModelInputAlias : QueenbeeSDK.Interface.Io.IAlias
    {
    }
    //public partial class IOAliasHandler
    //{
    //    //public List<IOAliasHandler> Handler { get; set; }
    //}
}