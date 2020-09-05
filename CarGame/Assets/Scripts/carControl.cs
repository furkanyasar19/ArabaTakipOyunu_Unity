using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carControl : MonoBehaviour
{
    public WheelCollider onSag, onSol, arkaSag, arkaSol;
    public float hiz, donmeHizi, frenGucu;


    //public GameObject Dusman;
    //public Transform spawnNoktasi;
    void Start()
    {
        //GameObject dusman = Instantiate(Dusman, spawnNoktasi.position, Quaternion.identity);  --Düşman Spawnlanma
    }

    void Update()
    {

        arkaSag.motorTorque = hiz * Input.GetAxis("Vertical");
        arkaSol.motorTorque = hiz * Input.GetAxis("Vertical");
        //arkaSag.motorTorque = hiz * 1;
        //arkaSol.motorTorque = hiz * 1;


        onSag.steerAngle = donmeHizi * Input.GetAxis("Horizontal");
        onSol.steerAngle = donmeHizi * Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.Space))
        {
            arkaSag.brakeTorque = frenGucu;
            arkaSol.brakeTorque = frenGucu;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            arkaSag.brakeTorque = 0;
            arkaSol.brakeTorque = 0;
        }
    }
     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag =="dusman")
        {
            Debug.Log("Çarptısds");
        }
    }
}