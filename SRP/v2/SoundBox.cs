namespace SRP.v2
{
    internal class SoundBox
    {
        private int soundLevel = 0;
        public int SoundLevel => soundLevel;

        public void SoundUp()
        {
            if (soundLevel >= 10)
            {
                return;
            }

            soundLevel++;
        }


        public void SoundDown()
        {
            if (soundLevel <= 0) 
            {
                return;
            }

            soundLevel--;
        }

        public void SetSoundLevel(int level)
        {
            if (level < 0 || level > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(level));
            }

            soundLevel = level;
        }
    }
}
