using UnityEngine;

namespace Strategy
{
    public class DefaultLog : ILog
    {
        public void WriteLog()
            => Debug.Log("Default log!");
    }
}
