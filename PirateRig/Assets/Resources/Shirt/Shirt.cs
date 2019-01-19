using UnityEngine;
using System.Collections;

public class Shirt : MonoBehaviour {
	public Sprite torso;
	public Sprite leftShoulder;
	public Sprite rightShoulder;
	public Sprite leftForearm;
	public Sprite rightForearm;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Equip(RigShuffler rig, Material shirtColor){
		rig.shirt.sprite = torso;
		rig.leftShoulder.sprite = leftShoulder;
		rig.rightShoulder.sprite = rightShoulder;
		rig.leftForearm.sprite = leftForearm;
		rig.rightForearm.sprite = rightForearm;

		rig.shirt.material = shirtColor;
		rig.leftShoulder.material = shirtColor;
		rig.rightShoulder.material = shirtColor;
		rig.leftForearm.material = shirtColor;
		rig.rightForearm.material = shirtColor;
	}
}
