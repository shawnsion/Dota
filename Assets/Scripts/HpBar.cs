//  Created By NPSF3000 (NPSF3001 randomgarbage gmail.com)
//  Free for all use, use at own risk.
//  Simple experiment, not much testing or research hs gone into this.
//  Attribution preferred.


using UnityEngine;
using System.Collections;

public class HpBar : MonoBehaviour
{
	
	Rect box;
	
	Texture2D background;
	Texture2D foreground;
	
	public float health = 50;
	public int maxHealth = 100;
	public int x = 10;
	public int y = 10;
	public int w = 100;
	public int h = 20;
	
	void Start()
	{
		box = new Rect(x, y, w, h);
		
		background = new Texture2D(1, 1, TextureFormat.RGB24, false);
		foreground = new Texture2D(1, 1, TextureFormat.RGB24, false);
		
		background.SetPixel(0, 0, Color.red);
		foreground.SetPixel(0, 0, Color.green);
		
		background.Apply();
		foreground.Apply();
	}
	
	void Update()
	{
		if (health < 0) health = 0;
		if (health > maxHealth) health = maxHealth;
	}
	
	void OnGUI()
	{
		GUI.BeginGroup(box);
		{
			GUI.DrawTexture(new Rect(0, 0, box.width, box.height), background, ScaleMode.StretchToFill);
			GUI.DrawTexture(new Rect(0, 0, box.width*health/maxHealth, box.height), foreground, ScaleMode.StretchToFill);
		}
		GUI.EndGroup(); ;
	}
	
}