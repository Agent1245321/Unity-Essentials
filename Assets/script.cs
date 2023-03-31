using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{

    public GameObject following;

    private float angleY;
    public bool hasBeenHiteth = false;

    private Vector3 startingTransform;
    private Quaternion startingRotation;
    
    // Start is called before the first frame update
    void Start()
    {
        startingTransform = this.transform.position;
        startingRotation = this.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasBeenHiteth)
        {
            angleY = Mathf.Atan((following.transform.position.x - this.transform.position.x) / (following.transform.position.z - this.transform.position.z)) * 180 / Mathf.PI;
            this.gameObject.transform.rotation = Quaternion.Euler(0, angleY, 0);
            this.transform.position = new Vector3(0, following.transform.position.y, -3);
        }
        else
        {
            this.transform.SetPositionAndRotation(startingTransform, startingRotation);
        }
    }
}
