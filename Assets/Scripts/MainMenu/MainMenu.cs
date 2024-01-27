using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int levelNumber;
    public GameObject _optionsPanel;
    private OptionsPanel optionsPanel;

    private void Start()
    {
        optionsPanel = _optionsPanel.GetComponent<OptionsPanel>();

        optionsPanel._volumeMusic = PlayerPrefs.GetInt("_volumeMusic", 1);
        optionsPanel._volumeSound = PlayerPrefs.GetInt("_volumeSound", 1);
        OptionsStartFunc();
        levelNumber = 1;
    }

    private void OptionsStartFunc ()
    {
        if (optionsPanel._volumeMusic == 0)
        {
            optionsPanel.MusicFalseButton();
        }

        if (optionsPanel._volumeSound == 0)
        {
            optionsPanel.SoundFalseButton();
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(levelNumber);
    }

    public void QuitGame()
    {
        Application.Quit();

        Debug.Log("Oyundan Ciktin");
    }

    public void Options()
    {
        _optionsPanel.SetActive(true);
    }
}
