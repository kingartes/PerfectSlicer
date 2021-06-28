using BzKovSoft.ObjectSlicerSamples;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slicer : MonoBehaviour
{
    [SerializeField] private GameObject _blade;
    [SerializeField] private float _duration;
    [SerializeField] private float _offsetY;
    [SerializeField] private float _stunDuration;

    private bool _isStunned;
    private BzKnife _knife;

    private void Start()
    {
        _knife = _blade.GetComponentInChildren<BzKnife>();
    }

    private void Update()
    {
        if (!_isStunned && Input.GetMouseButtonDown(0))
        {
            _knife.BeginNewSlice();
            _blade.transform.DOMoveY(_blade.transform.position.y - _offsetY, _duration).SetLoops(2, LoopType.Yoyo);
        }
    }

    public void Stun()
    {
        StartCoroutine(SetStunned());
    }

    private IEnumerator SetStunned ()
    {
        _isStunned = true;
        yield return new WaitForSeconds(_stunDuration);
        _isStunned = false;
    }
}
