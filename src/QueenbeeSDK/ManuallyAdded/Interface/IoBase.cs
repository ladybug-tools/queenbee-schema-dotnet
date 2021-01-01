using System.Collections.Generic;

namespace QueenbeeSDK.Interface.Io.Inputs
{
    public partial interface IoBase
    {
        string Name { get; set; }
        Dictionary<string, string> Annotations { get; set; }
        string Description { get; set; }
        bool Required { get; set; }
        object Spec { get; set; }
    }

}

namespace QueenbeeSDK.Interface.Io.Outputs
{
    public partial interface IoBase
    {
        string Name { get; set; }
        Dictionary<string, string> Annotations { get; set; }
        string Description { get; set; }
    }

}