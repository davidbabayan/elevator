using System;

namespace Lecture7
{
    public class Elevator
    {
        public Elevator(int Floors)
        {
            this.MaxFloor = Floors;
            this.IsDoorOpen = false;
        }
        public int CurrentFloor { get; set; }
        protected int LastFloor { get; set; }
        public int MaxFloor { get; }
        public bool IsDoorOpen { get; set; }
        protected int CalledFloor { get; set; }

        //Call button to call an elevator
        public void Call(int floor)
        {
            this.CalledFloor = floor;
            this.Move();
        }

        //Button to close the doors
        public void CloseDoors(int floor)
        {
            this.CalledFloor = floor;
            this.CloseDoors();
            this.Move();
        }

        //To start elevator move
        private void Move()
        {
            Console.WriteLine($"You are moving to the {this.CalledFloor} floor!");
            if (this.CurrentFloor == this.CalledFloor)
            {
                this.OpenDoors();
            }
            else
            {
                if (this.IsDoorOpen)
                {
                    this.CloseDoors();
                }

                this.LastFloor = this.CurrentFloor;

                int difference = Math.Abs(this.CurrentFloor - this.CalledFloor);

                for (int i = 0; i < difference; i++)
                {
                    this.Step();
                }

                this.OpenDoors();
                Console.WriteLine($"You are on {this.CurrentFloor} floor!");
            }
        }

        //Move elevator location
        private void Step()
        {
            if (this.CurrentFloor > this.CalledFloor)
            {
                --this.CurrentFloor;
            }
            else
            {
                ++this.CurrentFloor;
            }
        }

        //Open the doors when arrieved
        private void OpenDoors()
        {
            this.IsDoorOpen = true;
            Console.WriteLine("The doors are open!");
        }

        //System closing the doors
        private void CloseDoors()
        {
            this.IsDoorOpen = false;
            Console.WriteLine("The doors are close!");
        }
    }
}