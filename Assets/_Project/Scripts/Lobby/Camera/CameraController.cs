using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour {

    [SerializeField]
    private Transform upperPosition;
    [SerializeField]
    private Transform lowerPosition;
    [SerializeField]
    private float transitionSpeed = 2f;

    private Coroutine moveRoutine;

    public void SetTargetPosition(Transform target) {
        if (moveRoutine != null)
            StopCoroutine(moveRoutine);
        moveRoutine = StartCoroutine(MoveCamera(target));
    }

    private IEnumerator MoveCamera(Transform target) {
        float threshold = 0.001f;

        while (Vector3.Distance(transform.position, target.position) > threshold) {
            float step = Time.deltaTime * transitionSpeed;

            transform.position = Vector3.Lerp(transform.position, target.position, step);

            yield return null;
        }

        transform.position = target.position;
    }

}