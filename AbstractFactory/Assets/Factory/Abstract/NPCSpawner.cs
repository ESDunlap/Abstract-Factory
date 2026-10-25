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
        NPCRequirements _Requirements;
        _Requirements = new NPCRequirements();
        _Requirements.Friendly = true;
        _Requirements.RichLevel = Richness.Low;
        INPC m_Beggar = GetNPC(_Requirements);
        m_Beggar.Spawn();
        allVillagers.Add(m_Beggar);
    }

    public void SpawnFarmer()
    {
        NPCRequirements _Requirements;
        _Requirements = new NPCRequirements();
        _Requirements.Friendly = true;
        _Requirements.RichLevel = Richness.Middle;
        INPC m_Farmer = GetNPC(_Requirements);
        m_Farmer.Spawn();
        allVillagers.Add(m_Farmer);
    }

    public void SpawnShopowner()
    {
        NPCRequirements _Requirements;
        _Requirements = new NPCRequirements();
        _Requirements.Friendly = true;
        _Requirements.RichLevel = Richness.High;
        INPC m_Shopowner = GetNPC(_Requirements);
        m_Shopowner.Spawn();
        allVillagers.Add(m_Shopowner);
    }

    public void SpawnGoblin()
    {
        NPCRequirements _Requirements;
        _Requirements = new NPCRequirements();
        _Requirements.Friendly = false;
        _Requirements.RichLevel = Richness.Low;
        INPC m_Goblin = GetNPC(_Requirements);
        m_Goblin.Spawn();
        allVillagers.Add(m_Goblin);
    }

    public void SpawnOrc()
    {
        NPCRequirements _Requirements;
        _Requirements = new NPCRequirements();
        _Requirements.Friendly = false;
        _Requirements.RichLevel = Richness.Middle;
        INPC m_Goblin = GetNPC(_Requirements);
        m_Goblin.Spawn();
        allVillagers.Add(m_Goblin);
    }

    public void SpawnDragon()
    {
        NPCRequirements _Requirements;
        _Requirements = new NPCRequirements();
        _Requirements.Friendly = false;
        _Requirements.RichLevel = Richness.High;
        INPC m_Goblin = GetNPC(_Requirements);
        m_Goblin.Spawn();
        allVillagers.Add(m_Goblin);
    }

    public void SpawnRequest(NPCRequirements _Requirements)
    {
        INPC m_NPC = GetNPC(_Requirements);
        m_NPC.Spawn();
        allVillagers.Add(m_NPC);
    }

    private static INPC GetNPC(NPCRequirements requirements)
    {
        var factory = new NPCFactory(requirements);
        return factory.Create();
    }

}
