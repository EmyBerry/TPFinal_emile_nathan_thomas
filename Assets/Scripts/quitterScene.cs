using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitterScene : MonoBehaviour
{
    public void quitGame(){
        Application.Quit();
        Debug.Log("quitter jeux");
    }
}
