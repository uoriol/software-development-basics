using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDevelopmentCenter.Shared.LeetCodeClasses.Interfaces
{

    public interface ILeetCodeProblemSet<TInput, TOutput>
    {
        List<ILeetCodeProblem<TInput, TOutput>> Problems { get; }
    }
}
