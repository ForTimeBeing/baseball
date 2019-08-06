using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour {

	
	void Start () {
		StartCoroutine(DestroyPts());
	}
	IEnumerator DestroyPts()
    {
		yield return new WaitForSeconds(5);
		Destroy(gameObject);
	}
}
