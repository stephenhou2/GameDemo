using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class ActiveSkill : ISkill
{
    public void ApplySkill(List<Actor> actors, List<IBuff> buffs)
    {
        
    }

    public virtual bool Triggered(GameEvent type)
    {
        if (!type.HasEvent(EventType.PlayerOp))
            return false;

        return true;
    }
}
