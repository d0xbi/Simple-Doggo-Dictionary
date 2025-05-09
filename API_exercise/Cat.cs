using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace API_exercise
{

    public partial class Cat : Form
    {
        private static readonly string apiKey = "live_c3da3a7d-a2c0-4d44-9dd0-c5b6cb5e849f";
        private static readonly HttpClient httpClient = new HttpClient();
        private List<CatBreed> breeds;
        public Cat()
        {
            InitializeComponent();
            
 
        }

        // Update the Cat_Load method to have a void return type instead of Task.  
        private void Cat_Load(object sender, EventArgs e)
        {
            Reset();
            // Call the asynchronous method LoadBreedsAsync and handle it properly.  
            _ = LoadBreedsAsync();
        }
        private async Task LoadBreedsAsync()
        {
            try
            {
                httpClient.DefaultRequestHeaders.Clear();
                httpClient.DefaultRequestHeaders.Add("x-api-key", apiKey);

                var response = await httpClient.GetAsync("https://api.thedogapi.com/v1/breeds");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                breeds = JsonConvert.DeserializeObject<List<CatBreed>>(json);

                comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
                comboBox1.DisplayMember = "name";
                comboBox1.DataSource = breeds;
                comboBox1.SelectedIndex = -1; // No selection by default

                comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading breeds: " + ex.Message);
            }
        }
        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is CatBreed selectedBreed)
            {
                tbox_description.Text = selectedBreed.description;
                tbox_origin.Text = selectedBreed.origin;
                tbox_info.Text = selectedBreed.wikipedia_url;
                tbox_lifespan.Text = selectedBreed.life_span;
                tbox_intel.Text = selectedBreed.intelligence.ToString();
                tbox_rare.Text = selectedBreed.rare.ToString();

                // Load image for selected breed
                await LoadCatImage(selectedBreed.id);
            }
        }

        private async Task LoadCatImage(string breedId)
        {
            try
            {
                var response = await httpClient.GetAsync($"https://api.thedogapi.com/v1/images/search?breed_ids={breedId}");
                var json = await response.Content.ReadAsStringAsync();
                dynamic result = JsonConvert.DeserializeObject(json);
                string imageUrl = result[0]?.url;

                pictureBox1.Load(imageUrl);
            }
            catch
            {
                pictureBox1.Image = null;
            }
        }

        private void tbox_info_Click(object sender, EventArgs e)
        {
            string url = tbox_info.Text.Trim();
            if (!string.IsNullOrEmpty(url))
            {
                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not open URL: " + ex.Message);
                }
            }
        }

        private void Reset()
        {
            tbox_description.Clear();
            tbox_origin.Clear();
            tbox_info.Clear();

            pictureBox1.Image = null;
            comboBox1.SelectedIndex = -1;

        }


        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No image to save!");
                return;
            }

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = "Save Cat Image";
                saveDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|BMP Image|*.bmp";
                saveDialog.FileName = "cat_image";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Png;
                    string ext = Path.GetExtension(saveDialog.FileName).ToLower();

                    switch (ext)
                    {
                        case ".jpg":
                            format = System.Drawing.Imaging.ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = System.Drawing.Imaging.ImageFormat.Bmp;
                            break;
                        case ".png":
                        default:
                            format = System.Drawing.Imaging.ImageFormat.Png;
                            break;
                    }

                    try
                    {
                        pictureBox1.Image.Save(saveDialog.FileName, format);
                        MessageBox.Show("Image saved successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to save image: " + ex.Message);
                    }
                }
            }
        }
    }

    public class CatBreed
    {
        public string id { get; set; }
        public string name { get; set; }
        public string origin { get; set; }
        public string description { get; set; }
        public string wikipedia_url { get; set; }
        public string life_span { get; set; }
        public int intelligence { get; set; }
        public int rare { get; set; }
    }
}
