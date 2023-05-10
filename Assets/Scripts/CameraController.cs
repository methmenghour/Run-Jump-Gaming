using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform player;
   private void Update()
    {
        Vector3 cameraMovment = new Vector3(player.position.x, player.position.y, transform.position.z);
        cameraMovment.y = cameraMovment.y +1;
        transform.position = cameraMovment;
    }
}   
