using UnityEngine;
using System.Collections;

public class EnemySpawner2 : MonoBehaviour {

		public GameObject enemyPrefab;

		float spawnDistance = 12f;

		float enemyRate = 10;
		float nextEnemy = 8;

		// Update is called once per frame
		void Update () {
				nextEnemy -= Time.deltaTime;

				if(nextEnemy <= 0) {
						nextEnemy = enemyRate;
						enemyRate *= 0.3f;
						if(enemyRate < 1)
								enemyRate = 1;

						Vector3 offset = Random.onUnitSphere;

						offset.z = 0;

						offset = offset.normalized * spawnDistance;

						Instantiate(enemyPrefab, transform.position + offset, Quaternion.identity);
				}
		}
}
