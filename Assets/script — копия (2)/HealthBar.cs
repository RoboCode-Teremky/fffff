using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private GameObject imagePrefab;
    void OnEnable(){
        FindAnyObjectByType<playercontrol>().GetComponent<playercontrol>().hpChange.AddListener(UpdateBar);
    }
    void OnDisable(
    ){
        FindAnyObjectByType<playercontrol>().GetComponent<playercontrol>().hpChange.RemoveListener(UpdateBar);
    }
    public void UpdateBar(int hp){
        foreach(Transform child in transform){
           Destroy(child.gameObject);
        } 
        for(int i=0; i < hp; i++)
        Instantiate(imagePrefab, transform);
    }
}
