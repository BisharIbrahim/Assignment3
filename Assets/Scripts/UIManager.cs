using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public void LoadLevel1(){
        SceneManager.LoadScene("Level1");
    }
    public void LoadMenu(){

        SceneManager.LoadScene("StartScene");
    }
}
