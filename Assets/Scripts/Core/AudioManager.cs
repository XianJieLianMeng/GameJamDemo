using System.Collections.Generic;
using UniFramework.Event;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using static EventDefine;

public class AudioManager : SingletonMonoBehaviour<AudioManager>
{
    [SerializeField]
    public AudioSource backgroundMusicSource;
    [SerializeField]
    public AudioSource soundEffectSource;

    [SerializeField]
    private List<AudioClip> bgAudioClips = new List<AudioClip>();
    [SerializeField]
    private List<AudioClip> audioClips = new List<AudioClip>();

    private void Start()
    {
        UniEvent.AddListener<EventDefine.EventGameStartLevel>(OnEventGameStartLevel);
    }

    private void OnDestroy()
    {
        UniEvent.RemoveListener<EventDefine.EventGameStartLevel>(OnEventGameStartLevel);
    }


    private void OnEventGameStartLevel(IEventMessage message)
    {
        if (message is EventGameStartLevel startLevelMsg)
        {
            int bgIndex = startLevelMsg.Level;
            if(startLevelMsg.Level == 1)
            {
                bgIndex = 0;
            }
            else if(startLevelMsg.Level == 2)
            {
                bgIndex = 1;
            }
            PlayBackgroundMusic(GetBgAudioClip(bgIndex));
        }
    }

    public AudioClip GetBgAudioClip(int index)
    {
        return bgAudioClips[index];
    }


    public void PlayBackgroundMusic()
    {
        PlayBackgroundMusic(GetBgAudioClip(0));
    }

    // 播放背景音乐
    public void PlayBackgroundMusic(AudioClip musicClip)
    {
        if (backgroundMusicSource.isPlaying)
        {
            backgroundMusicSource.Stop();
        }

        backgroundMusicSource.clip = musicClip;
        backgroundMusicSource.loop = true;
        backgroundMusicSource.Play();
    }

    // 停止背景音乐
    public void StopBackgroundMusic()
    {
        backgroundMusicSource.Stop();
    }

    // 播放音效
    public void PlaySoundEffect(AudioClip soundEffectClip)
    {
        soundEffectSource.PlayOneShot(soundEffectClip);
    }

    public void PlaySoundEffect(int index)
    {
        soundEffectSource.PlayOneShot(audioClips[index]);
    }
}
