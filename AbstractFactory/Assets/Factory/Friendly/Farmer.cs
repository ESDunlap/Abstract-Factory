using UnityEngine;

public class Farmer : MonoBehaviour, INPC, Medium
{
    [SerializeField] private float pauseTime = 3f;
    private Vector3 startLocation;
    private Vector3 endLocation;
    private bool atStart = true;
    private float movementTime = 0;
    private float totalDistance;
    private bool reachedEnd = false;
    private float stopTimer = 0;
    public void Spawn()
    {
        startLocation = transform.position;
        endLocation = new Vector3(Random.Range(-10.0f, 10.0f),
            transform.position.y,
            Random.Range(-10.0f, 10.0f));
        totalDistance = Vector3.Distance(startLocation, endLocation);
        Debug.Log("I LIVE!");
    }
    public void Speak()
    {
        Debug.Log("Do you want to buy something?");
    }

    public void Move()
    {
        if (reachedEnd)
        {
            stopTimer += Time.deltaTime;
            if (stopTimer > pauseTime)
            {
                reachedEnd = false;
                stopTimer = 0;
            }
        }
        else if(atStart)
        {
            movementTime += Time.deltaTime * 5f * 1/totalDistance;
            transform.position = new Vector3(
            Mathf.Lerp(startLocation.x, endLocation.x, movementTime),
            startLocation.y,
            Mathf.Lerp(startLocation.z, endLocation.z, movementTime));
            if (movementTime >= 1)
            {
                reachedEnd = true;
                atStart = false;
                movementTime = 0;
            }
        }
        else
        {
            movementTime += Time.deltaTime * 5f * 1/totalDistance;
            transform.position = new Vector3(
            Mathf.Lerp(endLocation.x, startLocation.x, movementTime),
            startLocation.y,
            Mathf.Lerp(endLocation.z, startLocation.z, movementTime));
            if (movementTime >= 1)
            {
                reachedEnd = true;
                atStart = true;
                movementTime = 0;
            }
        }
    }

    public GameObject getGameObject(){ return gameObject; }
}
