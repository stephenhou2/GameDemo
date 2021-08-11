using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAndBlood : ActiveSkill
{
    public override bool Triggered(GameEvent evt)
    {
        if (!base.Triggered(evt))
            return false;

        return evt.HasEvent(EventType.HPChange);
    }
}
