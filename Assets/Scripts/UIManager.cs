using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public void LoadLevel1(){
        Debug.Log("Is this working?");
        SceneManager.LoadScene("Level1");
    }
}
