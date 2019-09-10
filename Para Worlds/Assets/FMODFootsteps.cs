using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FMODFootsteps : MonoBehaviour
{
    private float distance = 0.05f;
    private float Material;
    private LayerMask LM = 1 << 31;
    FMOD.Studio.EventInstance Foosteps;
    void Start()
    {
        Foosteps = FMODUnity.RuntimeManager.CreateInstance("event:/SFX/Ellen/Ellen_Footsteps");
    }
    void FixedUpdate()
    {
        MaterialCheck();
        Debug.DrawRay(transform.position, Vector2.down * distance, Color.blue);
    }
    void MaterialCheck()
    {
        RaycastHit2D hit;
        hit = Physics2D.Raycast(transform.position, Vector2.down, distance, LM);

        Foosteps.setParameterByName("Material", Material);

        if (hit.collider)
        {
            if (hit.collider.tag == "Dirt")
                Material = 1f;
            else if (hit.collider.tag == "Stone")
                Material = 2f;
            else
                Material = 1f;
        }
    }
    void PlayFoostepsEvent()
    {
        Foosteps.start();
    }
    void OnDestroy()
    {
        Foosteps.release();
    }
}