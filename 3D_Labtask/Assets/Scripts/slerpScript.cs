using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slerpScript : MonoBehaviour
{

    public Transform Target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Slerp(transform.position, Target.position, 0.01f);
    }
}
