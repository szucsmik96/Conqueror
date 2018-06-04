using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexMap : MonoBehaviour {

	public GameObject HexPrefab;
	Hex h;

	// Use this for initialization
	void Start () {
		GenerateMap ();
	}
		
	void GenerateMap(){
		for(int column =0; column<10; column++){
			for (int row = 0; row < 10; row++) {
				h = new Hex (column, row);

				Instantiate (HexPrefab, h.Position(), Quaternion.identity, this.transform);
			}
		}
	}
}
