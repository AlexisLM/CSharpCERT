/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio8
{
    class Auto
    {
        /// <summary>
        /// Car model.
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Car color.
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// State of the car. True = Engine started, False = Engine turned off.
        /// </summary>
        public bool State { get; set; }
        /// <summary>
        /// Speed of the car.
        /// </summary>
        public double Speed { get; set; }
        /// <summary>
        /// Direction of the car. Left = -1, Right = 1, Forward = 0.
        /// </summary>
        public short Direction { get; set; }
        /// <summary>
        /// Registration plate.
        /// </summary>
        public string Plate { get; set; }

        /// <summary>
        /// Auto constructor.
        /// </summary>
        public Auto() { }

        /// <summary>
        /// Auto constructor.
        /// </summary>
        /// <param name="model">Car model.</param>
        /// <param name="color">Car color.</param>
        /// <param name="plate">Registration plate.</param>
        public Auto(string model, string color, string plate)
        {
            Model = model;
            Color = color;
            Plate = plate;
        }

        /// <summary>
        /// Accelerates the car.
        /// </summary>
        /// <param name="speed">Speed to accelerate.</param>
        public void Accelerate(double speed)
        {
            Speed += speed;
        }

        /// <summary>
        /// Starts the car engine.
        /// </summary>
        public void Start()
        {
            State = true;
        }

        /// <summary>
        /// Turns off the car engine.
        /// </summary>
        public void TurnOff()
        {
            State = false;
        }

        /// <summary>
        /// Sets direction to left.
        /// </summary>
        public void TurnLeft()
        {
            Direction = -1;
        }

        /// <summary>
        /// Sets direction to right.
        /// </summary>
        public void TurnRight()
        {
            Direction = 1;
        }

        /// <summary>
        /// Sets direction to forward.
        /// </summary>
        public void GoForward()
        {
            Direction = 0;
        }

        /// <summary>
        /// Returns the string representation of the object.
        /// </summary>
        /// <returns>String representation of the object.</returns>
        public override string ToString()
        {
            string dir = Direction == -1 ? "Left" : (Direction == 1 ? "Right" :
                "Forward");
            string state = State ? "Engine started" : "Engine turned off";

            return $"{Plate}\n\tModel => {Model}\n\tColor => {Color}\n\t" +
                $"State => {state}\n\tSpeed => {Speed}km/h\n\t" +
                $"Direction => {dir}";
        }

    }
}
