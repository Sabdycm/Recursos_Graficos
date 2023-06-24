using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenesentree : MonoBehaviour
{

    private static AudioSource AS;


    private void Awake() {
        if(AS != null)
        {
            Destroy(gameObject);
        }
        else {
            DontDestroyOnLoad(this.gameObject);
            AS = GetComponent<AudioSource>();
        }
    }

    public void PlayMusic()
    {
        if(AS.isPlaying) return;
        AS.Play();
    }

    public void StopMusic()
    {
        AS.Stop();
    }
}
