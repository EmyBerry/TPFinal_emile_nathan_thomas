using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnterDestroy : MonoBehaviour
{
    [SerializeField]private string pickname;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == pickname){
            Destroy(gameObject);
        }
    }
}
