using UnityEngine;
//Disparar 4 balas con la L
public class BulletSpawnL : MonoBehaviour
{
    public GameObject prefabBulletL1;
    public GameObject prefabBulletL2;
    public GameObject prefabBulletL3;
    public GameObject prefabBulletL4;
    public Transform bSpawnL1;
    public Transform bSpawnL2;
    public Transform bSpawnL3;
    public Transform bSpawnL4;
  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            SpawnBulletL();
        }
    }

    void SpawnBulletL()
    {
        Instantiate(prefabBulletL1, bSpawnL1.position, transform.rotation);
        Instantiate(prefabBulletL2, bSpawnL2.position, transform.rotation);
        Instantiate(prefabBulletL3, bSpawnL3.position, transform.rotation);
        Instantiate(prefabBulletL4, bSpawnL4.position, transform.rotation);
    }
}