using UnityEngine;

namespace OhanaYa.SweepSwipe
{
    public sealed class RandomRotation : MonoBehaviour
    {
        #region Unity Messages
        void Awake()
        {
            this.axis = Random.onUnitSphere;
            this.andlePerSecond = 360.0f * Random.Range(0.1f, 2.0f);
        }

        void Update()
        {
            this.transform.Rotate(
                this.axis,
                this.andlePerSecond * Time.deltaTime);
        }
        #endregion

        Vector3 axis;
        float andlePerSecond;
    }
}
