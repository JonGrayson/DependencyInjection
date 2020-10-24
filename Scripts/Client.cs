using UnityEngine;
namespace Pattern.DependencyInjection
{
    public class Client : MonoBehaviour
    {
        // Bike controlled by the player
        public Bike m_PlayerBike;
        // Bike controlled by an android (AI)
        public Bike m_AndroidBike;
        public Bike m_EvanBike;
        public Bike m_StarshipBike;

        void Awake()
        {
            // Set up a bike with a human driver and jet engine
            IEngine jetEngine = new JetEngine();
            IDriver humanDriver = new HumanDriver();
            m_PlayerBike.SetEngine(jetEngine);
            m_PlayerBike.SetDriver(humanDriver);
            m_PlayerBike.StartEngine();

            // Set up a bike with a AI driver and a nitro engine
            IEngine nitroEngine = new NitroEngine();
            IDriver androidDriver = new AndroidDriver();
            m_PlayerBike.SetEngine(nitroEngine);
            m_PlayerBike.SetDriver(androidDriver);
            m_PlayerBike.StartEngine();

            // Set up a bike with an Evan Driver and Photon Engine
            IEngine photonEngine = new PhotonicEngine();
            IDriver evanDriver = new EvanDriver();
            m_PlayerBike.SetEngine(photonEngine);
            m_PlayerBike.SetDriver(evanDriver);
            m_PlayerBike.StartEngine();

            // Set up a bike with an Evan Driver and Photon Engine
            IEngine warpEngine = new WarpEngine();
            IDriver starshipDriver = new StarshipDriver();
            m_PlayerBike.SetEngine(warpEngine);
            m_PlayerBike.SetDriver(starshipDriver);
            m_PlayerBike.StartEngine();
        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                m_PlayerBike.TurnLeft();
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                m_PlayerBike.TurnRight();
            }
        }
        void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 500, 20), "Press A to turn LEFT and D to turn RIGHT");
            GUI.Label(new Rect(10, 30, 500, 20), "Output displayed in the debug console");
        }
    }
}
