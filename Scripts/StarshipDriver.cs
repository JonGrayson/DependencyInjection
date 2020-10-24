using UnityEngine;
public class StarshipDriver : IDriver
{
    private Bike m_Bike;
    public void Control(Bike bike)
    {
        m_Bike = bike;
        Debug.Log("This bike will be controlled by a Starship Captain");
    }
}