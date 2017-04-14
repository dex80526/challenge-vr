using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingViewScript : MonoBehaviour {

	public Canvas canvas;

	public string buildingName;

	// Use this for initialization
	void Start () {
		canvas = this.GetComponentInChildren<Canvas> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void displayData(bool state) {
		canvas.enabled = state;
		//display the info about this object (builing name, year built)
	}

	public string getBuildingData() {
		return buildingName;
	}
		
}
