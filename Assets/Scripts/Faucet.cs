using UnityEngine;
using System.Collections;

public class Faucet : MonoBehaviour {
	    public GameObject waterPrefab;
	    public int volume = 0;
	    // Use this for initialization
	    void Start () {
		    
		    }
	    
	    // Update is called once per frame
	    void Update () {
		    
		        for (int i = 0; i < (volume*Time.deltaTime); i++) {
			            Instantiate(waterPrefab, transform.position, transform.rotation);
			        }
		    }
}