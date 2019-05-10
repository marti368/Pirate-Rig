using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhatisGrey : MonoBehaviour {

	// Use this for initialization
	public SpriteRenderer spriteRendDefault;
	public Sprite sprite;
	void Start () {
		Debug.Log("does this thing work?");
		Texture2D spriteTexture = sprite.texture;
		sprite = spriteRendDefault.sprite;
		Color color = spriteTexture.GetPixel(1,1);

		Debug.Log(color.r);
		Debug.Log(color.g);
		Debug.Log(color.b);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
