using System;
using Dalworth.SDK;

namespace Dalworth.Domain
{
    public partial class TaskItemRequirement : ICounterField
    {
        public TaskItemRequirement(){}

        #region ICounterField Members

        public int CounterValue
        {
            get { return m_iD; }
            set { m_iD = value; }
        }

        public string CounterName
        {
            get { return "TaskItemRequirement"; }
        }

        #endregion        
    }
}
      