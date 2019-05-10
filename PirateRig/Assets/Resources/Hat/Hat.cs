using UnityEngine;
using System.Collections;

public class Hat : MonoBehaviour {
	public Sprite front;
	public Sprite back;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Equip(RigShuffler rig, Material hatColor, Material highlightColor){
		rig.hatFront.sprite = front;
		rig.hatBack.sprite = back;

		rig.hatFront.material = hatColor;
		rig.hatBack.material = hatColor;
	}
}
