using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IActor
{
    int GetEntityId();
    int GetWordId();

    void OnCreate();
    void OnDestroy();

    void ReceiveEvent(GameEvent evt); //接收事件（行为）
}
