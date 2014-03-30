using UnityEngine;
using System.Collections;

public class PlayerInfo : MonoBehaviour {
	public MapInfo.Affiliation affiliation;
	public double maxTimer = 5.0;
	public double timer = 5.0;
	// Use this for initialization
	void Start () {
		timer = maxTimer;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
