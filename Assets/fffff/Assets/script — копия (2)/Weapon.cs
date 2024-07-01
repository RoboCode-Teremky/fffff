using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float offset;
    public GameObject Bullet;
    public Transform shotPoint;
   private float timeBTWShots;
   public float startTimeBTWShots;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
        if(timeBTWShots <= 0){
        if(Input.GetMouseButton(0)){
            Quaternion bulletRotation = Quaternion.Euler(0f, 0f, rotZ);
             Instantiate(Bullet, shotPoint.position, bulletRotation);
           timeBTWShots = startTimeBTWShots;

        }
        }
        else{
            timeBTWShots -= Time.deltaTime;
        }
    }
    //void Shoot()
    //{
    //    
   // }
}
