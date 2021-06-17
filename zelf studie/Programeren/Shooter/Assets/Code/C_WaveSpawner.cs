using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_WaveSpawner : MonoBehaviour
{
	public Transform enemyPrefab;

	public Transform spawinpoint;

	public float timeWaves = 10f ;
	float coutdouwn = 2f;
	int waveNumb = 1;

	void Update() 
	{
		if (coutdouwn <= 0f)
		{
			SpawnWave();
			coutdouwn = timeWaves;
		}

		coutdouwn -= Time.deltaTime;
	}
	public void SpawnWave()
	{
		for (int i = 0; i < waveNumb; i++)
		{
			SpawnEnemy();
		}
		waveNumb++;
	}

	void SpawnEnemy() 
	{
		Instantiate(enemyPrefab, spawinpoint.position, spawinpoint.rotation);
	}
}
