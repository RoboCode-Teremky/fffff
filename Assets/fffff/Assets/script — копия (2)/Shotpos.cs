using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotpos : MonoBehaviour
{
     public Transform shotpos;
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)){
            Instantiate(Bullet, shotpos.transform.position, transform.rotation);
        }
    }
}
