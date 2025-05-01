using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDevelopmentCenter.Shared.LeetCodeClasses.Interfaces
{
    public interface ILeetCodeProblem<TInput, TOutput>
    {
        TInput Input { get; }
        TOutput Output { get; }

        TInput GenerateInputs();
        TOutput Solve(TInput input);
    }

    public abstract class LeetCodeProblemBase<TInput, TOutput> : ILeetCodeProblem<TInput, TOutput>
    {
        public TInput Input { get; }
        public TOutput Output { get; }

        protected LeetCodeProblemBase()
        {
            Input = GenerateInputs();
            Output = Solve(Input);
        }

        public abstract TInput GenerateInputs();
        public abstract TOutput Solve(TInput input);
    }
}
