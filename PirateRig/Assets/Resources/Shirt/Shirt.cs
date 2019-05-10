using UnityEngine;
using System.Collections;

public class Shirt : MonoBehaviour {
	public Sprite torso;
	public Sprite leftShoulder;
	public Sprite rightShoulder;
	public Sprite leftForearm;
	public Sprite rightForearm;
	public Recolor recolor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Equip(RigManager rig, Material shirtColor, Material highlight){
		Sprite torsoRecolor = recolor.DoRecolor (torso, shirtColor.color, highlight.color);
		Sprite leftShoulderRecolor = recolor.DoRecolor (leftShoulder, shirtColor.color, highlight.color);
		Sprite rightShoulderRecolor = recolor.DoRecolor (rightShoulder, shirtColor.color, highlight.color);
		Sprite leftForearmRecolor = recolor.DoRecolor (leftForearm, shirtColor.color, highlight.color);
		Sprite rightForearmRecolor = recolor.DoRecolor (rightForearm, shirtColor.color, highlight.color);
		rig.shirt.sprite = torsoRecolor;
		rig.leftShoulder.sprite = leftShoulderRecolor;
		rig.rightShoulder.sprite = rightShoulderRecolor;
		rig.leftForearm.sprite = leftForearmRecolor;
		rig.rightForearm.sprite = rightForearmRecolor;

	}
}
