using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Tweener : MonoBehaviour
{
    //private Tween activeTween;
    private List<Tween> activeTweens;
    private float currentTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (activeTweens != null)
        {
            foreach (Tween activeTween in activeTweens.ToList())
            {
                currentTime = Time.time - activeTween.StartTime;
                if (Vector3.Distance(activeTween.Target.position, activeTween.EndPos) > 0.1f)
                {
                    float timeFraction = currentTime / activeTween.Duration;
                    activeTween.Target.position = Vector3.Lerp(activeTween.StartPos, activeTween.EndPos, (float)System.Math.Pow(timeFraction, 3));
                }
                if (Vector3.Distance(activeTween.Target.position, activeTween.EndPos) <= 0.1f)
                {
                    activeTween.Target.position = activeTween.EndPos;
                    activeTweens.Remove(activeTween);
                }
            }
        }
    }

    public bool AddTween(Transform target, Vector3 startPos, Vector3 endPos, float duration)
    {
        if (!TweenExists(target))
        {
            Tween newTween = new Tween(target, startPos, endPos, Time.time, duration);
            if (activeTweens == null)
            {
                activeTweens = new List<Tween>();
            }
            activeTweens.Add(newTween);
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool TweenExists(Transform target)
    {
        if (activeTweens != null)
        {
            foreach (Tween tween in activeTweens)
            {
                if (tween.Target == target)
                {
                    return true;
                }
            }
        }
        return false;
    }
}