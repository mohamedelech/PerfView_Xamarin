using Plugin.Media;
using Plugin.Share;
using Plugin.Share.Abstractions;
using SQLite;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Perf_View_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailBench : ContentPage
    {
        private readonly SQLiteConnection _sqLiteConnection;
        private Performance perfDetail;
        public DetailBench(Performance perf)
        {
            InitializeComponent();
            _sqLiteConnection = DependencyService.Get<XamarinForms.SQLite.SQLite.ISQLite>().GetConnection();

            date.Text = perf.Date;
            weight.Text = perf.Weight;
            reps.Text = perf.Reps;
            address.Text = perf.Adresse;

            ImportedImage.Source = ImageSource.FromFile(perf.Photo);
            pathLabel.Text = perf.Photo;

            perfDetail = perf;

            imgShare.GestureRecognizers.Add(new TapGestureRecognizer(Share_Clicked_img));

        }

        private void Share_Clicked_img(View arg1, object arg2)
        {
            CrossShare.Current.Share("Bench Press \n" +
                "Weight : " + weight.Text + "\n" +
                "Reps : " + reps.Text, "Performance");
        }

        private async void ImportPhoto(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("Oops", "Pick photo is not supported !", "OK");
                return;
            }

            btnImport.BackgroundColor = Color.Green;


            var file = await CrossMedia.Current.PickPhotoAsync();

            if (file == null)
                return;

            pathLabel.Text = file.Path;

            ImportedImage.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });
        }

        private async void Update()
        {
            perfDetail.Date = date.Text;
            perfDetail.Weight = weight.Text;
            perfDetail.Reps = reps.Text;
            perfDetail.Adresse = address.Text;
            perfDetail.Photo = pathLabel.Text;

            _sqLiteConnection.Update(perfDetail);
            await Navigation.PushAsync(new ListView_Bench());
        }

        private async void Delete()
        {
            _sqLiteConnection.Delete(perfDetail);
            await Navigation.PushAsync(new ListView_Bench());
        }

        public void Share_Clicked(object sender, EventArgs e)
        {
            CrossShare.Current.Share("Bench Press \n" +
                "Weight : " + weight.Text + "\n" +
                "Reps : " + reps.Text, "Performance");
        }
    }
}