using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    public float camAngle;


    // Update is called once per frame
    void Update()
    {


        transform.position = new Vector3(transform.position.x, transform.position.y + camAngle, player.transform.position.z);


    }
}
