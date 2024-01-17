using UnityEngine;

namespace Singleton
{
    public class Log
    {
        private static Log _instance;

        public static Log Instance
        {
            get 
            {
                if (_instance == null)
                    _instance = new Log();

                return _instance;
            }
            private set
            { 
                _instance = value; 
            }
        }

        public void WriteLog(string text)
            => Debug.Log(text);
    }
}