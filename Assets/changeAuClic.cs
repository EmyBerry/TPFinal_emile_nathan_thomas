using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeAuClic : MonoBehaviour
{
    [SerializeField]private string sceneACharger;
    public void change()
    {
        SceneManager.LoadScene (sceneName:sceneACharger);        
    }
}
