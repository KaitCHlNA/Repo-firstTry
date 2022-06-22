using UnityEngine;
//Script con comportamiento de spawner de balas, Instanciación de "humo", interacción con vida de jugador.
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
    
    
    //Health Status
    private int bulletDamage = 15;
    private int playerLife = 100;
    private int playerDead = 0;
    
    //Smooke
    public GameObject prefabSmoke;
    public Transform smokePosition;


    void Start()
    {
        //Disparo automático de 1 bala (desafío 3)
        SpawnSpace();
        //Aparición de humo
        SmookeSpawn();
    }
    void Update()
    {
        //Disparo manual de 1 bala (desafío 3)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnSpace();
            SmookeSpawn();
            Health();
        }
        
        //Disparo manual y múltiple de 2,3 y 4 balas respectivamente (desafío complementario)
        if (Input.GetKeyDown(KeyCode.J))
        {
            SpawnJ();
            SmookeSpawn();

        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            SpawnK();
            SmookeSpawn();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            SpawnL();
            SmookeSpawn();
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

    
    //Para "adornar" la variable Damage 
    void Health()
    {
        Debug.Log("-" + bulletDamage + " damage"); 
        playerLife -= bulletDamage; 
        Debug.Log(playerLife + " HP");
        
        if(playerLife < playerDead)
        {
            Debug.Log("GAME OVER");
        }
    }
    
    //para practicar la instanciación de objetos
    void SmookeSpawn()
    {
        Instantiate(prefabSmoke, smokePosition.position,transform.rotation);
    }
}
