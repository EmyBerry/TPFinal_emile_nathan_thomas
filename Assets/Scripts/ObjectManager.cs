using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ObjectManager : MonoBehaviour
{
    [SerializeField] private PlayerInfos points;
    [SerializeField] private TextMeshProUGUI pointsDisplay;
    [SerializeField] private GameObject triggerCollider;
    private float _pointsPlayer;

    void Start()
    {
        points.points = 0;
        _pointsPlayer = points.points;

    }

    private void Update() {
        
        points.points = _pointsPlayer;
        ShowPoints();
    }

    private void OnTriggerEnter(Collider other) {

        if (other.tag == "Object") {

            _pointsPlayer++;
            Destroy(other.gameObject);
        }
    }

    private void ShowPoints() {

        pointsDisplay.text = points.points.ToString();
    }
}
