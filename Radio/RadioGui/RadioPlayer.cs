using System;
using WMPLib;

namespace Radio
{
    public class RadioPlayer
    {
        private static readonly RadioStation[] m_stations = new RadioStation[]
        {
            new RadioStation { Name = "BBC Radio One", Url = "http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio1_mf_p" },
            new RadioStation { Name = "BBC Radio Two", Url = "http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio2_mf_p" },
            new RadioStation { Name = "BBC 1Xtra", Url = "http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio1xtra_mf_p" },
            new RadioStation { Name = "BBC Radio Four", Url = "http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio4fm_mf_p" },
        };

        private WindowsMediaPlayer m_player;

        private RadioStation m_currentStation;
        
        public RadioPlayer()
        {
            m_player = new WindowsMediaPlayer();

            m_currentStation = m_stations[0];
        }

        public string CurrentStationName
        { 
            get { return m_currentStation.Name; }
        }

        public int NumberOfStations
        {
            get { return m_stations.Length; }
        }

        public bool SetStation(int index)
        {
            if (index < 0 || index >= NumberOfStations)
            {
                return false;
            }
            else
            {
                m_currentStation = m_stations[index];
                m_player.URL = m_currentStation.Url;

                return true;
            }
        }

        public void Play()
        {
            m_player.controls.play();
        }

        public void Stop()
        {
            m_player.controls.stop();
        }

        public int Volume
        {
            get { return m_player.settings.volume; }

            set { m_player.settings.volume = value; }
        }

    }
}
