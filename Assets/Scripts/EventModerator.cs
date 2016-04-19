using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;

namespace OhanaYa.SweepSwipe
{
    public sealed class EventModerator : MonoBehaviour
        , IObjectSwipedHandler
    {
        #region IObjectSwipedHandler
        void IObjectSwipedHandler.OnObjectSwiped(GameObject swipedObject)
        {
            Assert.IsNotNull(swipedObject);

            ExecuteEvents.Execute<IObjectSwipedHandler>(
                swipedObject,
                null,
                (h, _) => h.OnObjectSwiped(swipedObject));
        }
        #endregion
    }
}
