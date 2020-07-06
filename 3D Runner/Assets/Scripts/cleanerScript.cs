using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleanerScript : MonoBehaviour {

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Cleaner") {
			Destroy (this.gameObject);
		}
	}
}
