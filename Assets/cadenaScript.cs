using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cadenaScript : MonoBehaviour
{
    [SerializeField]private float targetTime;
    [SerializeField]private string pickname;
    [SerializeField]public bool isHeated;
    [SerializeField]private bool Heated;
    [SerializeField]private GameObject gameObject1;
    [SerializeField]private GameObject gameObject2;
    [SerializeField]private string sceneACharger;

 public void Update(){
    if(isHeated){

 targetTime -= Time.deltaTime;

 if (targetTime <= 0.0f)
 {
   timerEnded();
 }
        
    }
 }

 void timerEnded()
 {
   Heated = true;
 }

 private void OnTriggerEnter(Collider other)
    {
        if(Heated){
        if(other.gameObject.name == pickname){
            gameObject1.SetActive(false);
            gameObject2.SetActive(true);
        SceneManager.LoadScene (sceneName:sceneACharger);
        }
        }
    }
}
