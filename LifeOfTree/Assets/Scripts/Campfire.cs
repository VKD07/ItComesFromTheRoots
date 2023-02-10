using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Campfire : MonoBehaviour
{
    public ParticleSystem fireParticle;
    [SerializeField] Slider statusSlider;
    [SerializeField] float heat;

    AudioSource audioSource;

    private void Start()
    {
        audioSource= GetComponent<AudioSource>();
    }

    public void PressedButton()
    {
        Debug.Log("Button has been pressed");
        fireParticle.Stop();
    }

    private void Update()
    {
        if (fireParticle.isPlaying == true)
        {
            audioSource.enabled = true;
            statusSlider.value -= heat * Time.deltaTime;
        } else { audioSource.enabled = false;}
    }
}
