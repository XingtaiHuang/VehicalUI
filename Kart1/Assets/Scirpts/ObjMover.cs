using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMover : MonoBehaviour
{   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        const float speed = 2;
        float step = speed * Time.deltaTime;
        gameObject.transform.localPosition = Vector3.MoveTowards(gameObject.transform.localPosition, new Vector3(0, 0, -8), step);
    }
}
