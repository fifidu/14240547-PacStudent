using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tween
{
    // auto-properties
    private Transform _target;
    private Vector2 _startPos;
    private Vector2 _endPos;
    private float _startTime;
    private float _duration;

    public Tween(Transform target, Vector2 startPos, Vector2 endPos, float startTime, float duration)
    {
        _target = target;
        _startPos = startPos;
        _endPos = endPos;
        _startTime = startTime;
        _duration = duration;
    }

    public Transform Target
    {
        get
        {
            return _target;
        }
        private set
        {
            _target = value;
        }
    }

    public Vector2 StartPos
    {
        get
        {
            return _startPos;
        }
        private set
        {
            _startPos = value;
        }
    }

    public Vector2 EndPos
    {
        get
        {
            return _endPos;
        }
        private set
        {
            _endPos = value;
        }
    }

    public float StartTime
    {
        get
        {
            return _startTime;
        }
        private set
        {
            _startTime = value;
        }
    }

    public float Duration
    {
        get
        {
            return _duration;
        }
        private set
        {
            _duration = value;
        }
    }
}
