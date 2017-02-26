using UnityEngine;
using System.Collections;

public class Faucet : MonoBehaviour {
	public GameObject waterPrefab;
	public int volume = 0;
	public float offset = 0.0f;

	// Use this for initialization
	void Start () {
	    
	}
	    
	// Update is called once per frame
	void Update () {
		Vector3 position = transform.position;

	    for (int i = 0; i < (volume*Time.deltaTime); i++) {
			Instantiate(waterPrefab, position, transform.rotation);
			position.y += offset;
		}
	}
}