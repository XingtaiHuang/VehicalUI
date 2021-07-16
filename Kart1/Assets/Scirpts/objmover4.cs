using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objmover4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        const float speed = 4;
        float step = speed * Time.deltaTime;
        gameObject.transform.localPosition = Vector3.MoveTowards(gameObject.transform.localPosition, new Vector3(5, 0, -2), step);
    }
}
