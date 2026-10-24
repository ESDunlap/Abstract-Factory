using UnityEngine;

public class NPCFactory : AbstractNPCFactory
{
    private readonly INPCFactory _factory;
    private readonly NPCRequirements _requirements;

    public NPCFactory(NPCRequirements requirements)
    {
        if (requirements.Friendly)
        {
            _factory = new FriendlyFactory();
        }
        else
        {
            _factory= new HostileFactory();
        }
            _requirements = requirements;
    }

    public override INPC Create()
    {
        return _factory.Create(_requirements);
    }
}
