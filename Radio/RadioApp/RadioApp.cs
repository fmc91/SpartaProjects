using System;
using System.Linq;

namespace RadioApp
{
    public class Radio
    {
        private static int[] m_availableChannels = new int[] { 1, 2, 3, 4 };

        private int m_channel = 1;
        private bool m_on = false;

        public int Channel
        {
            get { return m_channel; }

            set
            {
                if (m_on && m_availableChannels.Contains(value))
                    m_channel = value;
            }
        }

        public string Play()
        {
            if (m_on)
                return $"Playing channel {Channel}";

            else
                return "Radio is off";
        }

        public void TurnOff()
        {
            m_on = false;
        }

        public void TurnOn()
        {
            m_on = true;
        }

        public void OnOffToggle()
        {
            m_on = !m_on;
        }

    }
}