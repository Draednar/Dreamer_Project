using UnityEngine;

internal class SisterShoutingTrigger : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
   {
       EventMng.current.SisterShoutingStart.Invoke();
   }

 }
