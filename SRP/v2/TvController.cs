namespace SRP.v2
{
    internal class TvController
    {
        private TV tv = new();
        private SoundBox soundBox = new();
        private Loger logger = new();

        public void TurnOnTV()
        {
            tv.On();
            logger.Log("TV is On...");

            soundBox.SetSoundLevel(5);
            logger.Log($"Sound level: {soundBox.SoundLevel}");

            soundBox.SoundUp();
            logger.Log($"Sound level: {soundBox.SoundLevel}");
        }

        public void TurnOffTV()
        {
            tv.Off();
            logger.Log("TV is Off...");
        }
        public void SelectChannel(int channelNumber)
        {
            tv.SelectChannel(channelNumber);
            if (tv.IsOn)
            {
                logger.Log($"Channel #{channelNumber} selected");
            }
        }

    }
}
