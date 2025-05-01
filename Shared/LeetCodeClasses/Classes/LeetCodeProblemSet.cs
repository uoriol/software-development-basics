using SoftwareDevelopmentCenter.Shared.LeetCodeClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDevelopmentCenter.Shared.LeetCodeClasses.Classes
{
    public class LeetCodeProblemSet<TInput, TOutput> : ILeetCodeProblemSet<TInput, TOutput>
    {
        public List<ILeetCodeProblem<TInput, TOutput>> Problems { get; } = new List<ILeetCodeProblem<TInput, TOutput>>();
    }
}
