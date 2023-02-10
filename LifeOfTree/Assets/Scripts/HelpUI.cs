using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpUI : MonoBehaviour
{
    [SerializeField] GameObject instructions;

    private void Awake()
    {
        instructions.SetActive(false);
    }

    public void OpenInstructions()
    {
        if(instructions.activeSelf == false)
        {
            instructions.SetActive(true);
       
        }
        else
        {
            instructions.SetActive(false);
       
        }
    }
}
