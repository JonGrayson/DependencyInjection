using UnityEngine;
public class WarpEngine : IEngine
{
    public void StartEngine()
    {
        OpenDysoniumValve();
        Debug.Log("Engine started");
    }
    private void OpenDysoniumValve()
    {
        Debug.Log("The Dysonium valve is open");
    }
}