using UnityEngine;
using UnityEngine.Assertions;

namespace OhanaYa.SweepSwipe
{
    public sealed class Cube : MonoBehaviour
        , IObjectSwipedHandler
    {
        #region Unity Inspectors
        [SerializeField]
        ParticleSystem effect;
        #endregion

        #region IObjectSwipedHandler
        void IObjectSwipedHandler.OnObjectSwiped(GameObject swipedObject)
        {
            Assert.IsNotNull(swipedObject);

            if (swipedObject == this.gameObject)
            {
                Assert.IsNotNull(this.effect);
                this.effect.Play();
            }
        }
        #endregion
    }
}
