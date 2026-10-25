using System.Linq;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using static UnityEngine.UI.ScrollRect;

public class Goblin : MonoBehaviour, INPC
{
    private GameObject target;
    private float movementSpeed = 5f;
    public void Spawn()
    {
        findTarget();
    }
    public void Speak()
    {
        Debug.Log("I'M GONNA STAB YOU!");
    }
    public void Move()
    {
        if (target != null)
        {
            float movement = movementSpeed * Time.deltaTime;
            Vector3 currentLocation = transform.position;
            Vector3 endLocation = target.transform.position - target.transform.forward;
            float distance = Vector3.Distance(currentLocation, endLocation);
            if (distance > movement)
            {
                gameObject.transform.position = Vector3.Lerp(currentLocation, endLocation, movement/distance);
            }
            else
            {
                gameObject.transform.position = endLocation;
            }
        }
        else
        {
            findTarget();
        }
    }

    private void findTarget()
    {
        if (target == null)
        {
            Debug.Log("SEARCHING FOR TARGET!");
            Medium[] possibleTargets = FindObjectsByType<MonoBehaviour>(FindObjectsSortMode.None).OfType<Medium>().ToArray();
            if (possibleTargets.Length != 0)
            {
                target = possibleTargets[Random.Range(0, possibleTargets.Length-1)].getGameObject();
            }
        }
    }


}
