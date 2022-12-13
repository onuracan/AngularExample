using IsTakipSistemi.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakipSistemi.Core.Return;

[Serializable]
public class AppReturn<T> where T : class
{
    public AppReturn()
    {
        this.Errors = new List<string>();
        this.Message = "-";
    }

    public T Entity { get; set; }
    public List<T> EntityList { get; set; }
    public Retcode Retcode { get; set; }
    public string Message { get; set; }
    public List<string> Errors { get; set; }
    public object GenObject { get; set; }
}