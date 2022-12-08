using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTriggerButton : MonoBehaviour
{
    [SerializeField] private doorActive door;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            door.OpenDoor();
        }
      /*  if (Input.GetKeyDown(KeyCode.G))
        {
            door.CloseDoor();
        }*/
    }
}
