using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Avatar : MonoBehaviour {

    public int resourceCount;
    public float rotSpeed;
    public float linearSpeed;
    public GameObject resourcePopPrefab;
    public Text textUI;

	// Use this for initialization
	void Start () {
        resourceCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * rotSpeed);

        transform.position += Input.GetAxis("Vertical") * transform.forward * linearSpeed;
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("resource get");
        resourceCount++;
        Destroy(other.gameObject);
        Instantiate(resourcePopPrefab, transform.position, Quaternion.identity);
        UpdateUI();
    }

    void UpdateUI()
    {
        textUI.text = "Apples: " + resourceCount;
    }
}
