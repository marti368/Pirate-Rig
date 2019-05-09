using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recolor : MonoBehaviour {

	//public SpriteRenderer spriteRendDefault;
	//public Sprite sprite;

	// Use this for initialization
	void Start () {
		//Material[] clothesColorAlbum = Resources.LoadAll<Material> ("ClothesColor");	
		//Material shirtColor = clothesColorAlbum [Random.Range (0, clothesColorAlbum.Length)];
		//Material effectsColor = clothesColorAlbum [Random.Range (0, clothesColorAlbum.Length)];
		//DoRecolor (spriteRendDefault, shirtColor.color,effectsColor.color);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public Sprite DoRecolor(Sprite sprite, Color color1, Color color2){
		Texture2D spriteTexture = sprite.texture;
		Rect spriteRect = sprite.rect;
		int spriteHeight = (int)spriteRect.height;
		int spriteWidth = (int)spriteRect.width;
		Color black = new Color (0, 0, 0, 1);
		Color clear = new Color (0, 0, 0, 0);
		Color white = new Color (1, 1, 1, 1);
		Color weird = new Color (1, 0, 1, 1);
		Color weird2 = new Color (0, 1, 1, 1);
		Color grey = new Color (.5019608f, .5019608f, .5019608f, 1);
		Texture2D texture = new Texture2D (spriteWidth,spriteHeight);
		for (int y = 0; y < texture.height; y++){
			for (int x = 0; x < texture.width; x++){
				Color color = spriteTexture.GetPixel(x,y);
				if (color == white){
					texture.SetPixel(x,y,color1);
				}
				else if (color == grey){
					texture.SetPixel(x,y,color2);
				}
				else{
					texture.SetPixel(x,y,color);
				}

			}

		}
		texture.Apply ();
		sprite = Sprite.Create (texture, spriteRect, new Vector2 (.5f, .5f));
		return sprite;

	}

}
