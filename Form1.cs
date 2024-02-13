
namespace BrainTumor
{
    public partial class Form1 : Form
    {
        float[] Newscores = new float[4];
        string imagePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    imagePath = openFileDialog.FileName;
                    pictureBox1.Image = Image.FromFile(imagePath);


                    // Read the image file and convert it to a byte array

                    /*

                    string[] canerName = { "Glioma", "Pituitary", "Meningioma", "No Tumor" };
                    int i = 0;
                    listBox1.Items.Clear();
                    foreach (float score in Newscores)
                    {
                        listBox1.Items.Add(canerName[i] + "==>" + (score * 100).ToString("N2") + "%");
                        i++;
                    }
                    */
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Loading the Image " + ex.Message + " Error");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            byte[] imageData = File.ReadAllBytes(imagePath);
            if (selectedIndex <= 0)
            {

                var input = new MLModel1.ModelInput
                {
                    Label = "Tumor", // Set the label value
                    ImageSource = imageData // Set the image data
                };

                // Make predictions
                var prediction = MLModel1.Predict(input);

                // Access prediction results
                var predictedLabel = prediction.PredictedLabel;
                var scores = prediction.Score;
                for (int j = 0; j < 4; j++)
                {
                    Newscores[j] = scores[j];
                }
            }
            else
            {
                try
                {

                    var modelPath = "C:\\Users\\medlmt\\Desktop\\GI2\\dotnet\\Project\\project2\\BrainTumorCategorical.pb";

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            string[] canerName = { "Glioma", "Meningioma", "No Tumor", "Pituitary" };
            int i = 0;
            listBox1.Items.Clear();
            foreach (float score in Newscores)
            {
                listBox1.Items.Add(canerName[i] + "==>" + (score * 100).ToString("N2") + "%");
                i++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            //pictureBox2.Image = null;
            listBox1.Items.Clear();
        }
    }
}