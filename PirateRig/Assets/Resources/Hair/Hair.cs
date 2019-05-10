using UnityEngine;
using System.Collections;

public class Hair : MonoBehaviour {
	public Sprite top;
	public Sprite front;
	public Sprite back;
	public Sprite hatHair;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Equip(RigShuffler rig, Material hairColor, bool hasHat){
		if (hasHat == true) {
			rig.hairTop.sprite = hatHair;
		} else {
			rig.hairTop.sprite = top;
		}
		rig.hairFront.sprite = front;
		rig.hairBack.sprite = back;

		rig.hairTop.material = hairColor;
		rig.hairFront.material = hairColor;
		rig.hairBack.material = hairColor;
	}
}
