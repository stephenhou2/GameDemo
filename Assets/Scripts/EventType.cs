using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EventType
{
    public static GameEvent PlayerOp { get; private set; }                          = new GameEvent(0, "PlayerOp");
    public static GameEvent Attack { get; private set; }                              = new GameEvent(1, "Attack");
    public static GameEvent Move { get; private set; }                               = new GameEvent(2, "Move");
    public static GameEvent BeAttack { get; private set; }                          = new GameEvent(3, "BeAttack");
    public static GameEvent HPChange { get; private set; }                       = new GameEvent(4, "HPChange");
    public static GameEvent MPChange { get; private set; }                      = new GameEvent(5, "MPChange");
}
