using UnityEngine;
using System.Collections;

public class Jacket : MonoBehaviour {
	public Sprite torso;
	public Sprite torsoFront;
	public Sprite torsoBack;
	public Sprite leftShoulder;
	public Sprite rightShoulder;
	public Sprite leftForearm;
	public Sprite rightForearm;
	public bool hasSleeves;
	public bool hasSash;
	public bool hasGlove;
	public bool hasMantle;
	public Recolor recolor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Equip(RigManager rig, Material jacketColor, Material highlight){
		if (torso != null) {
			Sprite torsoRecolor = recolor.DoRecolor (torso, jacketColor.color, highlight.color);
			rig.jacket.sprite = torsoRecolor;
		} 
		else {
			rig.jacket.sprite = null;
		}
		rig.jacketBack.sprite = torsoBack;

		rig.jacketBack.material = jacketColor;

		if (hasSleeves == true) {
			Sprite leftShoulderRecolor = recolor.DoRecolor (leftShoulder, jacketColor.color, highlight.color);
			Sprite rightShoulderRecolor = recolor.DoRecolor (rightShoulder, jacketColor.color, highlight.color);
			Sprite leftForearmRecolor = recolor.DoRecolor (leftForearm, jacketColor.color, highlight.color);
			Sprite rightForearmRecolor = recolor.DoRecolor (rightForearm, jacketColor.color, highlight.color);
			rig.leftShoulder.sprite = leftShoulderRecolor;
			rig.rightShoulder.sprite = rightShoulderRecolor;
			rig.leftForearm.sprite = leftForearmRecolor;
			rig.rightForearm.sprite = rightForearmRecolor;

		}
		if (hasMantle == true) {
			Sprite torsoFrontRecolor = recolor.DoRecolor (torsoFront, jacketColor.color, highlight.color);
			rig.jacketFront.sprite = torsoFrontRecolor;
		}
		if (hasGlove == true) {
			rig.leftHand.material = highlight;
			rig.rightHand.material = highlight;
		}
	

	}
}
