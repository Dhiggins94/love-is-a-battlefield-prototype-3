using UnityEngine;
using System.Collections;

public class hangry : MonoBehaviour
{
    public GameObject fishpellet;
    GameObject foodpelletclone;
    Vector3 destination;
    public float howHungry;
    bool hungry;
    public float spheresize = 10f;
    // Use this for initialization
    void Start()
    {
        hungry = true;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 destination = fishpellet.transform.position;
        Vector3 direction = Vector3.Normalize(destination - transform.position);
        Debug.Log("fish velocity =   " + GetComponent<Rigidbody>().velocity);
        GetComponent<Rigidbody>().AddForce(direction * howHungry);
        if (hungry)
        {
            destination = fishpellet.transform.position;

         
        }
        else
        {

            GetComponent<Rigidbody>().velocity = Vector3.zero;
            hungry = true;
        }
    }


    
    void OnCollisionEnter(Collision co)
    {


        if (co.gameObject.tag == "fishpellet")
        {
           
            
            Vector3 nearbyposition = fishpellet.transform.position + Random.insideUnitSphere * spheresize;
            GameObject clone = Instantiate(fishpellet, nearbyposition, Quaternion.identity) as GameObject;
            GameObject temp = fishpellet;
            Destroy(temp);
            fishpellet = clone;
            hungry = false;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
           
            {

                
                }
            }
        }
    }
