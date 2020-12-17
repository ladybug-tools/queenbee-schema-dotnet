using System.Linq;

namespace QueenbeeSDK
{
    public partial class Job
    {
        public void AddArgument(JobArgument arg)
        {
            if (Arguments == null) this.Arguments = new System.Collections.Generic.List<AnyOf<JobArgument, JobPathArgument>>();

            var existing = this.Arguments.OfType<JobArgument>().FirstOrDefault(_ => _.Name == arg.Name);
            if (existing == null)
                this.Arguments.Add(arg);
            else
                existing.Value = arg.Value;
        }
        public void AddArgument(JobPathArgument arg)
        {
            if (Arguments == null) this.Arguments = new System.Collections.Generic.List<AnyOf<JobArgument, JobPathArgument>>();

            var existing = this.Arguments.OfType<JobPathArgument>().FirstOrDefault(_ => _.Name == arg.Name);
            if (existing == null)
                this.Arguments.Add(arg);
            else
                existing.Source = arg.Source;
        }
    }
}