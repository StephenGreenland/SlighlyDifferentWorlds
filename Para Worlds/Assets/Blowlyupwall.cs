using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blowlyupwall : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



    }


    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "FireBall")
        {
            FMODUnity.RuntimeManager.PlayOneShotAttached("event:/Environment/Brick Wall Destory", gameObject);
            Destroy(this.gameObject);
            
        }

    }


}
