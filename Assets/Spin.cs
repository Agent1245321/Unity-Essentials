using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(rotation, Space.Self);
        rotation = new Vector3(rotation.x + Random.RandomRange(-.01f, .01f), rotation.y + Random.RandomRange(-.01f, .01f), rotation.z + Random.RandomRange(-.01f, .01f));
    }
}
