using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public static SFXManager instance;
    private void Awake()
    {
        instance = this;
    }

    public AudioSource[] soundEffects;
    public AudioSource musicEffect;
    int _volumeSound;
    int _volumeMusic;

    private void Start ()
    {
        _volumeMusic = PlayerPrefs.GetInt("_volumeMusic", 1);
        _volumeSound = PlayerPrefs.GetInt("_volumeSound", 1);

        AudioListener.volume = _volumeSound;
        musicEffect.volume = _volumeMusic;
    }

    public void PlaySFX(int sfxToPlay)
    {
        soundEffects[sfxToPlay].Stop();
        soundEffects[sfxToPlay].Play();
    }

    public void PlaySFXPitched(int sfxToPlay)
    {
        soundEffects[sfxToPlay].pitch = Random.Range(.8f, 1.2f);

        PlaySFX(sfxToPlay);
    }
}
