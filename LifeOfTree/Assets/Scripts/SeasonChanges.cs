using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SeasonChanges : MonoBehaviour
{
    [SerializeField] string[] seasons;
    float timeOfChange;

    [SerializeField] public GameObject [] seasonObjects;
    [SerializeField] TextMeshProUGUI uiText;
    public int randomSeason;

    [SerializeField] List<string> seasonNames;

    [SerializeField] public float minimumTime;
    [SerializeField] public float maximumTime;

    [SerializeField] StatusScript statusScript;

    public bool declare = false;

    Animator anim;


    void Awake()
    {
        
            StartCoroutine(SetTheSeason());
        anim = GetComponent<Animator>();
       
        
    }

    // Update is called once per frame
    void Update()
    {
     
    
    }

 

    IEnumerator SetTheSeason()
    {
        timeOfChange = Random.Range(minimumTime, maximumTime);
        while (true)
        {
            
            yield return new WaitForSeconds(timeOfChange);
            anim.SetTrigger("changeSeason");    
            randomSeason = Random.Range(0, seasonNames.Count);
            //AddAndRemove();
            changeSeasonText();


        }
    }

    

    void AddAndRemove()
    {

       

        if (seasonNames.Count > 0)
        {
            seasonNames.Remove(seasonNames[randomSeason]);
        }

        if (seasonNames.Count <= 0)
        {
            seasonNames.Add("Spring");
            seasonNames.Add("Summer");
            seasonNames.Add("Winter");
        }

    }

   

    private void changeSeasonText()
    {
        if (randomSeason == 0)
        {
           
            seasonObjects[0].SetActive(true);
            seasonObjects[1].SetActive(false);
            seasonObjects[2].SetActive(false);

        }else if(randomSeason == 1)
        {
            //statusScript.duringSummerReduction += 1;
            seasonObjects[0].SetActive(false);
            seasonObjects[1].SetActive(true);
            seasonObjects[2].SetActive(false);
        }
        else if (randomSeason == 2)
        {
            //statusScript.duringWinterReduction += 1;
            seasonObjects[0].SetActive(false);
            seasonObjects[1].SetActive(false);
            seasonObjects[2].SetActive(true);
        }
    }


}
