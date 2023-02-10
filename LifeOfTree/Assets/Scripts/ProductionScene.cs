using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProductionScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartScene());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator StartScene()
    {
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene(1);
    }
}
