using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudLimit : MonoBehaviour
{
    [SerializeField] float cloudTimeLimit;
    [SerializeField] float rainCloudTimeLimit;

    [SerializeField] bool RainCloud;
    [SerializeField] bool Cloud;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(RainCloud == true)
        {
            Destroy(this.gameObject, rainCloudTimeLimit);
        }else if(Cloud == true)
        {
            Destroy(this.gameObject, cloudTimeLimit);
        }
    }
}
