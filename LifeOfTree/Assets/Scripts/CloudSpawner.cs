using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    [SerializeField] GameObject cloud;
    [SerializeField] GameObject rainCloud;
    [SerializeField] ShopButton shop;
    //cloud cost
    [SerializeField] int cloudCost;
    [SerializeField] int rainCloudCost;
    [SerializeField] GameObject shopInterface;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PurchaseCloud()
    {
        
    
       if(shop.TotalPoints >= cloudCost)
        {
            shop.TotalPoints -= cloudCost;
            Instantiate(cloud, transform.position, Quaternion.Euler(-90f, 0f, 0f));
            shopInterface.SetActive(false);
        }
    }

    public void PurchaseRainCloud()
    {
       
        print(shop.TotalPoints);
        if (shop.TotalPoints >= rainCloudCost)
        {
            shop.TotalPoints -= cloudCost;
            Instantiate(rainCloud, transform.position, Quaternion.Euler(-90f, 0f, 0f));
            shopInterface.SetActive(false);
        }
    }
}
