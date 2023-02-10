using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    [SerializeField] Transform[] spawnLocations;
    [SerializeField] GameObject pointObject;
    [SerializeField] float objectSpeed;
    [SerializeField] int addPoints = 10;
    [SerializeField] GameObject floatingPoints;
    int randomNumber;
    [SerializeField] ShopButton shop;
    [SerializeField] LayerMask layer;
    RaycastHit hit;
    AudioSource audioSource;

    public int minTime;
    public int MaxTime;

    void Start()
    {
        StartCoroutine(spawnRandomPoints());
        audioSource= GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if(Physics.Raycast(ray, out hit, 100, layer) && Input.GetKeyDown(KeyCode.Mouse0))
        {
            shop.TotalPoints += addPoints;
            audioSource.Play();
            GameObject floatP = Instantiate(floatingPoints, hit.point, Quaternion.identity);
           
            Destroy(floatP, 2f);
            Destroy(hit.rigidbody.gameObject);
        }
    }

    IEnumerator spawnRandomPoints()
    {
        randomNumber = Random.Range(minTime, MaxTime);


        while (true)
        {
            yield return new WaitForSeconds(randomNumber);
            int randomLocation = Random.Range(0, spawnLocations.Length);
            


            GameObject point = Instantiate(pointObject, spawnLocations[randomLocation].position, Quaternion.identity);
            point.GetComponent<Rigidbody>().velocity = -transform.up * objectSpeed * Time.deltaTime;
        }

    }
}
