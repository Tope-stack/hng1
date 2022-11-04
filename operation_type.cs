using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;

namespace hng_task_1
{
    public enum operation_type
    {
        [EnumMember(Value = "addition")]
        addition,
        [EnumMember(Value = "subtraction")]
        subtraction,
        [EnumMember(Value ="multiplication")]
        multiplication
    }

    /* public enum operation_type
     {
         addition,
         subtraction,
         multiplication
     }*/
 /*   public static class operation_type
    {
        public const string addition = "addition"; 

        public const string subtraction = "subtraction";

        public const string multiplication = "multiplication";

    }*/
}
