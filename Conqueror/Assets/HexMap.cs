using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexMap : MonoBehaviour {

	public GameObject HexPrefab;

	// Use this for initialization
	void Start () {
		GenerateMap ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void GenerateMap(){
		for(int column =0; column<10; column++){
			for (int row = 0; row < 10; row++) {
				Instantiate (HexPrefab, new Vector3 (column, 0, row), Quaternion.identity, this.transform);
			}
		}
	}
}
