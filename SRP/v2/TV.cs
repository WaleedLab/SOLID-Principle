namespace SRP.v2
{
    internal class TV
    {
        private bool on = false;
        public bool IsOn => on;

        public void On()
        {
            on = true;
        }
        public void Off()
        {
            on = false;
        }

        public void SelectChannel(int channelNumber)
        {
            if (!on)
            {
                return;
            }
        }
    }
}
