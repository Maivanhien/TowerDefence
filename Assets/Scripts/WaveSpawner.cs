using System.Collections;
using UnityEngine;
using TMPro;

public class WaveSpawner : MonoBehaviour {
    public Transform enemyPrefab;
    public Transform spawnPoint;
    public float timeBetweenWaves = 5f;
    public TextMeshProUGUI countDownText;
    private float countDown = 2f;
    private int waveNumber = 0;

    private void Update() {
        countDown -= Time.deltaTime;
        countDownText.text = Mathf.Round(countDown).ToString();
        if (countDown <= 0) {
            StartCoroutine(SpawnWave());
            countDown = timeBetweenWaves;
        }
    }

    private IEnumerator SpawnWave() {
        waveNumber++;
        for (int i = 0; i < waveNumber; i++) {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
    }

    private void SpawnEnemy() {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
