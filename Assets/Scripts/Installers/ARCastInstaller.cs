using UnityEngine;
using UnityEngine.XR.ARFoundation;
using Zenject;
public class ARCastInstaller : MonoInstaller
{
    [SerializeField] private ARRaycastManager _raycast;
    public override void InstallBindings()
    {
        Container.Bind<ARRaycastManager>().FromInstance(_raycast).AsSingle().NonLazy();
    }
}
