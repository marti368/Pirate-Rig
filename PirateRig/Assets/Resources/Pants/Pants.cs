﻿using UnityEngine;
using System.Collections;

public class Pants : MonoBehaviour {
	public Sprite hips;
	public Sprite hipsBack;
	public Sprite leftThigh;
	public Sprite rightThigh;
	public Sprite leftShin;
	public Sprite rightShin;
	public Sprite leftFoot;
	public Sprite rightFoot;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
	
	}
	public void Equip(RigManager rig, Material pantsColor, Material bootsColor){
		rig.hips.sprite = hips;
		//rig.hipsBack.sprite = hipsBack;
		rig.leftThigh.sprite = leftThigh;
		rig.rightThigh.sprite = rightThigh;
		rig.leftShin.sprite = leftShin;
		rig.rightShin.sprite = rightShin;
		rig.leftFoot.sprite = leftFoot;
		rig.rightFoot.sprite = rightFoot;

		rig.hips.material = pantsColor;
		rig.leftThigh.material = pantsColor;
		rig.rightThigh.material = pantsColor;
		rig.leftShin.material = bootsColor;
		rig.rightShin.material = bootsColor;
		rig.leftFoot.material = bootsColor;
		rig.rightFoot.material = bootsColor;
	}
}
