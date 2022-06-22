using UnityEngine;
//Script creado para practicar instanciación de GameObject al momento de ser llamado por un input.

public class SmokeSpawn : MonoBehaviour
{
    public GameObject prefabSmoke;
    public Transform smokePosition;

    void Start()
    {
        Instantiate(prefabSmoke, smokePosition.position,transform.rotation);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabSmoke, smokePosition.position,transform.rotation);
        }   
        if (Input.GetKeyDown(KeyCode.J))
        {
            Instantiate(prefabSmoke, smokePosition.position,transform.rotation);
        }   
        if (Input.GetKeyDown(KeyCode.K))
        {
            Instantiate(prefabSmoke, smokePosition.position,transform.rotation);
        }   
        if (Input.GetKeyDown(KeyCode.L))
        {
            Instantiate(prefabSmoke, smokePosition.position,transform.rotation);
        }   
    }
}
