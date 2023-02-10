using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{

    [SerializeField] GameObject pausedUI;
    [SerializeField] GameObject pauseText;
    [SerializeField] GameObject closeBtn;
    [SerializeField] GameObject goBackBtn;
    [SerializeField] GameObject instructionsUI;
    [SerializeField] GameObject helpBtn;
    public void GoBack()
    {
        if(pausedUI.activeSelf == true)
        {
            pausedUI.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void closeInstructions()
    {
        pauseText.SetActive(true);
        closeBtn.SetActive(true);
        goBackBtn.SetActive(true);
        helpBtn.SetActive(true);
        instructionsUI.SetActive(false);
        
    }
}
