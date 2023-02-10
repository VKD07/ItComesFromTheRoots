using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Radio : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip[] songs;
    int quary = 0;
    public TextMeshProUGUI textMeshPro;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (!audioSource.isPlaying) 
        {
           audioSource.PlayOneShot(songs[quary]);
           Debug.Log("Song " + songs[quary]);

           textMeshPro.text = songs[quary].name;

           quary++;
           if(quary == songs.Length ) { quary= 0; }
        }
        
        
    }
        
    
}
