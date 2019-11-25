using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneratorScript : MonoBehaviour {

	public GameObject[] scenarios = new GameObject[5];

	public GameObject currentScenario;
	public GameObject nextScenario;
	public GameObject previousScenario;
	GameObject valueHolder;

	public GameObject cameraMovement;

	int previousScenarioIndex = 0;
	int nextScenarioIndex = 0;
	int minScenario = 0;
	int maxScenario = 5;


	public void firstScenarioGeneration() {
		
		nextScenario = scenarios [Random.Range (minScenario, maxScenario)];

		checkScenarioIndex ();

		setNextScenario ();
	}
		
	public void buildNextScenario() {

		if (cameraMovement.transform.position.x > nextScenario.transform.position.x) {

			previousScenario = currentScenario;
			previousScenario.SetActive (true);

			currentScenario = nextScenario;

			previousScenario.SetActive(false);

			nextScenario = scenarios [Random.Range (minScenario, maxScenario)];

			checkScenarioIndex ();

			setNextScenario ();
		}
	}

	void checkScenarioIndex() {
		
		previousScenarioIndex = System.Array.IndexOf (scenarios, currentScenario);
		nextScenarioIndex = System.Array.IndexOf (scenarios, nextScenario);

		if (previousScenarioIndex == nextScenarioIndex) {

			valueHolder = scenarios[4];
			scenarios[4] = scenarios[previousScenarioIndex];
			scenarios [previousScenarioIndex] = valueHolder;

			minScenario = 0;
			maxScenario = 4;

			nextScenario = scenarios [Random.Range (minScenario, maxScenario)];
		} else {}

	}

	void setNextScenario() {
		
		nextScenario.transform.position = new Vector3 (currentScenario.GetComponent<Transform> ().position.x + (51.76978f * 2f), 0f, 0f);
		nextScenario.SetActive (true);
	}
}
