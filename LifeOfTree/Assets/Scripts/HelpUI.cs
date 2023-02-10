using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpUI : MonoBehaviour
{
    [SerializeField] GameObject instructions;
    [SerializeField] GameObject pauseText;
    [SerializeField] GameObject closeBtn;
    [SerializeField] GameObject goBackBtn;

    private void Awake()
    {
        instructions.SetActive(false);
    }

    public void OpenInstructions()
    {
        if(instructions.activeSelf == false)
        {
            instructions.SetActive(true);
            pauseText.SetActive(false) ;
            closeBtn.SetActive(false);
            goBackBtn.SetActive(false);
            this.gameObject.SetActive(false);
       
        }
    }
}
