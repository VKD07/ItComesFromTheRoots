using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class TreeGrow : MonoBehaviour
{
    [SerializeField] public float treeGrow = 0;
    [SerializeField] TextMeshProUGUI maturityValue; 
    [SerializeField] public float growthRate = 1f;
    public GameObject[] trees;
    public ParticleSystem treeGrowParticle;
    [SerializeField] Slider statusSlider;
    bool oneTime = true;
    bool oneMoreTime = true;
    bool oneMoreMoreMoreTime = true;
    bool oneMoreMoreMoreMoreTime = true;


    private void Start()
    {
        maturityValue.SetText(treeGrow.ToString());
    }

    private void FixedUpdate()
    {
       if(statusSlider.value > 36.6f && statusSlider.value < 68.0f)
        {
            treeGrow += growthRate * Time.deltaTime;
            int treeGrowth = (int)treeGrow;
            maturityValue.SetText(treeGrowth.ToString());
            CurrentTree();
        }

       

    }

    private void CurrentTree()
    {
        if (treeGrow >= 20)
        {
            
            trees[0].SetActive(true);
            
            if (oneTime)
            {
                treeGrowParticle.Play();
                oneTime = false;
            }


        }

        if (treeGrow >= 50)
        {
         
            trees[0].SetActive(false);
            trees[1].SetActive(true);

            
            if (oneMoreTime)
            {
                treeGrowParticle.Play();
                oneMoreTime= false;
            }

        }

        if (treeGrow >= 75)
        {
        
            trees[1].SetActive(false);
            trees[2].SetActive(true);
        

            if (oneMoreMoreMoreTime)
            {
                treeGrowParticle.Play();
                oneMoreMoreMoreTime = false;
            }


        }

        if (treeGrow >= 100)
        {
       
            trees[2].SetActive(false);
            trees[3].SetActive(true);
           
            if (oneMoreMoreMoreMoreTime)
            {
                treeGrowParticle.Play();
                oneMoreMoreMoreMoreTime = false;
            }


        }
    }

    void StopParticle()
    {
        treeGrowParticle.Stop();
    }
}
