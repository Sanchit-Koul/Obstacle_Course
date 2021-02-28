using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeDelay = 3f;
    // Start is called before the first frame update
    MeshRenderer mesh;
    Rigidbody rigidbody;

    System.Random random = new System.Random();
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        mesh.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeDelay)
        {
            mesh.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
