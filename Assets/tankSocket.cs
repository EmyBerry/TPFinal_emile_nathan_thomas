using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankSocket : MonoBehaviour
{
    [SerializeField] public FlameManager FlameManagerScript;
    public void addTank(){
        FlameManagerScript.hasTank = true;
    }
    public void removeTank(){
        FlameManagerScript.hasTank = false;
    }
}
