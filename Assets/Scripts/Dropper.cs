using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer Renderer;
    Rigidbody  Rigidbody;
    [SerializeField] float timeToWait = 5f;
    
    void Start()
    {
        Renderer = GetComponent<MeshRenderer>();
        Rigidbody = GetComponent<Rigidbody>();

        Renderer.enabled = false;
        Rigidbody.useGravity = false;
        
    }

    
    void Update()
    {
        if(Time.time > timeToWait){
            Renderer.enabled = true;
            Rigidbody.useGravity = true;
        }
    }
}
