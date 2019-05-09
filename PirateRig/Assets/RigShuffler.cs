using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigShuffler: MonoBehaviour {

	public RigManager maleRig;
	public RigManager femaleRig;
	public RigManager rig;

	public bool hasShirt;
	public bool hasHat;
	public bool hasJacket;
	public bool hasBeard;
	public bool hasStache;
	public bool hasHair;
	public bool hasMask;
	public bool hasHeadEffect;
	public bool hasTorsoEffect;
	public bool isMale;
	public bool hasTattoo;
	// Use this for initialization
	void Start () {
		Shuffle ();
		
	}
	public void Shuffle(){
		string eyesAlbumName = "Eyes";
		string jacketAlbumName = "Jacket";
		string shirtAlbumName = "Shirt";
		string hairAlbumName = "Hair";
		string sashAlbumName = "Sash";
		string torsoEffectAlbumName = "Torso Effects";
		string maskAlbumName = "MaleMask";

		hasShirt = true;

		//Determining gender
		if (Random.Range (0, 2) != 0) {
			isMale = true;
			maleRig.transform.parent.gameObject.SetActive(true);
			femaleRig.transform.parent.gameObject.SetActive(false);
			rig = maleRig;
			if (Random.Range (0, 3) != 0) {
				hasBeard = true;
			}
			if (Random.Range (0, 3) != 0) {
				hasStache = true;
			}
			if (Random.Range (0, 9) == 0) {
				hasShirt = false;
			}
		} else {
			isMale = false;
			maleRig.transform.parent.gameObject.SetActive(false);
			femaleRig.transform.parent.gameObject.SetActive(true);
			rig = femaleRig;
			eyesAlbumName = "F Eyes";
			jacketAlbumName = "F Jacket";
			shirtAlbumName = "F Shirt";
			hairAlbumName = "F Hair";
			sashAlbumName = "F Sash";
			maskAlbumName = "F Mask";
			torsoEffectAlbumName = "Female Torso Effects";
			if (Random.Range (0, 3) == 0) {
				hasTattoo = true;
			}
			else{
				hasTattoo = false;
			}
		}
	

		//Picking Colors
		Material[] clothesColorAlbum = Resources.LoadAll<Material> ("ClothesColor");
		Material[] faceColorAlbum = Resources.LoadAll<Material> ("SkinColor");
		Material[] hairColorAlbum = Resources.LoadAll<Material> ("Hair");
		
		Material hairColor = hairColorAlbum [Random.Range (0, hairColorAlbum.Length)];
		Material skinColor = faceColorAlbum [Random.Range (0, faceColorAlbum.Length)];
		Material shirtColor = clothesColorAlbum [Random.Range (0, clothesColorAlbum.Length)];
		Material jacketColor = clothesColorAlbum [Random.Range (0, clothesColorAlbum.Length)];
		Material effectsColor = clothesColorAlbum [Random.Range (0, clothesColorAlbum.Length)];
		Material pantsColor = effectsColor;
		Material hatColor = jacketColor;
		Material highlightColor = shirtColor;

		//Setting SkinTone
		rig.head.material = skinColor;
		rig.rightHand.material = skinColor;
		rig.leftHand.material = skinColor;
		rig.torso.material = skinColor;
		rig.leftShoulderSkin.material = skinColor;
		rig.rightShoulderSkin.material = skinColor;
		rig.leftForearmSkin.material = skinColor;
		rig.rightForearmSkin.material = skinColor;
		rig.ear.material = skinColor;

		
		//Eyes
		Sprite[] eyesAlbum = Resources.LoadAll<Sprite> (eyesAlbumName);
		rig.eyes.sprite = eyesAlbum [Random.Range (0, eyesAlbum.Length)];

		//Pants
		GameObject[] pantsAlbum = Resources.LoadAll<GameObject> ("Pants");
		GameObject pantsObject = pantsAlbum [Random.Range (0, pantsAlbum.Length)];
		pantsObject.GetComponent<Pants> ().Equip (rig, pantsColor, jacketColor);

		//Shirt
		if (hasShirt == true) {         
			GameObject[] shirtAlbum = Resources.LoadAll<GameObject> (shirtAlbumName);
			GameObject shirtObject = shirtAlbum [Random.Range (0, shirtAlbum.Length)];
			shirtObject.GetComponent<Shirt> ().Equip (rig, shirtColor, effectsColor);
		} else {
			hasShirt = false;
			rig.shirt.sprite = null;
			rig.leftShoulder.sprite = null;
			rig.rightShoulder.sprite = null;
			rig.leftForearm.sprite = null;
			rig.rightForearm.sprite = null;
		}

		//Hat
		if (Random.Range (0, 3) != 0) {
			hasHat = true;
			GameObject[] hatAlbum = Resources.LoadAll<GameObject> ("Hat");
			GameObject hatObject = hatAlbum [Random.Range (0, hatAlbum.Length)];
			hatObject.GetComponent<Hat> ().Equip (rig, hatColor, highlightColor);
		} else {
			hasHat = false;
			rig.hatFront.sprite = null;
			rig.hatBack.sprite = null;
		}

		//Hair
		if (Random.Range (0, 3) != 0) {
			rig.hairBack.sprite = null;
			hasHair = true;
			GameObject[] hairAlbum = Resources.LoadAll<GameObject> (hairAlbumName);
			GameObject hairObject = hairAlbum [Random.Range (0, hairAlbum.Length)];
			hairObject.GetComponent<Hair> ().Equip (this, rig, hairColor, hasHat);
		} else {
			hasHair = false;
			rig.hair.sprite = null;
			rig.hairBack.sprite = null;
		}
		//Beard
		if (hasBeard == true) {
			Sprite[] beardAlbum = Resources.LoadAll<Sprite> ("Beard");
			rig.beard.sprite = beardAlbum [Random.Range (0, beardAlbum.Length)];
			rig.beard.material = hairColor;
		} else {
			rig.beard.sprite = null;
		}
		//Mustache
		if (hasStache == true) { 
			Sprite[] mustacheAlbum = Resources.LoadAll<Sprite> ("Mustache");
			rig.mustache.sprite = mustacheAlbum [Random.Range (0, mustacheAlbum.Length)];
			rig.mustache.material = hairColor;
		} else {
			rig.mustache.sprite = null;
		}
		//Head Effect
		if (Random.Range (0, 3) == 0) { 
			hasHeadEffect = true;
			Sprite[] headEffectAlbum = Resources.LoadAll<Sprite> ("HeadEffects");
			rig.headEffect.sprite = headEffectAlbum [Random.Range (0, headEffectAlbum.Length)];
			rig.headEffect.material = effectsColor;
		} else {
			hasHeadEffect = false;
			rig.headEffect.sprite = null;
		}

		//Tattoo
		if (hasTattoo == true) { 
			Sprite[] tattooAlbum = Resources.LoadAll<Sprite> ("Tattoo");
			rig.tattoo.sprite = tattooAlbum [Random.Range (0, tattooAlbum.Length)];
		} else {
			rig.tattoo.sprite = null;
		}

		
		if (Random.Range (0, 3) == 0) { 		//Torso Effect Check
			hasTorsoEffect = true;
			Sprite[] torsoEffectAlbum = Resources.LoadAll<Sprite> (torsoEffectAlbumName);
			rig.torsoEffect.sprite = torsoEffectAlbum [Random.Range (0, torsoEffectAlbum.Length)];
			rig.torsoEffect.material = effectsColor;
		} else {
			hasTorsoEffect = false;
			rig.torsoEffect.sprite = null;
		}

		if (Random.Range (0, 6) != 0) {			//Mask Check
			hasMask = false;
			rig.mask.sprite = null;
		} else {
			hasMask = true;
			Sprite[] maskAlbum = Resources.LoadAll<Sprite> (maskAlbumName);
			rig.mask.sprite = maskAlbum [Random.Range (0, maskAlbum.Length)];
			rig.mask.material = effectsColor;
			hasBeard = false;
			rig.beard.sprite = null;
			hasStache = false;
			rig.mustache.sprite = null;
		}
		//Jacket and Sash
		rig.jacketFront.sprite = null;
		if (Random.Range (0, 3) != 0) {
			hasJacket = true;
			GameObject[] coatAlbum = Resources.LoadAll<GameObject> (jacketAlbumName);
			GameObject coatObject = coatAlbum [Random.Range (0, coatAlbum.Length)];
			coatObject.GetComponent<Jacket> ().Equip (rig, jacketColor, highlightColor);
			if (coatObject.GetComponent<Jacket> ().hasSash == true) {
				Sprite [] sashAlbum = Resources.LoadAll<Sprite> (sashAlbumName);
				rig.sash.sprite = sashAlbum [Random.Range (0, sashAlbum.Length)];
				rig.sash.material = effectsColor;
			} else
				rig.sash.sprite = null;
		} else {
			hasJacket = false;
			hasJacket = false;
			rig.jacketFront.sprite = null;
			rig.jacketBack.sprite = null;
			rig.jacket.sprite = null;
			rig.sash.sprite = null;
		}

	}
	// Update is called once per frame
	void Update () {
		
	}
}
