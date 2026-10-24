using UnityEngine;

public class HostileFactory : INPCFactory
{
    public INPC Create(NPCRequirements requirements)
    {
        switch(requirements.RichLevel)
        {

        }
        return null;
    }
}
