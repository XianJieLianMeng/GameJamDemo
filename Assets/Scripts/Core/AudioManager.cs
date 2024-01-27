using System.Collections.Generic;
using UnityEngine;

public class AudioManager : SingletonMonoBehaviour<AudioManager>
{
    [SerializeField]
    public AudioSource backgroundMusicSource;
    [SerializeField]
    public AudioSource soundEffectSource;

    [SerializeField]
    private List<AudioClip> audioClips = new List<AudioClip>();


    public AudioClip GetAudioClip(int index)
    {
        return audioClips[index];
    }


    public void PlayBackgroundMusic()
    {
        PlayBackgroundMusic(GetAudioClip(0));
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
}
