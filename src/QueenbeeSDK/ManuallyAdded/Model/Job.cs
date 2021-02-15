using System.Linq;
using System.Collections.Generic;

namespace QueenbeeSDK
{
    public partial class Job
    {
        public void AddArgumentSet(List<AnyOf<JobArgument, JobPathArgument>> arg = default)
        {
            this.Arguments = Arguments ?? new List<List<AnyOf<JobArgument, JobPathArgument>>>();
            var argSet = arg ?? new List<AnyOf<JobArgument, JobPathArgument>>();
            this.Arguments.Add(argSet);
        }
        public bool AddArgumentToTheLast(JobArgument arg)
        {
            this.Arguments = Arguments ?? new List<List<AnyOf<JobArgument, JobPathArgument>>>();
            var argSet = this.Arguments.LastOrDefault();
            argSet = argSet ?? new List<AnyOf<JobArgument, JobPathArgument>>();

            var existing = argSet.OfType<JobArgument>().FirstOrDefault(_ => _.Name == arg.Name);
            if (existing == null)
                argSet.Add(arg);
            else
                existing.Value = arg.Value;

            this.Arguments.Add(argSet);
            return true;
        }
        public bool AddArgumentToTheLast(JobPathArgument arg)
        {
            this.Arguments = Arguments ?? new List<List<AnyOf<JobArgument, JobPathArgument>>>();
            var argSet = this.Arguments.LastOrDefault();
            argSet = argSet ?? new List<AnyOf<JobArgument, JobPathArgument>>();

            var existing = argSet.OfType<JobPathArgument>().FirstOrDefault(_ => _.Name == arg.Name);
            if (existing == null)
                argSet.Add(arg);
            else
                existing.Source = arg.Source;

            this.Arguments.Add(argSet);
            return true;
        }
    }
}