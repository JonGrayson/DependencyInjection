using UnityEngine;
public class PhotonicEngine : IEngine
{
    public void StartEngine()
    {
        OpenPhotonValve();
        Debug.Log("Engine started");
    }
    private void OpenPhotonValve()
    {
        Debug.Log("The photon valve is open");
    }
}
