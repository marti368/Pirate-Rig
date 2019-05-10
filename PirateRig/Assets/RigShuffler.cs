using UnityEngine;
using System.Collections;

public class RigShuffler : MonoBehaviour {

	public SpriteRenderer eyes;
	public SpriteRenderer ear;

	public SpriteRenderer hairTop;
	public SpriteRenderer hairFront;
	public SpriteRenderer hairBack;

	public SpriteRenderer beard;
	public SpriteRenderer mustache;

	public SpriteRenderer hatFront;
	public SpriteRenderer hatBack;

	public SpriteRenderer mask;

	public SpriteRenderer headEffect;
	public SpriteRenderer torsoEffect;

	public SpriteRenderer head;
	public SpriteRenderer torso;
	public SpriteRenderer leftShoulderSkin;
	public SpriteRenderer rightShoulderSkin;
	public SpriteRenderer leftForearmSkin;
	public SpriteRenderer rightForearmSkin;
	public SpriteRenderer hat;
	public SpriteRenderer leftShoulder;
	public SpriteRenderer rightShoulder;
	public SpriteRenderer leftForearm;
	public SpriteRenderer rightForearm;
	public SpriteRenderer leftHand;
	public SpriteRenderer rightHand;
	public SpriteRenderer shirt;
	//public SpriteRenderer neck;
	public SpriteRenderer hips;
	public SpriteRenderer leftThigh;
	public SpriteRenderer rightThigh;
	public SpriteRenderer leftShin;
	public SpriteRenderer rightShin;
	public SpriteRenderer leftFoot;
	public SpriteRenderer rightFoot;
	public SpriteRenderer jacket;
	public SpriteRenderer jacketFront;
	public SpriteRenderer jacketBack;

    public bool hasShirt;
	public bool hasHat;
	public bool hasJacket;
	public bool hasBeard;
	public bool hasStache;
	public bool hasHair;
	public bool hasMask;
	public bool hasHeadEffect;
	public bool hasTorsoEffect;

	// Use this for initialization
	void Start () {
		Shuffle();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Shuffle(){

		Sprite[] eyesAlbum = Resources.LoadAll<Sprite> ("Eyes");
		Sprite eye = eyesAlbum [Random.Range (0, eyesAlbum.Length)];
		//Sprite[] effectsAlbum = Resources.LoadAll<Sprite> ("Effects");
		//effect.sprite = effectsAlbum [Random.Range (0, effectsAlbum.Length)];

		GameObject[] pantsAlbum = Resources.LoadAll<GameObject> ("Pants");
		GameObject pantsObject = pantsAlbum [Random.Range (0, pantsAlbum.Length)];

		Material[] clothesColorAlbum = Resources.LoadAll<Material> ("ClothesColor");
		Material[] faceColorAlbum = Resources.LoadAll<Material> ("SkinColor");
		Material[] hairColorAlbum = Resources.LoadAll<Material> ("Hair");

		Material hairColor = hairColorAlbum [Random.Range (0, hairColorAlbum.Length)];
		Material skinColor = faceColorAlbum [Random.Range (0, faceColorAlbum.Length)];
		Material shirtColor = clothesColorAlbum [Random.Range (0, clothesColorAlbum.Length)];
		Material jacketColor = clothesColorAlbum [Random.Range (0, clothesColorAlbum.Length)];
		Material pantsColor = clothesColorAlbum [Random.Range (0, clothesColorAlbum.Length)];
		Material effectsColor = clothesColorAlbum [Random.Range (0, clothesColorAlbum.Length)];
		Material hatColor = jacketColor;
		Material highlightColor = shirtColor;

		pantsObject.GetComponent<Pants> ().Equip (this, pantsColor);

        if (Random.Range(0, 7) != 0) //Shirt Check
        {           
            hasShirt = true;
            GameObject[] shirtAlbum = Resources.LoadAll<GameObject>("Shirt");
            GameObject shirtObject = shirtAlbum[Random.Range(0, shirtAlbum.Length)];
            shirtObject.GetComponent<Shirt>().Equip(this, shirtColor);
        }
        else
        {
            hasShirt = false;
            shirt.sprite = null;
            leftShoulder.sprite = null;
            rightShoulder.sprite = null;
            leftForearm.sprite = null;
            rightForearm.sprite = null;
        }

        if (Random.Range (0, 3) != 0) {			//Hat Check
			hasHat = true;
			GameObject[] hatAlbum = Resources.LoadAll<GameObject> ("Hat");
			GameObject hatObject = hatAlbum [Random.Range (0, hatAlbum.Length)];
			hatObject.GetComponent<Hat> ().Equip (this, hatColor, highlightColor);

		} else {
			hasHat = false;
			hatFront.sprite = null;
			hatBack.sprite = null;
		}
		if (Random.Range (0, 3) != 0) {			//HairCheck
			hasHair = true;
			GameObject[] hairAlbum = Resources.LoadAll<GameObject> ("Hair");
			GameObject hairObject = hairAlbum [Random.Range (0, hairAlbum.Length)];
			hairObject.GetComponent<Hair> ().Equip (this, hairColor, hasHat);
		} else {
			hasHair = false;
			hairTop.sprite = null;
			hairFront.sprite = null;
			hairBack.sprite = null;
		}
		if (Random.Range (0, 3) != 0) { 		//Beard Check
			hasBeard = true;
			Sprite[] beardAlbum = Resources.LoadAll<Sprite> ("Beard");
			beard.sprite = beardAlbum [Random.Range (0, beardAlbum.Length)];
			beard.material = hairColor;
		} else {
			hasBeard = false;
			beard.sprite = null;
		}
		if (Random.Range (0, 3) != 0) { 		//Mustache Check
			hasStache = true;
			Sprite[] mustacheAlbum = Resources.LoadAll<Sprite> ("Mustache");
			mustache.sprite = mustacheAlbum [Random.Range (0, mustacheAlbum.Length)];
			mustache.material = hairColor;
		} else {
			hasStache = false;
			mustache.sprite = null;
		}
		if (Random.Range (0, 3) == 0) { 		//Head Effect Check
			hasHeadEffect = true;
			Sprite[] headEffectAlbum = Resources.LoadAll<Sprite> ("HeadEffects");
			headEffect.sprite = headEffectAlbum [Random.Range (0, headEffectAlbum.Length)];
			headEffect.material = effectsColor;
		} else {
			hasHeadEffect = false;
			headEffect.sprite = null;
		}

		if (Random.Range (0, 3) == 0) { 		//Torso Effect Check
			hasTorsoEffect = true;
			Sprite[] torsoEffectAlbum = Resources.LoadAll<Sprite> ("TorsoEffects");
			torsoEffect.sprite = torsoEffectAlbum [Random.Range (0, torsoEffectAlbum.Length)];
			torsoEffect.material = effectsColor;
		} else {
			hasTorsoEffect = false;
			torsoEffect.sprite = null;
		}

		/*if (Random.Range (0, 3) != 0) {			//Neck Check
			Sprite[] neckAlbum = Resources.LoadAll<Sprite> ("Neck");
			neck.sprite = neckAlbum [Random.Range (0, neckAlbum.Length)];
		} else {
			neck.sprite = null;
		}*/
		/*if (Random.Range (0, 6) != 0) {			//Mask Check
			hasMask = false;
			mask.sprite = null;
		} else {
			hasMask = true;
			Sprite[] maskAlbum = Resources.LoadAll<Sprite> ("MaleMask");
			mask.sprite = maskAlbum [Random.Range (0, maskAlbum.Length)];
			mask.material = jacketColor;
			hasBeard = false;
			beard.sprite = null;
			hasStache = false;
			mustache.sprite = null;
		}*/
		if (Random.Range (0, 3) != 0) {			//Jacket Check
			hasJacket = true;
			GameObject[] coatAlbum = Resources.LoadAll<GameObject> ("Jacket");
			GameObject coatObject = coatAlbum [Random.Range (0, coatAlbum.Length)];
			coatObject.GetComponent<Jacket> ().Equip (this, jacketColor, highlightColor);
		} else {
			hasJacket = false;
			hasJacket = false;
			jacketFront.sprite = null;
			jacketBack.sprite = null;
			jacket.sprite = null;
		}

		head.material = skinColor;
		rightHand.material = skinColor;
		leftHand.material = skinColor;
		torso.material = skinColor;
		leftShoulderSkin.material = skinColor;
		rightShoulderSkin.material = skinColor;
		leftForearmSkin.material = skinColor;
		rightForearmSkin.material = skinColor;
		ear.material = skinColor;
		//neck.material = jacketColor;
		eyes.sprite = eye;


			

	}
}
