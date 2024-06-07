using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fwdref : MonoBehaviour
{
    public GameObject lefthand;
    public GameObject righthand;
    public GameObject forwardref;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = lefthand.transform.forward.normalized;
        Vector3 direction2 = righthand.transform.forward.normalized;
        Vector3 combined = (direction + direction2).normalized;
        forwardref.transform.forward = combined;
    }
}
