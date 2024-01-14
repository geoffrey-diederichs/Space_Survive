using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public Asteroid asteroidModel;
    private int spawnRate = 1;
    private int spawnAmount = 1;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), this.spawnRate, this.spawnRate);
    }

    private void Spawn()
    {
        for (int i = 0; i < this.spawnAmount; i++)
        {
            int spawnX = 0, spawnY = 0, directionX = 0, directionY = 0;
            int randSpawn = Random.Range(0, 4);
            if (randSpawn == 0)
            {
                spawnX = Random.Range(-9, 9);
                spawnY = 6;
                
                directionX = 0;
                directionY = -1;
            }
            else if (randSpawn == 1)
            {
                spawnX = Random.Range(-9, 9);
                spawnY = -6;

                directionX = 0;
                directionY = 1;
            }
            else if (randSpawn == 2)
            {
                spawnX = 10;
                spawnY = Random.Range(-3, 3);

                directionX = -1;
                directionY = 0;
            }
            else if (randSpawn == 3)
            {
                spawnX = -10;
                spawnY = Random.Range(-3, 3);

                directionX = 1;
                directionY = 0;
            }
            Vector3 spawnPoint = this.transform.position + new Vector3(spawnX, spawnY, 0);

            Asteroid asteroid = Instantiate(asteroidModel, spawnPoint, new Quaternion());
            asteroid.SetMovement(new Vector2(directionX, directionY));
        }
    }
}
