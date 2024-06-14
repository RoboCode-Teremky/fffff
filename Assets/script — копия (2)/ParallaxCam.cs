using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxCam : MonoBehaviour
{
    private float startPos, lenth;
    
    public float parallaxEffect;
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position.x;
        lenth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float temp = (cam.transform.position.x * (1 - parallaxEffect));
        float dist = (cam.transform.position.x * parallaxEffect);
        transform.position = new Vector3(startPos + dist, transform.position.y, transform.position.z);
        if(temp > startPos + lenth) startPos += lenth;
        else if(temp < startPos - lenth) startPos -= lenth;
     }
}
