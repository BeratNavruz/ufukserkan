using UnityEngine;

public class OptionsPanel : MonoBehaviour
{
    public GameObject[] _buttons;
    public AudioSource _mainMusic;
    public int _volumeSound;
    public int _volumeMusic;

    public void SoundTrueButton ()
    {
        PlayerPrefs.SetInt("_volumeSound", 1);
        AudioListener.volume = 1;
        _buttons[0].SetActive(false);
        _buttons[1].SetActive(true);
    }

    public void SoundFalseButton ()
    {
        PlayerPrefs.SetInt("_volumeSound", 0);
        AudioListener.volume = 0;
        _buttons[1].SetActive(false);
        _buttons[0].SetActive(true);
    }

    public void MusicTrueButton ()
    {
        PlayerPrefs.SetInt("_volumeMusic", 1);
        _mainMusic.volume = 1;
        _buttons[2].SetActive(false);
        _buttons[3].SetActive(true);
    }

    public void MusicFalseButton ()
    {
        PlayerPrefs.SetInt("_volumeMusic", 0);
        _mainMusic.volume = 0;
        _buttons[3].SetActive(false);
        _buttons[2].SetActive(true);
    }

    public void BackButton ()
    {
        gameObject.SetActive(false);
    }

}
