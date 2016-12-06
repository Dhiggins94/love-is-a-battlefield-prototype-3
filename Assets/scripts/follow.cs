using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour {
    public Transform target;
    public Transform mytransform;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(target);
        transform.Translate(Vector3.forward * 6 * Time.deltaTime);
	}
}
