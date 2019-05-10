using UnityEngine;
using System.Collections;

public class Hat : MonoBehaviour {
	public Sprite front;
	public Sprite back;
	public Recolor recolor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Equip(RigManager rig, Material hatColor, Material highlight){
		Sprite hatRecolor = recolor.DoRecolor (front, hatColor.color, highlight.color);
		rig.hatFront.sprite = hatRecolor;
		rig.hatBack.sprite = back;
	
	}
}
