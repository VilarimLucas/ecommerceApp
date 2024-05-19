using System.ComponentModel;

namespace api_rest.Enums
{
    public enum TaskStatus
    {
        [Description("A fazer")]
        ToDo = 1,

        [Description("Em andamento")]
        Doing = 2,

        [Description("Feito")]
        Done = 3
    }
}
