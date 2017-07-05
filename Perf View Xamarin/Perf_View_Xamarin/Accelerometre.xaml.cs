using DeviceMotion.Plugin;
using DeviceMotion.Plugin.Abstractions;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Perf_View_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Accelerometre : ContentPage
    {
        float historyY = new float();
        int counter;

        public Accelerometre()
        {
            InitializeComponent();
        }

        private void BtnStart_OnClicked(object sender, EventArgs e)
        {
            CrossDeviceMotion.Current.Start(MotionSensorType.Accelerometer, MotionSensorDelay.Ui);
            CrossDeviceMotion.Current.SensorValueChanged += (s, a) =>
            {
                switch (a.SensorType)
                {
                    case MotionSensorType.Accelerometer:

                        float yChange = historyY - float.Parse(((MotionVector)a.Value).Y.ToString("F"));

                        historyY = float.Parse(((MotionVector)a.Value).Y.ToString("F"));

                        if (yChange > 2)
                        {
                            if (counter > 0)
                            {
                                counter = counter - 1;
                                Compteur.Text = counter.ToString();
                            }
                        }
                        else if (yChange < -2)
                        {
                            counter = counter + 1;
                            Compteur.Text = counter.ToString();
                        }

                        break;
                }
            };
        }

        private void BtnStop_OnClicked(object sender, EventArgs e)
        {
            CrossDeviceMotion.Current.Stop(MotionSensorType.Accelerometer);
        }
    }
}