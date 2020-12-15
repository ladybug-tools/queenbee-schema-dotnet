namespace QueenbeeSDK
{
    public partial class Job
    {
        public void AddArgument(JobArgument arg)
        {
            if (Arguments == null) this.Arguments = new System.Collections.Generic.List<AnyOf<JobArgument, JobPathArgument>>();
            this.Arguments.Add(arg);
        }
        public void AddArgument(JobPathArgument arg)
        {
            if (Arguments == null) this.Arguments = new System.Collections.Generic.List<AnyOf<JobArgument, JobPathArgument>>();
            this.Arguments.Add(arg);
        }
    }
}