using UnityEngine;
using System.Collections;

public class Camp : MonoBehaviour {
	public MapInfo.Affiliation affiliation;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (affiliation == MapInfo.Affiliation.none) {
			particleSystem.startColor = Color.white;
		}
		if (affiliation == MapInfo.Affiliation.red) {
			particleSystem.startColor = new Color(255,0,150,255);
		}
		if (affiliation == MapInfo.Affiliation.blue) {
			particleSystem.startColor = new Color(0,255,255,255);
		}
	}
}
