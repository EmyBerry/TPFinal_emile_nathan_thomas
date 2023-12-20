using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swithObjet : MonoBehaviour
{
    [SerializeField] GameObject objet1;
    [SerializeField] GameObject objet2;
    public void Switch()
    {
        objet1.SetActive(false);
        objet2.SetActive(true);
    }
}
