using UnityEngine;
using System.Collections;

public class EnemyHpBar : MonoBehaviour
{
	
	Rect box;
	
	Texture2D background;
	Texture2D foreground;
	
	public float health = 50;
	public int maxHealth = 100;
	
	void Start()
	{
	}
	
	void Update()
	{
		if (health < 0) health = 0;
		if (health > maxHealth) health = maxHealth;

	}
	
	void OnGUI()
	{
		if (renderer.isVisible == true) {
			Vector2 wantedPos = Camera.main.WorldToScreenPoint (transform.position);
			GUI.Box (new Rect (wantedPos.x, Screen.height - wantedPos.y, 60, 20), health + "/" + maxHealth);
		}
	}
	
}