using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScoringZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;

    public void OnCollisionEnter(Collision collision){


        Debug.Log("There is a collision");
        BaseEventData eventData = new BaseEventData(EventSystem.current);
        this.scoreTrigger.Invoke(eventData);

 
        
    }
    public void OnTriggerEnter(Collider other)
    {

        Debug.Log("There is a trigger");
        BaseEventData eventData = new BaseEventData(EventSystem.current);
        this.scoreTrigger.Invoke(eventData);
    }

    

}
