using UnityEngine;
using System.Collections;

public class Hair : MonoBehaviour {
	public Sprite hair;
	public Sprite back;
	public Sprite hatHair;
	public bool isBig;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Equip(RigShuffler shuffler, RigManager rig, Material hairColor, bool hasHat){

		if (shuffler.hasHat == true) {
			rig.hair.sprite = hatHair;
		} 
		else {
			rig.hair.sprite = hair;
		}
		
		rig.hairBack.sprite = back;

		rig.hair.material = hairColor;
		rig.hairBack.material = hairColor;
	}
}
