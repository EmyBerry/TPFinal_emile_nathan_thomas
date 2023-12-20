using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    [SerializeField] private TMP_Text timerTexte;
    [SerializeField] private float tempRestant;
    private string minutesstr;
    private string secondestr;

    // Update is called once per frame
    void Update()
    {
        if(tempRestant > 0){
            tempRestant -= Time.deltaTime;
        }
        else if(tempRestant < 0){
            tempRestant = 0;
            GameOver();
        }
        int minutes = Mathf.FloorToInt(tempRestant / 60);
        int seconde = Mathf.FloorToInt(tempRestant % 60);
        minutesstr = minutes.ToString();
        secondestr = seconde.ToString();
        timerTexte.text = minutesstr + " : " + secondestr;
    }

    private void GameOver(){
        SceneManager.LoadScene (sceneName:"GameOverScreen");
    }
}
