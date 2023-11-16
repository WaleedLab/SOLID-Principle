namespace SRP.v1
{
    internal class TV
    {
        private bool on = false; 
        public void On()
        {
            on = true;
            Console.WriteLine("TV is ON...");
        } 
        public void Off()
        {
            on = false;
            Console.WriteLine("TV is Off...");
        }

        public void SoundUp()
        {
            if (!on)
            {
                return;
            }

            Console.WriteLine("Sound up...");
        }
        public void SoundDown()
        {
            if (!on)
            {
                return;
            }

            Console.WriteLine("Sound down...");
        }

        public void SelectChannel(int channelNumber)
        {
            if (!on)
            {
                return;
            }

            Console.WriteLine($"Channel #{channelNumber} selected");
        }
    }
}
