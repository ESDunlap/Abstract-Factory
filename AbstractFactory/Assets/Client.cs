using UnityEngine;

public class Client : MonoBehaviour
{
    public NPCSpawner m_SpawnerNPC;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            m_SpawnerNPC.SpawnBeggar();
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            m_SpawnerNPC.SpawnFarmer();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            m_SpawnerNPC.SpawnShopowner();
        }
    }
}
