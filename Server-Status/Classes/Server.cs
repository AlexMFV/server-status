using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Drawing;

namespace Server_Status
{
    public class Server
    {
        public string _url { get; set; }
        public bool _isOn { get; set; }
        public float _updateTime { get; set; }

        public Server(string url, bool isOn = false, float updateTime = 5.0f)
        {
            this._url = url;
            this._isOn = isOn;
            this._updateTime = updateTime;
        }

        public void Call(int timeout = 5)
        {
            Ping _ping = new Ping();
            _ping.Send(this._url, timeout);
        }

        public Uri Status
        {
            get
            {
                return _isOn ? new Uri("pack://application:,,,/Resources/green.png") : new Uri("pack://application:,,,/Resources/red.png");
            }
        }

        public string URL
        {
            get { return _url; }
        }

        public string UpdateTime
        {
            get { return _updateTime + " seconds"; }
        }
    }
}
