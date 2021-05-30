using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Application
{
    public interface ICommand<TRequest>
    {
        void Execute(TRequest request);
    }

    public interface IQuery<TSearch, TResult>
    {
        TResult Execute(TSearch search);
    }

    public interface IUseCase
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}
