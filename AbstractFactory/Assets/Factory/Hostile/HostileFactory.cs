using UnityEngine;

public class HostileFactory : INPCFactory
{
    public INPC Create(NPCRequirements requirements)
    {
        switch(requirements.RichLevel)
        {
            case Richness.Low:
                {
                    GameObject prefab = Resources.Load("Goblin") as GameObject;
                    Vector3 randomLocation = new Vector3(Random.Range(-10.0f, 10.0f),
                    0.5f,
                    Random.Range(-10.0f, 10.0f));
                    Quaternion randomRotation = Quaternion.Euler(0, Random.Range(0f, 360.0f), 0);
                    var finishedNPC = GameObject.Instantiate(prefab, randomLocation, Quaternion.identity) as GameObject;
                    finishedNPC.transform.rotation = randomRotation;
                    return finishedNPC.GetComponent<INPC>();
                }
            case Richness.Middle:
                {
                    GameObject prefab = Resources.Load("Orc") as GameObject;
                    Vector3 randomLocation = new Vector3(Random.Range(-10.0f, 10.0f),
                    1f,
                    Random.Range(-10.0f, 10.0f));
                    Quaternion randomRotation = Quaternion.Euler(0, Random.Range(0f, 360.0f), 0);
                    var finishedNPC = GameObject.Instantiate(prefab, randomLocation, Quaternion.identity) as GameObject;
                    finishedNPC.transform.rotation = randomRotation;
                    return finishedNPC.GetComponent<INPC>();
                }
            case Richness.High:
                {
                    GameObject prefab = Resources.Load("Dragon") as GameObject;
                    Vector3 randomLocation = new Vector3(Random.Range(-10.0f, 10.0f),
                    1f,
                    Random.Range(-10.0f, 10.0f));
                    Quaternion randomRotation = Quaternion.Euler(0, Random.Range(0f, 360.0f), 0);
                    var finishedNPC = GameObject.Instantiate(prefab, randomLocation, Quaternion.identity) as GameObject;
                    finishedNPC.transform.rotation = randomRotation;
                    return finishedNPC.GetComponent<INPC>();
                }
        }
        return null;
    }
}
