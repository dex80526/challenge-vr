using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CollisionScript : MonoBehaviour {

	public bool collision;
	public GameObject body;
	public Canvas personDisplay;
	public Text textDisplay; 


	// Use this for initialization
	void Start () {
		personDisplay = this.gameObject.GetComponentsInChildren<Canvas> ()[0]; 
		textDisplay = this.gameObject.GetComponentInChildren<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		//detect if the person is in the Building
		//if yes, display some info about the building: name of building, year built, functioning/services, etc
		//let's first hard code the data now. the data could be looked up from other service or db based on the building id.
		//if not, do nothing
	}
		

	void OnTriggerEnter(Collider other) {
		Component otherComponent;
		if (other.tag == "building") {
			collision = true;

			otherComponent = other.gameObject.GetComponent<BuildingViewScript> (); //.displayData (collision);
			string buildingData = ((BuildingViewScript)otherComponent).getBuildingData();
			Debug.Log (buildingData);
			showBuildingData(buildingData, true);

		}

		if (other.tag == "parkinglot") {
			//myComponet = other.gameObject.GetComponent<BuildingViewScript> (); //.displayData (collision);
			//showParkingData();
		}


	}

	void OnTriggerExit(Collider other) {
		if (other.tag == "building") {
			collision = false;
			showBuildingData("", false);
		}
	}

	void showBuildingData(string data, bool show) {
		textDisplay.text = data;
		personDisplay.enabled = show;
	}

}
