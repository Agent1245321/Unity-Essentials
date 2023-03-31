using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private script camScript;
    public GameObject box;
    // Start is called before the first frame update
    void Start()
    {
        camScript = Camera.main.GetComponent<script>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        camScript.hasBeenHiteth = true;
        box.SetActive(false);
    }
}
