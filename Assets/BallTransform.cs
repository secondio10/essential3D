using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransform : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 scaleChange;
    public Vector3 positionChange;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += scaleChange;
        transform.position += positionChange;
    }
}
