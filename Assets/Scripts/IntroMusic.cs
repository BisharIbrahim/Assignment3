using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroMusic : MonoBehaviour
{
    public AudioClip intro, normalGhosts;
    bool introFinished = false;
    //AudioSource introSource;
   
    // Start is called before the first frame update
    void Start(){
        StartCoroutine(playMusic());
        
    }

    // Update is called once per frame
    void Update(){
        if(introFinished){
            GetComponent<AudioSource>().clip = normalGhosts;
            GetComponent<AudioSource>().Play();
            introFinished = false;
        }
    }

    IEnumerator playMusic(){
        GetComponent<AudioSource>().clip = intro;
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
        introFinished = true;
        
        
    //     //GetComponent<AudioSource>().loop = true;
    }
    
}
