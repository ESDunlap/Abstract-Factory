using UnityEngine;
using System.Collections.Generic;

public class NPCSpawner : MonoBehaviour
{
    public FriendlyFactory m_Factory;

    private List<INPC> allVillagers = new List<INPC>();

    public void Update()
    {
        foreach(INPC villager in allVillagers)
        {
            villager.Move();
        }
    }

    public void SpawnBeggar()
    {
        NPCRequirements _friendlyRequirements;
        _friendlyRequirements = new NPCRequirements();
        _friendlyRequirements.Friendly = true;
        _friendlyRequirements.RichLevel = Richness.Low;
        INPC m_Beggar = GetNPC(_friendlyRequirements);
        m_Beggar.Spawn();
        allVillagers.Add(m_Beggar);
    }

    public void SpawnFarmer()
    {
        NPCRequirements _friendlyRequirements;
        _friendlyRequirements = new NPCRequirements();
        _friendlyRequirements.Friendly = true;
        _friendlyRequirements.RichLevel = Richness.Middle;
        INPC m_Farmer = GetNPC(_friendlyRequirements);
        m_Farmer.Spawn();
        allVillagers.Add(m_Farmer);
    }

    public void SpawnShopowner()
    {
        NPCRequirements _friendlyRequirements;
        _friendlyRequirements = new NPCRequirements();
        _friendlyRequirements.Friendly = true;
        _friendlyRequirements.RichLevel = Richness.High;
        INPC m_Shopowner = GetNPC(_friendlyRequirements);
        m_Shopowner.Spawn();
        allVillagers.Add(m_Shopowner);
    }

    private static INPC GetNPC(NPCRequirements requirements)
    {
        var factory = new NPCFactory(requirements);
        return factory.Create();
    }

}
