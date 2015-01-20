﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Avatar : MonoBehaviour {

    public Dictionary<ResourceType, int> resourceCount = new Dictionary<ResourceType, int>();
    public float rotSpeed;
    public float linearSpeed;
    public GameObject resourcePopPrefab;
    public Text textUI;

	// Use this for initialization
	void Start () {
        resourceCount[ResourceType.Apple] = 0;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * rotSpeed);

        transform.position += Input.GetAxis("Vertical") * transform.forward * linearSpeed;

	}

    void OnTriggerEnter(Collider other)
    {
        resource resourceComponent = other.gameObject.GetComponent<resource>();

        if (resourceComponent != null)
        {
            Debug.Log("resource get");
            resourceCount[resourceComponent.type]++;
            Destroy(other.gameObject);
            Instantiate(resourcePopPrefab, transform.position, Quaternion.identity);
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        textUI.text = "Apples: " + resourceCount[ResourceType.Apple];
    }
}
