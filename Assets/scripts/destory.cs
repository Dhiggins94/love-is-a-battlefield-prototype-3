using UnityEngine;
using System.Collections;

public class destory : MonoBehaviour
{
    public AudioSource HitSound;
    public GameObject enemy;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            Destroy(other.gameObject);

        }
    }
}

