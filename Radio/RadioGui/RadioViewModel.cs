using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WMPLib;

namespace Radio
{
    public class RadioViewModel : INotifyPropertyChanged
    {

        #region Private Backing Fields

        private bool m_on;

        private int m_channel;

        private string m_message;

        #endregion

        private RadioPlayer m_player;

        public event PropertyChangedEventHandler PropertyChanged;

        public RadioViewModel(RadioPlayer player)
        {
            m_player = player;

            PropertyChanged += OnPropertyChanged;

            OnOffToggleCommand = new Command<object>(OnOffToggle);

            Channel = 0;
            Volume = 75;
            Message = String.Empty;

            m_player.SetStation(0);
            m_player.Stop();
        }

        public Command<object> OnOffToggleCommand { get; private set; }

        public bool On
        {
            get { return m_on; }

            set
            {
                if (m_on != value)
                {
                    m_on = value;
                    NotifyOfPropertyChanged();
                }
            }
        }

        public int Channel
        {
            get { return m_channel; }

            set
            {
                if (value >= 0 && value < m_player.NumberOfStations && m_channel != value)
                {
                    m_channel = value;

                    NotifyOfPropertyChanged();
                }
            }
        }

        public string Message
        {
            get { return m_message; }

            private set
            {
                if (m_message != value)
                {
                    m_message = value;
                    NotifyOfPropertyChanged();
                }
            }
        }

        public int Volume
        {
            get
            {
                if (m_player != null)
                    return m_player.Volume;
                else
                    return 0;
            }
            set
            {
                if (m_player != null && m_player.Volume != value)
                {
                    m_player.Volume = value;
                    NotifyOfPropertyChanged();
                }
            }
        }

        private void SetMessage()
        {
            if (On)
                Message = m_player.CurrentStationName;
            else
                Message = String.Empty;
        }

        private void OnOffToggle(object o)
        {
            On = !On;

            if(On)
                m_player.Play();
            else
                m_player.Stop();

            SetMessage();
        }

        private void OnChannelChanged()
        {
            m_player.SetStation(Channel);

            if (!On)
                m_player.Stop();

            SetMessage();
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Channel))
                OnChannelChanged();
        }

        private void NotifyOfPropertyChanged([CallerMemberName] string callerName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(callerName));
        }
    }
}
