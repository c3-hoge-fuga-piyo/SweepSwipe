using UnityEngine;
using UnityEngine.EventSystems;

namespace OhanaYa.SweepSwipe
{
    public interface IObjectSwipedHandler : IEventSystemHandler
    {
        void OnObjectSwiped(GameObject swipedObject);
    }
}
