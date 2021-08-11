using System.Collections.Generic;

public interface ISkill
{
    void ApplySkill(List<Actor> actors, List<IBuff> buffs);

    bool Triggered(GameEvent evt);
}


