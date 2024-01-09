using UnityEngine;

namespace TemplateMethod
{
    public abstract class BaseLog
    {
        public void WriteLog()
            => Debug.Log($"Write: {ReadDetails()}");

        protected abstract string ReadDetails();
    }
}
