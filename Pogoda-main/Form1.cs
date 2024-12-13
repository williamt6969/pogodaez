using PogodnaPogoda;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PogodnaPogoda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //stwórz nowego klienta HTTP
            HttpClient client = new HttpClient();
            //zdefiniuj adres api wraz z parametrami
            string url = "https://api.open-meteo.com/v1/forecast?latitude=54.3523&longitude=18.6491&current=temperature_2m,relative_humidity_2m,weather_code,wind_speed_10m,wind_direction_10m";
            //sciagnij dane z serwera
            //uzywa .Result, program czeka na odpowiedz serwera
            HttpResponseMessage response = client.GetAsync(url).Result;
            //przeczytaj faktyczna tresc odpowiedzi do zmiennej json jako string
            string json = response.Content.ReadAsStringAsync().Result;
            //wyswietla json w polu tekstowym
            richTextBox1.Text = json;
            //deserializuje json do obiektu
            APIResponse apiResponse = JsonConvert.DeserializeObject<APIResponse>(json);
            //wyswietla temperature w polu tekstowym
            temperatureTextBox.Text = apiResponse.current.temperature_2m.ToString();
            //dodaje spacje
            temperatureTextBox.Text += " ";
            //dopisuje jednostki
            temperatureTextBox.Text += apiResponse.current_units.temperature_2m;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //tworzy nowego klienta HTTP
            HttpClient client = new HttpClient();
            //zdefiniuj adres api wraz z parametrami
            string url = "https://api.open-meteo.com/v1/forecast?latitude=54.3523&longitude=18.6491&current=temperature_2m,relative_humidity_2m,weather_code,wind_speed_10m,wind_direction_10m";
            //sciaga dane z serwera
            //uzywa .Result, program czeka na odpowiedz serwera
            HttpResponseMessage response = client.GetAsync(url).Result;
            //czyta faktyczna tresc odpowiedzi do zmiennej json jako string
            string json = response.Content.ReadAsStringAsync().Result;
            //wyswietla json w polu tekstowym
            richTextBox1.Text = json;
            //deserializuje json do obiektu
            APIResponse apiResponse = JsonConvert.DeserializeObject<APIResponse>(json);
            //wyswietla wilgotnosc w polu tekstowym
            textBox1.Text = apiResponse.current.relative_humidity_2m.ToString();
            //dodaje spacje
            textBox1.Text += " ";
            //dopisuje jednostki
            textBox1.Text += apiResponse.current_units.relative_humidity_2m;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //tworzy nowego klienta HTTP
            HttpClient client = new HttpClient();
            //zdefiniuj adres api wraz z parametrami
            string url = "https://api.open-meteo.com/v1/forecast?latitude=54.3523&longitude=18.6491&current=temperature_2m,relative_humidity_2m,weather_code,wind_speed_10m,wind_direction_10m";
            //sciaga dane z serwera
            //uzywa .Result, program czeka na odpowiedz serwera
            HttpResponseMessage response = client.GetAsync(url).Result;
            //czyta faktyczna tresc odpowiedzi do zmiennej json jako string
            string json = response.Content.ReadAsStringAsync().Result;
            //wyswietla json w polu tekstowym
            richTextBox1.Text = json;
            //deserializuje json do obiektu
            APIResponse apiResponse = JsonConvert.DeserializeObject<APIResponse>(json);
            //wyswietla kod pogody w polu tekstowym
            textBox2.Text = GetWeatherDescription(apiResponse.current.weather_code);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //tworzy nowego klienta HTTP
            HttpClient client = new HttpClient();
            //zdefiniuj adres api wraz z parametrami
            string url = "https://api.open-meteo.com/v1/forecast?latitude=54.3523&longitude=18.6491&current=temperature_2m,relative_humidity_2m,weather_code,wind_speed_10m,wind_direction_10m";
            //sciaga dane z serwera
            //uzywa .Result, program czeka na odpowiedz serwera
            HttpResponseMessage response = client.GetAsync(url).Result;
            //czyta faktyczna tresc odpowiedzi do zmiennej json jako string
            string json = response.Content.ReadAsStringAsync().Result;
            //wyœwietla json w polu tekstowym
            richTextBox1.Text = json;
            //deserializuje json do obiektu
            APIResponse apiResponse = JsonConvert.DeserializeObject<APIResponse>(json);
            //wyswietla predkosc wiatru w polu tekstowym
            textBox3.Text = apiResponse.current.wind_speed_10m.ToString();
            //dodaje spacje
            textBox3.Text += " ";
            //dopisuje jednostki
            textBox3.Text += apiResponse.current_units.wind_speed_10m;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //tworzy nowego klienta HTTP
            HttpClient client = new HttpClient();
            //zdefiniuj adres api wraz z parametrami
            string url = "https://api.open-meteo.com/v1/forecast?latitude=54.3523&longitude=18.6491&current=temperature_2m,relative_humidity_2m,weather_code,wind_speed_10m,wind_direction_10m";
            //sciaga dane z serwera
            //uzywa .Result, program czeka na odpowiedz serwera
            HttpResponseMessage response = client.GetAsync(url).Result;
            //czyta faktyczna tresc odpowiedzi do zmiennej json jako string
            string json = response.Content.ReadAsStringAsync().Result;
            //wyswietla json w polu tekstowym
            richTextBox1.Text = json;
            //deserializuje json do obiektu
            APIResponse apiResponse = JsonConvert.DeserializeObject<APIResponse>(json);
            //wyswietla kierunek wiatru w polu tekstowym
            textBox4.Text = GetWindDirectionDescription(apiResponse.current.wind_direction_10m);
        }

        private string GetWeatherDescription(int weatherCode)
        {
            return weatherCode switch
            {
                0 => "Pogodnie",
                1 => "Glównie pogodnie",
                2 => "Czesciowo pochmurno",
                3 => "Pochmurno",
                45 => "Mgla",
                48 => "Mgla osadzajaca szadz",
                51 => "Mzawka: lekka",
                53 => "Mzawka: umiarkowana",
                55 => "Mzawka: gesta",
                56 => "Mzawka: lekka, marznaca",
                57 => "Mzawka: gesta, marznaca",
                61 => "Deszcz: lekki",
                63 => "Deszcz: umiarkowany",
                65 => "Deszcz: intensywny",
                66 => "Deszcz: lekki, marznacy",
                67 => "Deszcz: intensywny, marznacy",
                71 => "Snieg: lekki",
                73 => "Snieg: umiarkowany",
                75 => "Snieg: intensywny",
                77 => "Snieg ziarnisty",
                80 => "Przelotne opady deszczu: lekkie",
                81 => "Przelotne opady deszczu: umiarkowane",
                82 => "Przelotne opady deszczu: intensywne",
                85 => "Przelotne opady œniegu: lekkie",
                86 => "Przelotne opady œniegu: intensywne",
                95 => "Burza: lekka lub umiarkowana",
                96 => "Burza z gradem: lekka",
                99 => "Burza z gradem: intensywna",
                _ => "Nieznany kod pogodowy"
            };
        }

        private string GetWindDirectionDescription(int windDirection)
        {
            int roundedDirection = (int)Math.Round(windDirection / 90.0) * 90;
            return roundedDirection switch
            {
                0 => "Pólnoc",
                90 => "Wschód",
                180 => "Poludnie",
                270 => "Zachód",
                360 => "Pólnoc",
                _ => "Brak danych"
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void temperatureTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void temperatureLabel_Click(object sender, EventArgs e)
        {

        }
    }
}