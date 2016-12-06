using UnityEngine;
using System.Collections;

public class scott : MonoBehaviour
{
    public float scottstrength = 1000f;
    public AudioClip hitsound;
    public GameObject prefab1;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Ray beam = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(beam.origin, beam.direction * 1000f, Color.red);
        RaycastHit beamhit = new RaycastHit();

        if (Physics.Raycast(beam, out beamhit, 100f))
        {
            Debug.Log("hit?");


        }
            if (Input.GetMouseButton(0) && beamhit.rigidbody)
            {
                Debug.Log("Has rigibody");
                beamhit.rigidbody.AddForce((Random.insideUnitSphere) * scottstrength);
                beamhit.collider.gameObject.GetComponent<AudioSource>().PlayOneShot(hitsound);
            }
           

            }

        }
    









