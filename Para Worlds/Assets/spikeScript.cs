using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spikeScript : MonoBehaviour
{
    

    bool isdead;
    float timer;
    public int currentlvl;

    // Start is called before the first frame update
    void Start()
    {
        isdead = false;
        timer = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (isdead)
        {
            timer -= Time.deltaTime;
        }
        if (timer < 0)
        {
            SceneManager.LoadScene(currentlvl);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //crate partical effect
            Destroy(other.gameObject);
            isdead = true;
            Debug.Log("imdying");
            FMODUnity.RuntimeManager.PlayOneShotAttached("event:/Character/Death/Spike Impact", gameObject);
        }


    }
}
