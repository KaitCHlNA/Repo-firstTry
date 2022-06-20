using UnityEngine;
//Script creado para instanciar balas, pero NO para moverlas.
public class ShootingBullet : MonoBehaviour
{
    public GameObject prefabBullet;
    public Transform bulletSpawn; //"Cañón" --> "BulletSpawn" como un objeto vacío. 

    void Start()
    {
        //Proyectile();
    }

    void Update()
    {
        ShootBullet();
    }

    /* Método creado para probar el Instantiate y usarlo SOLO en Start
     
     void Proyectile()
    {
        Instantiate(prefabBullet, bulletSpawn.position, transform.rotation);
    }
    
    */
    
    void ShootBullet() //método "Disparo"
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Instantiate(prefabBullet, bulletSpawn.position, transform.rotation);
        }
        
        if (Input.GetKeyDown(KeyCode.K))
        {
            Instantiate(prefabBullet, bulletSpawn.position, transform.rotation);
        }
        
        if (Input.GetKeyDown(KeyCode.L))
        {
            Instantiate(prefabBullet, bulletSpawn.position, transform.rotation);
        }
    }
}
