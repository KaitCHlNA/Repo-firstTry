using UnityEngine;
/*Script creado para improvisar el daño recibido hasta perder.
 - Solo las balas disparadas por J se mostrará en consola.
- Deshabilitado en el inspector, si se habilita la consola mostrará daño infinito.

*/
public class PlayerHealth : MonoBehaviour
{
    public int bulletDamage = 15;
    private int playerLife = 100;
    private int playerDead = 0;

    void Start()
    {
        Debug.Log(playerLife + "HP");
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log("-" + bulletDamage + " damage"); 
            playerLife -= bulletDamage; 
            Debug.Log(playerLife + " HP");
        }

        if(playerLife < playerDead)
        {
            Debug.Log("GAME OVER");
        }
        
        /*
        if(Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("-" + bulletDamage + " damage"); 
            playerLife -= bulletDamage; 
            Debug.Log(playerLife + " HP");
        }
        
        if(Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("-" + bulletDamage + " damage"); 
            playerLife -= bulletDamage; 
            Debug.Log(playerLife + " HP");
        }
        */

    }

    void HealthStatus()
    {
        do
        {
            Debug.Log("-" + bulletDamage + " damage");
            playerLife -= bulletDamage;
            Debug.Log(playerLife + " HP");

        } while (0 >= playerLife || 0 <= playerLife);
        Debug.Log("GAME OVER");

    }
}
