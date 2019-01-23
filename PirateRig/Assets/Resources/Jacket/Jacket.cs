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

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Equip(RigShuffler rig, Material jacketColor, Material highlightColor){
		rig.jacket.sprite = torso;
		rig.jacketFront.sprite = torsoFront;
		rig.jacketBack.sprite = torsoBack;

		rig.jacket.material = jacketColor;
		rig.jacketFront.material = jacketColor;
		rig.jacketBack.material = jacketColor;

		if (hasSleeves == true) {
			rig.leftShoulder.sprite = leftShoulder;
			rig.rightShoulder.sprite = rightShoulder;
			rig.leftForearm.sprite = leftForearm;
			rig.rightForearm.sprite = rightForearm;

			rig.leftShoulder.material = jacketColor;
			rig.rightShoulder.material = jacketColor;
			rig.leftForearm.material = jacketColor;
			rig.rightForearm.material = jacketColor;
		}
	

	}
}
