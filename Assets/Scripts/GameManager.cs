using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    [SerializeField] private PlayerInfos _player;
    
    [SerializeField] private TMP_Text _gameTime;
    
    private float _remainingTime;
   
    void Start()
    {
        //REMOVE COMMENT WHEN IN MAIN MENU SCENE
        //testing value
        //_player.gameTime = 6;

        //actual value
        _player.gameTime = 600;

        _remainingTime = _player.gameTime;

        _gameTime.text = _remainingTime.ToString();
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
        
    }

    void Update()
    {
        timer();
        //ADD CONDITION WHEN IT HITS 0 IN THE SCENE
        // else {

        // }
        
    }

    private void timer() {

        if (_remainingTime > 0) {

            displayTimeLeft(_remainingTime);
            _remainingTime -= Time.deltaTime;
            
            _player.gameTime = _remainingTime;
        }

        else {

            _player.gameTime = 0;
        }

    }

    private void displayTimeLeft(float time) {

        float min = Mathf.FloorToInt(time/60);
        float sec = Mathf.FloorToInt(time % 60);

        _gameTime.text = string.Format("{0:00}:{1:00}",min,sec);
    }
}