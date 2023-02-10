using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class healthHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI healthValue;
    [SerializeField] Slider statusSlider;
    [SerializeField] int healthReduction;
    public int Totalhealth = 100;

    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        StartCoroutine(delay());
        healthValue.SetText(Totalhealth.ToString());
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      
    }

    IEnumerator delay()
    {

        while (true)
        {
            yield return new WaitForSeconds(1);

            if (statusSlider.value < 36.6f || statusSlider.value > 68.0f)
            {
                anim.SetTrigger("reduceHealth");
                Totalhealth -= healthReduction;


                print(Totalhealth);
                healthValue.SetText(Totalhealth.ToString());
            }
        }

    }
}
