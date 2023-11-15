using Plugins.Audio.Core;
using UnityEngine;
using YG;

namespace Internal.Scripts.AudioLogic
{
    public class AudioSwitcher : MonoBehaviour
    {
        [SerializeField] private SourceAudio sourceAudio;
        
        private string currentAudioName;

        private void SwitchAudio(string currentAudioKey)
        {
            if (currentAudioKey != null) 
                sourceAudio.Play(currentAudioKey);
        }

        private void StopCurrentAudio() => sourceAudio.Stop(currentAudioName);

        public void StartButtonClick(string audioName)
        {
            StopCurrentAudio();
            if (audioName != null) 
                SwitchAudio(audioName);
            currentAudioName = audioName;
        }

        public void StopButtonClick()
        {
            sourceAudio.Stop(currentAudioName);
            YandexGame.FullscreenShow();
            Debug.Log("Add Show");
        }
    }
}
