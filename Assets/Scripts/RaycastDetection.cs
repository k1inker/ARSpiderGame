using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine;
using System.Collections.Generic;
using Zenject;

public class RaycastDetection : MonoBehaviour
{
    public GameObject _player;

    [Inject] private ARRaycastManager _raycastManager;
    private void Start()
    {
        Instantiate(_player);
        _player.SetActive(false);
    }
    private void Update()
    {
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        _raycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, TrackableType.Planes);

        if(hits.Count > 0)
        {
            _player.transform.position = hits[0].pose.position;
            _player.SetActive(true);
        }
    }
}
