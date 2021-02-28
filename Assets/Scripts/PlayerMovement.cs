using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float controlValue = 0.02f;
    int collisionCount = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * controlValue * Time.deltaTime,
                            0,
                            Input.GetAxis("Vertical") * controlValue * Time.deltaTime);
    }

    void OnCollisionEnter(Collision other)
    {
        var random = new System.Random();
        GetComponent<MeshRenderer>().material.color = new Color((float)random.NextDouble(), (float)random.NextDouble(), (float)random.NextDouble());
    }
}
