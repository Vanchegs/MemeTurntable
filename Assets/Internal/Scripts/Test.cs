using Plugins.Audio.Core;
using UnityEngine;

namespace Internal.Scripts
{
    public class Test : MonoBehaviour
    {
        [SerializeField] private SourceAudio source;
    
        void Start()
        {
            source.Play("MrDudec");
        }
    }
}
