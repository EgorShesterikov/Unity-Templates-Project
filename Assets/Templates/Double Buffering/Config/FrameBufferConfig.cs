using UnityEngine;

namespace DoubleBuffering
{
    [CreateAssetMenu(fileName = "FrameBufferConfig", menuName = "DoubleBuffering/DoubleBuffering")]
    public class FrameBufferConfig : ScriptableObject
    {
        [SerializeField] private Texture2D _texture;

        public Texture2D Texture => _texture;    
    }

}
