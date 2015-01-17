using UnityEngine;
using System.Collections;

public class Avatar : MonoBehaviour {

    public int resourceCount;
    public float rotSpeed;
    public float linearSpeed;

	// Use this for initialization
	void Start () {
        resourceCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * rotSpeed);

        transform.position += Input.GetAxis("Vertical") * transform.forward * linearSpeed;

        Debug.DrawLine(transform.position, transform.position + transform.forward * 10);
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("resource get");
        resourceCount++;
        Destroy(other.gameObject);
    }
}
