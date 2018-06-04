﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hex {

	public Hex(int q, int r){
		this.Q = q;
		this.R = r;
		this.S = -(q + r);
	}

	public readonly int Q;
	public readonly int R;
	public readonly int S;

	readonly float WIDTH_MULTIPLIER=Mathf.Sqrt(3)/2;

	public Vector3 Position(){

		float radius = 1f;
		float height = radius * 2;
		float width = WIDTH_MULTIPLIER * height;

		float vert = height * 0.75f;
		float horiz = width;

		return new Vector3 (
			horiz*(this.Q+this.R/2f),
			0,
			vert*this.R
		);
	}
}
