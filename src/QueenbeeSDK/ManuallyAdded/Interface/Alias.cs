using System.Collections.Generic;

namespace QueenbeeSDK.Interface.Io.Inputs
{

    public partial interface IAlias: IoBase
    {
        List<string> Platform { get; set; }
        List<IOAliasHandler> Handler { get; set; }
        
    }
    

}

