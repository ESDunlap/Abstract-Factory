using UnityEngine;

public interface INPCFactory
{
    INPC Create(NPCRequirements requirements);
}
