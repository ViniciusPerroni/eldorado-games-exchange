using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesExchange.Application.lib
{
    public class GenericOutput<T>
    {
        public GenericOutput()
        {
            Errors = new List<string>();
        }

        public GenericOutput(T data) : this()
        {
            Data = data;
        }

        public T Data { get; set; }
        public IList<string> Errors { get; set; }
        public bool Ok { get { return Errors.Count == 0; } }
        public PageSummary Summary { get; set; }

        public void AddError(string error)
        {
            Errors.Add(error);
        }
        public void AddErrors(IList<string> errors)
        {
            ((List<string>)Errors).AddRange(errors);
        }
    }
}
