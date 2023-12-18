using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridgeDoorOpen : MonoBehaviour
{
    // Reference to the door GameObject
    public GameObject door;

    // Flag to check if the door is open
    private bool doorOpen;

    private void Start()
    {
        // Ensure the door is closed at the beginning
        doorOpen = false;
        CloseDoor();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player has entered the trigger collider
        if (other.CompareTag("Player"))
        {
            // If the door is closed, open it
            if (!doorOpen)
            {
                OpenDoor();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the player has exited the trigger collider
        if (other.CompareTag("Player"))
        {
            // If the door is open, close it
            if (doorOpen)
            {
                CloseDoor();
            }
        }
    }

    private void OpenDoor()
    {
        // Play any open door animation or change the door's rotation
        // For simplicity, this script assumes the door rotates around the Y-axis
        door.transform.Rotate(0f, 270f, 0f);

        // Update the door state
        doorOpen = true;
    }

    private void CloseDoor()
    {
        // Play any close door animation or reset the door's rotation
        // For simplicity, this script assumes the door rotates around the Y-axis
        door.transform.Rotate(0f, 0f, 0f);

        // Update the door state
        doorOpen = false;
    }
}
