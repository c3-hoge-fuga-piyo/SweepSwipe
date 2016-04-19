using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;

namespace OhanaYa.SweepSwipe
{
    [DisallowMultipleComponent]
    public sealed class Swipeable : MonoBehaviour
        , IPointerDownHandler
        , IPointerEnterHandler
    {
        void OnSwiped()
        {
            var parent = this.transform.parent;
            if (parent == null) return;

            ExecuteEvents.ExecuteHierarchy<IObjectSwipedHandler>(
                parent.gameObject,
                null,
                (h, _) => h.OnObjectSwiped(this.gameObject));
        }

        #region IPointerDownHandler
        void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
        {
            this.OnSwiped();

        }
        #endregion

        #region IPointerEnterHandler
        void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
        {
            Assert.IsNotNull(eventData);

            if (eventData.dragging) this.OnSwiped();
        }
        #endregion
    }
}
