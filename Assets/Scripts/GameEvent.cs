using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class GameEvent
{
    /*
     * 00000001 -攻击
     * 00000010-受击
     * 00000011--攻击+受击
     */
    private int[] mBuffer;
    private string mEventName;
    
    public GameEvent(int index, string name)
    {
        mBuffer = new int[CoreDefine.EventBufferSize];

        int index_1 = index / sizeof(int);
        int index_2 = index % sizeof(int);

        int value = (int)(1 << index_2);

        mEventName = name;

        if (index_1 >= 0 && index_1 < CoreDefine.EventBufferSize)
        {
            mBuffer[index_1]= value;
        }
        else
        {
            Debug.LogErrorFormat("EventTypeBuffer Create failed,index out of range,event name:{0}", name);
        }
    }

    public int[] GetEventBuffer()
    {
        return mBuffer;
    }

    public string GetEventName()
    {
        return mEventName;
    }

    public GameEvent(int[] buffer, string name)
    {
        mBuffer = buffer;
        mEventName = name;
    }

    public static GameEvent BindEventTypeBuffer(List<GameEvent> eventTypes,string name)
    {
        int[] buffer = new int[CoreDefine.EventBufferSize];
        StringBuilder s = new StringBuilder();
        for(int i=0;i< eventTypes.Count; i++)
        {
            GameEvent src = eventTypes[i];
            s.AppendFormat("{0}+",src.GetEventName());
            for (int j = 0;j<CoreDefine.EventBufferSize;j++)
            {
                buffer[j] |= src.GetEventBuffer()[i];
            }
        }
        return new GameEvent(buffer, s.ToString());
    }

    public bool HasEvent(GameEvent evt)
    {
        for (int i = 0; i < CoreDefine.EventBufferSize; i++)
        {
            int temp = mBuffer[i] |= evt.GetEventBuffer()[i];
            if (temp > 0)
                return true;
        }

        return false;
    }
}
