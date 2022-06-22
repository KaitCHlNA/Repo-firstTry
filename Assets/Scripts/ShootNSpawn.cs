using UnityEngine;
//Script con comportamiento de spawner de balas.
//Canyon --> player con varios GameObjects invisibles como spawn de balas.
public class ShootNSpawn : MonoBehaviour
{
    //1 Bullet Space
    public GameObject prefabBulletSpace;
    public Transform spawnSpace;
    
    //2 Bullets J
    public GameObject prefabBulletJ;
    public Transform spawnJ1;
    public Transform spawnJ2;
    
    //3 Bullets K
    public GameObject prefabBulletK;
    public Transform spawnK1;
    public Transform spawnK2;
    public Transform spawnK3;
    
    //4 Bullets L
    public GameObject prefabBulletL;
    public Transform spawnL1;
    public Transform spawnL2;
    public Transform spawnL3;
    public Transform spawnL4;


    void Start()
    {
        //Disparo automático de 1 bala (desafío 3)
        Instantiate(prefabBulletSpace, spawnSpace.position, transform.rotation); 
    }
    void Update()
    {
        //Disparo manual de 1 bala (desafío 3)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnSpace();
        }
        
        //Disparo manual y múltiple de 2,3 y 4 balas respectivamente (desafío complementario)
        if (Input.GetKeyDown(KeyCode.J))
        {
            SpawnJ();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            SpawnK();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            SpawnL();
        }
    }

    //Métodos de disparo (Spawn de balas para ser disparadas)
    void SpawnSpace()
    {
        Instantiate(prefabBulletSpace, spawnSpace.position, transform.rotation);
    }
    void SpawnJ()
    {
        Instantiate(prefabBulletJ, spawnJ1.position, transform.rotation);
        Instantiate(prefabBulletJ, spawnJ2.position, transform.rotation);
    }
    void SpawnK()
    {
        Instantiate(prefabBulletK, spawnK1.position, transform.rotation);
        Instantiate(prefabBulletK, spawnK2.position, transform.rotation);
        Instantiate(prefabBulletK, spawnK3.position, transform.rotation);
    }
    void SpawnL()
    {
        Instantiate(prefabBulletL, spawnL1.position, transform.rotation);
        Instantiate(prefabBulletL, spawnL2.position, transform.rotation);
        Instantiate(prefabBulletL, spawnL3.position, transform.rotation);
        Instantiate(prefabBulletL, spawnL4.position, transform.rotation);
    }

}
