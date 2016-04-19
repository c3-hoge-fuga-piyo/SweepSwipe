using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;

using System.Collections.Generic;

namespace OhanaYa
{
    public sealed class RearmostRaycaster : BaseRaycaster
    {
        #region BaseRaycaster
        public override Camera eventCamera { get { return null; } }

        public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
        {
            Assert.IsNotNull(eventData);
            Assert.IsNotNull(resultAppendList);
            Assert.IsNotNull(SortingLayer.layers);
            Assert.IsTrue(SortingLayer.layers.Length > 0);

            var rearmostLayer = SortingLayer.layers[0];

            resultAppendList.Add(new RaycastResult{
                gameObject = this.gameObject,
                module = this,
                distance = float.MaxValue,
                index = float.MaxValue,
                depth = int.MinValue,
                sortingLayer = rearmostLayer.id,
                sortingOrder = int.MinValue});
        }

        public override int sortOrderPriority { get { return int.MinValue; } }
        public override int renderOrderPriority { get { return int.MinValue; } }
        #endregion
    }
}
