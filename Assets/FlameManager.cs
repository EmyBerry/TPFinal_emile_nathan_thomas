using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameManager : MonoBehaviour
{
    [SerializeField]public bool hasTank;
    [SerializeField]private string cadenaNom;
    [SerializeField]private GameObject flameObjet;
    [SerializeField]public cadenaScript CadenaScript;
    private void OnTriggerEnter(Collider other)
    {
        if(hasTank){
        if(other.gameObject.name == cadenaNom){
            flameObjet.SetActive(true);
            CadenaScript.isHeated = true;
        }
        }
    }
}
