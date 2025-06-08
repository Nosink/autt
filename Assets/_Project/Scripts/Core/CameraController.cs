using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour {

    [SerializeField]
    private float mTransitionSpeed = 2f;

    private Coroutine mMoveCoro = null;

    public void MoveTo(Transform target) {
        if (mMoveCoro != null)
            StopCoroutine(mMoveCoro);
        mMoveCoro = StartCoroutine(Move(target));
    }

    private IEnumerator Move(Transform target) {
        float lThreshold = 0.001f;

        while (Vector3.Distance(transform.position, target.position) > lThreshold) {
            float step = Time.deltaTime * mTransitionSpeed;

            transform.position = Vector3.Lerp(transform.position, target.position, step);

            yield return null;
        }

    }

}