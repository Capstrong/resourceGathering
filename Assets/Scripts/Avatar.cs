using UnityEngine;
using System.Collections;

public class Avatar : MonoBehaviour {

    public int resourceCount;

	// Use this for initialization
	void Start () {
        resourceCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter(Collider other)
    {
        resourceCount++;
        Destroy(other.gameObject);
    }
}
