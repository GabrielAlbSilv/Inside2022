using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioVol : MonoBehaviour
{
    public float volMaster, volumeNarra, volumeMusica;
    
    void Update()
    {
        
    }

    public void VolumeMaster (float volume)
    {
        volMaster = volume;
        AudioListener.volume = volMaster;
    }
    public void VolumeNarra(float volume)
    {
        volumeNarra = volume;
        GameObject [] Narra = GameObject.FindGameObjectsWithTag("Narracao");
        for(int i=0; i<Narra.Length; i++)
        {
            Narra[i].GetComponent<AudioSource>().volume = volumeNarra;
        }
    }
    public void VolumeMusica(float volume)
    {
        volumeMusica = volume;
        AudioListener.volume = volumeMusica;
        GameObject[] Music = GameObject.FindGameObjectsWithTag("Music");
        for (int i = 0; i < Music.Length; i++)
        {
            Music[i].GetComponent<AudioSource>().volume = volumeMusica;
        }
    }
   
}
