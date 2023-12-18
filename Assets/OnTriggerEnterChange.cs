using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnterChange : MonoBehaviour
{
    [SerializeField]private string pickname;
    [SerializeField]private GameObject ObjectName1;
    [SerializeField]private GameObject ObjectName2;
    [SerializeField]private GameObject ObjectName3;
    [SerializeField]private GameObject ObjectName4;
    [SerializeField]private GameObject ObjectName5;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == pickname){
            ObjectName1.SetActive(true);
            ObjectName2.SetActive(true);
            ObjectName3.SetActive(true);
            ObjectName4.SetActive(false);
            ObjectName5.SetActive(true);
            Destroy(gameObject);
        }
    }
}
