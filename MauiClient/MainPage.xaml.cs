using System.Net.Http.Json;

namespace MauiClient
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCallApiButtonClicked(object sender, EventArgs e)
        {
            //create the http client
            var httpClient = new HttpClient();
            // switch if is android to http://10.0.2.2: 
            var baseUrl = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5131" : "http://localhost:5131";
            // get the response from get method of specific uri
            var response =  await httpClient.GetAsync($"{baseUrl}/WeatherForecast");
            // read and store the json string data of response
            var data = await response.Content.ReadAsStringAsync();
        }
    }
}