using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopButton : MonoBehaviour
{
    [SerializeField] GameObject shopInterface;
    [SerializeField] TextMeshProUGUI pointsValue;
    [SerializeField] public int TotalPoints;
    //cost shop
    //Heal
    [SerializeField] int healCost;
    [SerializeField] int additionalHeal;
    [SerializeField] TextMeshProUGUI healValue;
    [SerializeField] healthHandler healthHandler;
    //fire 
    [SerializeField] int fireCost;
    [SerializeField] ParticleSystem fire;
    [SerializeField] float fireTimeLimit;

    //Animation hover
    Animator anim;
   
    void Start()
    {
        shopInterface.SetActive(false);
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        pointsValue.SetText(TotalPoints.ToString());
    }

    public void OpenCloseShop()
    {
        if(shopInterface.activeSelf == false)
        {
            shopInterface.SetActive(true);
        }
        else
        {
            shopInterface.SetActive(false);
        }
    }

    public void PurchaseHeal()
    {
        if(TotalPoints >= healCost && healthHandler.Totalhealth < 100)
        {
            TotalPoints -= healCost;

            
              if(healthHandler.Totalhealth + additionalHeal > 100)
                {
                    healthHandler.Totalhealth = 100;
                     healValue.SetText(healthHandler.Totalhealth.ToString());
            }
                else
                {
                    healthHandler.Totalhealth += additionalHeal;

                    healValue.SetText(healthHandler.Totalhealth.ToString());
                }

            shopInterface.SetActive(false);


        }
    }

    public void PurchaseFire()
    {
        if(TotalPoints>= fireCost)
        {
            fire.Play();
            TotalPoints -= fireCost;
            shopInterface.SetActive(false);
            Invoke("TurnOffTheFire", fireTimeLimit);
           
        }
    }

    void TurnOffTheFire()
    {
        fire.Stop();
    }

        
}
