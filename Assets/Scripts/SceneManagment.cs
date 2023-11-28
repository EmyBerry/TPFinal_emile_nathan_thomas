using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{
    //loads the menu screen
    public void SceneMenu() {  
        SceneManager.LoadScene(0);
        //SceneManager.LoadScene("Accueil");
    }

    //loads the first outside scene, the start of the game
     public void SceneOutside() {  
        SceneManager.LoadScene(1);
        //SceneManager.LoadScene("SceneExt");
    }

    //loads the first inside scene, the second part of the game (kitchen)
     public void SceneInside1() {  
        SceneManager.LoadScene(2);
        //SceneManager.LoadScene("SceneInt1");
    }

    //loads the second inside scene, the second part of the game (living room)
    public void SceneInside2() {  
        SceneManager.LoadScene(3);
        //SceneManager.LoadScene("SceneInt2");
    }

    //loads the ending scene / credits
    public void SceneEnd() {
        SceneManager.LoadScene(4);
        //SceneManager.LoadScene("Fin");
    }
}
