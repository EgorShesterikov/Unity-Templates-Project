using UnityEngine;

namespace Strategy
{
    public class FullLog : ILog
    {
        public void WriteLog()
           => Debug.Log("Full log!");
    }
}
